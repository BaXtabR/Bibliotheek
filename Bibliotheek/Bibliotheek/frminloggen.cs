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
    public partial class frminloggen : Form
    {
        public frminloggen()
        {
            InitializeComponent();
        }

        private void btnregistreren_Click(object sender, EventArgs e)
        {
            frmregistreren registratie = new frmregistreren();
            registratie.Show();
            this.Hide();
        }

        private void btninloggen_Click(object sender, EventArgs e)
        {
            frmhome home = new frmhome();
            home.Show();
            this.Hide();
        }
    }
}
