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
    public partial class frmMijnBoeken : Form
    {
        private int[] BoekIds = new int[99999];
        public frmMijnBoeken()
        {
            InitializeComponent();
        }

        private void frmMijnBoeken_Load(object sender, EventArgs e)
        {
            int[] BoekIDs = new int[999999];

            String verbindingsstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Bib.accdb";

            OleDbConnection verbinding = new OleDbConnection(verbindingsstring);

            verbinding.Open();

            String code = "SELECT BoekId from tblLenen where GebruikerId like ?";

            OleDbCommand opdracht = new OleDbCommand(code, verbinding);

            opdracht.Parameters.AddWithValue("", frminloggen.id);

            OleDbDataReader dataLezer = opdracht.ExecuteReader(CommandBehavior.CloseConnection);

            int i = 0;

            while (dataLezer.Read())
            {
                BoekIDs[i] = Convert.ToInt32(dataLezer.GetValue(0));
                i++;
            }
            verbinding.Close();
            Mijn_Boeken_Load();
        }
        private void Mijn_Boeken_Load()
        {
            int lengte = BoekIds.Length;
            for(int i = 0; i <= lengte; i++)
            {
                String verbindingsstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Bib.accdb";

                OleDbConnection verbinding = new OleDbConnection(verbindingsstring);

                verbinding.Open();

                String code = "SELECT Titel from tblLenen where Boekid like ?";

                OleDbCommand opdracht = new OleDbCommand(code, verbinding);
                opdracht.Parameters.AddWithValue("", BoekIds[i]);
                OleDbDataReader dataLezer = opdracht.ExecuteReader(CommandBehavior.CloseConnection);
                while (dataLezer.Read())
                {
                    lsbboekbezit.Items.Add(dataLezer.GetValue(0));
                }
                verbinding.Close();
            }
            


        }
    }
}
