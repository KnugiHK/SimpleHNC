// Last modify:1528030015
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
            this.btn_Batch = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_Normal = new System.Windows.Forms.TabPage();
            this.tab_Batch = new System.Windows.Forms.TabPage();
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
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tab_Normal.SuspendLayout();
            this.tab_Batch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BatchHash)).BeginInit();
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
            this.label2.Location = new System.Drawing.Point(331, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Target Value";
            // 
            // targethash
            // 
            this.targethash.Location = new System.Drawing.Point(403, 214);
            this.targethash.Name = "targethash";
            this.targethash.Size = new System.Drawing.Size(373, 22);
            this.targethash.TabIndex = 2;
            // 
            // md5hash
            // 
            this.md5hash.Location = new System.Drawing.Point(403, 118);
            this.md5hash.Name = "md5hash";
            this.md5hash.ReadOnly = true;
            this.md5hash.Size = new System.Drawing.Size(373, 22);
            this.md5hash.TabIndex = 3;
            this.md5hash.Click += new System.EventHandler(this.md5hash_Click);
            // 
            // btn_check
            // 
            this.btn_check.Enabled = false;
            this.btn_check.Location = new System.Drawing.Point(547, 242);
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
            this.filelocation.Size = new System.Drawing.Size(373, 22);
            this.filelocation.TabIndex = 6;
            this.filelocation.DragDrop += new System.Windows.Forms.DragEventHandler(this.filelocation_DragDrop);
            // 
            // sha256hash
            // 
            this.sha256hash.Location = new System.Drawing.Point(403, 174);
            this.sha256hash.Name = "sha256hash";
            this.sha256hash.ReadOnly = true;
            this.sha256hash.Size = new System.Drawing.Size(373, 22);
            this.sha256hash.TabIndex = 7;
            this.sha256hash.Click += new System.EventHandler(this.sha256hash_Click);
            // 
            // sha1hash
            // 
            this.sha1hash.Location = new System.Drawing.Point(403, 146);
            this.sha1hash.Name = "sha1hash";
            this.sha1hash.ReadOnly = true;
            this.sha1hash.Size = new System.Drawing.Size(373, 22);
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
            this.btn_open.Location = new System.Drawing.Point(466, 242);
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
            this.crc32hash.Size = new System.Drawing.Size(373, 22);
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
            // btn_Batch
            // 
            this.btn_Batch.Location = new System.Drawing.Point(701, 242);
            this.btn_Batch.Name = "btn_Batch";
            this.btn_Batch.Size = new System.Drawing.Size(75, 23);
            this.btn_Batch.TabIndex = 18;
            this.btn_Batch.Text = "Batch";
            this.btn_Batch.UseVisualStyleBackColor = true;
            this.btn_Batch.Click += new System.EventHandler(this.btn_Batch_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 577);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 12);
            this.label7.TabIndex = 19;
            this.label7.Text = "© 2018 SimpleHNC";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(403, 61);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(373, 23);
            this.progressBar1.TabIndex = 20;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_Normal);
            this.tabControl1.Controls.Add(this.tab_Batch);
            this.tabControl1.Location = new System.Drawing.Point(-1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1189, 574);
            this.tabControl1.TabIndex = 21;
            // 
            // tab_Normal
            // 
            this.tab_Normal.AllowDrop = true;
            this.tab_Normal.Controls.Add(this.targethash);
            this.tab_Normal.Controls.Add(this.progressBar1);
            this.tab_Normal.Controls.Add(this.label1);
            this.tab_Normal.Controls.Add(this.label2);
            this.tab_Normal.Controls.Add(this.btn_Batch);
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
            // tab_Batch
            // 
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
            this.label9.Font = new System.Drawing.Font("新細明體", 18F);
            this.label9.Location = new System.Drawing.Point(550, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(365, 24);
            this.label9.TabIndex = 10;
            this.label9.Text = "Click any row to put value to calculator";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 18F);
            this.label8.Location = new System.Drawing.Point(568, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(328, 24);
            this.label8.TabIndex = 9;
            this.label8.Text = "Click any column to copy the value";
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("新細明體", 18F);
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
            // SimpleHNC
            // 
            this.AcceptButton = this.btn_check;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 598);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label7);
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
        private System.Windows.Forms.Button btn_Batch;
        private System.Windows.Forms.Label label7;
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
    }
}

