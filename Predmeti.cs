using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace Studentski_servis
{
 
    public partial class Predmeti : Form
    {
        public Predmeti()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlCeConnection conn = new SqlCeConnection(pocetna.connectionString);
            conn.Open();
            SqlCeCommand command = new SqlCeCommand();
            command.Connection = conn;
            command.CommandText = "SELECT ime, prezime, studijski_program FROM Student WHERE broj_indexa = '" + pocetna.korisnicko + "';";
            SqlCeDataReader reader = command.ExecuteReader();
            reader.Read();
            index.Text = pocetna.korisnicko;
            ime.Text = reader.GetString(0);
            prezime.Text = reader.GetString(1);
            int program = reader.GetInt32(2);
            int profesors;
            int asistents;
            string imeProfesora;
            neprijavljen.Items.Clear();
            Nepolozen.Items.Clear();
            sifra.Items.Clear();
            naziv.Items.Clear();
            listBox1.Items.Clear();
            profesor.Items.Clear();
            asistenti.Items.Clear();
            SqlCeDataReader read;
            SqlCeCommand com = new SqlCeCommand();
            com.Connection = conn;
            command.CommandText = "SELECT predmet, polozio, prijavio, ocjena FROM Ispiti WHERE student = '" + pocetna.korisnicko + "' ORDER BY predmet;";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (!reader.GetBoolean(1))
                    neprijavljen.Items.Add("Nepoložen");
                else
                    neprijavljen.Items.Add("" + reader.GetInt32(3));
                if (reader.GetBoolean(2))
                    Nepolozen.Items.Add("Prijavljen");
                else
                    Nepolozen.Items.Add("Neprijavljen");
                com.CommandText = "SELECT sifra_predmeta, naziv_predmeta, ime_profesora, ime_asistenta, ECTS FROM predmeti WHERE sifra_predmeta = '" + reader.GetString(0) + "';";
                read = com.ExecuteReader();
                read.Read();
                asistents = read.GetInt32(3);
                profesors = read.GetInt32(2);
                naziv.Items.Add(read.GetString(1));
                sifra.Items.Add(read.GetString(0));
                listBox1.Items.Add(read.GetInt32(4));
                com.CommandText = "SELECT ime, prezime FROM profesor WHERE id = " + profesors + ";";
                read = com.ExecuteReader();
                read.Read();
                imeProfesora = "" + read.GetString(0) + " " + read.GetString(1);
                profesor.Items.Add(imeProfesora);
                com.CommandText = "SELECT ime, prezime FROM profesor WHERE id = " + asistents + ";";
                read = com.ExecuteReader();
                read.Read();
                imeProfesora = "" + read.GetString(0) + " " + read.GetString(1);
                asistenti.Items.Add(imeProfesora);
            }
            conn.Close();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            pretraga_Click(sender, e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (IsInputKey(Keys.Enter))
                pretraga_Click(sender, e);

        }

        private void pretraga_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
            SqlCeConnection conn = new SqlCeConnection(pocetna.connectionString);
            conn.Open();
            SqlCeCommand command = new SqlCeCommand();
            command.Connection = conn;
            command.CommandText = "SELECT studijski_program FROM Student WHERE broj_indexa = '" + pocetna.korisnicko + "';";
            SqlCeDataReader reader = command.ExecuteReader();
            reader.Read();
            int program = reader.GetInt32(0);
            neprijavljen.Items.Clear();
            Nepolozen.Items.Clear();
            sifra.Items.Clear();
            naziv.Items.Clear();
            listBox1.Items.Clear();
            profesor.Items.Clear();
            asistenti.Items.Clear();
            SqlCeDataReader read;
            SqlCeCommand com = new SqlCeCommand();
            com.Connection = conn;
            if (radioButton1.Checked)
                command.CommandText = "SELECT * FROM Predmeti WHERE naziv_predmeta = '" + textBox1.Text + "' ORDER BY sifra_predmeta;";
            else if (radioButton2.Checked)
                command.CommandText = "SELECT * FROM Predmeti WHERE naziv_predmeta LIKE '%" + textBox1.Text + "%' ORDER BY sifra_predmeta;";
            else if (radioButton4.Checked)
                command.CommandText = "SELECT * FROM Predmeti WHERE sifra_predmeta = '" + textBox1.Text + "' ORDER BY sifra_predmeta; ";
            else if (radioButton3.Checked)
                command.CommandText = "SELECT * FROM Predmeti WHERE sifra_predmeta LIKE '%" + textBox1.Text + "%'ORDER BY sifra_predmeta;";
            else
            {
                MessageBox.Show("Nema uslova za pretragu");
                conn.Close();
                return;
            }
             reader = command.ExecuteReader();
             while (reader.Read())
             {
                 command.CommandText = "SELECT * FROM ispiti WHERE predmet = '" + reader.GetString(2) + "' AND student ='"+pocetna.korisnicko+"';";
                 read = command.ExecuteReader();
                 read.Read();
                 if (read.GetBoolean(2))
                     Nepolozen.Items.Add("Prijavljen");
                 else
                     Nepolozen.Items.Add("Neprijavljen");
                 if (read.GetBoolean(3))
                     neprijavljen.Items.Add("" + read.GetInt32(7));
                 else
                     neprijavljen.Items.Add("Nepoložen");
                 listBox1.Items.Add(""+reader.GetInt32(5));
                 naziv.Items.Add(reader.GetString(0));
                 sifra.Items.Add(read.GetString(1));
                 command.CommandText = "SELECT ime, prezime FROM Profesor WHERE id = " + reader.GetInt32(1) + ";";
                 read = command.ExecuteReader();
                 read.Read();
                 profesor.Items.Add(read.GetString(0) + " " + read.GetString(1));
                 command.CommandText = "SELECT ime, prezime FROM Profesor WHERE id = " + reader.GetInt32(4) + ";";
                 read = command.ExecuteReader();
                 read.Read();
                 asistenti.Items.Add(read.GetString(0) + " " + read.GetString(1));

             }
             conn.Close();

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        private void sifra_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = profesor.SelectedIndex = asistenti.SelectedIndex = Nepolozen.SelectedIndex = neprijavljen.SelectedIndex = naziv.SelectedIndex = sifra.SelectedIndex;
        }

        private void naziv_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = profesor.SelectedIndex = asistenti.SelectedIndex = Nepolozen.SelectedIndex = neprijavljen.SelectedIndex = sifra.SelectedIndex = naziv.SelectedIndex;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            profesor.SelectedIndex = asistenti.SelectedIndex = Nepolozen.SelectedIndex = neprijavljen.SelectedIndex = naziv.SelectedIndex = sifra.SelectedIndex = listBox1.SelectedIndex;
        }

        private void profesor_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = asistenti.SelectedIndex = Nepolozen.SelectedIndex = neprijavljen.SelectedIndex = naziv.SelectedIndex = sifra.SelectedIndex = profesor.SelectedIndex;
        }

        private void asistenti_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = profesor.SelectedIndex = Nepolozen.SelectedIndex = neprijavljen.SelectedIndex = naziv.SelectedIndex = sifra.SelectedIndex = asistenti.SelectedIndex;
        }

        private void Nepolozen_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = profesor.SelectedIndex = asistenti.SelectedIndex = neprijavljen.SelectedIndex = naziv.SelectedIndex = sifra.SelectedIndex = Nepolozen.SelectedIndex;
        }

        private void neprijavljen_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = profesor.SelectedIndex = asistenti.SelectedIndex = Nepolozen.SelectedIndex = sifra.SelectedIndex = naziv.SelectedIndex = neprijavljen.SelectedIndex;
        }

        
    }
}