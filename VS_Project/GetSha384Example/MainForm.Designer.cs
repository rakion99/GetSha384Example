namespace GetSha384Example
{
    partial class MainForm
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
            this.SelectFileBTN = new System.Windows.Forms.Button();
            this.Sha384Output = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.CurrentFileLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SelectFileBTN
            // 
            this.SelectFileBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectFileBTN.Location = new System.Drawing.Point(12, 25);
            this.SelectFileBTN.Name = "SelectFileBTN";
            this.SelectFileBTN.Size = new System.Drawing.Size(135, 49);
            this.SelectFileBTN.TabIndex = 0;
            this.SelectFileBTN.Text = "Select File";
            this.SelectFileBTN.UseVisualStyleBackColor = true;
            this.SelectFileBTN.Click += new System.EventHandler(this.SelectFileBTN_Click);
            // 
            // Sha384Output
            // 
            this.Sha384Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sha384Output.Location = new System.Drawing.Point(12, 92);
            this.Sha384Output.Name = "Sha384Output";
            this.Sha384Output.ReadOnly = true;
            this.Sha384Output.Size = new System.Drawing.Size(750, 131);
            this.Sha384Output.TabIndex = 1;
            this.Sha384Output.Text = "";
            this.Sha384Output.Enter += new System.EventHandler(this.Sha384Output_Enter);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.SupportMultiDottedExtensions = true;
            // 
            // CurrentFileLabel
            // 
            this.CurrentFileLabel.AutoSize = true;
            this.CurrentFileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentFileLabel.Location = new System.Drawing.Point(9, 228);
            this.CurrentFileLabel.Name = "CurrentFileLabel";
            this.CurrentFileLabel.Size = new System.Drawing.Size(0, 16);
            this.CurrentFileLabel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 253);
            this.Controls.Add(this.CurrentFileLabel);
            this.Controls.Add(this.Sha384Output);
            this.Controls.Add(this.SelectFileBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GetSha384Example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SelectFileBTN;
        private System.Windows.Forms.RichTextBox Sha384Output;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label CurrentFileLabel;
    }
}