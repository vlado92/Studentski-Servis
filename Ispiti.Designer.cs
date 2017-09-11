namespace Studentski_servis
{
    partial class Ispiti
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
            this.Polozeni = new System.Windows.Forms.Button();
            this.Nepolozeni = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Polozeni
            // 
            this.Polozeni.Location = new System.Drawing.Point(12, 12);
            this.Polozeni.Name = "Polozeni";
            this.Polozeni.Size = new System.Drawing.Size(126, 23);
            this.Polozeni.TabIndex = 0;
            this.Polozeni.Text = "Položeni ispiti";
            this.Polozeni.UseVisualStyleBackColor = true;
            this.Polozeni.Click += new System.EventHandler(this.Polozeni_Click);
            // 
            // Nepolozeni
            // 
            this.Nepolozeni.Location = new System.Drawing.Point(157, 12);
            this.Nepolozeni.Name = "Nepolozeni";
            this.Nepolozeni.Size = new System.Drawing.Size(115, 23);
            this.Nepolozeni.TabIndex = 1;
            this.Nepolozeni.Text = "Nepoloženi ispiti";
            this.Nepolozeni.UseVisualStyleBackColor = true;
            this.Nepolozeni.Click += new System.EventHandler(this.Nepolozeni_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(260, 199);
            this.listBox1.TabIndex = 2;
            // 
            // Ispiti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Nepolozeni);
            this.Controls.Add(this.Polozeni);
            this.Name = "Ispiti";
            this.Text = "Ispiti";
            this.Load += new System.EventHandler(this.Ispiti_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Polozeni;
        private System.Windows.Forms.Button Nepolozeni;
        private System.Windows.Forms.ListBox listBox1;
    }
}