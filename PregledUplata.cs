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
    public partial class UplateSkolarine : Form
    {
        public UplateSkolarine()
        {
            InitializeComponent();
        }

        private void UplateSkolarine_Load(object sender, EventArgs e)
        {
            vrsta.Items.Clear();
            vrsta1.Items.Clear();
            SqlCeConnection conn = new SqlCeConnection(pocetna.connectionString);
            conn.Open();
            SqlCeCommand command = new SqlCeCommand();
            command.Connection = conn;
            command.CommandText = "SELECT ime, prezime, studijski_program FROM Student WHERE broj_indexa = '" + pocetna.korisnicko + "';";
            SqlCeDataReader reader = command.ExecuteReader();
            SqlCeCommand com = new SqlCeCommand("", conn);
            SqlCeDataReader read;
            reader.Read();
            index.Text = pocetna.korisnicko;
            ime.Text = reader.GetString(0);
            prezime.Text = reader.GetString(1);
            command.CommandText = "SELECT * FROM Uplate WHERE broj_indexa = '" + pocetna.korisnicko + "';";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetString(2) == "Uplata ispita")
                {
                    com.CommandText = "SELECT predmet FROM Ispiti WHERE uplatnice = " + reader.GetInt64(3) + ";";
                    read = com.ExecuteReader();
                    read.Read();
                    com.CommandText = "SELECT naziv_predmeta FROM predmeti WHERE sifra_predmeta ='"+read.GetString(0)+"' ;";
                    //nadji ggresu
                    read = com.ExecuteReader();
                    read.Read();
                    string razmak= "";
                    if (reader.GetDateTime(4).Day.ToString().Length == 1)
                        razmak = razmak + " ";
                    if (reader.GetDateTime(4).Month.ToString().Length==1)
                        razmak = razmak + " ";
                    vrsta1.Items.Add(reader.GetDateTime(4).ToShortDateString()+razmak+"\t"+reader.GetString(2)+"\t"+reader.GetInt32(1)+"\t"+read.GetString(0));
                }
                else
                {
                    string razmak = "";
                    if (reader.GetDateTime(4).Day.ToString().Length == 1)
                        razmak = razmak + " ";
                    if (reader.GetDateTime(4).Month.ToString().Length == 1)
                        razmak = razmak + " ";
                    vrsta.Items.Add(reader.GetDateTime(4).ToShortDateString() + razmak+"\t" + reader.GetString(2) + "\t" + reader.GetInt32(1));                
                }
            }
        }
    }
}
