using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAES_MAXIME_YATHZEE
{
    public partial class EcranZeroPoint : Form
    {
        #region Initialisation des variables
        public int choix;
        DesactiveActiveLbl d = new DesactiveActiveLbl();
        EcranJeu f = new EcranJeu();
        #endregion

        #region Constructeur
        public EcranZeroPoint()
        {
            InitializeComponent();
        }
        #endregion

        #region Méthodes
        private void btnOuiZero_Click(object sender, EventArgs e)
        {
            choix = 1;
            this.Close();
        }

        private void btnNonZero_Click(object sender, EventArgs e)
        {
            choix = 0;
            this.Close();
        }
        #endregion
    }
}
