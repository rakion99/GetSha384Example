using System;
using System.IO;
using System.Windows.Forms;

namespace GetSha384Example
{
    public partial class MainForm : Form
    {
        public MainForm() => InitializeComponent();

        public string GetSHA384(string filepath)
        {
            FileStream filestream = new FileStream(filepath, FileMode.Open)
            {
                Position = 0
            };
            var filehash = BitConverter.ToString(System.Security.Cryptography.SHA384.Create().ComputeHash(filestream))
                               .Replace("-", string.Empty);
            filestream.Close();
            return filehash;
        }

        private void SelectFileBTN_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    foreach (string file in openFileDialog1.FileNames)
                    {
                        dataGridView1.Rows.Add(Path.GetFileName(file), GetSHA384(file));
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return;
                }
            }
            return;
        }
    }
}
