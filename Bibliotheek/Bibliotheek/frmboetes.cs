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
    public partial class frmboetes : Form
    {
        public frmboetes()
        {
            InitializeComponent();
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            frmhome home = new frmhome();
            home.Show();
            this.Hide();
        }

        private void frmboetes_Load(object sender, EventArgs e)
        {
            String verbindingsstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Bib.accdb";

            OleDbConnection verbinding = new OleDbConnection(verbindingsstring);

            verbinding.Open();

            String code = "SELECT Datum,Bedrag from tblBoetes where GebruikerId like ?";

            OleDbCommand opdracht = new OleDbCommand(code, verbinding);

            opdracht.Parameters.AddWithValue("", frminloggen.id);

            OleDbDataReader dataLezer = opdracht.ExecuteReader(CommandBehavior.CloseConnection);

            while (dataLezer.Read())
            {
                lsbboetes.Items.Add("Datum: " + dataLezer.GetValue(0) + " Bedrag: " + dataLezer.GetValue(1)+" euro.");
            }
            verbinding.Close();
        }
    }
}
