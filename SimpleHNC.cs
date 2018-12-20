// Last modify:1545310805
using System;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using DamienG.Security.Cryptography;
using System.Threading;

namespace SimpleHNC
{
    public partial class SimpleHNC : Form
    {
        Batch BatchForm = new Batch();
        
        public SimpleHNC()
        {
            InitializeComponent();

            BatchForm.Owner = this;
            BatchForm.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(filelocation.Text) && !String.IsNullOrEmpty(targethash.Text))
            {
                if(!String.IsNullOrEmpty(md5hash.Text) && !String.IsNullOrEmpty(sha1hash.Text) && !String.IsNullOrEmpty(sha256hash.Text))
                {
                    if(targethash.Text == md5hash.Text)
                    {
                        MessageBox.Show(@"Your target value is a MD5 value.
It is match with MD5 value of Source file.", "Matched");
                    }
                    else
                    {
                        if(targethash.Text == sha1hash.Text)
                        {
                            MessageBox.Show(@"Your target value is a SHA-1 value. 
It is match with SHA-1 value of Source file.", "Matched");
                        }
                        else
                        {
                            if (targethash.Text == sha256hash.Text)
                            {
                                MessageBox.Show(@"Your target value is a SHA-256 value.
It is match with SHA-256 value of Source file.", "Matched");
                            }
                            else
                            {
                                if (targethash.Text == crc32hash.Text)
                                {
                                    MessageBox.Show(@"Your target value is a CRC32 value.
It is match with CRC32 value of Source file.", "Matched");
                                }
                                else
                                {
                                    MessageBox.Show("Your target value does not match any hash value above.", "Fail");
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Hash value must be calculated.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Target and Source cannot be empty.", "Error");
            }
        }

        public static string CalMD5(string filename)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filename))
                {
                    var hash = md5.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }

        public static string CalSHA1(string filename)
        {
            using (var sha1 = SHA1.Create())
            {
                using (var stream = File.OpenRead(filename))
                {
                    var hash = sha1.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }

        public static string CalSHA256(string filename)
        {
            using (var sha256 = SHA256.Create())
            {
                using (var stream = File.OpenRead(filename))
                {
                    var hash = sha256.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }
        public static string CalCRC32(string filename)
        {
            var crc32 = new Crc32();
            var hash = String.Empty;

            using (var fs = File.Open(filename, FileMode.Open))
                foreach (byte b in crc32.ComputeHash(fs)) hash += b.ToString("x2").ToLower();

            return hash;

        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Title = "Select File";
            OFD.Filter = "All Type (*.*)|*.*";
            OFD.InitialDirectory = ".\\";
            if(OFD.ShowDialog() == DialogResult.OK)
            {
                md5hash.Text = "";
                sha1hash.Text = "";
                sha256hash.Text = "";
                crc32hash.Text = "";
                SimpleHNC BatchForm = new SimpleHNC();
                filelocation.Text = OFD.FileName;
                if (File.Exists(filelocation.Text))
                {
                    if (md5check.Checked)
                    {
                        md5hash.Text = CalMD5(filelocation.Text);
                    }
                    if (sha1check.Checked)
                    {
                        sha1hash.Text = CalSHA1(filelocation.Text);
                    }
                    if (sha256check.Checked)
                    {
                        sha256hash.Text = CalSHA256(filelocation.Text);
                    }
                    if (crc32check.Checked)
                    {
                        crc32hash.Text = CalCRC32(filelocation.Text);
                    }
                }
                else
                {
                    MessageBox.Show("Source File cannot found", "Error");
                }
            }
        }

        private void filelocation_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files != null && files.Length != 0)
            {
                filelocation.Text = files[0];
            }
        }

        private void ShowWaitingMsg()
        {
        }

        private void btn_Batch_Click(object sender, EventArgs e)
        {
                BatchForm.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for hash function icon by dDara from the Noun Project" + "\n\n" + @"Copyright 2018 MultiPlay Fun Studio

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the 'Software'), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED 'AS IS', WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.",

        "SimpleHNC Beta 2 Credit");

        }

    }
}
