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
    public partial class Prijava : Form
    {
        public static Int64 vrsta;
        public static string predmeti;
        public static int izlasci;
        public Prijava()
        {
            InitializeComponent();
        }
        private void Prijava_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
            dosadasnjih_prijava.Clear();
            comboBox1.Hide();
            predmet.Hide();
            broj_prijava.Hide();
            Profesor.Hide();
            textBox1.Hide();
            dosadasnjih_prijava.Hide();
            prijavljen.Hide();
            polozen.Hide();
            predmet.Show();
            comboBox1.Show();
            comboBox1.Items.Clear();
            predmet.Items.Clear();
            SqlCeConnection conn = new SqlCeConnection(pocetna.connectionString);
            conn.Open();
            SqlCeCommand command = new SqlCeCommand();
            command.CommandType = CommandType.Text;
            command.Connection = conn;
            command.CommandText = "SELECT studijski_program, godina_studija FROM Student WHERE broj_indexa = '"+pocetna.korisnicko+"';";
            SqlCeDataReader reader = command.ExecuteReader();
            reader.Read();
            int godina = reader.GetInt32(1);
            command.CommandText = "SELECT predmet FROM studijski_predmeti WHERE program = " + reader.GetInt32(0) + ";";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                SqlCeCommand comm = new SqlCeCommand("SELECT * FROM predmeti WHERE sifra_predmeta = '" + reader.GetString(0) + "' AND semestar < 2*"+godina+"+1 ORDER BY sifra_predmeta;", conn);
                SqlCeDataReader read = comm.ExecuteReader();
                while (read.Read())
                {
                    predmet.Items.Add(read.GetString(0));
                    comboBox1.Items.Add(read.GetString(2));
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Profesor.Show();
            dosadasnjih_prijava.Show();
            broj_prijava.Show();
            textBox1.Show();
            prijavljen.Show();
            polozen.Show();
            if (comboBox1.SelectedIndex <= comboBox1.Items.Count && comboBox1.SelectedIndex > -1)
                predmet.SelectedIndex = comboBox1.SelectedIndex;
            if(predmet.SelectedIndex <= predmet.Items.Count && predmet.SelectedIndex > -1)
                comboBox1.SelectedIndex = predmet.SelectedIndex;
            SqlCeConnection conn = new SqlCeConnection(pocetna.connectionString);
            conn.Open();
            SqlCeCommand command = new SqlCeCommand();
            command.CommandType = CommandType.Text;
            command.Connection = conn;
            command.CommandText = "SELECT izlazio, prijavio, polozio FROM Ispiti WHERE predmet = '" + comboBox1.SelectedItem.ToString() + "' AND student = '"+pocetna.korisnicko+"';";
            SqlCeDataReader reader = command.ExecuteReader();
            reader.Read();
            dosadasnjih_prijava.Text = ""+reader.GetSqlInt32(0);
            bool prijavio = reader.GetBoolean(1);
            bool polozio = reader.GetBoolean(2);
            if (prijavio)
                prijavljen.Text = "Prijavljen";
            else
                prijavljen.Text = "Neprijavljen";
            if (polozio)
                polozen.Text = "Polozen";
            else
                polozen.Text = "Nepolozen";
            if (polozio || prijavio)
                button1.Enabled = false;
            else
                button1.Enabled = true;
            command.CommandText = "SELECT ime_profesora FROM predmeti WHERE sifra_predmeta = '" + comboBox1.SelectedItem.ToString() + "';";
            reader = command.ExecuteReader();
            reader.Read();
            command.CommandText = "SELECT ime,  prezime FROM Profesor WHERE id = "+reader.GetInt32(0)+";";
            reader = command.ExecuteReader();
            reader.Read();
            textBox1.Text = reader.GetString(0) + " " + reader.GetString(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0 || predmet.SelectedIndex < 0)
            {
                MessageBox.Show("NIste unijeli ispravno predmet");
                comboBox1.Focus();
                return;
            }
            predmeti=comboBox1.SelectedItem.ToString();
            izlasci = Int32.Parse(dosadasnjih_prijava.Text) + 1;
            DialogResult result = MessageBox.Show("Želite da prijavite " + comboBox1.SelectedItem.ToString() + " " + predmet.SelectedItem.ToString() + " kod profesora " + textBox1.Text + " po " + izlasci + ". put?", "Prijava Ispita", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int uplata = (izlasci > 3) ? 20 : 2;
                SqlCeConnection conn = new SqlCeConnection(pocetna.connectionString);
                conn.Open();
                SqlCeCommand command = new SqlCeCommand("INSERT INTO Uplate(broj_indexa, vrsta_uplate, visina_uplate, datum) VALUES ('" + pocetna.korisnicko + "', 'Uplata ispita', " + uplata + ", '" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "');", conn);
                command.ExecuteNonQuery();
                command.CommandText = "Select MAX(id) from Uplate Where broj_indexa = '" + pocetna.korisnicko + "' AND vrsta_uplate = 'Uplata ispita' AND visina_uplate = "+uplata+";";
                SqlCeDataReader reader = command.ExecuteReader();
                reader.Read();
                vrsta = reader.GetInt64(0);
                new Uplate().Show();
               
            }
            else
            {
                Prijava_Load(sender, e);
            }

        }
    }
}
