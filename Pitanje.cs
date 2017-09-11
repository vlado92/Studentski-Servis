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
    public partial class Pitanje : Form
    {
        public Pitanje()
        {
            InitializeComponent();
        }
        int uplata;
        SqlCeConnection conn = new SqlCeConnection(pocetna.connectionString);
        SqlCeCommand command = new SqlCeCommand();
        SqlCeDataReader reader;
        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            command.Connection = conn;
            command.CommandText = "SELECT nacin_finansiranja FROM Student WHERE broj_indexa = '" + pocetna.korisnicko + "';";
            reader = command.ExecuteReader();
            reader.Read();
            if (reader.GetString(0) == "Budžet")
            {
                uplata = 120;
                command.CommandText = "INSERT INTO Uplate(broj_indexa, vrsta_uplate, visina_uplate, datum) VALUES ('" + pocetna.korisnicko + "', 'Uplata semestra', " + uplata + ", '" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "');";

                command.ExecuteNonQuery();
                command.CommandText = "Select id from Uplate Where broj_indexa = '" + pocetna.korisnicko + "' AND vrsta_uplate = 'Uplata semestra' AND visina_uplate = " + uplata + ";";
                reader = command.ExecuteReader();
                reader.Read();
                Prijava.vrsta = reader.GetInt64(0);   
            }
            else if (reader.GetString(0) == "Samofinasiranje")
            {
                uplata = 250;
                command.CommandText = "INSERT INTO Uplate(broj_indexa, vrsta_uplate, visina_uplate, datum) VALUES ('" + pocetna.korisnicko + "', 'Uplata semestra', " + uplata + ", '" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "');";
                command.ExecuteNonQuery();
                command.CommandText = "Select id from Uplate Where broj_indexa = '" + pocetna.korisnicko + "' AND vrsta_uplate = 'Uplata semestra' AND visina_uplate = " + uplata + ";";
                reader = command.ExecuteReader();
                reader.Read();
                Prijava.vrsta = reader.GetInt64(0);
            }
            else
            {
                uplata = 750;
                command.CommandText = "INSERT INTO Uplate(broj_indexa, vrsta_uplate, visina_uplate, datum) VALUES ('" + pocetna.korisnicko + "', 'Uplata semestra', " + uplata + ", '" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "');";
                command.ExecuteNonQuery();
                command.CommandText = "Select id from Uplate Where broj_indexa = '" + pocetna.korisnicko + "' AND vrsta_uplate = 'Uplata semestra' AND visina_uplate = " + uplata + ";";
                reader = command.ExecuteReader();
                reader.Read();
                Prijava.vrsta = reader.GetInt64(0);
            }
            conn.Close();
            new Uplate().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            command.Connection = conn;
            command.CommandText = "SELECT polozio FROM Ispiti WHERE student = '" + pocetna.korisnicko + "';";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetBoolean(0) == false)
                {
                    MessageBox.Show("Niste položili sve ispite");
                    conn.Close();
                    return;
                }
            }
            uplata = 250;
            command = new SqlCeCommand("INSERT INTO Uplate(broj_indexa, vrsta_uplate, visina_uplate, datum) VALUES ('" + pocetna.korisnicko + "', 'Uplata diplomskog', " + uplata + ", '" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "');");
            command.ExecuteNonQuery();
            command.CommandText = "Select id from Uplate Where broj_indexa = '" + pocetna.korisnicko + "' AND vrsta_uplate = 'Uplata semestra' AND visina_uplate = " + uplata + ";";
            reader = command.ExecuteReader();
            reader.Read();
            Prijava.vrsta = reader.GetInt64(0);
            conn.Close();
            new Uplate().Show();
        }
    }
}
