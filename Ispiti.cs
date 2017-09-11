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
    public partial class Ispiti : Form
    {
        public Ispiti()
        {
            InitializeComponent();
        }
        SqlCeConnection conn = new SqlCeConnection(pocetna.connectionString);
        SqlCeCommand command = new SqlCeCommand();
            
        private void Ispiti_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void Polozeni_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            conn.Open();
            command.Connection = conn;
            command.CommandText = "SELECT godina_studija FROM Student WHERE broj_indexa = '" + pocetna.korisnicko + "';";
            SqlCeDataReader reader = command.ExecuteReader();
            SqlCeDataReader read;
            reader.Read();
            int godina = reader.GetInt32(0);
            command.CommandText = "SELECT sifra_predmeta, naziv_predmeta FROM predmeti WHERE semestar = " + godina + "*2-1 OR semestar = " + godina + "*2;";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                command.CommandText = "SELECT * FROM ispiti WHERE polozio = 'true' AND predmet ='" + reader.GetString(0) + "' AND student = '" + pocetna.korisnicko + "';";
                read =command.ExecuteReader();
                while (read.Read())
                {
                    listBox1.Items.Add(reader.GetString(1));
                }
            }
            conn.Close();
            
        }

        private void Nepolozeni_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            conn.Open();
            command.Connection = conn;
            command.CommandText = "SELECT godina_studija FROM Student WHERE broj_indexa = '" + pocetna.korisnicko + "';";
            SqlCeDataReader reader = command.ExecuteReader();
            SqlCeDataReader read;
            reader.Read();
            int godina = reader.GetInt32(0);
            command.CommandText = "SELECT sifra_predmeta, naziv_predmeta FROM predmeti WHERE semestar = " + godina + "*2-1 OR semestar = " + godina + "*2;";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                command.CommandText = "SELECT * FROM ispiti WHERE polozio = 'false' AND predmet ='"+reader.GetString(0)+"' AND student = '"+pocetna.korisnicko+"';";
                read = command.ExecuteReader();
                while (read.Read())
                {
                    listBox1.Items.Add(reader.GetString(1));
                }
            }
            conn.Close();
        }
    }
}
