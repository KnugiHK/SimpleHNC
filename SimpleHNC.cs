using System;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace SimpleHNC
{
    public partial class SimpleHNC : Form
    {
        public SimpleHNC()
        {
            InitializeComponent();
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
It is match with file MD5 value.", "Matched");
                    }
                    else
                    {
                        if(targethash.Text == sha1hash.Text)
                        {
                            MessageBox.Show(@"Your target value is a SHA-1 value. 
It is match with SHA-1 value.", "Matched");
                        }
                        else
                        {
                            if (targethash.Text == sha256hash.Text)
                            {
                                MessageBox.Show(@"Your target value is a SHA-256 value.
It is match with SHA-256 value.", "Matched");
                            }
                            else
                            {
                                MessageBox.Show("Your target value does not match any hash value above", "Fail");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Hash value must be calculated", "Error");
                }
            }
            else
            {
                MessageBox.Show("Target and Source cannot be empty", "Error");
            }
        }

        static string CalMD5(string filename)
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

        static string CalSHA1(string filename)
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

        static string CalSHA256(string filename)
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

        private void btn_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Title = "Select File";
            OFD.Filter = "All Type (*.*)|*.*";
            OFD.InitialDirectory = ".\\";
            if(OFD.ShowDialog() == DialogResult.OK)
            {
                SimpleHNC f1 = new SimpleHNC();
                f1.Text = "Please wait while calculating";
                filelocation.Text = OFD.FileName;
                if (File.Exists(filelocation.Text))
                {
                    md5hash.Text = CalMD5(filelocation.Text);
                    sha1hash.Text = CalSHA1(filelocation.Text);
                    sha256hash.Text = CalSHA256(filelocation.Text);
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
    }
}
