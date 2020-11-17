using System;
using System.Collections;
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
    class DesactiveActiveLbl
    {
        #region Initialisation des variables
        #endregion

        #region Constructeur DesactiveActiveLbl
        public DesactiveActiveLbl()
        {

        }
        #endregion

        #region Méthodes
        public void desactivationLbl(Label lblSomme1, Label lblSomme2, Label lblSomme3, Label lblSomme4, Label lblSomme5,
            Label lblSomme6, Label lblBrelan, Label lblCarre, Label lblFull, Label lblPSuite, Label lblGSuite,Label lblYathzee, Label lblChance,
            CheckBox chBox1, CheckBox chBox2, CheckBox chBox3, CheckBox chBox4, CheckBox chBox5)
            //Méthode qui permet d'activer ou désactiver les labels en fonction de si ils ont déjà été remplis une fois ou pas (se lancer au click du bouton valider)
        {

            #region DESACTIVATION/ACTIVATION LABEL PARTIE GAUCHE
            //Label Somme 1
            if (lblSomme1.Text != "")
            {
                lblSomme1.Enabled = false;
            }
            else
            {
                lblSomme1.Enabled = true;
            }

            //Label Somme 2
            if (lblSomme2.Text != "")
            {
                lblSomme2.Enabled = false;
            }
            else
            {
                lblSomme2.Enabled = true;
            }

            //Label Somme 3
            if (lblSomme3.Text != "")
            {
                lblSomme3.Enabled = false;
            }
            else
            {
                lblSomme3.Enabled = true;
            }

            //Label Somme 4
            if (lblSomme4.Text != "")
            {
                lblSomme4.Enabled = false;
            }
            else
            {
                lblSomme4.Enabled = true;
            }

            //Label Somme 5
            if (lblSomme5.Text != "")
            {
                lblSomme5.Enabled = false;
            }
            else
            {
                lblSomme5.Enabled = true;
            }

            //Label Somme 6
            if (lblSomme6.Text != "")
            {
                lblSomme6.Enabled = false;
            }
            else
            {
                lblSomme6.Enabled = true;
            }
            #endregion
            #region DESACTIVATION/ACTIVATION LABEL PARTIE DROITE
            if (lblBrelan.Text != "")
            {
                lblBrelan.Enabled = false;
            }
            else
            {
                lblBrelan.Enabled = true;
            }

            if (lblCarre.Text != "")
            {
                lblCarre.Enabled = false;
            }
            else
            {
                lblCarre.Enabled = true;
            }

            if (lblFull.Text != "")
            {
                lblFull.Enabled = false;
            }
            else
            {
                lblFull.Enabled = true;
            }

            if (lblPSuite.Text != "")
            {
                lblPSuite.Enabled = false;
            }
            else
            {
                lblPSuite.Enabled = true;
            }

            if (lblGSuite.Text != "")
            {
                lblGSuite.Enabled = false;
            }
            else
            {
                lblGSuite.Enabled = true;
            }

            if (lblYathzee.Text != "")
            {
                lblYathzee.Enabled = false;
            }
            else
            {
                lblYathzee.Enabled = true;
            }

            if (lblChance.Text != "")
            {
                lblChance.Enabled = false;
            }
            else
            {
                lblChance.Enabled = true;
            }
            #endregion
        }

        public void desactiveTout(Label lblSomme1, Label lblSomme2, Label lblSomme3, Label lblSomme4, Label lblSomme5,
            Label lblSomme6, Label lblBrelan, Label lblCarre, Label lblFull, Label lblPSuite, Label lblGSuite, Label lblYathzee, Label lblChance)
            //Méthode qui permet de désactiver les clicks sur les labels tant que l'utilisateur n'as pas valider sa liste de chiffre
        {
            #region Partie gauche
            lblSomme1.Enabled = false;
            lblSomme2.Enabled = false;
            lblSomme3.Enabled = false;
            lblSomme4.Enabled = false;
            lblSomme5.Enabled = false;
            lblSomme6.Enabled = false;
            #endregion

            #region Partie droite
            lblBrelan.Enabled = false;
            lblCarre.Enabled = false;
            lblFull.Enabled = false;
            lblPSuite.Enabled = false;
            lblGSuite.Enabled = false;
            lblYathzee.Enabled = false;
            lblChance.Enabled = false;
            #endregion
        }
        #endregion
    }
}
