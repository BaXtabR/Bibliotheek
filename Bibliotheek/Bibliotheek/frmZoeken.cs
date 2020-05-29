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
    public partial class frmZoeken : Form
    {
        int keuze = 0;
        public static int[] gezochteIDs = new int[50];
        public frmZoeken()
        {
            InitializeComponent();
        }

        

        private void btnterug_Click(object sender, EventArgs e)
        {
            frmboeken boek = new frmboeken();
            boek.Show();
            this.Hide();

        }
        private void zoek_waarde(int zoeker)
        {
            if(zoeker == 0)
            {
                txtZoekWaarde.Visible = false;
                btnZoeken.Visible = false;
            }
            else
            {
                txtZoekWaarde.Visible = true;
                btnZoeken.Visible = true;
            }
        }

        private void rdbAuteur_CheckedChanged(object sender, EventArgs e)
        {
            keuze = 2;
            zoek_waarde(keuze);
        }

        private void rdbTitel_CheckedChanged(object sender, EventArgs e)
        {
            keuze = 1;
            zoek_waarde(keuze);
        }

        private void rdbLeeg_CheckedChanged(object sender, EventArgs e)
        {
            keuze = 0;
            zoek_waarde(keuze);
        }

        private void rdbISBN_CheckedChanged(object sender, EventArgs e)
        {
            keuze = 4;
            zoek_waarde(keuze);
        }

        private void rdbgenre_CheckedChanged(object sender, EventArgs e)
        {
            keuze = 5;
            zoek_waarde(keuze);
        }

        private void btnZoeken_Click(object sender, EventArgs e)
        {
            string zoekw = txtZoekWaarde.Text;
            if (string.IsNullOrEmpty(zoekw.Trim()))
            {
                MessageBox.Show("Er moet een waarde worden ingegeven");
            }
            else
            {
                zoeken(zoekw);
            }
        }
        private void zoeken(string zoekw)
        {
            String verbindingsstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Bib.accdb";

            OleDbConnection verbinding = new OleDbConnection(verbindingsstring);
            
            verbinding.Open();
            String code = "";
            switch (keuze)
            {
                case 1:
                     code = "SELECT Boekid from tblBoeken where Titel Like ?";
                    break;
                case 2:
                     code = "SELECT Boekid from tblBoeken where Auteur Like ?";
                    break;
                case 4:
                     code = "SELECT Boekid from tblBoeken where ISBN Like ?";

                    break;
                case 5:
                     code = "SELECT b.Boekid from tblBoeken b,tblCategorien c,tblCategoriePerBoek cpb where cpb.BoekId = b.Boekid AND c.CategorieId = cpb.CategorieId And c.categorie Like ?";
                    break;
            }
           

            OleDbCommand opdracht = new OleDbCommand(code, verbinding);

            opdracht.Parameters.AddWithValue("","%"+ zoekw +"%");
          
           OleDbDataReader dataLezer = opdracht.ExecuteReader(CommandBehavior.CloseConnection);

            int i = 0;

            while (dataLezer.Read())
            {
                gezochteIDs[i] = Convert.ToInt32(dataLezer.GetValue(0));
                i++;
            }
            verbinding.Close();
            MessageBox.Show(Convert.ToString(gezochteIDs[0]));
            if(gezochteIDs[0] == 0)
            {
                MessageBox.Show("Er zijn geen correcte resultaten");
            }
            else
            {
                frmResultaat_zoeken_Boeken rzb = new frmResultaat_zoeken_Boeken();
                rzb.Show();
                this.Hide();
            }
            
        }
    }
}
