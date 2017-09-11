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

    public partial class pocetna : Form
    {
        public static string connectionString;
        public static string korisnicko;
        public pocetna(string tekst)
        {
            connectionString = @"Data Source=" + tekst;
            InitializeComponent();
        }
        private void Uloguj_se_dugme_Click(object sender, EventArgs e)
        {
            if(Student.Checked)
            {
                if (string.IsNullOrEmpty(username1.Text) | string.IsNullOrEmpty(password1.Text))
                {
                    MessageBox.Show("Unesite broj indexa i šifru!");
                    username1.Focus();
                }
                else
                {
                    try
                    {
                        SqlCeConnection conn = new SqlCeConnection(connectionString);
                        conn.Open();
                        SqlCeCommand cmd = new SqlCeCommand();
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "SELECT broj_indexa, sifra FROM Student WHERE broj_indexa = '" + username1.Text + "';";
                        SqlCeDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        string ime = reader.GetString(0);
                        string sifra = reader.GetString(1);
                        if (sifra.Equals(password1.Text))
                        {
                            MessageBox.Show("Uspješno logovanje");
                            korisnicko = ime;
                            new Opcije().Show();
                        }
                        else
                        {
                            MessageBox.Show("Pogrešna šifra");
                            username1.Clear();
                            username1.Focus();
                            return;
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Nepostojeći broj indexa");
                    }
                }
            }
            else if (Profesor.Checked)
            {
                SqlCeConnection conn = new SqlCeConnection(connectionString);
                conn.Open();
                SqlCeCommand cmd = new SqlCeCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT id FROM Profesor WHERE ime = '"+username1.Text+"' AND prezime = '"+password1.Text+"';";
                SqlCeDataReader reader = cmd.ExecuteReader();
                reader.Read();
                korisnicko = "" + reader.GetInt32(0);
                    new Profesor().Show();
                
            }
            else
            {
                MessageBox.Show("molim vas unesit da li ste profesor ili student");
            }
        }
        private void pocetna_Deactivate(object sender, EventArgs e)
        {
            this.Opacity = 0;
        }
        private void pocetna_Activated(object sender, EventArgs e)
        {
            this.Opacity = 1;
            username1.Clear();
            password1.Clear();
            username1.Focus();
        }
        private void registruj_Click(object sender, EventArgs e)
        {
            new registracija().Show();
        }

        private void pocetna_Load(object sender, EventArgs e)
        {
        }
    }
}
