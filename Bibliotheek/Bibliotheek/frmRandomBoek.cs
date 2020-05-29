using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Bibliotheek
{
    public partial class frmRandomBoek : Form
    {
        public static string auteur, ISBN, Beschrijvingen,titel;
        private bool status;
        public static bool toegang = true;
        public static int onthoud;
        public frmRandomBoek()
        {
            InitializeComponent();
        }

        private void btnterug_Click(object sender, EventArgs e)
        {
            frmboeken boeken = new frmboeken();
            boeken.Show();
            this.Hide();

        }

        private void pcbboek2_Click(object sender, EventArgs e)
        {
            frmboeken.Key = 3;
            frmcommentaar comm = new frmcommentaar();
            comm.Show();
            this.Hide();
        }

        private void btnontlenen2_Click(object sender, EventArgs e)
        {
            if (status)
            {
                ontlenen(onthoud, frminloggen.id);
            }
            else
            {
                MessageBox.Show("Sorry dit boek is niet ter beschikking");
            }
        }
        private void ontlenen(int boek, int user)
        {
            String verbindingsstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Bib.accdb";

            OleDbConnection verbinding = new OleDbConnection(verbindingsstring);

            try
            {
                verbinding.Open();

                OleDbCommand opdracht = new OleDbCommand("INSERT INTO tblLenen (BoekId, GebruikerId,DatumVanLenen) VALUES (?,?,?)", verbinding);
                String date = DateTime.Now.ToString("dd/MM/yyyy");

                opdracht.Parameters.AddWithValue("", boek);

                opdracht.Parameters.AddWithValue("", user);

                opdracht.Parameters.AddWithValue("", date);

                opdracht.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fout bij het invoegen van gegevens in de databank " + ex);
            }
            finally
            {
                verbinding.Close();
                wijzig_status(boek);
            }
        }
        private void wijzig_status(int boek)
        {
            String verbindingsstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Bib.accdb";

            OleDbConnection verbinding = new OleDbConnection(verbindingsstring);

            try
            {
                verbinding.Open();
                String opdrString = "update tblBoeken set Status =? where Boekid = ?";
                OleDbCommand opdracht = new OleDbCommand(opdrString, verbinding);
                opdracht.Parameters.AddWithValue("", false);
                opdracht.Parameters.AddWithValue("", boek);

                opdracht.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("boek status fout " + ex);
            }
            finally
            {
                verbinding.Close();
                pcbstatus.BackColor = Color.Red;
            }
        }
        private void btnmeerinfo2_Click(object sender, EventArgs e)
        {
            frmboeken.Key = 3;
            frmmeer_info info = new frmmeer_info();
            info.Show();
            this.Hide();
        }

        private void frmRandomBoek_Load(object sender, EventArgs e)
        {
            int tell = 0;
            if (toegang)
            {
                tell = random_boek();
                onthoud = tell;
            }
            else
            {
                tell = onthoud;
            } 
                String verbindingsstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Bib.accdb";

                OleDbConnection verbinding = new OleDbConnection(verbindingsstring);

                verbinding.Open();

                String code = "SELECT * from tblBoeken Where BoekId = ?";

                OleDbCommand opdracht = new OleDbCommand(code, verbinding);

                opdracht.Parameters.AddWithValue("", tell);

                OleDbDataReader dataLezer = opdracht.ExecuteReader(CommandBehavior.CloseConnection);

                while (dataLezer.Read())
                {
                    pcbboek.ImageLocation = Convert.ToString(dataLezer.GetValue(5));
                    auteur = Convert.ToString(dataLezer.GetValue(3));
                    ISBN = Convert.ToString(dataLezer.GetValue(1));
                    Beschrijvingen = Convert.ToString(dataLezer.GetValue(4));
                    titel = Convert.ToString(dataLezer.GetValue(2));
                    status = Convert.ToBoolean(dataLezer.GetValue(6));
                }
            if (status)
            {
                pcbstatus.BackColor = Color.Green;
            }
            else
            {
                pcbstatus.BackColor = Color.Red;
            }
            lbltiteltext.Text = titel;

        }
        private int random_boek()
        {
            int rndmboek = 0, max = 0;

            String verbindingsstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Bib.accdb";

            OleDbConnection verbinding = new OleDbConnection(verbindingsstring);

            verbinding.Open();

            String code = "SELECT count(*) from tblBoeken";

            OleDbCommand opdracht = new OleDbCommand(code, verbinding);

            OleDbDataReader dataLezer = opdracht.ExecuteReader(CommandBehavior.CloseConnection);



            while (dataLezer.Read())
            {
                max = Convert.ToInt32(dataLezer.GetValue(0));
            }

            Random rand = new Random();
            rndmboek = rand.Next(1, max + 1);

            return rndmboek;
        }
    }
}
