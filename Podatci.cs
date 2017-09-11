using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
//nedostaje citavo jedno dugme (Izmjeni podatke)
namespace Studentski_servis
{
    
    public partial class Glavno : Form 
    {
        void ocisti()
        {
            sifriranje.Hide();
            Podatci.Hide();
            Promjena_lozinke.Hide();
            Slika.Hide();
            Index.Hide();
            Ime_prezime.Hide();
            Pol.Hide();
            datum.Hide();
            mesto.Hide();
            mail.Hide();
            telefon.Hide();
            JMBG.Hide();
            JMBGtext.Hide();
            emailtext.Hide();
            brojtelefonatext.Hide();
            dateTimePicker1.Hide();
            mjestotext.Hide();
            poltext.Hide();
            textBox8.Hide();
            broj_indexa.Hide();
            JMBGtext.Hide();
            stara_sifra.Hide();
            starasifra.Hide();
            nova_sifra.Hide();
            novatext.Hide();
            potvrda_nove.Hide();
            potvrdatext.Hide();
            promjena_sifre.Hide();
            studijskiprogram.Hide();
            studijski.Hide();
            godinastudija.Hide();
            godinastudijatext.Hide();
            put.Hide();
        }
        void popuni()
        {
            SqlCeConnection conn = new SqlCeConnection(pocetna.connectionString);
            conn.Open();
            SqlCeCommand command = new SqlCeCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM Student WHERE broj_indexa = '"+pocetna.korisnicko+"';";
            command.Connection = conn;
            SqlCeDataReader reader = command.ExecuteReader();
            int program = 0;
            int mjesto = 0;
            reader.Read();
                broj_indexa.Text = reader.GetString(10);
                string ime = reader.GetString(0);
                string prezime = reader.GetString(1);
                textBox8.Text = "" + ime + " " + prezime;
                poltext.Text = reader.GetString(5);
                JMBGtext.Text = reader.GetString(6);
                emailtext.Text = reader.GetString(8);
                brojtelefonatext.Text = reader.GetString(7);
                program = reader.GetInt32(9);
                mjesto = reader.GetInt32(3);
                godinastudijatext.Text = ""+reader.GetInt32(4);
                put.Text = ""+reader.GetInt32(12)+". put";
                dateTimePicker1.Value = reader.GetDateTime(2);
            command.CommandText = "SELECT naziv_programa FROM Studijski_program WHERE id = " + program + ";";
            reader = command.ExecuteReader();
            reader.Read();
            studijskiprogram.Text = reader.GetString(0);
            
            command.CommandText = "SELECT Naziv_grada FROM Mjesto_rodjenja WHERE id = '" + mjesto + "';";
            reader = command.ExecuteReader();
            reader.Read();
            mjestotext.Text = reader.GetString(0);
        }
        public Glavno()
        {
            InitializeComponent();
            ocisti();
        }
        private void Početna_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Administracija_Click(object sender, EventArgs e)
        {
            ocisti();
            Podatci.Show();
            Promjena_lozinke.Show();
            this.Size = new Size(627, 98);
        }

        private void Promjena_lozinke_CheckedChanged(object sender, EventArgs e)
        {
            ocisti();
            broj_indexa.Size = new System.Drawing.Size(179, 20);
            this.Size = new Size(627, 215);
            stara_sifra.Show();
            starasifra.Show();
            nova_sifra.Show();
            novatext.Show();
            potvrda_nove.Show();
            potvrdatext.Show();
            Index.Show();
            broj_indexa.Show();
            promjena_sifre.Show();
            Promjena_lozinke.Show();
            Podatci.Show();
            sifriranje.Show();
            Slika.Show();
            popuni();
        }

        private void promjena_sifre_Click(object sender, EventArgs e)
        {
                SqlCeConnection conn = new SqlCeConnection(pocetna.connectionString);
                conn.Open();
                SqlCeCommand command = new SqlCeCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT broj_indexa, sifra FROM Student WHERE broj_indexa = '"+broj_indexa.Text+"';";
                command.Connection = conn;
                SqlCeDataReader reader = command.ExecuteReader();
                reader.Read();
                string ime = reader.GetString(0);
                string sifra = reader.GetString(1);
            if (novatext.Text.Equals(potvrdatext.Text) && starasifra.Text.Equals(sifra))
            {
               MessageBox.Show("Uspješno ste promjenili šifru", "Odlican unos", MessageBoxButtons.OK);
               command.CommandText = "UPDATE Student SET sifra = '" + novatext.Text + "' WHERE broj_indexa = '" + ime + "';";
               command.ExecuteNonQuery();
               
            }
            else
            {
                MessageBox.Show("Nova šifra se ne poklapa!", "Pogrešan unos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                novatext.Clear();
                potvrdatext.Clear();
                starasifra.Clear();
                starasifra.Focus();
            }
        }

        private void Podatci_CheckedChanged(object sender, EventArgs e)
        {
            ocisti();
            broj_indexa.Size = new Size(118, 21);
            this.Size = new Size(627, 215);
            Slika.Show();
            Index.Show();
            Ime_prezime.Show();
            Pol.Show();
            datum.Show();
            mesto.Show();
            mail.Show();
            telefon.Show();
            JMBG.Show();
            JMBGtext.Show();
            emailtext.Show();
            brojtelefonatext.Show();
            dateTimePicker1.Show();
            mjestotext.Show();
            poltext.Show();
            textBox8.Show();
            broj_indexa.Show();
            Podatci.Show();
            Promjena_lozinke.Show();
            studijskiprogram.Show();
            studijski.Show();
            godinastudija.Show();
            godinastudijatext.Show();
            put.Show();
        
            popuni();
        }

        private void Prikrij_sifru_CheckedChanged(object sender, EventArgs e)
        {
            if (sifriranje.Checked)
            {
                novatext.PasswordChar = '*';
                potvrdatext.PasswordChar = '*';
                starasifra.PasswordChar = '*';
            }
            else
            {

                novatext.PasswordChar = '\0';
                potvrdatext.PasswordChar = '\0';
                starasifra.PasswordChar = '\0';
            }

        }

    }

}
