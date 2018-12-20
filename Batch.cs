// Last modify:1545310805
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace SimpleHNC
{
    public partial class Batch : Form
    {
        public Batch()
        {
            InitializeComponent();
        }

        private void SelectFolder_Click(object sender, EventArgs e)
        {
            OpenFileDialog folderBrowser = new OpenFileDialog();
            folderBrowser.ValidateNames = false;
            folderBrowser.CheckFileExists = false;
            folderBrowser.CheckPathExists = true;
            folderBrowser.FileName = "Folder Selection.";
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                folderPath.Text = Path.GetDirectoryName(folderBrowser.FileName);
            }
            if (String.IsNullOrEmpty(folderPath.Text))
            {
                return;
            }
            int fCount = Directory.GetFiles(folderPath.Text, "*", SearchOption.TopDirectoryOnly).Length;
            
            DirectoryInfo d = new DirectoryInfo(folderPath.Text);
            FileInfo[] Files = d.GetFiles("*.*");
            string str = "";
            foreach (FileInfo file in Files)
            {
                str = str + "," + file.Name;
            }
            string[] filename = str.Split(',');
            int i = 1;
            while (i <= fCount)
            {
                string fileXlocation = folderPath.Text + "\\" + filename[i];

                this.dataGridView1.Rows.Add(filename[i], SimpleHNC.CalCRC32(fileXlocation),
                                                         SimpleHNC.CalMD5(fileXlocation),
                                                         SimpleHNC.CalSHA1(fileXlocation),
                                                         SimpleHNC.CalSHA256(fileXlocation));
                i++;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.Value != null)
            {
                Clipboard.SetDataObject(dataGridView1.CurrentCell.Value.ToString(), false);
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SimpleHNC main = new SimpleHNC();
            int IndexOfRow = dataGridView1.CurrentCell.RowIndex;
            if (dataGridView1.Rows[IndexOfRow].Cells[0].Value != null)
            {
                main.filelocation.Text = folderPath.Text + dataGridView1.Rows[IndexOfRow].Cells[0].Value.ToString();
                main.crc32hash.Text = dataGridView1.Rows[IndexOfRow].Cells[1].Value.ToString();
                main.md5hash.Text = dataGridView1.Rows[IndexOfRow].Cells[2].Value.ToString();
                main.sha1hash.Text = dataGridView1.Rows[IndexOfRow].Cells[3].Value.ToString();
                main.sha256hash.Text = dataGridView1.Rows[IndexOfRow].Cells[4].Value.ToString();
                main.Show();
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            SimpleHNC f2 = (SimpleHNC)this.Owner;
            f2.Show();
        }

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
    }
}
