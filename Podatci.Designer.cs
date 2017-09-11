namespace Studentski_servis
{
    partial class Glavno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Glavno));
            this.Početna = new System.Windows.Forms.Button();
            this.Slika = new System.Windows.Forms.PictureBox();
            this.Index = new System.Windows.Forms.TextBox();
            this.Ime_prezime = new System.Windows.Forms.TextBox();
            this.Pol = new System.Windows.Forms.TextBox();
            this.mesto = new System.Windows.Forms.TextBox();
            this.datum = new System.Windows.Forms.TextBox();
            this.telefon = new System.Windows.Forms.TextBox();
            this.mail = new System.Windows.Forms.TextBox();
            this.JMBG = new System.Windows.Forms.TextBox();
            this.JMBGtext = new System.Windows.Forms.TextBox();
            this.emailtext = new System.Windows.Forms.TextBox();
            this.brojtelefonatext = new System.Windows.Forms.TextBox();
            this.mjestotext = new System.Windows.Forms.TextBox();
            this.poltext = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.broj_indexa = new System.Windows.Forms.TextBox();
            this.potvrda_nove = new System.Windows.Forms.TextBox();
            this.nova_sifra = new System.Windows.Forms.TextBox();
            this.stara_sifra = new System.Windows.Forms.TextBox();
            this.promjena_sifre = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.sifriranje = new System.Windows.Forms.CheckBox();
            this.starasifra = new System.Windows.Forms.MaskedTextBox();
            this.novatext = new System.Windows.Forms.MaskedTextBox();
            this.potvrdatext = new System.Windows.Forms.MaskedTextBox();
            this.Podatci = new System.Windows.Forms.Button();
            this.Promjena_lozinke = new System.Windows.Forms.Button();
            this.studijski = new System.Windows.Forms.TextBox();
            this.studijskiprogram = new System.Windows.Forms.TextBox();
            this.godinastudijatext = new System.Windows.Forms.TextBox();
            this.godinastudija = new System.Windows.Forms.TextBox();
            this.put = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Slika)).BeginInit();
            this.SuspendLayout();
            // 
            // Početna
            // 
            this.Početna.Dock = System.Windows.Forms.DockStyle.Top;
            this.Početna.Location = new System.Drawing.Point(0, 0);
            this.Početna.Name = "Početna";
            this.Početna.Size = new System.Drawing.Size(616, 33);
            this.Početna.TabIndex = 1;
            this.Početna.Text = "Početna";
            this.Početna.UseVisualStyleBackColor = true;
            this.Početna.Click += new System.EventHandler(this.Početna_Click);
            // 
            // Slika
            // 
            this.Slika.Image = ((System.Drawing.Image)(resources.GetObject("Slika.Image")));
            this.Slika.Location = new System.Drawing.Point(0, 72);
            this.Slika.Name = "Slika";
            this.Slika.Size = new System.Drawing.Size(70, 74);
            this.Slika.TabIndex = 12;
            this.Slika.TabStop = false;
            // 
            // Index
            // 
            this.Index.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Index.Enabled = false;
            this.Index.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Index.ForeColor = System.Drawing.Color.Black;
            this.Index.Location = new System.Drawing.Point(76, 71);
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            this.Index.Size = new System.Drawing.Size(111, 21);
            this.Index.TabIndex = 19;
            this.Index.TabStop = false;
            this.Index.Text = "Broj Indeksa";
            // 
            // Ime_prezime
            // 
            this.Ime_prezime.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Ime_prezime.Enabled = false;
            this.Ime_prezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ime_prezime.ForeColor = System.Drawing.Color.Black;
            this.Ime_prezime.Location = new System.Drawing.Point(76, 94);
            this.Ime_prezime.Name = "Ime_prezime";
            this.Ime_prezime.ReadOnly = true;
            this.Ime_prezime.Size = new System.Drawing.Size(111, 21);
            this.Ime_prezime.TabIndex = 20;
            this.Ime_prezime.TabStop = false;
            this.Ime_prezime.Text = "Ime i Prezime";
            // 
            // Pol
            // 
            this.Pol.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Pol.Enabled = false;
            this.Pol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pol.ForeColor = System.Drawing.Color.Black;
            this.Pol.Location = new System.Drawing.Point(76, 117);
            this.Pol.Name = "Pol";
            this.Pol.ReadOnly = true;
            this.Pol.Size = new System.Drawing.Size(111, 21);
            this.Pol.TabIndex = 21;
            this.Pol.TabStop = false;
            this.Pol.Text = "Pol";
            // 
            // mesto
            // 
            this.mesto.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.mesto.Enabled = false;
            this.mesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mesto.ForeColor = System.Drawing.Color.Black;
            this.mesto.Location = new System.Drawing.Point(317, 71);
            this.mesto.Name = "mesto";
            this.mesto.ReadOnly = true;
            this.mesto.Size = new System.Drawing.Size(111, 21);
            this.mesto.TabIndex = 23;
            this.mesto.TabStop = false;
            this.mesto.Text = "Mesto rodjenja";
            // 
            // datum
            // 
            this.datum.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.datum.Enabled = false;
            this.datum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datum.ForeColor = System.Drawing.Color.Black;
            this.datum.Location = new System.Drawing.Point(76, 140);
            this.datum.Name = "datum";
            this.datum.ReadOnly = true;
            this.datum.Size = new System.Drawing.Size(111, 21);
            this.datum.TabIndex = 24;
            this.datum.TabStop = false;
            this.datum.Text = "Datum rodjenja";
            // 
            // telefon
            // 
            this.telefon.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.telefon.Enabled = false;
            this.telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefon.ForeColor = System.Drawing.Color.Black;
            this.telefon.Location = new System.Drawing.Point(317, 139);
            this.telefon.Name = "telefon";
            this.telefon.ReadOnly = true;
            this.telefon.Size = new System.Drawing.Size(111, 21);
            this.telefon.TabIndex = 31;
            this.telefon.TabStop = false;
            this.telefon.Text = "Broj telefona";
            // 
            // mail
            // 
            this.mail.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.mail.Enabled = false;
            this.mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mail.ForeColor = System.Drawing.Color.Black;
            this.mail.Location = new System.Drawing.Point(317, 117);
            this.mail.Name = "mail";
            this.mail.ReadOnly = true;
            this.mail.Size = new System.Drawing.Size(111, 21);
            this.mail.TabIndex = 32;
            this.mail.TabStop = false;
            this.mail.Text = "E-mail";
            // 
            // JMBG
            // 
            this.JMBG.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.JMBG.Enabled = false;
            this.JMBG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JMBG.ForeColor = System.Drawing.Color.Black;
            this.JMBG.Location = new System.Drawing.Point(317, 94);
            this.JMBG.Name = "JMBG";
            this.JMBG.ReadOnly = true;
            this.JMBG.Size = new System.Drawing.Size(111, 21);
            this.JMBG.TabIndex = 33;
            this.JMBG.TabStop = false;
            this.JMBG.Text = "JMBG";
            // 
            // JMBGtext
            // 
            this.JMBGtext.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.JMBGtext.Enabled = false;
            this.JMBGtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JMBGtext.ForeColor = System.Drawing.Color.Black;
            this.JMBGtext.Location = new System.Drawing.Point(434, 94);
            this.JMBGtext.Name = "JMBGtext";
            this.JMBGtext.ReadOnly = true;
            this.JMBGtext.Size = new System.Drawing.Size(183, 21);
            this.JMBGtext.TabIndex = 41;
            this.JMBGtext.TabStop = false;
            // 
            // emailtext
            // 
            this.emailtext.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.emailtext.Enabled = false;
            this.emailtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailtext.ForeColor = System.Drawing.Color.Black;
            this.emailtext.Location = new System.Drawing.Point(434, 117);
            this.emailtext.Name = "emailtext";
            this.emailtext.ReadOnly = true;
            this.emailtext.Size = new System.Drawing.Size(183, 21);
            this.emailtext.TabIndex = 40;
            this.emailtext.TabStop = false;
            // 
            // brojtelefonatext
            // 
            this.brojtelefonatext.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.brojtelefonatext.Enabled = false;
            this.brojtelefonatext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brojtelefonatext.ForeColor = System.Drawing.Color.Black;
            this.brojtelefonatext.Location = new System.Drawing.Point(434, 140);
            this.brojtelefonatext.Name = "brojtelefonatext";
            this.brojtelefonatext.ReadOnly = true;
            this.brojtelefonatext.Size = new System.Drawing.Size(183, 21);
            this.brojtelefonatext.TabIndex = 39;
            this.brojtelefonatext.TabStop = false;
            // 
            // mjestotext
            // 
            this.mjestotext.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mjestotext.Enabled = false;
            this.mjestotext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mjestotext.ForeColor = System.Drawing.Color.Black;
            this.mjestotext.Location = new System.Drawing.Point(434, 71);
            this.mjestotext.Name = "mjestotext";
            this.mjestotext.ReadOnly = true;
            this.mjestotext.Size = new System.Drawing.Size(183, 21);
            this.mjestotext.TabIndex = 37;
            this.mjestotext.TabStop = false;
            // 
            // poltext
            // 
            this.poltext.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.poltext.Enabled = false;
            this.poltext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poltext.ForeColor = System.Drawing.Color.Black;
            this.poltext.Location = new System.Drawing.Point(192, 117);
            this.poltext.Name = "poltext";
            this.poltext.ReadOnly = true;
            this.poltext.Size = new System.Drawing.Size(118, 21);
            this.poltext.TabIndex = 36;
            this.poltext.TabStop = false;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox8.Enabled = false;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.ForeColor = System.Drawing.Color.Black;
            this.textBox8.Location = new System.Drawing.Point(193, 94);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(118, 21);
            this.textBox8.TabIndex = 35;
            this.textBox8.TabStop = false;
            // 
            // broj_indexa
            // 
            this.broj_indexa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.broj_indexa.Enabled = false;
            this.broj_indexa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.broj_indexa.ForeColor = System.Drawing.Color.Black;
            this.broj_indexa.Location = new System.Drawing.Point(193, 71);
            this.broj_indexa.Name = "broj_indexa";
            this.broj_indexa.ReadOnly = true;
            this.broj_indexa.Size = new System.Drawing.Size(118, 21);
            this.broj_indexa.TabIndex = 1;
            this.broj_indexa.TabStop = false;
            // 
            // potvrda_nove
            // 
            this.potvrda_nove.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.potvrda_nove.Enabled = false;
            this.potvrda_nove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.potvrda_nove.ForeColor = System.Drawing.Color.Black;
            this.potvrda_nove.Location = new System.Drawing.Point(77, 117);
            this.potvrda_nove.Name = "potvrda_nove";
            this.potvrda_nove.ReadOnly = true;
            this.potvrda_nove.Size = new System.Drawing.Size(111, 21);
            this.potvrda_nove.TabIndex = 44;
            this.potvrda_nove.TabStop = false;
            this.potvrda_nove.Text = "Nova šifra";
            // 
            // nova_sifra
            // 
            this.nova_sifra.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.nova_sifra.Enabled = false;
            this.nova_sifra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nova_sifra.ForeColor = System.Drawing.Color.Black;
            this.nova_sifra.Location = new System.Drawing.Point(75, 140);
            this.nova_sifra.Name = "nova_sifra";
            this.nova_sifra.ReadOnly = true;
            this.nova_sifra.Size = new System.Drawing.Size(111, 21);
            this.nova_sifra.TabIndex = 43;
            this.nova_sifra.TabStop = false;
            this.nova_sifra.Text = "Nova šifra";
            // 
            // stara_sifra
            // 
            this.stara_sifra.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.stara_sifra.Enabled = false;
            this.stara_sifra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stara_sifra.ForeColor = System.Drawing.Color.Black;
            this.stara_sifra.Location = new System.Drawing.Point(76, 95);
            this.stara_sifra.Name = "stara_sifra";
            this.stara_sifra.ReadOnly = true;
            this.stara_sifra.Size = new System.Drawing.Size(111, 21);
            this.stara_sifra.TabIndex = 42;
            this.stara_sifra.TabStop = false;
            this.stara_sifra.Text = "Stara šifra";
            // 
            // promjena_sifre
            // 
            this.promjena_sifre.Location = new System.Drawing.Point(410, 72);
            this.promjena_sifre.Name = "promjena_sifre";
            this.promjena_sifre.Size = new System.Drawing.Size(129, 43);
            this.promjena_sifre.TabIndex = 52;
            this.promjena_sifre.Text = "Promjeni šifru";
            this.promjena_sifre.UseVisualStyleBackColor = true;
            this.promjena_sifre.Click += new System.EventHandler(this.promjena_sifre_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(192, 141);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(119, 20);
            this.dateTimePicker1.TabIndex = 46;
            // 
            // sifriranje
            // 
            this.sifriranje.AutoSize = true;
            this.sifriranje.Location = new System.Drawing.Point(488, 116);
            this.sifriranje.Name = "sifriranje";
            this.sifriranje.Size = new System.Drawing.Size(73, 17);
            this.sifriranje.TabIndex = 47;
            this.sifriranje.TabStop = false;
            this.sifriranje.Text = "Prikrij šifre";
            this.sifriranje.UseVisualStyleBackColor = true;
            this.sifriranje.CheckedChanged += new System.EventHandler(this.Prikrij_sifru_CheckedChanged);
            // 
            // starasifra
            // 
            this.starasifra.Location = new System.Drawing.Point(194, 95);
            this.starasifra.Name = "starasifra";
            this.starasifra.Size = new System.Drawing.Size(179, 20);
            this.starasifra.TabIndex = 49;
            // 
            // novatext
            // 
            this.novatext.Location = new System.Drawing.Point(194, 118);
            this.novatext.Name = "novatext";
            this.novatext.Size = new System.Drawing.Size(178, 20);
            this.novatext.TabIndex = 50;
            // 
            // potvrdatext
            // 
            this.potvrdatext.Location = new System.Drawing.Point(194, 142);
            this.potvrdatext.Name = "potvrdatext";
            this.potvrdatext.Size = new System.Drawing.Size(178, 20);
            this.potvrdatext.TabIndex = 51;
            // 
            // Podatci
            // 
            this.Podatci.Location = new System.Drawing.Point(0, 39);
            this.Podatci.Name = "Podatci";
            this.Podatci.Size = new System.Drawing.Size(311, 27);
            this.Podatci.TabIndex = 53;
            this.Podatci.TabStop = false;
            this.Podatci.Text = "Podatci o studentu";
            this.Podatci.UseVisualStyleBackColor = true;
            this.Podatci.Click += new System.EventHandler(this.Podatci_CheckedChanged);
            // 
            // Promjena_lozinke
            // 
            this.Promjena_lozinke.Location = new System.Drawing.Point(317, 39);
            this.Promjena_lozinke.Name = "Promjena_lozinke";
            this.Promjena_lozinke.Size = new System.Drawing.Size(300, 27);
            this.Promjena_lozinke.TabIndex = 54;
            this.Promjena_lozinke.TabStop = false;
            this.Promjena_lozinke.Text = "Promjena lozinke";
            this.Promjena_lozinke.UseVisualStyleBackColor = true;
            this.Promjena_lozinke.Click += new System.EventHandler(this.Promjena_lozinke_CheckedChanged);
            // 
            // studijski
            // 
            this.studijski.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.studijski.Enabled = false;
            this.studijski.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studijski.ForeColor = System.Drawing.Color.Black;
            this.studijski.Location = new System.Drawing.Point(44, 167);
            this.studijski.Name = "studijski";
            this.studijski.ReadOnly = true;
            this.studijski.Size = new System.Drawing.Size(144, 21);
            this.studijski.TabIndex = 55;
            this.studijski.TabStop = false;
            this.studijski.Text = "Studijski program";
            // 
            // studijskiprogram
            // 
            this.studijskiprogram.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.studijskiprogram.Enabled = false;
            this.studijskiprogram.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studijskiprogram.ForeColor = System.Drawing.Color.Black;
            this.studijskiprogram.Location = new System.Drawing.Point(194, 168);
            this.studijskiprogram.Name = "studijskiprogram";
            this.studijskiprogram.ReadOnly = true;
            this.studijskiprogram.Size = new System.Drawing.Size(178, 21);
            this.studijskiprogram.TabIndex = 56;
            this.studijskiprogram.TabStop = false;
            // 
            // godinastudijatext
            // 
            this.godinastudijatext.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.godinastudijatext.Enabled = false;
            this.godinastudijatext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.godinastudijatext.ForeColor = System.Drawing.Color.Black;
            this.godinastudijatext.Location = new System.Drawing.Point(499, 167);
            this.godinastudijatext.Name = "godinastudijatext";
            this.godinastudijatext.ReadOnly = true;
            this.godinastudijatext.Size = new System.Drawing.Size(32, 21);
            this.godinastudijatext.TabIndex = 57;
            this.godinastudijatext.TabStop = false;
            // 
            // godinastudija
            // 
            this.godinastudija.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.godinastudija.Enabled = false;
            this.godinastudija.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.godinastudija.ForeColor = System.Drawing.Color.Black;
            this.godinastudija.Location = new System.Drawing.Point(382, 168);
            this.godinastudija.Name = "godinastudija";
            this.godinastudija.ReadOnly = true;
            this.godinastudija.Size = new System.Drawing.Size(111, 21);
            this.godinastudija.TabIndex = 58;
            this.godinastudija.TabStop = false;
            this.godinastudija.Text = "Godina Studija";
            // 
            // put
            // 
            this.put.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.put.Enabled = false;
            this.put.Location = new System.Drawing.Point(537, 168);
            this.put.Name = "put";
            this.put.ReadOnly = true;
            this.put.Size = new System.Drawing.Size(67, 20);
            this.put.TabIndex = 59;
            this.put.TabStop = false;
            this.put.Text = "put";
            // 
            // Glavno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(616, 251);
            this.ControlBox = false;
            this.Controls.Add(this.put);
            this.Controls.Add(this.godinastudijatext);
            this.Controls.Add(this.godinastudija);
            this.Controls.Add(this.studijskiprogram);
            this.Controls.Add(this.studijski);
            this.Controls.Add(this.Promjena_lozinke);
            this.Controls.Add(this.Podatci);
            this.Controls.Add(this.potvrdatext);
            this.Controls.Add(this.novatext);
            this.Controls.Add(this.starasifra);
            this.Controls.Add(this.sifriranje);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.promjena_sifre);
            this.Controls.Add(this.potvrda_nove);
            this.Controls.Add(this.nova_sifra);
            this.Controls.Add(this.stara_sifra);
            this.Controls.Add(this.JMBGtext);
            this.Controls.Add(this.emailtext);
            this.Controls.Add(this.brojtelefonatext);
            this.Controls.Add(this.mjestotext);
            this.Controls.Add(this.poltext);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.broj_indexa);
            this.Controls.Add(this.JMBG);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.telefon);
            this.Controls.Add(this.datum);
            this.Controls.Add(this.mesto);
            this.Controls.Add(this.Pol);
            this.Controls.Add(this.Ime_prezime);
            this.Controls.Add(this.Index);
            this.Controls.Add(this.Slika);
            this.Controls.Add(this.Početna);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Glavno";
            this.ShowIcon = false;
            this.Text = "Glavni Meni";
            this.Load += new System.EventHandler(this.Administracija_Click);
            ((System.ComponentModel.ISupportInitialize)(this.Slika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Početna;
        private System.Windows.Forms.PictureBox Slika;
        private System.Windows.Forms.TextBox Index;
        private System.Windows.Forms.TextBox Ime_prezime;
        private System.Windows.Forms.TextBox Pol;
        private System.Windows.Forms.TextBox mesto;
        private System.Windows.Forms.TextBox datum;
        private System.Windows.Forms.TextBox telefon;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.TextBox JMBG;
        private System.Windows.Forms.TextBox JMBGtext;
        private System.Windows.Forms.TextBox emailtext;
        private System.Windows.Forms.TextBox brojtelefonatext;
        private System.Windows.Forms.TextBox mjestotext;
        private System.Windows.Forms.TextBox poltext;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox broj_indexa;
        private System.Windows.Forms.TextBox potvrda_nove;
        private System.Windows.Forms.TextBox nova_sifra;
        private System.Windows.Forms.TextBox stara_sifra;
        private System.Windows.Forms.Button promjena_sifre;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox sifriranje;
        private System.Windows.Forms.MaskedTextBox starasifra;
        private System.Windows.Forms.MaskedTextBox novatext;
        private System.Windows.Forms.MaskedTextBox potvrdatext;
        private System.Windows.Forms.Button Podatci;
        private System.Windows.Forms.Button Promjena_lozinke;
        private System.Windows.Forms.TextBox studijski;
        private System.Windows.Forms.TextBox studijskiprogram;
        private System.Windows.Forms.TextBox godinastudijatext;
        private System.Windows.Forms.TextBox godinastudija;
        private System.Windows.Forms.TextBox put;

    }
}