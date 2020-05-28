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
    public partial class frmRandomBoek : Form
    {
        public static string auteur, ISBN, Beschrijvingen,titel;
        private bool status;
        public frmRandomBoek()
        {
            InitializeComponent();
        }

        private void btnterug_Click(object sender, EventArgs e)
        {
            frmboeken boeken = new frmboeken();
            boeken.Show();
            this.Hide();

        }

        private void btnmeerinfo2_Click(object sender, EventArgs e)
        {
            frmboeken.Key = 3;
            frmmeer_info info = new frmmeer_info();
            info.Show();
            this.Hide();
        }

        private void frmRandomBoek_Load(object sender, EventArgs e)
        {
            int tell = random_boek();
            String verbindingsstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Bib.accdb";

            OleDbConnection verbinding = new OleDbConnection(verbindingsstring);

            verbinding.Open();

            String code = "SELECT * from tblBoeken Where BoekId = ?";

            OleDbCommand opdracht = new OleDbCommand(code, verbinding);

            opdracht.Parameters.AddWithValue("", tell);

            OleDbDataReader dataLezer = opdracht.ExecuteReader(CommandBehavior.CloseConnection);

            while (dataLezer.Read())
            {
                pcbboek2.ImageLocation = Convert.ToString(dataLezer.GetValue(5));
                auteur = Convert.ToString(dataLezer.GetValue(3));
                ISBN = Convert.ToString(dataLezer.GetValue(1));
                Beschrijvingen = Convert.ToString(dataLezer.GetValue(4));
                titel = Convert.ToString(dataLezer.GetValue(2));
               status =  Convert.ToBoolean(dataLezer.GetValue(6));
            }

        }
        private int random_boek()
        {
            int rndmboek = 0, max = 0;

            String verbindingsstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Bib.accdb";

            OleDbConnection verbinding = new OleDbConnection(verbindingsstring);

            verbinding.Open();

            String code = "SELECT count(*) from tblBoeken";

            OleDbCommand opdracht = new OleDbCommand(code, verbinding);

            OleDbDataReader dataLezer = opdracht.ExecuteReader(CommandBehavior.CloseConnection);



            while (dataLezer.Read())
            {
                max = Convert.ToInt32(dataLezer.GetValue(0));
            }

            Random rand = new Random();
            rndmboek = rand.Next(1, max + 1);

            return rndmboek;
        }
    }
}
