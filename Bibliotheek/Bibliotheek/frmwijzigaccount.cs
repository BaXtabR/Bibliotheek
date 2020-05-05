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

namespace Bibliotheek
{
    public partial class frmwijzigaccount : Form
    {
        public frmwijzigaccount()
        {
            InitializeComponent();
        }

        private void frmwijzigaccount_Load(object sender, EventArgs e)
        {

        }

        private void lblvnaam_Click(object sender, EventArgs e)
        {
            lblvnaam.Text = Interaction.InputBox("Geef nieuwe waarde");

        }
    }
}
