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
    public partial class frmcommentaar : Form
    {
        public static int boekid;
        int[] gebruikers = new int[100];
        bool[] likes = new bool[100];
        string[] commentaar = new string[100];
        string[] gebruikernamen = new string[100];
        int minimum = 0;
        public frmcommentaar()
        {
            InitializeComponent();
        }

        private void frmcommentaar_Load(object sender, EventArgs e)
        {
            
            if (frmboeken.Key == 1)
            {
                int y = frmboeken.boek_info;
                boekid = frmboeken.boekIDs[y];
            }
            else if (frmboeken.Key == 2)
            {
                int y = frmResultaat_zoeken_Boeken.meer_boek_info;
                boekid = frmboeken.boekIDs[y];
            }
            else
            {
                boekid = frmRandomBoek.onthoud;
            }
            laadtitel(boekid);
            laadcomments(boekid);

        }
        private void laadtitel(int id)
        {
            String verbindingsstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Bib.accdb";

            OleDbConnection verbinding = new OleDbConnection(verbindingsstring);

            verbinding.Open();

            String code = "SELECT Titel from tblBoeken Where BoekId = ?";

            OleDbCommand opdracht = new OleDbCommand(code, verbinding);

            opdracht.Parameters.AddWithValue("", id);

            OleDbDataReader dataLezer = opdracht.ExecuteReader(CommandBehavior.CloseConnection);
            while (dataLezer.Read())
            {
                lblcommentaar.Text = Convert.ToString(dataLezer.GetValue(0));
            }
            verbinding.Close();
        }
        private void laadcomments(int id)
        {

            String verbindingsstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Bib.accdb";

            OleDbConnection verbinding = new OleDbConnection(verbindingsstring);

            verbinding.Open();

            String code = "SELECT * from tblCommentaar Where BoekId = ?";

            OleDbCommand opdracht = new OleDbCommand(code, verbinding);

            opdracht.Parameters.AddWithValue("", id);

            OleDbDataReader dataLezer = opdracht.ExecuteReader(CommandBehavior.CloseConnection);

            int i = 0;
            while (dataLezer.Read())
            {
                gebruikers[i] = Convert.ToInt32(dataLezer.GetValue(2));
                vind_gebruiker(i, gebruikers[i]);
                likes[i] = Convert.ToBoolean(dataLezer.GetValue(4));
                commentaar[i] = Convert.ToString(dataLezer.GetValue(3));
                i++;
            }
            verbinding.Close();
            vull_plaatsen(minimum);

        }
        private void vull_plaatsen(int min)
        {   if(gebruikers[min] == 0)
            {
                pcbLike1.Visible = false;
                txtcommentaar1.Visible = false;
                lblgebruikercom1.Visible = false;
                lblLeeg.Visible = true;
                lblLeeg.Text = "Sorry, niemand heeft commentaar gegeven voor dit boek";
            }
            if (gebruikers[min+1] == 0)
            {
                pcbLike2.Visible = false;
                txtcommentaar2.Visible = false;
                lblgebruikercom2.Visible = false;
            }
            if (gebruikers[min+2] == 0)
            {
                pcbLike3.Visible = false;
                txtcommentaar3.Visible = false;
                lblgebruikercom3.Visible = false;
                btnback.Visible = false;
                btnnext.Visible = false;
            }

            txtcommentaar1.Text = commentaar[min];
            txtcommentaar2.Text = commentaar[min + 1];
            txtcommentaar3.Text = commentaar[min + 2];
            lblgebruikercom1.Text = gebruikernamen[min];
            lblgebruikercom2.Text = gebruikernamen[min + 1];
            lblgebruikercom3.Text = gebruikernamen[min + 2];
            if (likes[min])
            {
                pcbLike1.BackColor = Color.Green;
            }
            else
            {
                pcbLike1.BackColor = Color.Red;
            }
            if (likes[min+1])
            {
                pcbLike2.BackColor = Color.Green;
            }
            else
            {
                pcbLike2.BackColor = Color.Red;
            }
            if (likes[min+2])
            {
                pcbLike3.BackColor = Color.Green;
            }
            else
            {
                pcbLike3.BackColor = Color.Red;
            }
        }
        private void vind_gebruiker(int teller, int id)
        {
            String verbindingsstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Bib.accdb";

            OleDbConnection verbinding = new OleDbConnection(verbindingsstring);

            verbinding.Open();

            String code = "SELECT Gebruikersnaam from tblGebruiker Where GebruikerId Like ?";

            OleDbCommand opdracht = new OleDbCommand(code, verbinding);

            opdracht.Parameters.AddWithValue("", id);

            OleDbDataReader dataLezer = opdracht.ExecuteReader(CommandBehavior.CloseConnection);
            while (dataLezer.Read())
            {
                gebruikernamen[teller] = Convert.ToString(dataLezer.GetValue(0));
            }
            verbinding.Close();
        }

        private void btnterug_Click(object sender, EventArgs e)
        {
            if (frmboeken.Key == 1)
            {
                frmboeken boek = new frmboeken();
                boek.Show();
                this.Hide();
            }
            else if (frmboeken.Key == 2)
            {
                frmResultaat_zoeken_Boeken boek = new frmResultaat_zoeken_Boeken();
                boek.Show();
                this.Hide();
            }
            else
            {
                frmRandomBoek.toegang = false;
                frmRandomBoek rboek = new frmRandomBoek();
                rboek.Show();
                this.Hide();
            }
        }

        private void frmcommentaar_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (frmboeken.Key == 1)
            {
                frmboeken boek = new frmboeken();
                boek.Show();
                this.Hide();
            }
            else if (frmboeken.Key == 2)
            {
                frmResultaat_zoeken_Boeken boek = new frmResultaat_zoeken_Boeken();
                boek.Show();
                this.Hide();
            }
            else
            {
                frmRandomBoek rboek = new frmRandomBoek();
                rboek.Show();
                this.Hide();
            }
        }

        private void pcbLike2_Click(object sender, EventArgs e)
        {

        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            int maximum = 0, max;
            String verbindingsstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Bib.accdb";

            OleDbConnection verbinding = new OleDbConnection(verbindingsstring);

            verbinding.Open();

            String code = "SELECT count(*) FROM tblcommentaar";

            OleDbCommand opdracht = new OleDbCommand(code, verbinding);

            OleDbDataReader dataLezer = opdracht.ExecuteReader(CommandBehavior.CloseConnection);



            while (dataLezer.Read())
            {
                maximum = Convert.ToInt32(dataLezer.GetValue(0));
            }

            max = minimum + 3;
            if (max != maximum)
            {
                minimum++;
                vull_plaatsen(minimum);
            }
            else
            {
                MessageBox.Show("Je kunt geen commentaren meer laden");
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            if(minimum != 0)
            {
                minimum--;
                vull_plaatsen(minimum);
            }
            else
            {
                MessageBox.Show("Je kunt geen commentaren meer laden");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCommentMaken commsopen = new frmCommentMaken();
            this.Hide();
            commsopen.Show();
        }
    }
}
