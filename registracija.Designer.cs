namespace Studentski_servis
{
    partial class registracija
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
            this.prijava = new System.Windows.Forms.Button();
            this.JMBG = new System.Windows.Forms.TextBox();
            this.mail = new System.Windows.Forms.TextBox();
            this.telefon = new System.Windows.Forms.TextBox();
            this.datum = new System.Windows.Forms.TextBox();
            this.mesto = new System.Windows.Forms.TextBox();
            this.Pol = new System.Windows.Forms.TextBox();
            this.Ime = new System.Windows.Forms.TextBox();
            this.Index = new System.Windows.Forms.TextBox();
            this.JMBGtext = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.broj = new System.Windows.Forms.TextBox();
            this.imetext = new System.Windows.Forms.TextBox();
            this.brojIndexa = new System.Windows.Forms.TextBox();
            this.polM = new System.Windows.Forms.RadioButton();
            this.polz = new System.Windows.Forms.RadioButton();
            this.rodjenje = new System.Windows.Forms.DateTimePicker();
            this.Prezime = new System.Windows.Forms.TextBox();
            this.prezimetext = new System.Windows.Forms.TextBox();
            this.mestoRodjenja = new System.Windows.Forms.ComboBox();
            this.sifra = new System.Windows.Forms.TextBox();
            this.sifriranje = new System.Windows.Forms.CheckBox();
            this.sifratext = new System.Windows.Forms.MaskedTextBox();
            this.godina = new System.Windows.Forms.ComboBox();
            this.studijskipravac = new System.Windows.Forms.TextBox();
            this.godina_studija = new System.Windows.Forms.TextBox();
            this.studijski_pravac = new System.Windows.Forms.ComboBox();
            this.put = new System.Windows.Forms.ComboBox();
            this.Drzava = new System.Windows.Forms.TextBox();
            this.drzava_text = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // prijava
            // 
            this.prijava.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.prijava.Location = new System.Drawing.Point(0, 373);
            this.prijava.Name = "prijava";
            this.prijava.Size = new System.Drawing.Size(268, 37);
            this.prijava.TabIndex = 16;
            this.prijava.Text = "Prijavi se";
            this.prijava.UseVisualStyleBackColor = true;
            this.prijava.Click += new System.EventHandler(this.prijava_Click);
            // 
            // JMBG
            // 
            this.JMBG.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.JMBG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JMBG.ForeColor = System.Drawing.Color.Black;
            this.JMBG.Location = new System.Drawing.Point(3, 163);
            this.JMBG.Name = "JMBG";
            this.JMBG.ReadOnly = true;
            this.JMBG.Size = new System.Drawing.Size(111, 21);
            this.JMBG.TabIndex = 41;
            this.JMBG.TabStop = false;
            this.JMBG.Text = "JMBG";
            // 
            // mail
            // 
            this.mail.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mail.ForeColor = System.Drawing.Color.Black;
            this.mail.Location = new System.Drawing.Point(3, 186);
            this.mail.Name = "mail";
            this.mail.ReadOnly = true;
            this.mail.Size = new System.Drawing.Size(111, 21);
            this.mail.TabIndex = 40;
            this.mail.TabStop = false;
            this.mail.Text = "E-mail";
            // 
            // telefon
            // 
            this.telefon.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefon.ForeColor = System.Drawing.Color.Black;
            this.telefon.Location = new System.Drawing.Point(3, 209);
            this.telefon.Name = "telefon";
            this.telefon.ReadOnly = true;
            this.telefon.Size = new System.Drawing.Size(111, 21);
            this.telefon.TabIndex = 39;
            this.telefon.TabStop = false;
            this.telefon.Text = "Broj telefona";
            // 
            // datum
            // 
            this.datum.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.datum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datum.ForeColor = System.Drawing.Color.Black;
            this.datum.Location = new System.Drawing.Point(3, 96);
            this.datum.Name = "datum";
            this.datum.ReadOnly = true;
            this.datum.Size = new System.Drawing.Size(111, 21);
            this.datum.TabIndex = 38;
            this.datum.TabStop = false;
            this.datum.Text = "Datum rodjenja";
            // 
            // mesto
            // 
            this.mesto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mesto.ForeColor = System.Drawing.Color.Black;
            this.mesto.Location = new System.Drawing.Point(3, 119);
            this.mesto.Name = "mesto";
            this.mesto.ReadOnly = true;
            this.mesto.Size = new System.Drawing.Size(111, 21);
            this.mesto.TabIndex = 37;
            this.mesto.TabStop = false;
            this.mesto.Text = "Mesto rodjenja";
            // 
            // Pol
            // 
            this.Pol.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Pol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pol.ForeColor = System.Drawing.Color.Black;
            this.Pol.Location = new System.Drawing.Point(3, 73);
            this.Pol.Name = "Pol";
            this.Pol.ReadOnly = true;
            this.Pol.Size = new System.Drawing.Size(111, 21);
            this.Pol.TabIndex = 36;
            this.Pol.TabStop = false;
            this.Pol.Text = "Pol";
            // 
            // Ime
            // 
            this.Ime.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Ime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ime.ForeColor = System.Drawing.Color.Black;
            this.Ime.Location = new System.Drawing.Point(3, 27);
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            this.Ime.Size = new System.Drawing.Size(111, 21);
            this.Ime.TabIndex = 35;
            this.Ime.TabStop = false;
            this.Ime.Text = "Ime";
            // 
            // Index
            // 
            this.Index.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Index.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Index.ForeColor = System.Drawing.Color.Black;
            this.Index.Location = new System.Drawing.Point(3, 3);
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            this.Index.Size = new System.Drawing.Size(111, 21);
            this.Index.TabIndex = 34;
            this.Index.TabStop = false;
            this.Index.Text = "Broj Indeksa";
            // 
            // JMBGtext
            // 
            this.JMBGtext.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.JMBGtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JMBGtext.ForeColor = System.Drawing.Color.Black;
            this.JMBGtext.Location = new System.Drawing.Point(120, 163);
            this.JMBGtext.MaxLength = 13;
            this.JMBGtext.Name = "JMBGtext";
            this.JMBGtext.Size = new System.Drawing.Size(137, 21);
            this.JMBGtext.TabIndex = 8;
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.Color.Black;
            this.email.Location = new System.Drawing.Point(120, 187);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(137, 21);
            this.email.TabIndex = 9;
            // 
            // broj
            // 
            this.broj.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.broj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.broj.ForeColor = System.Drawing.Color.Black;
            this.broj.Location = new System.Drawing.Point(120, 210);
            this.broj.Name = "broj";
            this.broj.Size = new System.Drawing.Size(137, 21);
            this.broj.TabIndex = 10;
            // 
            // imetext
            // 
            this.imetext.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.imetext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imetext.ForeColor = System.Drawing.Color.Black;
            this.imetext.Location = new System.Drawing.Point(120, 27);
            this.imetext.Name = "imetext";
            this.imetext.Size = new System.Drawing.Size(137, 21);
            this.imetext.TabIndex = 2;
            // 
            // brojIndexa
            // 
            this.brojIndexa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.brojIndexa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brojIndexa.ForeColor = System.Drawing.Color.Black;
            this.brojIndexa.Location = new System.Drawing.Point(120, 3);
            this.brojIndexa.Name = "brojIndexa";
            this.brojIndexa.Size = new System.Drawing.Size(137, 21);
            this.brojIndexa.TabIndex = 1;
            // 
            // polM
            // 
            this.polM.AutoSize = true;
            this.polM.Location = new System.Drawing.Point(120, 77);
            this.polM.Name = "polM";
            this.polM.Size = new System.Drawing.Size(52, 17);
            this.polM.TabIndex = 4;
            this.polM.TabStop = true;
            this.polM.Text = "muški";
            this.polM.UseVisualStyleBackColor = true;
            // 
            // polz
            // 
            this.polz.AutoSize = true;
            this.polz.Location = new System.Drawing.Point(202, 77);
            this.polz.Name = "polz";
            this.polz.Size = new System.Drawing.Size(55, 17);
            this.polz.TabIndex = 5;
            this.polz.TabStop = true;
            this.polz.Text = "ženski";
            this.polz.UseVisualStyleBackColor = true;
            // 
            // rodjenje
            // 
            this.rodjenje.AllowDrop = true;
            this.rodjenje.Location = new System.Drawing.Point(120, 98);
            this.rodjenje.MaxDate = new System.DateTime(2014, 12, 31, 0, 0, 0, 0);
            this.rodjenje.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.rodjenje.Name = "rodjenje";
            this.rodjenje.Size = new System.Drawing.Size(137, 20);
            this.rodjenje.TabIndex = 6;
            this.rodjenje.Value = new System.DateTime(2014, 12, 31, 0, 0, 0, 0);
            // 
            // Prezime
            // 
            this.Prezime.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Prezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prezime.ForeColor = System.Drawing.Color.Black;
            this.Prezime.Location = new System.Drawing.Point(3, 49);
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            this.Prezime.Size = new System.Drawing.Size(111, 21);
            this.Prezime.TabIndex = 60;
            this.Prezime.TabStop = false;
            this.Prezime.Text = "Prezime";
            // 
            // prezimetext
            // 
            this.prezimetext.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.prezimetext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prezimetext.ForeColor = System.Drawing.Color.Black;
            this.prezimetext.Location = new System.Drawing.Point(120, 49);
            this.prezimetext.Name = "prezimetext";
            this.prezimetext.Size = new System.Drawing.Size(137, 21);
            this.prezimetext.TabIndex = 3;
            // 
            // mestoRodjenja
            // 
            this.mestoRodjenja.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.mestoRodjenja.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.mestoRodjenja.FormattingEnabled = true;
            this.mestoRodjenja.Items.AddRange(new object[] {
            "Foca",
            "Zvornik",
            "Bijeljina",
            "Bratunac"});
            this.mestoRodjenja.Location = new System.Drawing.Point(120, 119);
            this.mestoRodjenja.Name = "mestoRodjenja";
            this.mestoRodjenja.Size = new System.Drawing.Size(137, 21);
            this.mestoRodjenja.TabIndex = 7;
            this.mestoRodjenja.SelectedIndexChanged += new System.EventHandler(this.mestoRodjenja_SelectedIndexChanged);
            // 
            // sifra
            // 
            this.sifra.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.sifra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sifra.ForeColor = System.Drawing.Color.Black;
            this.sifra.Location = new System.Drawing.Point(3, 280);
            this.sifra.Name = "sifra";
            this.sifra.ReadOnly = true;
            this.sifra.Size = new System.Drawing.Size(111, 21);
            this.sifra.TabIndex = 66;
            this.sifra.TabStop = false;
            this.sifra.Text = "Sifra";
            // 
            // sifriranje
            // 
            this.sifriranje.AutoSize = true;
            this.sifriranje.Checked = true;
            this.sifriranje.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sifriranje.Location = new System.Drawing.Point(134, 303);
            this.sifriranje.Name = "sifriranje";
            this.sifriranje.Size = new System.Drawing.Size(73, 17);
            this.sifriranje.TabIndex = 15;
            this.sifriranje.TabStop = false;
            this.sifriranje.Text = "Prikrij sifru";
            this.sifriranje.UseVisualStyleBackColor = true;
            this.sifriranje.CheckedChanged += new System.EventHandler(this.sifriranje_CheckedChanged);
            // 
            // sifratext
            // 
            this.sifratext.BeepOnError = true;
            this.sifratext.Location = new System.Drawing.Point(120, 281);
            this.sifratext.Name = "sifratext";
            this.sifratext.PromptChar = '-';
            this.sifratext.Size = new System.Drawing.Size(137, 20);
            this.sifratext.TabIndex = 14;
            // 
            // godina
            // 
            this.godina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.godina.FormattingEnabled = true;
            this.godina.Items.AddRange(new object[] {
            "Prva",
            "Druga",
            "Treca",
            "Cetvrta",
            "Apsolvent",
            "Master",
            "Doktorat"});
            this.godina.Location = new System.Drawing.Point(120, 232);
            this.godina.Name = "godina";
            this.godina.Size = new System.Drawing.Size(87, 21);
            this.godina.TabIndex = 11;
            // 
            // studijskipravac
            // 
            this.studijskipravac.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.studijskipravac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studijskipravac.ForeColor = System.Drawing.Color.Black;
            this.studijskipravac.Location = new System.Drawing.Point(3, 257);
            this.studijskipravac.Name = "studijskipravac";
            this.studijskipravac.ReadOnly = true;
            this.studijskipravac.Size = new System.Drawing.Size(111, 21);
            this.studijskipravac.TabIndex = 76;
            this.studijskipravac.TabStop = false;
            this.studijskipravac.Text = "Studijski Pravac";
            // 
            // godina_studija
            // 
            this.godina_studija.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.godina_studija.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.godina_studija.ForeColor = System.Drawing.Color.Black;
            this.godina_studija.Location = new System.Drawing.Point(3, 232);
            this.godina_studija.Name = "godina_studija";
            this.godina_studija.ReadOnly = true;
            this.godina_studija.Size = new System.Drawing.Size(111, 21);
            this.godina_studija.TabIndex = 73;
            this.godina_studija.TabStop = false;
            this.godina_studija.Text = "Godina Studija";
            // 
            // studijski_pravac
            // 
            this.studijski_pravac.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.studijski_pravac.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.studijski_pravac.FormattingEnabled = true;
            this.studijski_pravac.Location = new System.Drawing.Point(120, 258);
            this.studijski_pravac.Name = "studijski_pravac";
            this.studijski_pravac.Size = new System.Drawing.Size(137, 21);
            this.studijski_pravac.TabIndex = 13;
            // 
            // put
            // 
            this.put.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.put.FormattingEnabled = true;
            this.put.Items.AddRange(new object[] {
            "1. put",
            "2. put",
            "3. put",
            "4. put"});
            this.put.Location = new System.Drawing.Point(209, 232);
            this.put.Name = "put";
            this.put.Size = new System.Drawing.Size(45, 21);
            this.put.TabIndex = 12;
            // 
            // Drzava
            // 
            this.Drzava.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Drzava.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drzava.ForeColor = System.Drawing.Color.Black;
            this.Drzava.Location = new System.Drawing.Point(3, 141);
            this.Drzava.Name = "Drzava";
            this.Drzava.ReadOnly = true;
            this.Drzava.Size = new System.Drawing.Size(111, 21);
            this.Drzava.TabIndex = 77;
            this.Drzava.TabStop = false;
            this.Drzava.Text = "Država rođenja";
            // 
            // drzava_text
            // 
            this.drzava_text.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.drzava_text.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.drzava_text.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drzava_text.FormattingEnabled = true;
            this.drzava_text.Items.AddRange(new object[] {
            "Foca",
            "Zvornik",
            "Bijeljina",
            "Bratunac"});
            this.drzava_text.Location = new System.Drawing.Point(120, 144);
            this.drzava_text.Name = "drzava_text";
            this.drzava_text.Size = new System.Drawing.Size(137, 21);
            this.drzava_text.TabIndex = 78;
            this.drzava_text.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.Items.AddRange(new object[] {
            "Budžet",
            "Samofinasiranje",
            "Vanredno"});
            this.listBox1.Location = new System.Drawing.Point(0, 326);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(286, 43);
            this.listBox1.TabIndex = 79;
            // 
            // registracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 410);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.drzava_text);
            this.Controls.Add(this.Drzava);
            this.Controls.Add(this.put);
            this.Controls.Add(this.studijski_pravac);
            this.Controls.Add(this.godina);
            this.Controls.Add(this.studijskipravac);
            this.Controls.Add(this.godina_studija);
            this.Controls.Add(this.sifratext);
            this.Controls.Add(this.sifriranje);
            this.Controls.Add(this.sifra);
            this.Controls.Add(this.mestoRodjenja);
            this.Controls.Add(this.prezimetext);
            this.Controls.Add(this.Prezime);
            this.Controls.Add(this.rodjenje);
            this.Controls.Add(this.polz);
            this.Controls.Add(this.polM);
            this.Controls.Add(this.JMBGtext);
            this.Controls.Add(this.email);
            this.Controls.Add(this.broj);
            this.Controls.Add(this.imetext);
            this.Controls.Add(this.brojIndexa);
            this.Controls.Add(this.JMBG);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.telefon);
            this.Controls.Add(this.datum);
            this.Controls.Add(this.mesto);
            this.Controls.Add(this.Pol);
            this.Controls.Add(this.Ime);
            this.Controls.Add(this.Index);
            this.Controls.Add(this.prijava);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "registracija";
            this.Text = "registracija";
            this.Load += new System.EventHandler(this.registracija_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button prijava;
        private System.Windows.Forms.TextBox JMBG;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.TextBox telefon;
        private System.Windows.Forms.TextBox datum;
        private System.Windows.Forms.TextBox mesto;
        private System.Windows.Forms.TextBox Pol;
        private System.Windows.Forms.TextBox Ime;
        private System.Windows.Forms.TextBox Index;
        private System.Windows.Forms.TextBox JMBGtext;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox broj;
        private System.Windows.Forms.TextBox imetext;
        private System.Windows.Forms.TextBox brojIndexa;
        private System.Windows.Forms.RadioButton polM;
        private System.Windows.Forms.RadioButton polz;
        private System.Windows.Forms.DateTimePicker rodjenje;
        private System.Windows.Forms.TextBox Prezime;
        private System.Windows.Forms.TextBox prezimetext;
        private System.Windows.Forms.ComboBox mestoRodjenja;
        private System.Windows.Forms.TextBox sifra;
        private System.Windows.Forms.CheckBox sifriranje;
        private System.Windows.Forms.MaskedTextBox sifratext;
        private System.Windows.Forms.ComboBox godina;
        private System.Windows.Forms.TextBox studijskipravac;
        private System.Windows.Forms.TextBox godina_studija;
        private System.Windows.Forms.ComboBox studijski_pravac;
        private System.Windows.Forms.ComboBox put;
        private System.Windows.Forms.TextBox Drzava;
        private System.Windows.Forms.ComboBox drzava_text;
        private System.Windows.Forms.ListBox listBox1;
    }
}