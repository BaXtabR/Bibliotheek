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
    public partial class frmoverzichtboetes : Form
    {
        public frmoverzichtboetes()
        {
            InitializeComponent();
        }

        private void frmoverzichtboetes_Load(object sender, EventArgs e)
        {
            //verbinding met de databank openen
            String verbindingsstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Bib.accdb";

            OleDbConnection verbinding = new OleDbConnection(verbindingsstring);

            try
            {
                verbinding.Open();

                String sql = "SELECT * from tblBoeken";

                OleDbDataAdapter oledbAdapter = new OleDbDataAdapter(sql, verbinding);

                DataSet mijnDataSat = new DataSet();
                oledbAdapter.Fill(mijnDataSat);

                mijnDataSat.DataSetName = "omschrijving fouten";

                dgvOverzichtBoetes.DataSource = mijnDataSat.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemen bij vullen van tabel.");
            }
            finally
            {
                verbinding.Close();
            }
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            frmhome home = new frmhome();
            home.Show();
            this.Hide();
        }
    }
}
