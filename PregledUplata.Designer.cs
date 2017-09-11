namespace Studentski_servis
{
    partial class UplateSkolarine
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
            this.Predmet = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vrsta = new System.Windows.Forms.ListBox();
            this.ime = new System.Windows.Forms.TextBox();
            this.prezime = new System.Windows.Forms.TextBox();
            this.index = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.vrsta1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Predmet
            // 
            this.Predmet.AutoSize = true;
            this.Predmet.Location = new System.Drawing.Point(250, 187);
            this.Predmet.Name = "Predmet";
            this.Predmet.Size = new System.Drawing.Size(26, 13);
            this.Predmet.TabIndex = 28;
            this.Predmet.Text = "Ispit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Datum uplate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Visina uplate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Vrsta uplate";
            // 
            // vrsta
            // 
            this.vrsta.FormattingEnabled = true;
            this.vrsta.Location = new System.Drawing.Point(15, 46);
            this.vrsta.Name = "vrsta";
            this.vrsta.Size = new System.Drawing.Size(316, 121);
            this.vrsta.TabIndex = 20;
            // 
            // ime
            // 
            this.ime.Enabled = false;
            this.ime.Location = new System.Drawing.Point(82, 5);
            this.ime.Name = "ime";
            this.ime.ReadOnly = true;
            this.ime.Size = new System.Drawing.Size(112, 20);
            this.ime.TabIndex = 19;
            // 
            // prezime
            // 
            this.prezime.Enabled = false;
            this.prezime.Location = new System.Drawing.Point(203, 5);
            this.prezime.Name = "prezime";
            this.prezime.ReadOnly = true;
            this.prezime.Size = new System.Drawing.Size(97, 20);
            this.prezime.TabIndex = 18;
            // 
            // index
            // 
            this.index.Enabled = false;
            this.index.Location = new System.Drawing.Point(13, 5);
            this.index.Name = "index";
            this.index.ReadOnly = true;
            this.index.Size = new System.Drawing.Size(60, 20);
            this.index.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Datum uplate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(177, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Visina uplate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(108, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Vrsta uplate";
            // 
            // vrsta1
            // 
            this.vrsta1.FormattingEnabled = true;
            this.vrsta1.Location = new System.Drawing.Point(15, 203);
            this.vrsta1.Name = "vrsta1";
            this.vrsta1.Size = new System.Drawing.Size(316, 173);
            this.vrsta1.TabIndex = 32;
            // 
            // UplateSkolarine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 388);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.vrsta1);
            this.Controls.Add(this.Predmet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vrsta);
            this.Controls.Add(this.ime);
            this.Controls.Add(this.prezime);
            this.Controls.Add(this.index);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UplateSkolarine";
            this.Text = "Pregled uplata";
            this.Load += new System.EventHandler(this.UplateSkolarine_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Predmet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox vrsta;
        private System.Windows.Forms.TextBox ime;
        private System.Windows.Forms.TextBox prezime;
        private System.Windows.Forms.TextBox index;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox vrsta1;
    }
}