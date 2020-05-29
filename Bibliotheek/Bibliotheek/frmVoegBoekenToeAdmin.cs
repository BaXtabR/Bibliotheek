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
    public partial class frmVoegBoekenToeAdmin : Form
    {
        public frmVoegBoekenToeAdmin()
        {
            InitializeComponent();
        }

        private void VoegBoekenToeAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnVerzenden_Click(object sender, EventArgs e)
        {
            bool toevoegen = true;
            if (string.IsNullOrEmpty(txttitel.Text))
            {
                toevoegen = false;
            }
            if (string.IsNullOrEmpty(txtisbn.Text))
            {
                toevoegen = false;
            }
            
            if (string.IsNullOrEmpty(txtauteur.Text))
            {
                toevoegen = false;
            }
            if(string.IsNullOrEmpty(txtafbeelding.Text))
            {
                toevoegen = false;
            }
            if (string.IsNullOrEmpty(txtomschrijving.Text))
            {
                toevoegen = false;
            }

            if (toevoegen)
            {
                nieuw_boek();
            }
        }
        private void nieuw_boek()
        {
            string titel = txttitel.Text;
            string auteur = txtauteur.Text;
            string afbeelding = txtafbeelding.Text;
            string omschrijving = txtomschrijving.Text;
            string ISBN = txtisbn.Text;


            String verbindingsstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Bib.accdb";

            OleDbConnection verbinding = new OleDbConnection(verbindingsstring);

            try
            {
                verbinding.Open();

                String code = "INSERT INTO tblBoeken ( ISBN, Titel, auteur, omschrijving, afbeelding ) VALUES(?,?,?,?,?)";
                OleDbCommand opdracht = new OleDbCommand(code, verbinding);
                opdracht.Parameters.AddWithValue("", ISBN);
                opdracht.Parameters.AddWithValue("", titel);
                opdracht.Parameters.AddWithValue("", auteur);
                opdracht.Parameters.AddWithValue("", omschrijving);
                opdracht.Parameters.AddWithValue("", afbeelding);


                opdracht.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show("hey " + ex);
            }
            finally
            {
                MessageBox.Show("Het boek is opgnomen");
                verbinding.Close();
                frmhome comms = new frmhome();
                comms.Show();
                this.Hide();
            }
        }
    }
}
