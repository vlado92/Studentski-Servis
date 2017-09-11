namespace Studentski_servis
{
    partial class Predmeti
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
            this.index = new System.Windows.Forms.TextBox();
            this.prezime = new System.Windows.Forms.TextBox();
            this.ime = new System.Windows.Forms.TextBox();
            this.naziv = new System.Windows.Forms.ListBox();
            this.sifra = new System.Windows.Forms.ListBox();
            this.profesor = new System.Windows.Forms.ListBox();
            this.asistenti = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Nepolozen = new System.Windows.Forms.ListBox();
            this.neprijavljen = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ECTS = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pretraga = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // index
            // 
            this.index.Enabled = false;
            this.index.Location = new System.Drawing.Point(12, 12);
            this.index.Name = "index";
            this.index.ReadOnly = true;
            this.index.Size = new System.Drawing.Size(63, 20);
            this.index.TabIndex = 0;
            // 
            // prezime
            // 
            this.prezime.Enabled = false;
            this.prezime.Location = new System.Drawing.Point(202, 12);
            this.prezime.Name = "prezime";
            this.prezime.ReadOnly = true;
            this.prezime.Size = new System.Drawing.Size(100, 20);
            this.prezime.TabIndex = 1;
            // 
            // ime
            // 
            this.ime.Enabled = false;
            this.ime.Location = new System.Drawing.Point(81, 12);
            this.ime.Name = "ime";
            this.ime.ReadOnly = true;
            this.ime.Size = new System.Drawing.Size(115, 20);
            this.ime.TabIndex = 2;
            // 
            // naziv
            // 
            this.naziv.FormattingEnabled = true;
            this.naziv.Location = new System.Drawing.Point(86, 82);
            this.naziv.Name = "naziv";
            this.naziv.Size = new System.Drawing.Size(200, 225);
            this.naziv.TabIndex = 3;
            this.naziv.SelectedIndexChanged += new System.EventHandler(this.naziv_SelectedIndexChanged);
            // 
            // sifra
            // 
            this.sifra.FormattingEnabled = true;
            this.sifra.Location = new System.Drawing.Point(8, 82);
            this.sifra.Name = "sifra";
            this.sifra.Size = new System.Drawing.Size(72, 225);
            this.sifra.TabIndex = 6;
            this.sifra.SelectedIndexChanged += new System.EventHandler(this.sifra_SelectedIndexChanged);
            // 
            // profesor
            // 
            this.profesor.FormattingEnabled = true;
            this.profesor.Location = new System.Drawing.Point(330, 83);
            this.profesor.Name = "profesor";
            this.profesor.Size = new System.Drawing.Size(112, 225);
            this.profesor.TabIndex = 7;
            this.profesor.SelectedIndexChanged += new System.EventHandler(this.profesor_SelectedIndexChanged);
            // 
            // asistenti
            // 
            this.asistenti.FormattingEnabled = true;
            this.asistenti.Location = new System.Drawing.Point(448, 84);
            this.asistenti.Name = "asistenti";
            this.asistenti.Size = new System.Drawing.Size(120, 225);
            this.asistenti.TabIndex = 8;
            this.asistenti.SelectedIndexChanged += new System.EventHandler(this.asistenti_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Šifra predmeta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Naziv predmet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ime profesora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(469, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "ime Asistenta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(680, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Položen";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(593, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Prijavljen";
            // 
            // Nepolozen
            // 
            this.Nepolozen.FormattingEnabled = true;
            this.Nepolozen.Location = new System.Drawing.Point(574, 83);
            this.Nepolozen.Name = "Nepolozen";
            this.Nepolozen.Size = new System.Drawing.Size(78, 225);
            this.Nepolozen.TabIndex = 15;
            this.Nepolozen.SelectedIndexChanged += new System.EventHandler(this.Nepolozen_SelectedIndexChanged);
            // 
            // neprijavljen
            // 
            this.neprijavljen.FormattingEnabled = true;
            this.neprijavljen.Location = new System.Drawing.Point(658, 84);
            this.neprijavljen.Name = "neprijavljen";
            this.neprijavljen.Size = new System.Drawing.Size(78, 225);
            this.neprijavljen.TabIndex = 16;
            this.neprijavljen.SelectedIndexChanged += new System.EventHandler(this.neprijavljen_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(292, 83);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(32, 225);
            this.listBox1.TabIndex = 18;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // ECTS
            // 
            this.ECTS.AutoSize = true;
            this.ECTS.Location = new System.Drawing.Point(295, 68);
            this.ECTS.Name = "ECTS";
            this.ECTS.Size = new System.Drawing.Size(35, 13);
            this.ECTS.TabIndex = 17;
            this.ECTS.Text = "ECTS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(364, -1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Traži predmet";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(367, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 20;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // pretraga
            // 
            this.pretraga.Location = new System.Drawing.Point(711, 4);
            this.pretraga.Name = "pretraga";
            this.pretraga.Size = new System.Drawing.Size(75, 28);
            this.pretraga.TabIndex = 23;
            this.pretraga.Text = "Pretraži";
            this.pretraga.UseVisualStyleBackColor = true;
            this.pretraga.Click += new System.EventHandler(this.pretraga_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(484, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(97, 17);
            this.radioButton1.TabIndex = 21;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Tačan predmet";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(484, 25);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(108, 17);
            this.radioButton2.TabIndex = 22;
            this.radioButton2.Text = "Sadržo u predmet";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(598, 25);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(81, 17);
            this.radioButton3.TabIndex = 25;
            this.radioButton3.Text = "Sadrži u šifri";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(598, 2);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(78, 17);
            this.radioButton4.TabIndex = 24;
            this.radioButton4.Text = "Tačno šifra";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(711, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 30);
            this.button1.TabIndex = 26;
            this.button1.Text = "Poništi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Predmeti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 318);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.pretraga);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ECTS);
            this.Controls.Add(this.neprijavljen);
            this.Controls.Add(this.Nepolozen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.asistenti);
            this.Controls.Add(this.profesor);
            this.Controls.Add(this.sifra);
            this.Controls.Add(this.naziv);
            this.Controls.Add(this.ime);
            this.Controls.Add(this.prezime);
            this.Controls.Add(this.index);
            this.Name = "Predmeti";
            this.Text = "Predmeti";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox index;
        private System.Windows.Forms.TextBox prezime;
        private System.Windows.Forms.TextBox ime;
        private System.Windows.Forms.ListBox naziv;
        private System.Windows.Forms.ListBox sifra;
        private System.Windows.Forms.ListBox profesor;
        private System.Windows.Forms.ListBox asistenti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox Nepolozen;
        private System.Windows.Forms.ListBox neprijavljen;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label ECTS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button pretraga;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button button1;




    }
}