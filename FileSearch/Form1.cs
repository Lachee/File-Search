using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSearch
{
    public partial class Form1 : Form
    {
        private volatile int readFiles = 0;
        private volatile int totalFiles = 0;
        private volatile bool isWorking = false;

        private string[] scannedFileNames = null;

        private SemaphoreSlim semaphore = new SemaphoreSlim(1, 1);

        private int _lastResultCount = 0;
        private List<ScanResult> results = new List<ScanResult>();
        public struct ScanResult
        {
            public string filename;
            public int line;
            public string content;
            public int matchIndex, matchLength;
            public override string ToString()
            {
                return filename + ":" + line;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private async void progress_timer_Tick(object sender, EventArgs e)
        {
            await semaphore.WaitAsync();

            SetProgress(readFiles, totalFiles);
            btn_scan.Enabled = !isWorking;
            btn_abort.Enabled = isWorking;

            while (_lastResultCount < results.Count)
            {
                var result = results[_lastResultCount++];
                listbox_results.Items.Add(result);
            }

            if (!isWorking) progress_timer.Enabled = false;

            semaphore.Release();
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = textbox_directory.Text;
            var result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK) textbox_directory.Text = folderBrowserDialog.SelectedPath;
        }

        private void btn_scan_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(textbox_directory.Text))
            {
                MessageBox.Show("The selected folder does not exist", "Missing Folder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(textbox_searchPattern.Text))
            {
                MessageBox.Show("The search pattern is null or empty", "Missing Query", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(textbox_regex.Text))
            {
                MessageBox.Show("The regex is null or empty", "Missing Query", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //First get all the files we have
            if (scannedFileNames == null) 
                scannedFileNames = Directory.GetFiles(textbox_directory.Text, textbox_searchPattern.Text, SearchOption.AllDirectories);

            btn_scan.Enabled = false;
            btn_abort.Enabled = true;
            progress_timer.Enabled = true;
            results.Clear();
            listbox_results.Items.Clear();
            BeginScan(scannedFileNames, new Regex(textbox_regex.Text));
        }

        private async void BeginScan(string[] files, Regex regex)
        {
            isWorking = true;
            readFiles = 0;
            totalFiles = files.Length;

            for (readFiles = 0; readFiles < totalFiles; readFiles++)
            {
                if (!isWorking) break;
                using (var reader = File.OpenText(files[readFiles]))
                {
                    var fileText = await reader.ReadToEndAsync();
                    var fileLines = fileText.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
                    for (int i = 0; i < fileLines.Length; i++)
                    {
                        if (!isWorking) break;
                        var match = regex.Match(fileLines[i]);
                        if (match.Success)
                        {
                            await semaphore.WaitAsync();
                            results.Add(new ScanResult()
                            {
                                filename = files[readFiles],
                                line = i + 1,
                                content = fileLines[i],
                                matchIndex = match.Index,
                                matchLength = match.Length
                            });
                            semaphore.Release();
                        }
                    }
                }
            }

            isWorking = false;
        }

        private void SetProgress(int index, int count)
        {
            label_progress.Text = $"{index} / {count}";
            progressbar.Maximum = count;
            progressbar.Value = index;
        }

        private void listbox_results_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listbox_results.SelectedIndex < 0)
            {
                richbox_contents.Text = "";
                btn_openfile.Enabled = false;
                btn_notepadpp.Enabled = false;
                btn_browsefolder.Enabled = false;
                return;
            }

            var result = (ScanResult) listbox_results.SelectedItem;
            int mi = result.matchIndex;
            int mie = result.matchIndex + result.matchLength;
            string c = result.content;

            string rich = c.Substring(0, mi) + @"\b " + c.Substring(mi, mie - mi) + @"\b0 " + c.Substring(mie);
            rich = rich.Trim(' ', '\t');
            rich = rich.Replace("{", "\\{");
            rich = rich.Replace("}", "\\}");
            richbox_contents.Rtf = @"{\rtf1\ansi" + rich + @"\line }";

            btn_openfile.Enabled = true;
            btn_browsefolder.Enabled = true;
            btn_notepadpp.Enabled = true;
        }

        private void btn_browsefolder_Click(object sender, EventArgs e)
        {
            if (listbox_results.SelectedIndex < 0) return;
            var result = (ScanResult)listbox_results.SelectedItem;
            System.Diagnostics.Process.Start("explorer.exe", "/select,\"" + result.filename + "\"");
        }

        private void btn_openfile_Click(object sender, EventArgs e)
        {
            if (listbox_results.SelectedIndex < 0) return;
            var result = (ScanResult)listbox_results.SelectedItem;
            System.Diagnostics.Process.Start("\"" + result.filename + "\"");
        }

        private void btn_notepadpp_Click(object sender, EventArgs e)
        {
            if (listbox_results.SelectedIndex < 0) return;
            if (!File.Exists(textbox_notepadpp.Text))
            {
                MessageBox.Show("Cannot locate notepad++. The file given was incorrect: " + textbox_notepadpp.Text, "Notepad++ Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = (ScanResult)listbox_results.SelectedItem;
            System.Diagnostics.Process.Start(textbox_notepadpp.Text, "\"" + result.filename + "\" -n" + result.line);
        }

        private void textbox_directory_TextChanged(object sender, EventArgs e)
        {
            scannedFileNames = null;
        }

        private void btn_abort_Click(object sender, EventArgs e)
        {
            isWorking = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }
    }
}
