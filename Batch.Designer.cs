namespace SimpleHNC
{
    partial class Batch
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CRC32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MD5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SHA1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SHA256 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.folderPath = new System.Windows.Forms.TextBox();
            this.SelectFolder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileName,
            this.CRC32,
            this.MD5,
            this.SHA1,
            this.SHA256});
            this.dataGridView1.Location = new System.Drawing.Point(12, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(1107, 330);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // FileName
            // 
            this.FileName.HeaderText = "FileName";
            this.FileName.MinimumWidth = 10;
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            this.FileName.Width = 150;
            // 
            // CRC32
            // 
            this.CRC32.HeaderText = "CRC32";
            this.CRC32.Name = "CRC32";
            this.CRC32.ReadOnly = true;
            this.CRC32.Width = 65;
            // 
            // MD5
            // 
            this.MD5.HeaderText = "MD5";
            this.MD5.Name = "MD5";
            this.MD5.ReadOnly = true;
            this.MD5.Width = 200;
            // 
            // SHA1
            // 
            this.SHA1.HeaderText = "SHA1";
            this.SHA1.Name = "SHA1";
            this.SHA1.ReadOnly = true;
            this.SHA1.Width = 250;
            // 
            // SHA256
            // 
            this.SHA256.HeaderText = "SHA256";
            this.SHA256.Name = "SHA256";
            this.SHA256.ReadOnly = true;
            this.SHA256.Width = 380;
            // 
            // folderPath
            // 
            this.folderPath.Location = new System.Drawing.Point(29, 29);
            this.folderPath.Name = "folderPath";
            this.folderPath.ReadOnly = true;
            this.folderPath.Size = new System.Drawing.Size(370, 22);
            this.folderPath.TabIndex = 1;
            // 
            // SelectFolder
            // 
            this.SelectFolder.Location = new System.Drawing.Point(417, 27);
            this.SelectFolder.Name = "SelectFolder";
            this.SelectFolder.Size = new System.Drawing.Size(75, 23);
            this.SelectFolder.TabIndex = 2;
            this.SelectFolder.Text = "Select Folder";
            this.SelectFolder.UseVisualStyleBackColor = true;
            this.SelectFolder.Click += new System.EventHandler(this.SelectFolder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 18F);
            this.label1.Location = new System.Drawing.Point(538, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Click any column to copy the value";
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("新細明體", 18F);
            this.btn_back.Location = new System.Drawing.Point(928, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(191, 46);
            this.btn_back.TabIndex = 4;
            this.btn_back.Text = "Back to calculation";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 18F);
            this.label2.Location = new System.Drawing.Point(538, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(365, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Click any row to put value to calculator";
            // 
            // Batch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 412);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectFolder);
            this.Controls.Add(this.folderPath);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Batch";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpleHNC - Batch";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox folderPath;
        private System.Windows.Forms.Button SelectFolder;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRC32;
        private System.Windows.Forms.DataGridViewTextBoxColumn MD5;
        private System.Windows.Forms.DataGridViewTextBoxColumn SHA1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SHA256;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label2;
    }
}