﻿using System;
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
        public static int Key;
        int lengte;
        private int[] BoekIds = new int[50];
        private static String tijdlenen;
        private static double boeteBedrag;
        int gebruikernummer = frminloggen.id;
        public frmMijnBoeken()
        {
            InitializeComponent();
        }

        private void frmMijnBoeken_Load(object sender, EventArgs e)
        {

            String verbindingsstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Bib.accdb";

            OleDbConnection verbinding = new OleDbConnection(verbindingsstring);

            verbinding.Open();

            String code = "SELECT BoekId from tblLenen where GebruikerId like ? and InBezit=?";

            OleDbCommand opdracht = new OleDbCommand(code, verbinding);

            opdracht.Parameters.AddWithValue("", frminloggen.id);
            opdracht.Parameters.AddWithValue("", true);

            OleDbDataReader dataLezer = opdracht.ExecuteReader(CommandBehavior.CloseConnection);

            int i = 0;

            while (dataLezer.Read())
            {
                BoekIds[i] = Convert.ToInt32(dataLezer.GetValue(0));
                i++;
            }
            verbinding.Close();
            lengte = BoekIds.Length;
            for(int y=0;y<lengte;y++)
            {
              Mijn_Boeken_Load(BoekIds[y]);
            }
           
            
        }
        private void Mijn_Boeken_Load(int id)
        {

             String verbindingsstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Bib.accdb";

              OleDbConnection verbinding = new OleDbConnection(verbindingsstring);

              verbinding.Open();

            String code = "SELECT Titel from tblBoeken b,tblLenen l where b.Boekid=? and l.InBezit=? and l.BoekId=b.Boekid and Gebruikerid=?";
            OleDbCommand opdracht = new OleDbCommand(code, verbinding);
            opdracht.Parameters.AddWithValue("", id);
            opdracht.Parameters.AddWithValue("", true);
            opdracht.Parameters.AddWithValue("", gebruikernummer);
            OleDbDataReader dataLezer = opdracht.ExecuteReader(CommandBehavior.CloseConnection);
   
            while (dataLezer.Read())
            {

               lsbboekbezit.Items.Add(dataLezer.GetValue(0));
              
            }
            verbinding.Close();

        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            frmhome home = new frmhome();
            home.Show();
            this.Hide();
        }

        private void btnTerugbrengen_Click(object sender, EventArgs e)
        {
            String titel = Convert.ToString(lsbboekbezit.SelectedItem);

            String verbindingsstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Bib.accdb";

            OleDbConnection verbinding = new OleDbConnection(verbindingsstring);

            try
            {
                verbinding.Open();
                String opdrString = "update tblBoeken set Status =? where Titel = ?";
                OleDbCommand opdracht = new OleDbCommand(opdrString, verbinding);
                opdracht.Parameters.AddWithValue("", true);
                opdracht.Parameters.AddWithValue("", titel);

                opdracht.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("boek status fout " + ex);
            }
            finally
            {
                verbinding.Close();
                int id= zoek_boekid(titel);
                bezitstatus(id);
                boeteBerekenen();
            }
            frmhome home = new frmhome();
            home.Show();
            this.Hide();

        }
        private void boeteBerekenen()
        {
            String titel = Convert.ToString(lsbboekbezit.SelectedItem);
            int id = zoek_boekid(titel);
            String verbindingsstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Bib.accdb";

            OleDbConnection verbinding = new OleDbConnection(verbindingsstring);

            verbinding.Open();

            String code = "SELECT * from tblLenen where BoekId = ?";
            OleDbCommand opdracht = new OleDbCommand(code, verbinding);
            opdracht.Parameters.AddWithValue("", id);
            OleDbDataReader dataLezer = opdracht.ExecuteReader(CommandBehavior.CloseConnection);

            DateTime datumVandaag = DateTime.Now;

            while (dataLezer.Read())
            {
                tijdlenen = Convert.ToString(dataLezer.GetValue(3));
            }
                boeteToevoegen();
        


            verbinding.Close();
        }

        private void boeteToevoegen()
        {

            String datumVandaag = DateTime.Now.ToString("dd/MM/yyyy");
            TimeSpan verschil = Convert.ToDateTime(datumVandaag) - (Convert.ToDateTime(tijdlenen));
            double aantDagen = (Convert.ToDouble(verschil.TotalDays));

            if (aantDagen > 21)
            {

                boeteBedrag = Math.Round((aantDagen * 0.10), 2);
                MessageBox.Show("U heeft het boek te laat ingeleverd, u moet een boete van " + boeteBedrag + " euro betalen!");

                String verbindingsstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Bib.accdb";

                OleDbConnection verbinding = new OleDbConnection(verbindingsstring);

                try
                {
                    verbinding.Open();

                    String code = "INSERT INTO tblBoetes (GebruikerId,Datum,Bedrag) VALUES (?,?,?)";
                    OleDbCommand opdracht = new OleDbCommand(code, verbinding);
                    opdracht.Parameters.AddWithValue("", gebruikernummer);
                    opdracht.Parameters.AddWithValue("", datumVandaag);
                    opdracht.Parameters.AddWithValue("", boeteBedrag);
                    OleDbDataReader dataLezer = opdracht.ExecuteReader(CommandBehavior.CloseConnection);


                    opdracht.ExecuteNonQuery();
                }

                catch (Exception ex)
                {
                }
                finally
                {
                    verbinding.Close();
                }
            }
        }

        private void bezitstatus(int id)
        {
            String verbindingsstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Bib.accdb";

            OleDbConnection verbinding = new OleDbConnection(verbindingsstring);

            try
            {
                verbinding.Open();
                String opdrString = "update tblLenen set InBezit =? where BoekId = ?";
                OleDbCommand opdracht = new OleDbCommand(opdrString, verbinding);
                opdracht.Parameters.AddWithValue("", false);
                opdracht.Parameters.AddWithValue("", id);

                opdracht.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("boek status fout " + ex);
            }
            finally
            {
                verbinding.Close();
            }
        }

        private int zoek_boekid(String titel)
        {
            int BoekId=0;

            String verbindingsstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Bib.accdb";

            OleDbConnection verbinding = new OleDbConnection(verbindingsstring);

            verbinding.Open();

            String code = "SELECT Boekid from tblBoeken where Titel Like ?";
            OleDbCommand opdracht = new OleDbCommand(code, verbinding);
            opdracht.Parameters.AddWithValue("", titel);
            OleDbDataReader dataLezer = opdracht.ExecuteReader(CommandBehavior.CloseConnection);

            while (dataLezer.Read())
            {
                BoekId=Convert.ToInt32(dataLezer.GetValue(0));
                
            }
            verbinding.Close();
            return BoekId;  
        }
    }
}
