using System;
using System.IO;
using System.Windows.Forms;

namespace GetSha384Example
{
    public partial class MainForm : Form
    {
        public MainForm() => InitializeComponent();

        public static string GetSHA384(string filepath)
        {
            FileStream filestream = new FileStream(filepath, FileMode.Open)
            {
                Position = 0
            };

            return BitConverter.ToString(System.Security.Cryptography.SHA384.Create().ComputeHash(filestream))
                               .Replace("-", string.Empty);
        }

        private void SelectFileBTN_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Sha384Output.Text = GetSHA384(openFileDialog1.FileName);
                    CurrentFileLabel.Text = openFileDialog1.FileName;
                    Sha384Output.Focus();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return;
                }
            }
            return;
        }

        private void Sha384Output_Enter(object sender, EventArgs e) => Sha384Output.SelectAll();
    }
}
