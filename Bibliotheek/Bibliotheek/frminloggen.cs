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
    public partial class frminloggen : Form
    {
        public static string gebruiker;
        public static bool admin;
        public frminloggen()
        {
            InitializeComponent();
        }

        private void btnregistreren_Click(object sender, EventArgs e)
        {
            frmregistreren registratie = new frmregistreren();
            registratie.Show();
            this.Hide();
            //dit is goed
        }

        private void btninloggen_Click(object sender, EventArgs e)
        {
            string username, paswoord;
            int aantal = 0;

            username = txtgebruikersnaam.Text;
            paswoord = txtpaswoord.Text;
            

            String verbindingsstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Bib.accdb";

            OleDbConnection verbinding = new OleDbConnection(verbindingsstring);

            verbinding.Open();

            String code = "SELECT * from tblGebruiker where Gebruikersnaam like ? AND Wachtwoord like ?";

            OleDbCommand opdracht = new OleDbCommand(code, verbinding);

            opdracht.Parameters.AddWithValue("", username);
            opdracht.Parameters.AddWithValue("", paswoord);

            OleDbDataReader dataLezer = opdracht.ExecuteReader(CommandBehavior.CloseConnection);

            

            while (dataLezer.Read())
            {
                aantal++;
                gebruiker = Convert.ToString(dataLezer.GetValue(4));
                admin = Convert.ToBoolean(dataLezer.GetBoolean(6));
            }



            if(aantal == 1)
            {
                frmhome home = new frmhome();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("De gebruiker of wachtwoord zijn fout");
            }
            
        }
    }
}
