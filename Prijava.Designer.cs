namespace Studentski_servis
{
    partial class Prijava
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
            this.predmet = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Profesor = new System.Windows.Forms.Label();
            this.broj_prijava = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dosadasnjih_prijava = new System.Windows.Forms.TextBox();
            this.prijavljen = new System.Windows.Forms.Label();
            this.polozen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // predmet
            // 
            this.predmet.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.predmet.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.predmet.Dock = System.Windows.Forms.DockStyle.Right;
            this.predmet.FormattingEnabled = true;
            this.predmet.Location = new System.Drawing.Point(67, 0);
            this.predmet.Name = "predmet";
            this.predmet.Size = new System.Drawing.Size(188, 21);
            this.predmet.TabIndex = 20;
            this.predmet.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(70, 21);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 48);
            this.button1.TabIndex = 22;
            this.button1.Text = "Prijavi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Profesor
            // 
            this.Profesor.AutoSize = true;
            this.Profesor.Location = new System.Drawing.Point(-1, 27);
            this.Profesor.Name = "Profesor";
            this.Profesor.Size = new System.Drawing.Size(71, 13);
            this.Profesor.TabIndex = 23;
            this.Profesor.Text = "Ime profesora";
            // 
            // broj_prijava
            // 
            this.broj_prijava.AutoSize = true;
            this.broj_prijava.Location = new System.Drawing.Point(-1, 50);
            this.broj_prijava.Name = "broj_prijava";
            this.broj_prijava.Size = new System.Drawing.Size(98, 13);
            this.broj_prijava.TabIndex = 24;
            this.broj_prijava.Text = "Do sada ste prijavili";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(76, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(179, 20);
            this.textBox1.TabIndex = 25;
            this.textBox1.TabStop = false;
            // 
            // dosadasnjih_prijava
            // 
            this.dosadasnjih_prijava.Enabled = false;
            this.dosadasnjih_prijava.ForeColor = System.Drawing.Color.Black;
            this.dosadasnjih_prijava.Location = new System.Drawing.Point(103, 50);
            this.dosadasnjih_prijava.Name = "dosadasnjih_prijava";
            this.dosadasnjih_prijava.ReadOnly = true;
            this.dosadasnjih_prijava.Size = new System.Drawing.Size(152, 20);
            this.dosadasnjih_prijava.TabIndex = 26;
            this.dosadasnjih_prijava.TabStop = false;
            // 
            // prijavljen
            // 
            this.prijavljen.AutoSize = true;
            this.prijavljen.Location = new System.Drawing.Point(24, 77);
            this.prijavljen.Name = "prijavljen";
            this.prijavljen.Size = new System.Drawing.Size(35, 13);
            this.prijavljen.TabIndex = 27;
            this.prijavljen.Text = "label1";
            // 
            // polozen
            // 
            this.polozen.AutoSize = true;
            this.polozen.Location = new System.Drawing.Point(132, 79);
            this.polozen.Name = "polozen";
            this.polozen.Size = new System.Drawing.Size(35, 13);
            this.polozen.TabIndex = 28;
            this.polozen.Text = "label1";
            // 
            // Prijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 150);
            this.Controls.Add(this.polozen);
            this.Controls.Add(this.prijavljen);
            this.Controls.Add(this.dosadasnjih_prijava);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.broj_prijava);
            this.Controls.Add(this.Profesor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.predmet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Prijava";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Prijava";
            this.Load += new System.EventHandler(this.Prijava_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox predmet;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Profesor;
        private System.Windows.Forms.Label broj_prijava;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox dosadasnjih_prijava;
        private System.Windows.Forms.Label prijavljen;
        private System.Windows.Forms.Label polozen;
    }
}