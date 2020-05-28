using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliotheek
{
    public partial class frmmeer_info : Form
    {
        public frmmeer_info()
        {
            InitializeComponent();
        }

        private void frmmeer_info_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(frmboeken.Key == 1)
            {
                frmboeken boek = new frmboeken();
                boek.Show();
                this.Hide();
            }
            else if(frmboeken.Key == 2)
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

        private void btnterug_Click(object sender, EventArgs e)
        {
            if (frmboeken.Key == 1)
            {
                frmboeken boek = new frmboeken();
                boek.Show();
                this.Hide();
            }
            else if(frmboeken.Key == 2)
            {
                frmResultaat_zoeken_Boeken boek = new frmResultaat_zoeken_Boeken();
                boek.Show();
                this.Hide();
            }
            else
            {

            }
        }

        private void frmmeer_info_Load(object sender, EventArgs e)
        {
            if (frmboeken.Key == 1)
            {
                int y = frmboeken.boek_info;
                lblauteurtext.Text = frmboeken.auteurs[y];
                lblisbntext.Text = frmboeken.ISBNs[y];
                txtomschrijving.Text = frmboeken.Beschrijvingen[y];
            }
            else if(frmboeken.Key == 2)
            {
                int y = frmResultaat_zoeken_Boeken.meer_boek_info;
                lblauteurtext.Text = frmResultaat_zoeken_Boeken.auteurs[y];
                lblisbntext.Text = frmResultaat_zoeken_Boeken.ISBNs[y];
                txtomschrijving.Text = frmResultaat_zoeken_Boeken.Beschrijvingen[y];
            }
            else
            {
                
                lblauteurtext.Text = frmRandomBoek.auteur;
                lblisbntext.Text = frmRandomBoek.ISBN;
                txtomschrijving.Text = frmRandomBoek.Beschrijvingen;
            }
           
        }
    }
}
