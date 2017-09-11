namespace Studentski_servis
{
    partial class pocetna
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
            this.Uloguj_se_dugme = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.username1 = new System.Windows.Forms.TextBox();
            this.password1 = new System.Windows.Forms.MaskedTextBox();
            this.registruj = new System.Windows.Forms.Button();
            this.Profesor = new System.Windows.Forms.RadioButton();
            this.Student = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Uloguj_se_dugme
            // 
            this.Uloguj_se_dugme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Uloguj_se_dugme.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Uloguj_se_dugme.Location = new System.Drawing.Point(0, 119);
            this.Uloguj_se_dugme.Name = "Uloguj_se_dugme";
            this.Uloguj_se_dugme.Size = new System.Drawing.Size(237, 23);
            this.Uloguj_se_dugme.TabIndex = 2;
            this.Uloguj_se_dugme.Text = "Uloguj se";
            this.Uloguj_se_dugme.UseVisualStyleBackColor = true;
            this.Uloguj_se_dugme.Click += new System.EventHandler(this.Uloguj_se_dugme_Click);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(13, 14);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(66, 13);
            this.username.TabIndex = 3;
            this.username.Text = "Broj Indeksa";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(51, 37);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(28, 13);
            this.password.TabIndex = 4;
            this.password.Text = "Šifra";
            // 
            // username1
            // 
            this.username1.Location = new System.Drawing.Point(85, 11);
            this.username1.Name = "username1";
            this.username1.Size = new System.Drawing.Size(142, 20);
            this.username1.TabIndex = 0;
            // 
            // password1
            // 
            this.password1.Culture = new System.Globalization.CultureInfo("en-US");
            this.password1.Location = new System.Drawing.Point(85, 34);
            this.password1.Name = "password1";
            this.password1.PasswordChar = '*';
            this.password1.Size = new System.Drawing.Size(142, 20);
            this.password1.TabIndex = 1;
            // 
            // registruj
            // 
            this.registruj.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.registruj.Location = new System.Drawing.Point(0, 93);
            this.registruj.Name = "registruj";
            this.registruj.Size = new System.Drawing.Size(237, 26);
            this.registruj.TabIndex = 5;
            this.registruj.Text = "Registruj se";
            this.registruj.UseVisualStyleBackColor = true;
            this.registruj.Click += new System.EventHandler(this.registruj_Click);
            // 
            // Profesor
            // 
            this.Profesor.AutoSize = true;
            this.Profesor.Location = new System.Drawing.Point(16, 60);
            this.Profesor.Name = "Profesor";
            this.Profesor.Size = new System.Drawing.Size(64, 17);
            this.Profesor.TabIndex = 6;
            this.Profesor.TabStop = true;
            this.Profesor.Text = "Profesor";
            this.Profesor.UseVisualStyleBackColor = true;
            // 
            // Student
            // 
            this.Student.AutoSize = true;
            this.Student.Location = new System.Drawing.Point(138, 60);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(62, 17);
            this.Student.TabIndex = 7;
            this.Student.TabStop = true;
            this.Student.Text = "Student";
            this.Student.UseVisualStyleBackColor = true;
            // 
            // pocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(237, 142);
            this.Controls.Add(this.Student);
            this.Controls.Add(this.Profesor);
            this.Controls.Add(this.registruj);
            this.Controls.Add(this.password1);
            this.Controls.Add(this.username1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.Uloguj_se_dugme);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "pocetna";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Studentski Servis";
            this.Activated += new System.EventHandler(this.pocetna_Activated);
            this.Deactivate += new System.EventHandler(this.pocetna_Deactivate);
            this.Load += new System.EventHandler(this.pocetna_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Uloguj_se_dugme;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.MaskedTextBox password1;
        private System.Windows.Forms.Button registruj;
        public System.Windows.Forms.TextBox username1;
        private System.Windows.Forms.RadioButton Profesor;
        private System.Windows.Forms.RadioButton Student;
    }
}

