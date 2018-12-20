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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "MD5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Target Value";
            // 
            // targethash
            // 
            this.targethash.Location = new System.Drawing.Point(88, 175);
            this.targethash.Name = "targethash";
            this.targethash.Size = new System.Drawing.Size(373, 22);
            this.targethash.TabIndex = 2;
            // 
            // md5hash
            // 
            this.md5hash.Location = new System.Drawing.Point(88, 79);
            this.md5hash.Name = "md5hash";
            this.md5hash.ReadOnly = true;
            this.md5hash.Size = new System.Drawing.Size(373, 22);
            this.md5hash.TabIndex = 3;
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(232, 203);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(75, 23);
            this.btn_check.TabIndex = 4;
            this.btn_check.Text = "Check!";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Source File";
            // 
            // filelocation
            // 
            this.filelocation.AllowDrop = true;
            this.filelocation.Location = new System.Drawing.Point(88, 12);
            this.filelocation.Name = "filelocation";
            this.filelocation.ReadOnly = true;
            this.filelocation.Size = new System.Drawing.Size(373, 22);
            this.filelocation.TabIndex = 6;
            this.filelocation.DragDrop += new System.Windows.Forms.DragEventHandler(this.filelocation_DragDrop);
            // 
            // sha256hash
            // 
            this.sha256hash.Location = new System.Drawing.Point(88, 135);
            this.sha256hash.Name = "sha256hash";
            this.sha256hash.ReadOnly = true;
            this.sha256hash.Size = new System.Drawing.Size(373, 22);
            this.sha256hash.TabIndex = 7;
            // 
            // sha1hash
            // 
            this.sha1hash.Location = new System.Drawing.Point(88, 107);
            this.sha1hash.Name = "sha1hash";
            this.sha1hash.ReadOnly = true;
            this.sha1hash.Size = new System.Drawing.Size(373, 22);
            this.sha1hash.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "SHA-256";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 110);
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
            this.btn_open.Location = new System.Drawing.Point(151, 203);
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
            this.label6.Location = new System.Drawing.Point(24, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "CRC32";
            // 
            // crc32hash
            // 
            this.crc32hash.Location = new System.Drawing.Point(88, 51);
            this.crc32hash.Name = "crc32hash";
            this.crc32hash.ReadOnly = true;
            this.crc32hash.Size = new System.Drawing.Size(373, 22);
            this.crc32hash.TabIndex = 13;
            // 
            // crc32check
            // 
            this.crc32check.AutoSize = true;
            this.crc32check.Checked = true;
            this.crc32check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.crc32check.Location = new System.Drawing.Point(67, 54);
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
            this.md5check.Location = new System.Drawing.Point(67, 82);
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
            this.sha1check.Location = new System.Drawing.Point(67, 110);
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
            this.sha256check.Location = new System.Drawing.Point(67, 138);
            this.sha256check.Name = "sha256check";
            this.sha256check.Size = new System.Drawing.Size(15, 14);
            this.sha256check.TabIndex = 17;
            this.sha256check.UseVisualStyleBackColor = true;
            // 
            // btn_Batch
            // 
            this.btn_Batch.Location = new System.Drawing.Point(386, 203);
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
            this.label7.Location = new System.Drawing.Point(1, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 12);
            this.label7.TabIndex = 19;
            this.label7.Text = "© 2018 SimpleHNC";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // SimpleHNC
            // 
            this.AcceptButton = this.btn_check;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 231);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Batch);
            this.Controls.Add(this.sha256check);
            this.Controls.Add(this.sha1check);
            this.Controls.Add(this.md5check);
            this.Controls.Add(this.crc32check);
            this.Controls.Add(this.crc32hash);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sha1hash);
            this.Controls.Add(this.sha256hash);
            this.Controls.Add(this.filelocation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.md5hash);
            this.Controls.Add(this.targethash);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SimpleHNC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpleHNC - Beta";
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
        public System.Windows.Forms.TextBox md5hash;
        public System.Windows.Forms.TextBox filelocation;
        public System.Windows.Forms.TextBox sha256hash;
        public System.Windows.Forms.TextBox sha1hash;
        public System.Windows.Forms.TextBox crc32hash;
        private System.Windows.Forms.Label label7;
    }
}

