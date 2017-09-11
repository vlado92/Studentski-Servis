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
    public partial class Uplate : Form
    {
        public Uplate()
        {
            InitializeComponent();
        }

        private void dugme_Click(object sender, EventArgs e)
        {
            
            SqlCeConnection conn = new SqlCeConnection(pocetna.connectionString);
            conn.Open();
            SqlCeCommand command = new SqlCeCommand();
            command.Connection = conn;
            command.CommandType = CommandType.Text;
            command.CommandText = "Select vrsta_uplate from uplate where broj_indexa = '"+pocetna.korisnicko+"'AND id = "+Prijava.vrsta+";";
            SqlCeDataReader reader = command.ExecuteReader();
            reader.Read();
            if (reader.GetString(0) == "Uplata ispita")
            {
                command.CommandText = "UPDATE Ispiti SET prijavio = 'true', uplatnice = " + Prijava.vrsta + ", izlazio = " + Prijava.izlasci + " WHERE student = '" + pocetna.korisnicko + "'AND predmet = '" + Prijava.predmeti + "';";
                command.ExecuteNonQuery();
            } 
            this.Close();
            }

        private void Uplate_Load(object sender, EventArgs e)
        {
            brojIndexa.Text = pocetna.korisnicko;
            SqlCeConnection conn = new SqlCeConnection(pocetna.connectionString);
            conn.Open();
            SqlCeCommand command = new SqlCeCommand();
            command.Connection = conn;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT ime, prezime FROM student WHERE broj_indexa = '" + brojIndexa.Text + "';";
            SqlCeDataReader reader = command.ExecuteReader();
            reader.Read();
            string ime = reader.GetString(0) + " " + reader.GetString(1);
            imeStudenta.Text = ime;
            command.CommandText = "SELECT vrsta_uplate, visina_uplate FROM Uplate WHERE id = "+Prijava.vrsta+";";
            reader = command.ExecuteReader();
            reader.Read();
            visinaUplate.Text =""+ reader.GetInt32(1);
            svrhaUplate.Text = reader.GetString(0);
            datumUplate.Text = DateTime.Now.ToLongDateString().ToString();
            if (svrhaUplate.Text != "Uplata ispita")
            {
                put.Hide();
                label3.Hide();
            }
            else
            {
                put.Show();
                label3.Show();
                put.Text = "" + Prijava.izlasci;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
