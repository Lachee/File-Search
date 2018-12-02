namespace FileSearch
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.progressbar = new System.Windows.Forms.ProgressBar();
            this.label_progress = new System.Windows.Forms.Label();
            this.btn_browse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listbox_results = new System.Windows.Forms.ListBox();
            this.btn_scan = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.progress_timer = new System.Windows.Forms.Timer(this.components);
            this.richbox_contents = new System.Windows.Forms.RichTextBox();
            this.btn_openfile = new System.Windows.Forms.Button();
            this.btn_browsefolder = new System.Windows.Forms.Button();
            this.btn_notepadpp = new System.Windows.Forms.Button();
            this.btn_abort = new System.Windows.Forms.Button();
            this.textbox_notepadpp = new System.Windows.Forms.TextBox();
            this.textbox_searchPattern = new System.Windows.Forms.TextBox();
            this.textbox_regex = new System.Windows.Forms.TextBox();
            this.textbox_directory = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // progressbar
            // 
            this.progressbar.Location = new System.Drawing.Point(76, 415);
            this.progressbar.Name = "progressbar";
            this.progressbar.Size = new System.Drawing.Size(445, 23);
            this.progressbar.TabIndex = 0;
            // 
            // label_progress
            // 
            this.label_progress.AutoSize = true;
            this.label_progress.Location = new System.Drawing.Point(527, 421);
            this.label_progress.Name = "label_progress";
            this.label_progress.Size = new System.Drawing.Size(24, 13);
            this.label_progress.TabIndex = 1;
            this.label_progress.Text = "0/0";
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(528, 8);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(61, 23);
            this.btn_browse.TabIndex = 2;
            this.btn_browse.Text = "Open..";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Directory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Regex";
            // 
            // listbox_results
            // 
            this.listbox_results.FormattingEnabled = true;
            this.listbox_results.Location = new System.Drawing.Point(13, 71);
            this.listbox_results.Name = "listbox_results";
            this.listbox_results.Size = new System.Drawing.Size(576, 329);
            this.listbox_results.TabIndex = 10;
            this.listbox_results.SelectedIndexChanged += new System.EventHandler(this.listbox_results_SelectedIndexChanged);
            // 
            // btn_scan
            // 
            this.btn_scan.Location = new System.Drawing.Point(528, 37);
            this.btn_scan.Name = "btn_scan";
            this.btn_scan.Size = new System.Drawing.Size(61, 23);
            this.btn_scan.TabIndex = 11;
            this.btn_scan.Text = "SCAN";
            this.btn_scan.UseVisualStyleBackColor = true;
            this.btn_scan.Click += new System.EventHandler(this.btn_scan_Click);
            // 
            // progress_timer
            // 
            this.progress_timer.Enabled = true;
            this.progress_timer.Tick += new System.EventHandler(this.progress_timer_Tick);
            // 
            // richbox_contents
            // 
            this.richbox_contents.Location = new System.Drawing.Point(596, 71);
            this.richbox_contents.Name = "richbox_contents";
            this.richbox_contents.Size = new System.Drawing.Size(296, 252);
            this.richbox_contents.TabIndex = 12;
            this.richbox_contents.Text = "";
            // 
            // btn_openfile
            // 
            this.btn_openfile.Enabled = false;
            this.btn_openfile.Location = new System.Drawing.Point(596, 329);
            this.btn_openfile.Name = "btn_openfile";
            this.btn_openfile.Size = new System.Drawing.Size(67, 23);
            this.btn_openfile.TabIndex = 13;
            this.btn_openfile.Text = "Open";
            this.btn_openfile.UseVisualStyleBackColor = true;
            this.btn_openfile.Click += new System.EventHandler(this.btn_openfile_Click);
            // 
            // btn_browsefolder
            // 
            this.btn_browsefolder.Enabled = false;
            this.btn_browsefolder.Location = new System.Drawing.Point(773, 329);
            this.btn_browsefolder.Name = "btn_browsefolder";
            this.btn_browsefolder.Size = new System.Drawing.Size(119, 23);
            this.btn_browsefolder.TabIndex = 14;
            this.btn_browsefolder.Text = "Reveal in Explorer";
            this.btn_browsefolder.UseVisualStyleBackColor = true;
            this.btn_browsefolder.Click += new System.EventHandler(this.btn_browsefolder_Click);
            // 
            // btn_notepadpp
            // 
            this.btn_notepadpp.Enabled = false;
            this.btn_notepadpp.Location = new System.Drawing.Point(669, 329);
            this.btn_notepadpp.Name = "btn_notepadpp";
            this.btn_notepadpp.Size = new System.Drawing.Size(98, 23);
            this.btn_notepadpp.TabIndex = 15;
            this.btn_notepadpp.Text = "Open Notepad++";
            this.btn_notepadpp.UseVisualStyleBackColor = true;
            this.btn_notepadpp.Click += new System.EventHandler(this.btn_notepadpp_Click);
            // 
            // btn_abort
            // 
            this.btn_abort.Enabled = false;
            this.btn_abort.Location = new System.Drawing.Point(15, 415);
            this.btn_abort.Name = "btn_abort";
            this.btn_abort.Size = new System.Drawing.Size(55, 23);
            this.btn_abort.TabIndex = 17;
            this.btn_abort.Text = "Abort";
            this.btn_abort.UseVisualStyleBackColor = true;
            this.btn_abort.Click += new System.EventHandler(this.btn_abort_Click);
            // 
            // textbox_notepadpp
            // 
            this.textbox_notepadpp.Location = new System.Drawing.Point(669, 358);
            this.textbox_notepadpp.Name = "textbox_notepadpp";
            this.textbox_notepadpp.Size = new System.Drawing.Size(98, 20);
            this.textbox_notepadpp.TabIndex = 16;
            this.textbox_notepadpp.Text = global::FileSearch.Properties.Settings.Default.notepadpp;
            // 
            // textbox_searchPattern
            // 
            this.textbox_searchPattern.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::FileSearch.Properties.Settings.Default, "last_filter", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textbox_searchPattern.Location = new System.Drawing.Point(410, 10);
            this.textbox_searchPattern.Name = "textbox_searchPattern";
            this.textbox_searchPattern.Size = new System.Drawing.Size(111, 20);
            this.textbox_searchPattern.TabIndex = 8;
            this.textbox_searchPattern.Text = global::FileSearch.Properties.Settings.Default.last_filter;
            this.textbox_searchPattern.TextChanged += new System.EventHandler(this.textbox_directory_TextChanged);
            // 
            // textbox_regex
            // 
            this.textbox_regex.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::FileSearch.Properties.Settings.Default, "last_regex", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textbox_regex.Location = new System.Drawing.Point(96, 37);
            this.textbox_regex.Name = "textbox_regex";
            this.textbox_regex.Size = new System.Drawing.Size(426, 20);
            this.textbox_regex.TabIndex = 6;
            this.textbox_regex.Text = global::FileSearch.Properties.Settings.Default.last_regex;
            // 
            // textbox_directory
            // 
            this.textbox_directory.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::FileSearch.Properties.Settings.Default, "last_directory", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textbox_directory.Location = new System.Drawing.Point(96, 10);
            this.textbox_directory.Name = "textbox_directory";
            this.textbox_directory.Size = new System.Drawing.Size(308, 20);
            this.textbox_directory.TabIndex = 3;
            this.textbox_directory.Text = global::FileSearch.Properties.Settings.Default.last_directory;
            this.textbox_directory.TextChanged += new System.EventHandler(this.textbox_directory_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 450);
            this.Controls.Add(this.btn_abort);
            this.Controls.Add(this.textbox_notepadpp);
            this.Controls.Add(this.btn_notepadpp);
            this.Controls.Add(this.btn_browsefolder);
            this.Controls.Add(this.btn_openfile);
            this.Controls.Add(this.richbox_contents);
            this.Controls.Add(this.btn_scan);
            this.Controls.Add(this.listbox_results);
            this.Controls.Add(this.textbox_searchPattern);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textbox_regex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textbox_directory);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.label_progress);
            this.Controls.Add(this.progressbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "File Scanner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressbar;
        private System.Windows.Forms.Label label_progress;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.TextBox textbox_directory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textbox_regex;
        private System.Windows.Forms.TextBox textbox_searchPattern;
        private System.Windows.Forms.ListBox listbox_results;
        private System.Windows.Forms.Button btn_scan;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Timer progress_timer;
        private System.Windows.Forms.RichTextBox richbox_contents;
        private System.Windows.Forms.Button btn_openfile;
        private System.Windows.Forms.Button btn_browsefolder;
        private System.Windows.Forms.Button btn_notepadpp;
        private System.Windows.Forms.TextBox textbox_notepadpp;
        private System.Windows.Forms.Button btn_abort;
    }
}

