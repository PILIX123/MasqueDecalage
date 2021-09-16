using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasqueDecalage
{
    public partial class frmMaskDecalage : Form
    {
        uint[] tDateHeure = { 3247998492, 3279396729, 2926558652, 2130065906, 2395699451,
                              3814201359, 1984496033, 2585988554, 2064086791, 3207116534};
        int indiceHeure;
        int indiceDate;
        public frmMaskDecalage()
        {
            InitializeComponent();
            indiceHeure = 0;
            indiceDate = 0;
        }

        private void btnDate_Click(object sender, EventArgs e)
        {

        }

        private void btnHeurre_Click(object sender, EventArgs e)
        {

        }

        private void btnSortie_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
