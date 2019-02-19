// Last modify:1550578075
namespace SimpleHNC
{
    partial class SimpleHNC
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimpleHNC));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.targethash = new System.Windows.Forms.TextBox();
            this.md5hash = new System.Windows.Forms.TextBox();
            this.btn_check = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.filelocation = new System.Windows.Forms.TextBox();
            this.sha256hash = new System.Windows.Forms.TextBox();
            this.sha1hash = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_open = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.crc32hash = new System.Windows.Forms.TextBox();
            this.crc32check = new System.Windows.Forms.CheckBox();
            this.md5check = new System.Windows.Forms.CheckBox();
            this.sha1check = new System.Windows.Forms.CheckBox();
            this.sha256check = new System.Windows.Forms.CheckBox();
            this.copyright = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_Normal = new System.Windows.Forms.TabPage();
            this.sha384hash = new System.Windows.Forms.TextBox();
            this.sha512hash = new System.Windows.Forms.TextBox();
            this.sha512check = new System.Windows.Forms.CheckBox();
            this.sha384check = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_import = new System.Windows.Forms.Button();
            this.btn_export = new System.Windows.Forms.Button();
            this.tab_Batch = new System.Windows.Forms.TabPage();
            this.btn_report = new System.Windows.Forms.Button();
            this.check_subfolders = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.SelectFolder = new System.Windows.Forms.Button();
            this.folderPath = new System.Windows.Forms.TextBox();
            this.BatchHash = new System.Windows.Forms.DataGridView();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Display_CRC32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Display_MD5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Display_SHA1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Display_SHA256 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_ = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.check_ClipboardValue = new System.Windows.Forms.CheckBox();
            this.panel_ContextMenu = new System.Windows.Forms.Panel();
            this.btn_RightClickMenu = new System.Windows.Forms.Button();
            this.btn_RemoveRightClickMenu = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tab_Normal.SuspendLayout();
            this.tab_Batch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BatchHash)).BeginInit();
            this.btn_.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_ContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "MD5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Target Value";
            // 
            // targethash
            // 
            this.targethash.Location = new System.Drawing.Point(403, 271);
            this.targethash.Name = "targethash";
            this.targethash.Size = new System.Drawing.Size(375, 22);
            this.targethash.TabIndex = 2;
            // 
            // md5hash
            // 
            this.md5hash.Location = new System.Drawing.Point(403, 118);
            this.md5hash.Name = "md5hash";
            this.md5hash.ReadOnly = true;
            this.md5hash.Size = new System.Drawing.Size(375, 22);
            this.md5hash.TabIndex = 3;
            this.md5hash.Click += new System.EventHandler(this.md5hash_Click);
            // 
            // btn_check
            // 
            this.btn_check.Enabled = false;
            this.btn_check.Location = new System.Drawing.Point(484, 299);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(75, 23);
            this.btn_check.TabIndex = 4;
            this.btn_check.Text = "Check!";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Source File";
            // 
            // filelocation
            // 
            this.filelocation.AllowDrop = true;
            this.filelocation.Location = new System.Drawing.Point(403, 31);
            this.filelocation.Name = "filelocation";
            this.filelocation.ReadOnly = true;
            this.filelocation.Size = new System.Drawing.Size(375, 22);
            this.filelocation.TabIndex = 6;
            this.filelocation.DragDrop += new System.Windows.Forms.DragEventHandler(this.filelocation_DragDrop);
            // 
            // sha256hash
            // 
            this.sha256hash.Location = new System.Drawing.Point(403, 174);
            this.sha256hash.Name = "sha256hash";
            this.sha256hash.ReadOnly = true;
            this.sha256hash.Size = new System.Drawing.Size(375, 22);
            this.sha256hash.TabIndex = 7;
            this.sha256hash.Click += new System.EventHandler(this.sha256hash_Click);
            // 
            // sha1hash
            // 
            this.sha1hash.Location = new System.Drawing.Point(403, 146);
            this.sha1hash.Name = "sha1hash";
            this.sha1hash.ReadOnly = true;
            this.sha1hash.Size = new System.Drawing.Size(375, 22);
            this.sha1hash.TabIndex = 8;
            this.sha1hash.Click += new System.EventHandler(this.sha1hash_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "SHA-256";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(343, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "SHA-1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(403, 299);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(75, 23);
            this.btn_open.TabIndex = 11;
            this.btn_open.Text = "Select File";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(339, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "CRC32";
            // 
            // crc32hash
            // 
            this.crc32hash.Location = new System.Drawing.Point(403, 90);
            this.crc32hash.Name = "crc32hash";
            this.crc32hash.ReadOnly = true;
            this.crc32hash.Size = new System.Drawing.Size(375, 22);
            this.crc32hash.TabIndex = 13;
            this.crc32hash.Click += new System.EventHandler(this.crc32hash_Click);
            // 
            // crc32check
            // 
            this.crc32check.AutoSize = true;
            this.crc32check.Checked = true;
            this.crc32check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.crc32check.Location = new System.Drawing.Point(382, 93);
            this.crc32check.Name = "crc32check";
            this.crc32check.Size = new System.Drawing.Size(15, 14);
            this.crc32check.TabIndex = 14;
            this.crc32check.UseVisualStyleBackColor = true;
            // 
            // md5check
            // 
            this.md5check.AutoSize = true;
            this.md5check.Checked = true;
            this.md5check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.md5check.Location = new System.Drawing.Point(382, 121);
            this.md5check.Name = "md5check";
            this.md5check.Size = new System.Drawing.Size(15, 14);
            this.md5check.TabIndex = 15;
            this.md5check.UseVisualStyleBackColor = true;
            // 
            // sha1check
            // 
            this.sha1check.AutoSize = true;
            this.sha1check.Checked = true;
            this.sha1check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sha1check.Location = new System.Drawing.Point(382, 149);
            this.sha1check.Name = "sha1check";
            this.sha1check.Size = new System.Drawing.Size(15, 14);
            this.sha1check.TabIndex = 16;
            this.sha1check.UseVisualStyleBackColor = true;
            // 
            // sha256check
            // 
            this.sha256check.AutoSize = true;
            this.sha256check.Checked = true;
            this.sha256check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sha256check.Location = new System.Drawing.Point(382, 177);
            this.sha256check.Name = "sha256check";
            this.sha256check.Size = new System.Drawing.Size(15, 14);
            this.sha256check.TabIndex = 17;
            this.sha256check.UseVisualStyleBackColor = true;
            // 
            // copyright
            // 
            this.copyright.AutoSize = true;
            this.copyright.Location = new System.Drawing.Point(12, 577);
            this.copyright.Name = "copyright";
            this.copyright.Size = new System.Drawing.Size(128, 12);
            this.copyright.TabIndex = 19;
            this.copyright.Text = "© 2018-2019 SimpleHNC";
            this.copyright.Click += new System.EventHandler(this.copyright_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(403, 61);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(375, 23);
            this.progressBar1.TabIndex = 20;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_Normal);
            this.tabControl1.Controls.Add(this.tab_Batch);
            this.tabControl1.Controls.Add(this.btn_);
            this.tabControl1.Location = new System.Drawing.Point(-1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1189, 574);
            this.tabControl1.TabIndex = 21;
            // 
            // tab_Normal
            // 
            this.tab_Normal.AllowDrop = true;
            this.tab_Normal.Controls.Add(this.sha384hash);
            this.tab_Normal.Controls.Add(this.sha512hash);
            this.tab_Normal.Controls.Add(this.sha512check);
            this.tab_Normal.Controls.Add(this.sha384check);
            this.tab_Normal.Controls.Add(this.label13);
            this.tab_Normal.Controls.Add(this.label12);
            this.tab_Normal.Controls.Add(this.btn_import);
            this.tab_Normal.Controls.Add(this.btn_export);
            this.tab_Normal.Controls.Add(this.targethash);
            this.tab_Normal.Controls.Add(this.progressBar1);
            this.tab_Normal.Controls.Add(this.label1);
            this.tab_Normal.Controls.Add(this.label2);
            this.tab_Normal.Controls.Add(this.md5hash);
            this.tab_Normal.Controls.Add(this.sha256check);
            this.tab_Normal.Controls.Add(this.btn_check);
            this.tab_Normal.Controls.Add(this.sha1check);
            this.tab_Normal.Controls.Add(this.label3);
            this.tab_Normal.Controls.Add(this.md5check);
            this.tab_Normal.Controls.Add(this.filelocation);
            this.tab_Normal.Controls.Add(this.crc32check);
            this.tab_Normal.Controls.Add(this.sha256hash);
            this.tab_Normal.Controls.Add(this.crc32hash);
            this.tab_Normal.Controls.Add(this.sha1hash);
            this.tab_Normal.Controls.Add(this.label6);
            this.tab_Normal.Controls.Add(this.label4);
            this.tab_Normal.Controls.Add(this.btn_open);
            this.tab_Normal.Controls.Add(this.label5);
            this.tab_Normal.Location = new System.Drawing.Point(4, 22);
            this.tab_Normal.Name = "tab_Normal";
            this.tab_Normal.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Normal.Size = new System.Drawing.Size(1181, 548);
            this.tab_Normal.TabIndex = 0;
            this.tab_Normal.Text = "Normal";
            this.tab_Normal.UseVisualStyleBackColor = true;
            this.tab_Normal.DragDrop += new System.Windows.Forms.DragEventHandler(this.tab_Normal_DragDrop);
            this.tab_Normal.DragEnter += new System.Windows.Forms.DragEventHandler(this.tab_Normal_DragEnter);
            // 
            // sha384hash
            // 
            this.sha384hash.Location = new System.Drawing.Point(403, 202);
            this.sha384hash.Name = "sha384hash";
            this.sha384hash.ReadOnly = true;
            this.sha384hash.Size = new System.Drawing.Size(375, 22);
            this.sha384hash.TabIndex = 28;
            this.sha384hash.Click += new System.EventHandler(this.sha384hash_Click);
            // 
            // sha512hash
            // 
            this.sha512hash.Location = new System.Drawing.Point(403, 230);
            this.sha512hash.Name = "sha512hash";
            this.sha512hash.ReadOnly = true;
            this.sha512hash.Size = new System.Drawing.Size(375, 22);
            this.sha512hash.TabIndex = 27;
            this.sha512hash.Click += new System.EventHandler(this.sha512hash_Click);
            // 
            // sha512check
            // 
            this.sha512check.AutoSize = true;
            this.sha512check.Checked = true;
            this.sha512check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sha512check.Location = new System.Drawing.Point(382, 233);
            this.sha512check.Name = "sha512check";
            this.sha512check.Size = new System.Drawing.Size(15, 14);
            this.sha512check.TabIndex = 26;
            this.sha512check.UseVisualStyleBackColor = true;
            // 
            // sha384check
            // 
            this.sha384check.AutoSize = true;
            this.sha384check.Checked = true;
            this.sha384check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sha384check.Location = new System.Drawing.Point(382, 205);
            this.sha384check.Name = "sha384check";
            this.sha384check.Size = new System.Drawing.Size(15, 14);
            this.sha384check.TabIndex = 25;
            this.sha384check.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(331, 235);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 12);
            this.label13.TabIndex = 24;
            this.label13.Text = "SHA-512";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(331, 207);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 12);
            this.label12.TabIndex = 23;
            this.label12.Text = "SHA-384";
            // 
            // btn_import
            // 
            this.btn_import.Location = new System.Drawing.Point(703, 299);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(75, 23);
            this.btn_import.TabIndex = 22;
            this.btn_import.Text = "Import";
            this.btn_import.UseVisualStyleBackColor = true;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // btn_export
            // 
            this.btn_export.Location = new System.Drawing.Point(622, 299);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(75, 23);
            this.btn_export.TabIndex = 21;
            this.btn_export.Text = "Export";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // tab_Batch
            // 
            this.tab_Batch.Controls.Add(this.btn_report);
            this.tab_Batch.Controls.Add(this.check_subfolders);
            this.tab_Batch.Controls.Add(this.label9);
            this.tab_Batch.Controls.Add(this.label8);
            this.tab_Batch.Controls.Add(this.btn_back);
            this.tab_Batch.Controls.Add(this.SelectFolder);
            this.tab_Batch.Controls.Add(this.folderPath);
            this.tab_Batch.Controls.Add(this.BatchHash);
            this.tab_Batch.Location = new System.Drawing.Point(4, 22);
            this.tab_Batch.Name = "tab_Batch";
            this.tab_Batch.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Batch.Size = new System.Drawing.Size(1181, 548);
            this.tab_Batch.TabIndex = 1;
            this.tab_Batch.Text = "Batch";
            this.tab_Batch.UseVisualStyleBackColor = true;
            // 
            // btn_report
            // 
            this.btn_report.Enabled = false;
            this.btn_report.Location = new System.Drawing.Point(11, 52);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(98, 23);
            this.btn_report.TabIndex = 12;
            this.btn_report.Text = "Export Report";
            this.btn_report.UseVisualStyleBackColor = true;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // check_subfolders
            // 
            this.check_subfolders.AutoSize = true;
            this.check_subfolders.Location = new System.Drawing.Point(306, 52);
            this.check_subfolders.Name = "check_subfolders";
            this.check_subfolders.Size = new System.Drawing.Size(150, 16);
            this.check_subfolders.TabIndex = 11;
            this.check_subfolders.Text = "Including file in subfolders";
            this.check_subfolders.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("PMingLiU", 18F);
            this.label9.Location = new System.Drawing.Point(550, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(365, 24);
            this.label9.TabIndex = 10;
            this.label9.Text = "Click any row to put value to calculator";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("PMingLiU", 18F);
            this.label8.Location = new System.Drawing.Point(568, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(293, 24);
            this.label8.TabIndex = 9;
            this.label8.Text = "Click any cell to copy the value";
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("PMingLiU", 18F);
            this.btn_back.Location = new System.Drawing.Point(946, 26);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(191, 46);
            this.btn_back.TabIndex = 8;
            this.btn_back.Text = "Back to calculation";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // SelectFolder
            // 
            this.SelectFolder.Location = new System.Drawing.Point(461, 48);
            this.SelectFolder.Name = "SelectFolder";
            this.SelectFolder.Size = new System.Drawing.Size(75, 23);
            this.SelectFolder.TabIndex = 7;
            this.SelectFolder.Text = "Select Folder";
            this.SelectFolder.UseVisualStyleBackColor = true;
            this.SelectFolder.Click += new System.EventHandler(this.SelectFolder_Click);
            // 
            // folderPath
            // 
            this.folderPath.Location = new System.Drawing.Point(11, 19);
            this.folderPath.Name = "folderPath";
            this.folderPath.ReadOnly = true;
            this.folderPath.Size = new System.Drawing.Size(525, 22);
            this.folderPath.TabIndex = 6;
            // 
            // BatchHash
            // 
            this.BatchHash.AllowUserToResizeColumns = false;
            this.BatchHash.AllowUserToResizeRows = false;
            this.BatchHash.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BatchHash.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BatchHash.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileName,
            this.Display_CRC32,
            this.Display_MD5,
            this.Display_SHA1,
            this.Display_SHA256});
            this.BatchHash.Location = new System.Drawing.Point(11, 84);
            this.BatchHash.Name = "BatchHash";
            this.BatchHash.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.BatchHash.Size = new System.Drawing.Size(1161, 458);
            this.BatchHash.TabIndex = 5;
            this.BatchHash.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BatchHash_CellClick);
            this.BatchHash.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.BatchHash_CellFormatting);
            this.BatchHash.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.BatchHash_RowHeaderMouseClick);
            this.BatchHash.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.BatchHash_RowPrePaint);
            // 
            // FileName
            // 
            this.FileName.HeaderText = "FileName";
            this.FileName.MinimumWidth = 10;
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            this.FileName.Width = 200;
            // 
            // Display_CRC32
            // 
            this.Display_CRC32.HeaderText = "CRC32";
            this.Display_CRC32.Name = "Display_CRC32";
            this.Display_CRC32.ReadOnly = true;
            this.Display_CRC32.Width = 65;
            // 
            // Display_MD5
            // 
            this.Display_MD5.HeaderText = "MD5";
            this.Display_MD5.Name = "Display_MD5";
            this.Display_MD5.ReadOnly = true;
            this.Display_MD5.Width = 200;
            // 
            // Display_SHA1
            // 
            this.Display_SHA1.HeaderText = "SHA1";
            this.Display_SHA1.Name = "Display_SHA1";
            this.Display_SHA1.ReadOnly = true;
            this.Display_SHA1.Width = 250;
            // 
            // Display_SHA256
            // 
            this.Display_SHA256.HeaderText = "SHA256";
            this.Display_SHA256.Name = "Display_SHA256";
            this.Display_SHA256.ReadOnly = true;
            this.Display_SHA256.Width = 380;
            // 
            // btn_
            // 
            this.btn_.Controls.Add(this.panel1);
            this.btn_.Controls.Add(this.panel_ContextMenu);
            this.btn_.Location = new System.Drawing.Point(4, 22);
            this.btn_.Name = "btn_";
            this.btn_.Padding = new System.Windows.Forms.Padding(3);
            this.btn_.Size = new System.Drawing.Size(1181, 548);
            this.btn_.TabIndex = 2;
            this.btn_.Text = "Setting";
            this.btn_.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.check_ClipboardValue);
            this.panel1.Location = new System.Drawing.Point(6, 276);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1166, 266);
            this.panel1.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("PMingLiU", 16F);
            this.label11.Location = new System.Drawing.Point(446, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(280, 44);
            this.label11.TabIndex = 5;
            this.label11.Text = "Beta Feature\r\nYou Must Enable It Every Time";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // check_ClipboardValue
            // 
            this.check_ClipboardValue.AutoSize = true;
            this.check_ClipboardValue.Location = new System.Drawing.Point(450, 91);
            this.check_ClipboardValue.Name = "check_ClipboardValue";
            this.check_ClipboardValue.Size = new System.Drawing.Size(252, 16);
            this.check_ClipboardValue.TabIndex = 4;
            this.check_ClipboardValue.Text = "Always paste content on clipboard to target value";
            this.check_ClipboardValue.UseVisualStyleBackColor = true;
            // 
            // panel_ContextMenu
            // 
            this.panel_ContextMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_ContextMenu.Controls.Add(this.btn_RightClickMenu);
            this.panel_ContextMenu.Controls.Add(this.btn_RemoveRightClickMenu);
            this.panel_ContextMenu.Controls.Add(this.label10);
            this.panel_ContextMenu.Location = new System.Drawing.Point(6, 6);
            this.panel_ContextMenu.Name = "panel_ContextMenu";
            this.panel_ContextMenu.Size = new System.Drawing.Size(1169, 264);
            this.panel_ContextMenu.TabIndex = 3;
            // 
            // btn_RightClickMenu
            // 
            this.btn_RightClickMenu.Font = new System.Drawing.Font("PMingLiU", 20F);
            this.btn_RightClickMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_RightClickMenu.Location = new System.Drawing.Point(202, 130);
            this.btn_RightClickMenu.Name = "btn_RightClickMenu";
            this.btn_RightClickMenu.Size = new System.Drawing.Size(284, 112);
            this.btn_RightClickMenu.TabIndex = 0;
            this.btn_RightClickMenu.Text = "Add Hash calculation to \r\ncontext menu\r\n";
            this.btn_RightClickMenu.UseVisualStyleBackColor = true;
            this.btn_RightClickMenu.Click += new System.EventHandler(this.btn_RightClickMenu_Click);
            // 
            // btn_RemoveRightClickMenu
            // 
            this.btn_RemoveRightClickMenu.Font = new System.Drawing.Font("PMingLiU", 20F);
            this.btn_RemoveRightClickMenu.Location = new System.Drawing.Point(704, 130);
            this.btn_RemoveRightClickMenu.Name = "btn_RemoveRightClickMenu";
            this.btn_RemoveRightClickMenu.Size = new System.Drawing.Size(284, 112);
            this.btn_RemoveRightClickMenu.TabIndex = 1;
            this.btn_RemoveRightClickMenu.Text = "Remove Hash calculation\r\nfrom context menu ";
            this.btn_RemoveRightClickMenu.UseVisualStyleBackColor = true;
            this.btn_RemoveRightClickMenu.Click += new System.EventHandler(this.btn_RemoveRightClickMenu_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("PMingLiU", 20F);
            this.label10.Location = new System.Drawing.Point(334, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(538, 27);
            this.label10.TabIndex = 2;
            this.label10.Text = "These two button REQUIRE ADMIN PRIVILEGE";
            // 
            // SimpleHNC
            // 
            this.AcceptButton = this.btn_check;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 598);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.copyright);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SimpleHNC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpleHNC - Beta";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tab_Normal.ResumeLayout(false);
            this.tab_Normal.PerformLayout();
            this.tab_Batch.ResumeLayout(false);
            this.tab_Batch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BatchHash)).EndInit();
            this.btn_.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_ContextMenu.ResumeLayout(false);
            this.panel_ContextMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox targethash;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox crc32check;
        private System.Windows.Forms.CheckBox md5check;
        private System.Windows.Forms.CheckBox sha1check;
        private System.Windows.Forms.CheckBox sha256check;
        private System.Windows.Forms.Label copyright;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.TextBox filelocation;
        public System.Windows.Forms.TextBox md5hash;
        public System.Windows.Forms.TextBox sha256hash;
        public System.Windows.Forms.TextBox sha1hash;
        public System.Windows.Forms.TextBox crc32hash;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_Normal;
        private System.Windows.Forms.TabPage tab_Batch;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button SelectFolder;
        private System.Windows.Forms.TextBox folderPath;
        private System.Windows.Forms.DataGridView BatchHash;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox check_subfolders;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Display_CRC32;
        private System.Windows.Forms.DataGridViewTextBoxColumn Display_MD5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Display_SHA1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Display_SHA256;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.TabPage btn_;
        private System.Windows.Forms.Button btn_RightClickMenu;
        private System.Windows.Forms.Button btn_RemoveRightClickMenu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel_ContextMenu;
        private System.Windows.Forms.CheckBox check_ClipboardValue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox sha384hash;
        public System.Windows.Forms.TextBox sha512hash;
        private System.Windows.Forms.CheckBox sha512check;
        private System.Windows.Forms.CheckBox sha384check;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}

