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
        private static int min;
        private static int[] boekIDs = new int[3];
        public static string[] auteurs = new string[3];
        public static string[] Beschrijvingen = new string[3];
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
            frmmeer_info info = new frmmeer_info();
            boek_info = 0;
            info.Show();
            this.Hide();
        }

        private void btnmeerinfo2_Click(object sender, EventArgs e)
        {
            frmmeer_info info = new frmmeer_info();
            boek_info = 1;
            info.Show();
            this.Hide();
        }

        private void btnmeerinfo3_Click(object sender, EventArgs e)
        {
            frmmeer_info info = new frmmeer_info();
            boek_info = 2;
            info.Show();
            this.Hide();
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
                ontlenen(boekIDs[0]);
            }
            else
            {
                MessageBox.Show("Sorry dit boek is niet ter beschikking");
            }
        }
        private void ontlenen(int boek)
        {
            string opdrString;
            String verbindingsstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Bib.accdb";

            OleDbConnection verbinding = new OleDbConnection(verbindingsstring);

            verbinding.Open();
            try
            {
                opdrString = "update tblBoeken set Status = ? where Boekid = ?";


                OleDbCommand opdracht = new OleDbCommand(opdrString, verbinding);
                opdracht.Parameters.AddWithValue("", false);
                opdracht.Parameters.AddWithValue("", boek);

                opdracht.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemen bij Weizigen van de voornaam." + ex);
            }
            finally
            {
                status_van_boek(boek, false);
                verbinding.Close();
            }
        }

        private void btnontlenen2_Click(object sender, EventArgs e)
        {
            if (boekstatusen[1])
            {
                ontlenen(boekIDs[1]);
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
                ontlenen(boekIDs[2]);
            }
            else
            {
                MessageBox.Show("Sorry dit boek is niet ter beschikking");
            }
        }
    }
}
