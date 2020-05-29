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
    public partial class frmboeken : Form
    {
        public static int Key;
        private static int min;
        public static int[] boekIDs = new int[3];
        public static string[] auteurs = new string[3];
        public static string[] Beschrijvingen = new string[3];
        public static string[] Afbeelding = new string[3];
        public static string[] Titels = new string[3];
        public static string[] ISBNs = new string[3];
        public static bool[] boekstatusen = new bool[3];
        public static int boek_info;

        public frmboeken()
        {
            InitializeComponent();
        }

        private void frmboeken_Load(object sender, EventArgs e)
        {
            Key = 1;
            min = 1;
            boeken_load(min);
        }
        private void boeken_load(int minimum)
        {
            

            for (int i = 1; i <= 3; i++)
            {

                String verbindingsstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Bib.accdb";

                OleDbConnection verbinding = new OleDbConnection(verbindingsstring);

                verbinding.Open();

                String code = "SELECT * from tblBoeken where Boekid like ?";

                OleDbCommand opdracht = new OleDbCommand(code, verbinding);

                opdracht.Parameters.AddWithValue("", minimum);

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
                minimum++;
            }
            lbltiteltext1.Text = Titels[0];
            lbltiteltext2.Text = Titels[1];
            lbltiteltext3.Text = Titels[2];
            pcbboek1.ImageLocation = Afbeelding[0];
            pcbboek2.ImageLocation = Afbeelding[1];
            pcbboek3.ImageLocation = Afbeelding[2];


        }

        private void frmboeken_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

       private void v_Click(object sender, EventArgs e)
        {
            //foute benaming button en de knop is vervangen
        }

        private void btnmeerinfo1_Click(object sender, EventArgs e)
        {
            meerinfo(0);
        }

        private void btnmeerinfo2_Click(object sender, EventArgs e)
        {
            meerinfo(1);
        }

        private void btnmeerinfo3_Click(object sender, EventArgs e)
        {
            meerinfo(2);
        }

        private void btnvooruit_Click(object sender, EventArgs e)
        {
            int maximum = 0, max;
            String verbindingsstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Bib.accdb";

            OleDbConnection verbinding = new OleDbConnection(verbindingsstring);

            verbinding.Open();

            String code = "SELECT count(*) FROM tblBoeken";

            OleDbCommand opdracht = new OleDbCommand(code, verbinding);

            OleDbDataReader dataLezer = opdracht.ExecuteReader(CommandBehavior.CloseConnection);



            while (dataLezer.Read())
            {
                maximum = Convert.ToInt32(dataLezer.GetValue(0));
            }

            max = min + 2;
            if(max != maximum)
            {
                min++;
                boeken_load(min);
            }
            else
            {
                MessageBox.Show("Je kunt geen boeken meer laden");
            }
            
        }

        private void btnachteruit_Click(object sender, EventArgs e)
        {
            if(min != 1)
            {
                min--;
                boeken_load(min);
            }
            else
            {
                MessageBox.Show("Je bent terug bij de start");
            }

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
            frmhome home = new frmhome();
            home.Show();
            this.Hide();
        }

        private void btnontlenen1_Click(object sender, EventArgs e)
        {
            if (boekstatusen[0])
            {
                ontlenen(boekIDs[0],frminloggen.id,0);
            }
            else
            {
                MessageBox.Show("Sorry dit boek is niet ter beschikking");
            }
        }
        private void ontlenen(int boek,int user, int pos)
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
                wijzig_status(boek,pos);
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

        private void btnontlenen2_Click(object sender, EventArgs e)
        {
            if (boekstatusen[1])
            {
                ontlenen(boekIDs[1], frminloggen.id,1);
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
                ontlenen(boekIDs[2], frminloggen.id,2);
            }
            else
            {
                MessageBox.Show("Sorry dit boek is niet ter beschikking");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btnZoeken_Click(object sender, EventArgs e)
        {
            frmZoeken zoek = new frmZoeken();
            zoek.Show();
            this.Hide();
        }

        private void btnrandomboek_Click(object sender, EventArgs e)
        {
            frmRandomBoek.toegang = true;
            frmRandomBoek rboek = new frmRandomBoek();
            rboek.Show();
            this.Hide();
        }
        private void meerinfo(int place)
        {
            frmmeer_info info = new frmmeer_info();
            boek_info = place;
            info.Show();
            this.Hide();
        }
        private void commentaar(int place)
        {
            boek_info = place;
            frmcommentaar comm = new frmcommentaar();
            comm.Show();
            this.Hide();
        }

        private void pcbboek1_Click(object sender, EventArgs e)
        {
            commentaar(0);
        }

        private void pcbboek2_Click(object sender, EventArgs e)
        {
            commentaar(1);
        }

        private void pcbboek3_Click(object sender, EventArgs e)
        {
            commentaar(2);
        }
    }
}
