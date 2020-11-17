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
    public partial class EcranPrincipal : Form
    {
        #region Initialisation des variables
        #endregion

        #region Constructeur EcranPincipal()
        public EcranPrincipal()
        {
            InitializeComponent();
        }
        #endregion

        #region Méthodes
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnJouer_Click(object sender, EventArgs e)
        {
            EcranInitialisationJeu f = new EcranInitialisationJeu();
            f.ShowDialog();
        }
        #endregion
    }
}
