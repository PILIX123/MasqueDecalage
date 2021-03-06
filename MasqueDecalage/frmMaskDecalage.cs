/*Pierre-Luc Robitaille et Victor Saulnier
 * Masque et décallage
 * 16/09/2021*/
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
            uint maskAn = 0xFE000000;
            uint maskMois = 0x01E00000;
            uint maskJour = 0x001F0000;
            string[] tMois = { "Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre" };
            uint Jour, Mois, An;
            string jour;
            uint value = tDateHeure[indiceDate];
            An = (uint)((value & maskAn) / Math.Pow(2, 25) + 1900);
            Mois = (uint)((value & maskMois) / Math.Pow(2, 21));
            Jour = (uint)((value & maskJour) / Math.Pow(2, 16));
            if (Jour < 10)
                jour = "0" + Jour.ToString();
            else
                jour = Jour.ToString();

            txtDate.Text = jour + "/" + tMois[Mois - 1] + "/" + An.ToString();

            indiceDate++;
            if (indiceDate > 9)
                indiceDate = 0;
        }
        private void btnHeurre_Click(object sender, EventArgs e)
        {
            uint value = tDateHeure[indiceHeure];
            uint Heures, Minutes, Secondes;
            string heure,minute,seconde;
            Heures = (uint)(((((value << 16) >> 16) >> 11) << 11) / Math.Pow(2, 11));
            Minutes = (uint)(((((value << 21) >> 21) >> 5) << 5) / Math.Pow(2, 5));
            Secondes = (uint)((((value << 27) >> 27) / Math.Pow(2, 0)) * 2);
            if (Heures == 0)
                heure = "00";
            else if (Heures < 10)
                heure = "0" + Heures.ToString();
            else
                heure = Heures.ToString();
            if (Minutes == 0)
                minute = "00";
            else if (Minutes < 10)
                minute = "0" + Minutes.ToString();
            else
                minute = Minutes.ToString();
            if (Secondes == 0)
                seconde = "00";
            else if (Secondes < 10)
                seconde = "0" + Secondes.ToString();
            else
                seconde = Secondes.ToString();
            textHeure.Text = heure + ":" + minute + ":" + seconde;
            indiceHeure++;
            if (indiceHeure > 9)
                indiceHeure = 0;
        }

        private void btnSortie_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
