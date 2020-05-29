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
    public partial class frmCommentMaken : Form
    {
        public frmCommentMaken()
        {
            InitializeComponent();
        }

        private void btntrug_Click(object sender, EventArgs e)
        {
            frmcommentaar comms = new frmcommentaar();
            comms.Show();
            this.Hide();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtmessage.Text.Trim()))
            {
                MessageBox.Show("Je moet een een reden schrijven waarom je het boek niet goed vond voordat je je commentaar kan versturen");
            }
            else
            {
               doorsturen();
            }
        }
        private void doorsturen()
        {
            string commentaar = txtmessage.Text;
            bool like = false;
            if (rdbgoed.Checked)
            {
                like = true;
            }
            int id = frmcommentaar.boekid;
            string user = frminloggen.gebruiker;
            int userid = user_identification(user);

            String verbindingsstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Bib.accdb";

            OleDbConnection verbinding = new OleDbConnection(verbindingsstring);

            try
            {
                verbinding.Open();

                String code = "INSERT INTO tblCommentaar ( Boekid, Gebruikerid, commentaar, [Like] ) VALUES(?,?,?,?)";
                OleDbCommand opdracht = new OleDbCommand(code, verbinding);
                opdracht.Parameters.AddWithValue("", id);
                opdracht.Parameters.AddWithValue("", userid);
                opdracht.Parameters.AddWithValue("", commentaar);
                opdracht.Parameters.AddWithValue("", like);

                opdracht.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show("hey "+ex);
            }
            finally
            {
                MessageBox.Show("U comment is opgeslaan");
                verbinding.Close();
                frmcommentaar comms = new frmcommentaar();
                comms.Show();
                this.Hide();
            }

        }
        private int user_identification(string gebruikernaam)
        {
            int id = 0;
            String verbindingsstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Bib.accdb";

            OleDbConnection verbinding = new OleDbConnection(verbindingsstring);

            verbinding.Open();

            String code = "SELECT GebruikerId from tblGebruiker Where gebruikersnaam = ?";

            OleDbCommand opdracht = new OleDbCommand(code, verbinding);

            opdracht.Parameters.AddWithValue("", gebruikernaam);

            OleDbDataReader dataLezer = opdracht.ExecuteReader(CommandBehavior.CloseConnection);
            while (dataLezer.Read())
            {
               id = Convert.ToInt32(dataLezer.GetValue(0));
            }
            verbinding.Close();


            return id;
        }

        private void frmCommentMaken_Load(object sender, EventArgs e)
        {
            rdbgoed.Checked = true;
        }
    }
}
