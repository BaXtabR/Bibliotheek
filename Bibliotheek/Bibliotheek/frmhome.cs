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
    public partial class frmhome : Form
    {
        public frmhome()
        {
            InitializeComponent();
        }

        private void lblsettings_Click(object sender, EventArgs e)
        {

        }

        private void frmhome_Load(object sender, EventArgs e)
        {
            lblgebebruiker.Text = frminloggen.gebruiker;
            if (!frminloggen.admin)
            {
                btnoverzichboetes.Hide();
                btnoverzichtaccounts.Hide();
                btnoverzichtboeken.Hide();
            }
        }

        private void frmhome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnaccount_Click(object sender, EventArgs e)
        {
            frmwijzigaccount account = new frmwijzigaccount();
            account.Show();
            this.Hide();
        }

        private void btnboetes_Click(object sender, EventArgs e)
        {
            frmboetes boetes = new frmboetes();
            boetes.Show();
            this.Hide();
        }

        private void btnMijnboeken_Click(object sender, EventArgs e)
        {
            frmMijnBoeken Mboeken = new frmMijnBoeken();
            Mboeken.Show();
            this.Hide();
        }

        private void btnbib_Click(object sender, EventArgs e)
        {
            frmboeken boeken = new frmboeken();
            boeken.Show();
            this.Hide();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

        }

        private void btnoverzichtboeken_Click(object sender, EventArgs e)
        {
            frmoverzichtboeken oboeken = new frmoverzichtboeken();
            oboeken.Show();
            this.Hide();
        }

        private void btnoverzichtaccounts_Click(object sender, EventArgs e)
        {
            frmoverzichtgebruikers oaccounts = new frmoverzichtgebruikers();
            oaccounts.Show();
            this.Hide();
        }

        private void btnoverzichboetes_Click(object sender, EventArgs e)
        {
            frmoverzichtboetes oboetes = new frmoverzichtboetes();
            oboetes.Show();
            this.Hide();
        }
    }
}
