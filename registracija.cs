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
    public partial class registracija : Form
    {
        public registracija()
        {
            InitializeComponent();
        }
        bool mesto_postoji;
        private void prijava_Click(object sender, EventArgs e)
        {   
            try {
                SqlCeConnection conn = new SqlCeConnection(pocetna.connectionString);
                conn.Open();
                SqlCeCommand command = new SqlCeCommand();
                command.Connection = conn;
                command.CommandType = CommandType.Text;
                Int64 nesto;
                string polovi = "";
                if (godina.SelectedIndex < 0 || godina.Items.Count < godina.SelectedIndex)
                {
                    MessageBox.Show("Niste dobro unijeli godinu studija!");
                    godina.Focus();
                    godina.SelectedIndex = -1;
                }
                if (studijski_pravac.SelectedIndex < 0 || studijski_pravac.SelectedIndex > studijski_pravac.MaxLength)
                {
                    MessageBox.Show("Niste dobro unijeli pravac studija!");
                    studijski_pravac.Focus();
                    studijski_pravac.SelectedIndex = -1;
                    return;
                }

                if (imetext.TextLength == 0)
                {
                    MessageBox.Show("Niste unijeli Vaše ime!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    imetext.Focus();
                    return;
                }
                else
                {
                    for (int i = 0; i < imetext.TextLength; i++)
                        if ((imetext.Text[i] >= 'z' && imetext.Text[i] <= 'a') || (imetext.Text[i] <= 'A' && imetext.Text[i] >= 'Z'))
                        {
                            MessageBox.Show("Niste unijeli ispravno Vaše ime!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else
                        {
                            imetext.Text.ToLowerInvariant();
                            imetext.Text.First().ToString().ToUpperInvariant();
                        }
                }
                if (brojIndexa.Text.Length == 0)
                {
                    MessageBox.Show("Niste unijeli Vaš broj indeksa!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    brojIndexa.Focus();
                    return;
                }
                if (prezimetext.TextLength == 0)
                {
                    MessageBox.Show("Niste unijeli Vaše prezime!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    prezimetext.Focus();
                    return;
                }
                else
                {
                    for (int i = 0; i < prezimetext.TextLength; i++)
                        if ((prezimetext.Text[i] >= 'z' && prezimetext.Text[i] <= 'a') || (prezimetext.Text[i] <= 'A' && prezimetext.Text[i] >= 'Z'))
                        {
                            MessageBox.Show("Niste unijeli ispravno Vaše ime!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else
                        {
                            prezimetext.Text.ToLowerInvariant();
                            prezimetext.Text.First().ToString().ToUpperInvariant();
                        }
                }
                if (!polM.Checked && !polz.Checked)
                {
                    MessageBox.Show("Niste unijeli Vaš pol!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DateTime rodjendan = DateTime.Parse(rodjenje.Text);
                string dan, mjesec;
                if (rodjendan.Day < 10)
                    dan = "0" + rodjendan.Day;
                else
                    dan = "" + rodjendan.Day;
                if (rodjendan.Month < 10)
                    mjesec = "0" + rodjendan.Month;
                else
                    mjesec = "" + rodjendan.Month;
                DateTime today = DateTime.Today;
                int age = today.Year - rodjendan.Year;
                if (age < 18)
                {
                    MessageBox.Show("Pogrešan unos godina");
                    return;
                }
                if (mestoRodjenja.SelectedIndex < 0 || mestoRodjenja.SelectedIndex > mestoRodjenja.Items.Count)
                {
                    MessageBox.Show("Niste unijeli ispravno mjesto rodjenja!", "Greška pri unosu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mestoRodjenja.Focus();
                    mestoRodjenja.SelectedIndex = -1;
                    return;
                }


                if (!Int64.TryParse(JMBGtext.Text, out nesto))
                {
                    MessageBox.Show("Niste unijeli ispravno matični broj!", "Greška pri unosu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    JMBGtext.Focus();
                    JMBGtext.Clear();
                    return;
                }
                else
                {
                    if (JMBGtext.Text.Length != 13)
                    {
                        MessageBox.Show("maticni broj nema dovoljno karaktera");
                        JMBGtext.Focus();
                        return;
                    }
                }
                if (sifratext.Text == "")
                {
                    MessageBox.Show("Niste unijeli Vašu šifru!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    prezimetext.Focus();
                    return;
                }

                if (telefon.Text != "")
                {
                    if (!Int64.TryParse(broj.Text, out nesto))
                    {
                        MessageBox.Show("Niste unijeli ispravno broj telefona!", "Greška pri unosu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        broj.Focus();
                        broj.Clear();
                        return;
                    }
                }
                else
                    telefon.Text = "0";
                if (polM.Checked)
                    polovi = "muško";
                else if (polz.Checked)
                    polovi = "žensko";

                if(put.SelectedIndex < 0)
                {
                    MessageBox.Show("Molim Vas unesite koji ste put na Vašoj godini studija!");
                    put.Focus();
                    put.SelectedIndex = -1;
                    return;
                }
                if (listBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("Niste izabrali način finasiranja");
                    listBox1.Focus();
                    return;
                }
                if (sifratext.Text == "" || sifratext.Text.Length > 30)
                MessageBox.Show("Niste dobro unijeli šifru!");
                command.CommandText = "INSERT INTO student (broj_indexa, ime, prezime, datum_rodjenja,  JMBG, broj_telefona, email, mjesto_rodjenja, pol, godina_studija, studijski_program, sifra, koji_put, nacin_finansiranja) VALUES ('" + brojIndexa.Text + "', '" + imetext.Text + "', '" + prezimetext.Text + "', '" + rodjendan.Year + "-" + mjesec + "-" + dan + "', '" + JMBGtext.Text + "', " + broj.Text + ", '" + email.Text + "', " + mestoRodjenja.SelectedIndex + ",'" + polovi + "', " + godina.SelectedIndex + "+1, " + studijski_pravac.SelectedIndex + "+1, '" + sifratext.Text + "', " + put.SelectedIndex + "+1, '"+listBox1.SelectedItem.ToString()+"');";
                command.ExecuteNonQuery();
                command.CommandText = "SELECT predmet FROM studijski_predmeti WHERE program = "+studijski_pravac.SelectedIndex+"+1;";
                  
                SqlCeDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                        command.CommandText = "INSERT INTO Ispiti (Student, predmet, prijavio, polozio, izlazio) VALUES ('"+brojIndexa.Text+"', '"+reader.GetString(0)+"', 'false', 'false', 0);";
                        command.ExecuteNonQuery();
                    
                }
                    MessageBox.Show("Korisik " + imetext.Text + " " + prezimetext.Text + " uspješno registrovan, i korisničko ime je " + brojIndexa.Text + ".");
                this.Close();
            }
            catch(Exception ee)
            {   
                MessageBox.Show("" + ee);
             }
        }
        private void sifriranje_CheckedChanged(object sender, EventArgs e)
        {
            if (sifriranje.Checked)
            {
                sifratext.PasswordChar = '*';
            }
            else
                sifratext.PasswordChar = '\0';

        }
        private void registracija_Load(object sender, EventArgs e)
        {
            SqlCeConnection conn = new SqlCeConnection(pocetna.connectionString);
            conn.Open();
            SqlCeCommand command = new SqlCeCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM Studijski_program;";
            command.Connection = conn;
            SqlCeDataReader reader = command.ExecuteReader();
            studijski_pravac.Items.Clear();
            while (reader.Read())
            {
                studijski_pravac.Items.Add(reader.GetString(0));
            }
            command.CommandText = "SELECT * FROM Mjesto_rodjenja;";
            reader = command.ExecuteReader();
            mestoRodjenja.Items.Clear();
            while (reader.Read())
            {
                mestoRodjenja.Items.Add(reader.GetString(0));
            }
            
            command.CommandText = "SELECT * FROM Drzave;";
            reader = command.ExecuteReader();
            drzava_text.Items.Clear();
            while (reader.Read())
            {
                drzava_text.Items.Add(reader.GetString(1));
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCeConnection conn = new SqlCeConnection(pocetna.connectionString);
            conn.Open();
            SqlCeCommand command = new SqlCeCommand();
            command.Connection = conn;
            if (!mesto_postoji)
            {
                command.CommandText = "INSERT INTO Mjesto_rodjenja ( Naziv_grada, drzava) VALUES('" + mestoRodjenja.Text + "', " + drzava_text.SelectedIndex + ");";
                mestoRodjenja.Items.Add(mestoRodjenja.Text);
                command.ExecuteNonQuery();
                mestoRodjenja.SelectedIndex = mestoRodjenja.Items.Count - 1;
            }
        }

        private void mestoRodjenja_SelectedIndexChanged(object sender, EventArgs e)
        {
            int resultIndex = -1;
            resultIndex = mestoRodjenja.FindStringExact(mestoRodjenja.Text);
            if (resultIndex == -1)
                mesto_postoji = false;
            else
                mesto_postoji = true;

            if (!mesto_postoji)
            {
                MessageBox.Show("popravilo se");
            }
            else
            {
                SqlCeConnection conn = new SqlCeConnection(pocetna.connectionString);
                conn.Open();

                SqlCeCommand command = new SqlCeCommand();
                command.Connection = conn;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT drzava FROM Mjesto_rodjenja WHERE id = " + mestoRodjenja.SelectedIndex + ";";
                SqlCeDataReader reader = command.ExecuteReader();
                reader.Read();
                int drzavaa = reader.GetInt32(0);
                command.CommandText = "SELECT * FROM Drzave WHERE id = " + drzavaa + ";";
                reader = command.ExecuteReader();
                reader.Read();
                drzava_text.SelectedIndex = reader.GetInt32(0);
            }

        }

    }
}
