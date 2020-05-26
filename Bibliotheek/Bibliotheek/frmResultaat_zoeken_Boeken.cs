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
    public partial class frmResultaat_zoeken_Boeken : Form
    {
        private static int[] boekIDs = new int[3];
        public static string[] auteurs = new string[3];
        public static string[] Beschrijvingen = new string[3];
        public static string[] Afbeelding = new string[3];
        public static string[] Titels = new string[3];
        public static string[] ISBNs = new string[3];
        public static bool[] boekstatusen = new bool[3];
        public static int meer_boek_info;
        int y = 1;
        public frmResultaat_zoeken_Boeken()
        {
            InitializeComponent();
        }

        private void frmResultaat_zoeken_Boeken_Load(object sender, EventArgs e)
        {
                    zoeken_laden(y);
                    leeg(frmZoeken.gezochteIDs[1], frmZoeken.gezochteIDs[2]);
        }
        private void leeg(int boek2, int boek3)
        {
            if (boek2 == 0)
            {
                pcbboek2.Visible = false;
                lblstatusboek2.Visible = false;
                pcbstatus2.Visible = false;
                lbltitel2.Visible = false;
                lbltiteltext2.Visible = false;
                btnmeerinfo2.Visible = false;
                btnontlenen2.Visible = false;
            }
             if (boek3 == 0)
            {
                pcbboek3.Visible = false;
                lblstatusboek3.Visible = false;
                pcbstatus3.Visible = false;
                lbltitel3.Visible = false;
                lbltiteltext3.Visible = false;
                btnmeerinfo3.Visible = false;
                btnontlenen3.Visible = false;
            }
        }
        private void zoeken_laden(int min)
        {

            for (int i = 1; i <= 3; i++)
            {

                String verbindingsstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Bib.accdb";

                OleDbConnection verbinding = new OleDbConnection(verbindingsstring);

                verbinding.Open();

                String code = "SELECT * from tblBoeken where Boekid like ?";

                OleDbCommand opdracht = new OleDbCommand(code, verbinding);

                opdracht.Parameters.AddWithValue("", min);

                OleDbDataReader dataLezer = opdracht.ExecuteReader(CommandBehavior.CloseConnection);



                while (dataLezer.Read())
                {
                    auteurs[i - 1] = Convert.ToString(dataLezer.GetValue(3));
                    Beschrijvingen[i - 1] = Convert.ToString(dataLezer.GetValue(4));
                    Afbeelding[i - 1] = Convert.ToString(dataLezer.GetValue(5));
                    Titels[i - 1] = Convert.ToString(dataLezer.GetValue(2));
                    ISBNs[i - 1] = Convert.ToString(dataLezer.GetValue(1));
                    boekstatusen[i - 1] = dataLezer.GetBoolean(6);
                    status_van_boek(i - 1, dataLezer.GetBoolean(6));
                    boekIDs[i - 1] = Convert.ToInt32(dataLezer.GetValue(0));
                }
                min++;
            }
            lbltiteltext1.Text = Titels[0];
            lbltiteltext2.Text = Titels[1];
            lbltiteltext3.Text = Titels[2];
            pcbboek1.ImageLocation = Afbeelding[0];
            pcbboek2.ImageLocation = Afbeelding[1];
            pcbboek3.ImageLocation = Afbeelding[2];
         }
        private void status_van_boek(int welkboek, bool status)
        {
            switch (welkboek)
            {
                case 0:
                    if (status)
                    {
                        pcbstatus1.BackColor = Color.Green;
                    }
                    else
                    {
                        pcbstatus1.BackColor = Color.Red;
                    }
                    break;
                case 1:
                    if (status)
                    {
                        pcbstatus2.BackColor = Color.Green;
                    }
                    else
                    {
                        pcbstatus2.BackColor = Color.Red;
                    }
                    break;
                case 2:
                    if (status)
                    {
                        pcbstatus3.BackColor = Color.Green;
                    }
                    else
                    {
                        pcbstatus3.BackColor = Color.Red;
                    }
                    break;
            }
        }

        private void btnterug_Click(object sender, EventArgs e)
        {
            frmboeken boeken = new frmboeken();
            boeken.Show();
            this.Hide();
        }

        private void btnmeerinfo2_Click(object sender, EventArgs e)
        {
            frmboeken.Key = 2;
            frmmeer_info info = new frmmeer_info();
            meer_boek_info = 1;
            info.Show();
            this.Hide();
        }

        private void btnmeerinfo1_Click(object sender, EventArgs e)
        {
            frmboeken.Key = 2;
            frmmeer_info info = new frmmeer_info();
            meer_boek_info = 0;
            info.Show();
            this.Hide();
        }

        private void btnmeerinfo3_Click(object sender, EventArgs e)
        {
            frmboeken.Key = 2;
            frmmeer_info info = new frmmeer_info();
            meer_boek_info = 2;
            info.Show();
            this.Hide();
        }

        private void btnvooruit_Click(object sender, EventArgs e)
        {
            if (frmZoeken.gezochteIDs[y+2] != 0)
            {
                y++;
                zoeken_laden(y);
            }
            else
            {
                MessageBox.Show("Je kunt niet verder terug gaan");
            }
            

        }

        private void btnachteruit_Click(object sender, EventArgs e)
        {
            if (y != 1)
            {
                y--;
                zoeken_laden(y);
            }
            else
            {
                MessageBox.Show("Je kunt niet verder terug gaan");
            }
           
        }
        private void ontlenen(int boek, int user, int pos)
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
                wijzig_status(boek, pos);
            }
        }
        private void wijzig_status(int boek, int pos)
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
                boekstatusen[pos] = false;
                status_van_boek(pos, false);
            }
        }

        private void btnontlenen1_Click(object sender, EventArgs e)
        {
            if (boekstatusen[0])
            {
                ontlenen(boekIDs[0], frminloggen.id, 0);
            }
            else
            {
                MessageBox.Show("Sorry dit boek is niet ter beschikking");
            }
        }

        private void btnontlenen2_Click(object sender, EventArgs e)
        {
            if (boekstatusen[1])
            {
                ontlenen(boekIDs[1], frminloggen.id, 1);
            }
            else
            {
                MessageBox.Show("Sorry dit boek is niet ter beschikking");
            }
        }

        private void btnontlenen3_Click(object sender, EventArgs e)
        {
            if (boekstatusen[2])
            {
                ontlenen(boekIDs[2], frminloggen.id, 2);
            }
            else
            {
                MessageBox.Show("Sorry dit boek is niet ter beschikking");
            }
        }
    }

    }

