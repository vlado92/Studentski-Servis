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
    public partial class Profesor : Form
    {
        public Profesor()
        {
            InitializeComponent();
        }
        List<string> studenti = new List<string>();
        List<string> predmeti= new List<string>();
        
        SqlCeConnection conn = new SqlCeConnection(pocetna.connectionString);
        SqlCeCommand command = new SqlCeCommand();
        SqlCeDataReader reader;
        private void Profesor_Load(object sender, EventArgs e)
        {
            this.Size = new Size(591, 252);
            label1.Hide();
            label2.Hide();
            textBox1.Hide();
            textBox2.Hide();
            Ocjena.Hide();
            comboBox1.Hide();
            conn.Open();
            string tabova = "\t\t\t";
            listBox1.Items.Clear();
            SqlCeCommand command2 = new SqlCeCommand("", conn);
            SqlCeDataReader reader2, reader3, reader4;
            command.CommandText = "SELECT sifra_predmeta FROM predmeti WHERE ime_profesora = "+Int32.Parse(pocetna.korisnicko)+ "ORDER BY sifra_predmeta;";
            command.Connection = conn;
            reader = command.ExecuteReader();
            while(reader.Read())
            {
                command2.CommandText = "Select naziv_predmeta, semestar, ECTS FROM predmeti WHERE sifra_predmeta = '" + reader.GetString(0) + "';";
                reader2 = command2.ExecuteReader();
                reader2.Read();
                if (reader2.GetString(0).Length > 9 && reader2.GetString(0).Length < 19)
                    tabova = "\t\t";
                if (reader2.GetString(0).Length > 18)
                    tabova = "\t";
                command2.CommandText = "Select student, izlazio FROM Ispiti where predmet = '" + reader.GetString(0) + "' AND prijavio = 'true' AND polozio = 'false';";
                reader3 = command2.ExecuteReader();
                while(reader3.Read())
                {
                    command2.CommandText = "SELECT ime, prezime FROM Student wHEre broj_indexa = '" + reader3.GetString(0) + "';";
                    reader4 = command2.ExecuteReader();
                    reader4.Read();
                    studenti.Add(reader3.GetString(0));
                    predmeti.Add(reader.GetString(0));
                listBox1.Items.Add(reader.GetString(0) + " \t"+ reader2.GetString(0) +tabova+ reader2.GetInt32(1) +" \t " + reader2.GetInt32(2)+"\t"+reader4.GetString(0) +" "+reader4.GetString(1)+"\t"+reader3.GetInt32(1)+". put");
                }
            }
            conn.Close();
         }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Size = new Size(591, 332);
            label1.Show();
            label2.Show();
            textBox1.Show();
            textBox2.Show();
            Ocjena.Show();
            comboBox1.Show();
            conn.Open();
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Niste odabrali koji je student u pitanju");
            }
            command.CommandText = "Select ime, prezime FROM Student WHERE broj_indexa = '" + studenti[listBox1.SelectedIndex] + "';";
            reader = command.ExecuteReader();
            reader.Read();
            textBox1.Text = reader.GetString(0) + " " + reader.GetString(1);
            command.CommandText = "Select naziv_predmeta FROM Predmeti WHERE sifra_predmeta = '" + predmeti[listBox1.SelectedIndex] + "';";
            reader = command.ExecuteReader();
            reader.Read();
            textBox2.Text = reader.GetString(0);
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            int[] brojevi = new int[listBox1.SelectedIndices.Count];
            listBox1.SelectedIndices.CopyTo(brojevi, 0);
            command.Connection = conn;
            for (int i = 0; i < brojevi.Length; i++)
            {
                command.CommandText = "UPDATE Ispiti SET prijavio = 'false', polozio = 'false' WHERE predmet = '" + predmeti[i] + "' AND Student = '" + studenti[i] + "';";
                command.ExecuteNonQuery();
            }
            conn.Close();
            
            Profesor_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            command.Connection = conn;
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Molim Vas unesite koju je ocjenu dobio student.");
                conn.Close();
                return;
            }
            command.CommandText = "UPDATE Ispiti SET prijavio = 'false', polozio = 'true', ocjena = " + Int32.Parse(comboBox1.SelectedItem.ToString()) + " WHERE predmet = '" + predmeti[listBox1.SelectedIndex] + "' AND Student = '" + studenti[listBox1.SelectedIndex] + "';";
            command.ExecuteNonQuery();
            conn.Close();

            Profesor_Load(sender, e);
        }
    }
}
