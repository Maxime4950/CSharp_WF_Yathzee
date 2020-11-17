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
    class Start
    {
        #region Initialisaton des variables
        
        #endregion

        #region Constructeur Start
        public Start()
        {
            
        }
        #endregion

        #region Méthodes
        public void InitialisationStart(Label labelNom, string nom, Label labelNbLancer,int nbLancer,PictureBox pb1,
            PictureBox pb2, PictureBox pb3, PictureBox pb4, PictureBox pb5, Button btnValider,
            Label lblSomme1, Label lblSomme2, Label lblSomme3, Label lblSomme4, Label lblSomme5, Label lblSomme6,
            Label lblTotSomme,Label lblPrime, Label lblTotFinalGauche, Label lblBrelan, Label lblCarre,
            Label lblFull, Label lblPSuite, Label lblGSuite, Label lblYathzee, Label lblChance, string nbJoueur)
        {
            if(nbJoueur == "J1")
            {
                labelNom.Text += nom;
            }
            else if(nbJoueur == "J2")
            {
                labelNom.Text += nom;
            }

            labelNbLancer.Text = "Lancer(s) restant(s) : " + nbLancer;

            pb1.Enabled = false;
            pb2.Enabled = false;
            pb3.Enabled = false;
            pb4.Enabled = false;
            pb5.Enabled = false;


            lblSomme1.Enabled = false;
            lblSomme2.Enabled = false;
            lblSomme3.Enabled = false;
            lblSomme4.Enabled = false;
            lblSomme5.Enabled = false;
            lblSomme6.Enabled = false;

            lblTotSomme.Enabled = false;
            lblPrime.Enabled = false;
            lblTotFinalGauche.Enabled = false;
            lblBrelan.Enabled = false;
            lblCarre.Enabled = false;
            lblFull.Enabled = false;
            lblPSuite.Enabled = false;
            lblGSuite.Enabled = false;
            lblYathzee.Enabled = false;
            lblChance.Enabled = false;

            btnValider.Enabled = false;

        }

        public void Tours(Panel pJ1, Panel pJ2, int nbTourJ1, int nbTourJ2)
        {
            if (pJ1.Enabled == false)
            {
                pJ1.Enabled = true;
                pJ2.Enabled = false;

            }

            else if (pJ2.Enabled == false)
            {
                pJ1.Enabled = false;
                pJ2.Enabled = true;
            }
        }
        #endregion
    }
}
