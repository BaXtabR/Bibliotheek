using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Data.OleDb;

namespace Bibliotheek
{
    public partial class frmwijzigaccount : Form
    {
        //globale strings die gebruikt worden bij het weizigen van het document.
        private static string vnaam, anaam, gnaam, email;
        public frmwijzigaccount()
        {
            InitializeComponent();
        }

        private void frmwijzigaccount_Load(object sender, EventArgs e)
        {
            laad_data();
        }

        private void lblanaam_Click(object sender, EventArgs e)
        {
            //variabele die de nieuwe achternaam bevat
            string nieuw = "", opdrString;
            while (!nieuw.Equals(""))
            {
                nieuw = Interaction.InputBox("Geef de nieuwe Achternaam");
            }

            String verbindingsstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Bib.accdb";

            OleDbConnection verbinding = new OleDbConnection(verbindingsstring);

            verbinding.Open();

            try
            {
                opdrString = "update tblGebruiker set Achternaam= ? where Achternaam = ?";


                OleDbCommand opdracht = new OleDbCommand(opdrString, verbinding);
                opdracht.Parameters.AddWithValue("", nieuw);
                opdracht.Parameters.AddWithValue("", anaam);

                opdracht.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemen bij Weizigen van de voornaam." + ex);
            }
            finally
            {
                verbinding.Close();
                laad_data();
            }
        }

        private void lblgnaam_Click(object sender, EventArgs e)
        {
            //variabele die de nieuwe gebruikersnaam bevat
            string nieuw = "", opdrString;
            while (!nieuw.Equals(""))
            {
                nieuw = Interaction.InputBox("Geef de nieuwe gebruikernaam");
            }

            //verbinding met de databank openen
            String verbindingsstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Bib.accdb";

            OleDbConnection verbinding = new OleDbConnection(verbindingsstring);

            verbinding.Open();

            //Updaten van de data omtrent de gebruikersnaam
            try
            {
                opdrString = "update tblGebruiker set Gebruikersnaam= ? where Gebruikersnaam = ?";


                OleDbCommand opdracht = new OleDbCommand(opdrString, verbinding);
                opdracht.Parameters.AddWithValue("", nieuw);
                opdracht.Parameters.AddWithValue("", gnaam);

                opdracht.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemen bij Weizigen van de voornaam." + ex);
            }
            finally
            {
                // het sluiten van de verbinding en het updaten van de gebruiker en dan de gegevens opnieuw laden.
                verbinding.Close();
                frminloggen.gebruiker = nieuw;
                laad_data();
            }

        }

        private void lblemail_Click(object sender, EventArgs e)
        {
            // variabele die de niewe email adress bevat
            string nieuw = "", opdrString;
            while (!nieuw.Equals(""))
            {
                nieuw = Interaction.InputBox("Geef de nieuwe Email addresss");
            }

            //verbinding opendoen met databank
            String verbindingsstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Bib.accdb";

            OleDbConnection verbinding = new OleDbConnection(verbindingsstring);

            verbinding.Open();
            //Het updaten van de databank en de nieuwe email voor de oude weizigen
            try
            {
                opdrString = "update tblGebruiker set Email = ? where Email = ?";


                OleDbCommand opdracht = new OleDbCommand(opdrString, verbinding);
                opdracht.Parameters.AddWithValue("", nieuw);
                opdracht.Parameters.AddWithValue("", email);

                opdracht.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemen bij Weizigen van de voornaam." + ex);
            }
            finally
            {
                //de verbinding sluiten en de gegevens opnieuw laden
                verbinding.Close();
                laad_data();
            }
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            frmhome home = new frmhome();
            home.Show();
            this.Hide();
        }

        private void lblvnaam_Click(object sender, EventArgs e)
        {
            //variabele die de nieuwe voornaam bevat
            string nieuw = "", opdrString;
            while (!nieuw.Equals("") )
            {
                nieuw = Interaction.InputBox("Geef de nieuwe Voornaam");
            }
            
            //verbinding met databank 
            String verbindingsstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Bib.accdb";

            OleDbConnection verbinding = new OleDbConnection(verbindingsstring);

            verbinding.Open();

            //wijzigen van de voornaam in de databank
            try
            {
                opdrString = "update tblGebruiker set Voornaam= ? where Voornaam = ?";


                OleDbCommand opdracht = new OleDbCommand(opdrString, verbinding);
                opdracht.Parameters.AddWithValue("", nieuw);
                opdracht.Parameters.AddWithValue("", vnaam);

                opdracht.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemen bij Weizigen van de voornaam." + ex);
            }
            finally
            {
                //sluiten databank en verversen data
                verbinding.Close();
                laad_data();
            }

        }
        private void laad_data()
        {
            //Het laden van de labels met de gepaste informatie van de gebruiker die via de gebruikersnaam worden doorgegeven

            String verbindingsstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Bib.accdb";

            OleDbConnection verbinding = new OleDbConnection(verbindingsstring);

            verbinding.Open();

            String code = "SELECT * from tblGebruiker where Gebruikersnaam like ?";

            OleDbCommand opdracht = new OleDbCommand(code, verbinding);

            opdracht.Parameters.AddWithValue("", frminloggen.gebruiker);

            OleDbDataReader dataLezer = opdracht.ExecuteReader(CommandBehavior.CloseConnection);

            while (dataLezer.Read())
            {
                // het laden van gegevens in een String die in het hele document toegangkelijk zijn en deze dan in de labels doen
                vnaam = Convert.ToString(dataLezer.GetValue(1));
                lblvnaam.Text = vnaam;
                anaam = Convert.ToString(dataLezer.GetValue(2));
                lblanaam.Text = anaam;
                gnaam = Convert.ToString(dataLezer.GetValue(4));
                lblgnaam.Text = gnaam;
                email = Convert.ToString(dataLezer.GetValue(3));
                lblemail.Text = email;
            }

            verbinding.Close();
        }

        private void frmwijzigaccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            //sluiten van de applicatie
            Application.Exit();
        }
    }
}
