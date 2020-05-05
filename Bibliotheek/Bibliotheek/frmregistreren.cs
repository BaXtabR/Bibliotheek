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
    public partial class frmregistreren : Form
    {
        public frmregistreren()
        {
            InitializeComponent();
        }

        private void frmregistreren_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBevestig_Click(object sender, EventArgs e)
        {
            //variabele die controleerd of er een fout is of niet
            bool controle = true;

            string vnaam, anaam, pwoord, email, username, bpwoord;
            vnaam = txtvnaam.Text;
            anaam = txtachternaam.Text;
            pwoord = txtpaswoord.Text;
            //paswoordpatroon = "^.*(?=.{,})(?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&+=]).*$";
            email = txtemail.Text;
            username = txtgebruikersnaam.Text;
            bpwoord = txtbevestigpaswoord.Text;

            if (string.IsNullOrEmpty(vnaam.Trim()))
            {
                controle = false;
            }
            if (string.IsNullOrEmpty(anaam.Trim()))
            {
                controle = false;
            }
            if (string.IsNullOrEmpty(pwoord.Trim()))
            {
                controle = false;
            }
            if(pwoord != bpwoord)
            {
                controle = false;
            }
            if (string.IsNullOrEmpty(email.Trim()))
            {
                controle = false;
            }
            if (string.IsNullOrEmpty(username.Trim()))
            {
                controle = false;
            }

            if (controle)
            {
                frmhome home = new frmhome();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("fout");
            }
        }
    }
}
