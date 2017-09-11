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
    public partial class Opcije : Form
    {
        public Opcije()
        {
            InitializeComponent();
        }

        private void Odjava_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Administracija_Click(object sender, EventArgs e)
        {
            new Glavno().Show();
        }
        private void Opcije_Load(object sender, EventArgs e)
        {
            this.Size = new Size(126, 280);
            if (pocetna.korisnicko == "a" || pocetna.korisnicko == "MR6/11")
            {
                this.Size = new Size(126, 320);
            }
        }
        private void Upisi_Click(object sender, EventArgs e)
        {
        }
        private void Prijava_Click(object sender, EventArgs e)
        {
            new Prijava().Show();
        }
        private void Predmeti_Click(object sender, EventArgs e)
        {
            new Predmeti().Show();
        }
        private void Uplate_Click(object sender, EventArgs e)
        {
            new Pitanje().Show();
        }
        private void pregledUplata_Click(object sender, EventArgs e)
        {

            new UplateSkolarine().Show();
        }
        private void rokovi_Click(object sender, EventArgs e)
        {
            
        }
        private void Ispiti_Click(object sender, EventArgs e)
        {
            new Ispiti().Show();
        }

        
        private void Unesi_predmet_Click(object sender, EventArgs e)
        {
            int nesto;
            if(!Int32.TryParse(ects.Text, out nesto))
            {
                MessageBox.Show("Neispravno uneseni ECTS bodovi");
            }
            if (naziv_predmeta.TextLength == 0 || sifra_predmeta.TextLength == 0 || profesor_ime.SelectedIndex < 0 || asistent_ime.SelectedIndex < 0 || godina_slusanja.SelectedIndex < 0||stud_prog.SelectedIndex <0|| ects.TextLength == 0)
            {
                MessageBox.Show("Pogrešan unos");
                naziv_predmeta.Clear();
                sifra_predmeta.Clear();
                profesor_ime.SelectedIndex = -1;
                asistent_ime.SelectedIndex = -1;
                godina_slusanja.SelectedIndex = -1;
                stud_prog.SelectedIndex = -1;
                stud_prog.Focus();
            }
            else
            {
                string imeprezime;
                imeprezime = profesor_ime.SelectedItem.ToString();
                string[] names = imeprezime.Split(' ');
                label8.Text = "" + names[0] + names[1];
                SqlCeConnection conn = new SqlCeConnection(pocetna.connectionString);
                conn.Open();
                SqlCeCommand command = new SqlCeCommand();
                command.Connection = conn;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM Profesor WHERE ime = '" + names[0] + "' AND prezime = '" + names[1] + "';";
                SqlCeDataReader reader = command.ExecuteReader();
                reader.Read();
                int profesor = reader.GetInt32(0);
                imeprezime = asistent_ime.SelectedItem.ToString();
                string[] name = imeprezime.Split(' ');
                command.CommandText = "SELECT * FROM Profesor WHERE ime = '" + name[0] + "' AND prezime = '" + name[1] + "';";
                reader = command.ExecuteReader();
                reader.Read();
                int  asistent = reader.GetInt32(0);
                label8.Text = "" +asistent +" " +profesor;
                command.CommandText = "INSERT INTO Predmeti (sifra_predmeta, naziv_predmeta, Ime_profesora, Ime_asistenta, semestar, ECTS) VALUES('" + sifra_predmeta.Text + "', '" + naziv_predmeta.Text + "', " + profesor + ", " + asistent + ", " + godina_slusanja.SelectedIndex + "+1, "+ects.Text+");";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO studijski_predmeti (program, predmet) VALUES (" + stud_prog.SelectedIndex + "+1, '" + sifra_predmeta.Text + "');";
                command.ExecuteNonQuery();
                command.CommandText = "SELECT * FROM student WHERE studijski_program = " + stud_prog.SelectedIndex + "+1;";
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    command.CommandText = "INSERT INTO Ispiti (student, predmet, prijavio, polozio, izlazio) VALUES ('" + reader.GetString(10) + "', '" + sifra_predmeta.Text + "', 'false','false', 0);";
                    command.ExecuteNonQuery();
                }
                stud_prog.SelectedIndex = -1;
                profesor_ime.SelectedItem = -1;
                asistent_ime.SelectedItem = 1;
                naziv_predmeta.Clear();
                sifra_predmeta.Clear();
                godina_slusanja.SelectedIndex = -1;
                sifra_predmeta.Focus();
            }
        }
        private void dodaj_Click(object sender, EventArgs e)
        {
            this.Size = new Size(598, 320);
            SqlCeConnection conn = new SqlCeConnection(pocetna.connectionString);
            conn.Open();
            SqlCeCommand command = new SqlCeCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = "SELECT * FROM Studijski_program;";
            command.Connection = conn;
            SqlCeDataReader reader = command.ExecuteReader();
            stud_prog.Items.Clear();
            while (reader.Read())
            { stud_prog.Items.Add(reader.GetString(0)); }

            command.CommandText = "SELECT * FROM Profesor WHERE tip = 'Profesor';";
            reader = command.ExecuteReader();
            profesor_ime.Items.Clear();
            string ime = "";
            string prezime = "";

            while (reader.Read())
            {
                ime = reader.GetString(1);
                prezime = reader.GetString(2);
                profesor_ime.Items.Add(ime + " " + prezime);
            }

            command.CommandText = "SELECT * FROM Profesor WHERE tip = 'Asistent';";
            reader = command.ExecuteReader();
            asistent_ime.Items.Clear();
            while (reader.Read())
            {
                ime = reader.GetString(1);
                prezime = reader.GetString(2);
                asistent_ime.Items.Add(ime + " " + prezime);
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
        bool mesto_postoji;
        private void unos_profesora_Click(object sender, EventArgs e)
        {
            
            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("nije unijet status profesora");
            }
            else
            {
                
                    if (Ime_profesora_dodaj.Text.Length == 0 || prezime_profesora_dodaj.Text.Length == 0 || dodaj_zvanje.SelectedIndex < 0)
                {
                    MessageBox.Show("greska u unosu podataka");
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
                string tip = "nedefinisano";
                if (radioButton2.Checked)
                {
                 tip = "Profesor";
                }
                if(radioButton1.Checked)
                {
                    tip = "Asistent";
                }
                SqlCeConnection conn = new SqlCeConnection(pocetna.connectionString);
                conn.Open();
                SqlCeCommand command = new SqlCeCommand();
                command.Connection = conn;
                command.CommandText = "INSERT INTO Profesor (ime, prezime, zvanje, dan_rodjenja,  tip, mjesto_rodjenja)VALUES('" + Ime_profesora_dodaj.Text + "', '" + prezime_profesora_dodaj.Text + "', '" + dodaj_zvanje.SelectedItem.ToString() + "','" + rodjendan.Year + "-" + mjesec + "-" + dan + "', '"+tip+"', "+mestoRodjenja.SelectedIndex+");";
                command.ExecuteNonQuery();
                Ime_profesora_dodaj.Clear();
                prezime_profesora_dodaj.Clear();
                dodaj_zvanje.SelectedIndex = -1;
                Ime_profesora_dodaj.Focus();
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
            label8.Text = mesto_postoji.ToString();
            
            if (mesto_postoji)
            {
                SqlCeConnection conn = new SqlCeConnection(pocetna.connectionString);
                conn.Open();
                //try
                //{
                SqlCeCommand command = new SqlCeCommand();
                command.Connection = conn;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT drzava FROM Mjesto_rodjenja WHERE naziv_grada = '" + mestoRodjenja.SelectedItem.ToString() + "';";
                SqlCeDataReader reader = command.ExecuteReader();
                reader.Read();
                drzava_text.SelectedIndex = reader.GetInt32(0);
               /* }
                catch (Exception ee)
                {
                    MessageBox.Show("" + ee);
                }*/
                conn.Close();
            }
            else
            {
                label8.Text = "greska";
            }
        }
        private void dodaj_program_Click(object sender, EventArgs e)
        {
            SqlCeConnection conn = new SqlCeConnection(pocetna.connectionString);
            conn.Open();
            SqlCeCommand command = new SqlCeCommand();
            command.Connection = conn;
            command.CommandText = "INSERT INTO Studijski_program (naziv_programa)VALUES('" + naziv_text.Text+ "');";
            command.ExecuteNonQuery();
            naziv_text.Focus();
            naziv_text.Clear();
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            dodaj_zvanje.Items.Clear();
            if (radioButton1.Checked)
            {
                dodaj_zvanje.Items.Add("Viši Asistent");
                dodaj_zvanje.Items.Add("Asistent");
            }
            else if (radioButton2.Checked)
            {
                dodaj_zvanje.Items.Add("Profesor doktor");
                dodaj_zvanje.Items.Add("Docent doktor");
            }
        }
        private void drzava_text_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCeConnection conn = new SqlCeConnection(pocetna.connectionString);
            conn.Open();
            SqlCeCommand command = new SqlCeCommand();
            command.Connection = conn;
            if (!mesto_postoji)
            {
                command.CommandText = "INSERT INTO Mjesto_rodjenja ( Naziv_grada, drzava) VALUES('" + mestoRodjenja.Text+ "', " + drzava_text.SelectedIndex + ");";
                mestoRodjenja.Items.Add(mestoRodjenja.Text);
                command.ExecuteNonQuery();
                mestoRodjenja.SelectedIndex = mestoRodjenja.Items.Count -1;
            }
        }


    }
}
