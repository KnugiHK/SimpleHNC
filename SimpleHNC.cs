﻿// Last modify:1545310805
using System;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using DamienG.Security.Cryptography; //Using library from DamienGKit for calculate CRC32 value
using System.ComponentModel;
using System.Threading;

namespace SimpleHNC
{
    public struct mainUI
    {
        public string filelocation;
        public string crc32;
        public string md5;
        public string sha1;
        public string sha256;
    };

    public partial class SimpleHNC : Form //public partial class SimpleHNC : Form
    {

        //Create "Batch" in the beginning

        private BackgroundWorker bw;
        public string md5value;
        public string sha1value;
        public string sha256value;
        public string crc32value;

        public SimpleHNC()
        {
            InitializeComponent();
            //Specifing this the the owner of "Batch"

            //initBackgroundWorker();
            if (null == System.Windows.Application.Current)
            {
                new System.Windows.Application();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Check if the textbox is empty
            if(!String.IsNullOrEmpty(filelocation.Text) && !String.IsNullOrEmpty(targethash.Text))
            {
                if(!String.IsNullOrEmpty(md5hash.Text) || 
                   !String.IsNullOrEmpty(sha1hash.Text) || 
                   !String.IsNullOrEmpty(sha256hash.Text) || 
                   !String.IsNullOrEmpty(crc32hash.Text))
                    {
                    //if target hash value match md5's
                    if (targethash.Text == md5hash.Text)
                    {
                        MessageBox.Show(@"Your target value is a MD5 value.
It is match with MD5 value of Source file.", "Matched");
                    }
                    else
                    {
                        //if target hash value match sha1's
                        if (targethash.Text == sha1hash.Text)
                        {
                            MessageBox.Show(@"Your target value is a SHA-1 value. 
It is match with SHA-1 value of Source file.", "Matched");
                        }
                        else
                        {
                            //if target hash value match sha256's
                            if (targethash.Text == sha256hash.Text)
                            {
                                MessageBox.Show(@"Your target value is a SHA-256 value.
It is match with SHA-256 value of Source file.", "Matched");
                            }
                            else
                            {
                                //if target hash value match crc32's
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

        //Calculating MD5 hash value
        public static string CalMD5(string filename)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filename))
                {
                    //Calculate hash value using methon in MD5 with the file chosen in File.OpenRead()
                    var hash = md5.ComputeHash(stream); 
                    //Convert hash from BIN to HEX and replace "-" to "" and change every letter to lower case
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }

        //Calculating SHA1 hash value
        public static string CalSHA1(string filename)
        {
            using (var sha1 = SHA1.Create())
            {
                using (var stream = File.OpenRead(filename))
                {
                    //Calculate hash value using methon in SHA-1 with the file chosen in File.OpenRead()
                    var hash = sha1.ComputeHash(stream);
                    //Convert hash from BIN to HEX and replace "-" to "" and change every letter to lower case
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }

        //Calculating SHA256 hash value
        public static string CalSHA256(string filename)
        {
            using (var sha256 = SHA256.Create())
            {
                using (var stream = File.OpenRead(filename))
                {
                    //Calculate hash value using methon in SHA-256 with the file chosen in File.OpenRead()
                    var hash = sha256.ComputeHash(stream);
                    //Convert hash from BIN to HEX and replace "-" to "" and change every letter to lower case
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }

        //Calculating CRC32 hash value
        public static string CalCRC32(string filename)
        {
            var crc32 = new Crc32();
            var hash = String.Empty;

            using (var fs = File.Open(filename, FileMode.Open))
                foreach (byte b in crc32.ComputeHash(fs)) //Calculate every byte of the file by using ComputeHash()
                {
                    hash += b.ToString("x2").ToLower();
                }
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
                btn_open.Enabled = false;
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
                    btn_open.Enabled = true;

                    //Calculate at another thread
                    /**Invoke(new Action(() =>
                    {
                        bw.RunWorkerAsync();
                    }));**/
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

            this.Hide();
            Batch BatchForm = new Batch();
            BatchForm.Closed += (s, args) => this.Close();
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

        private void crc32hash_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(crc32hash.Text))
            {
                crc32hash.SelectAll();
                Clipboard.SetText(crc32hash.Text);
            }
        }

        private void md5hash_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(md5hash.Text))
            {
                md5hash.SelectAll();
                Clipboard.SetText(md5hash.Text);
            }
        }

        private void sha1hash_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(sha1hash.Text))
            {
                sha1hash.SelectAll();
                Clipboard.SetText(sha1hash.Text);
            }
        }

        private void sha256hash_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(sha256hash.Text))
            {
                sha256hash.SelectAll();
                Clipboard.SetText(sha256hash.Text);
            }
        }
        
        //TODO: Calculate at background
        /**private void initBackgroundWorker()
        {
            bw = new BackgroundWorker();
            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;
            bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            bw.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_WorkerCompleted);
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {

            MethodInvoker mi = new MethodInvoker(UpdateUI);
            BeginInvoke(mi, null);
            if (md5check.Checked)
            {
                md5value = CalMD5(filelocation.Text);
            }
            if (sha1check.Checked)
            {
                sha1value = CalSHA1(filelocation.Text);
            }
            if (sha256check.Checked)
            {
                sha256value = CalSHA256(filelocation.Text);
            }
            if (crc32check.Checked)
            {
                crc32value = CalCRC32(filelocation.Text);
            }

            //System.Windows.Application.Current.Dispatcher.BeginInvoke(a);

        }

        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            string x = e.ProgressPercentage.ToString();
        }

        private void bw_WorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                btn_open.Enabled = true;
            }));

        }

        private void UpdateUI()
        {
            MessageBox.Show("Completed");
            crc32hash.Text = crc32value;
            md5hash.Text = md5value;
            sha1hash.Text = sha1value;
            sha256hash.Text = sha256value;
        }**/

    }

}
