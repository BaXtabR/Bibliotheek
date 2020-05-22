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
    public partial class frmmeer_info : Form
    {
        public frmmeer_info()
        {
            InitializeComponent();
        }

        private void frmmeer_info_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmboeken boek = new frmboeken();
            boek.Show();
            this.Hide();
        }

        private void btnterug_Click(object sender, EventArgs e)
        {
            frmboeken boek = new frmboeken();
            boek.Show();
            this.Hide();
        }

        private void frmmeer_info_Load(object sender, EventArgs e)
        {
            int y = frmboeken.boek_info;
            lblauteurtext.Text = frmboeken.auteurs[y];
            lblisbntext.Text = frmboeken.ISBNs[y];
            txtomschrijving.Text = frmboeken.Beschrijvingen[y];
        }
    }
}
