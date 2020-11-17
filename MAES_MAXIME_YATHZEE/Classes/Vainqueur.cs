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
    class Vainqueur
    {
        #region Initialisation des variables
        #endregion

        #region Constructeur Vainqueur
        public Vainqueur()
        {

        }
        #endregion

        #region Méthodes
        public void DetermineVainqueur(Label lblTotalFinalJ1,int totFinalJ1,Label lblTotalFinalJ2,int totFinalJ2,Label lblNomJoueur1,Label lblNomJoueur2,Panel pJ1,Panel pJ2, Button btnRecommencer)
        {
            if(lblTotalFinalJ1.Text != "" && lblTotalFinalJ2.Text != "")
            {
                if(totFinalJ1 > totFinalJ2)
                {
                    MessageBox.Show("Victoire de: " + lblNomJoueur1.Text + " avec " + totFinalJ1 + " points.\n" +
                        "Contre: " + lblNomJoueur2.Text + " avec " + totFinalJ2 + " points.");
                }
                else if(totFinalJ1 < totFinalJ2)
                {
                    MessageBox.Show("Victoire de: " + lblNomJoueur2.Text + " avec " + totFinalJ2 + " points.\n" +
                        "Contre: " + lblNomJoueur1.Text + " avec " + totFinalJ1 + " points.");
                }
                else if(totFinalJ1 == totFinalJ2)
                {
                    MessageBox.Show("Egalite entre: " + lblNomJoueur1.Text + " avec " + totFinalJ1 + " points.\n" +
                       "Contre: " + lblNomJoueur2.Text + " avec " + totFinalJ2 + " points.");
                }
                pJ1.Enabled = pJ2.Enabled = false;
                btnRecommencer.Enabled = true;
            }
            
        }
        #endregion
    }
}
