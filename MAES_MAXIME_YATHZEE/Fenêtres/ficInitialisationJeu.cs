using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // Fichier

namespace MAES_MAXIME_YATHZEE
{
    public partial class EcranInitialisationJeu : Form
    {
        #region Initialisation des variables
        int nbJ1, nbJ2;
        string nb;
        Random aleatoire = new Random();
        Save sauvegarde = new Save();
        #endregion

        #region Constructeur EcranInitialisation
        public EcranInitialisationJeu()
        {
            InitializeComponent();
            btnCommencer.Enabled = false;
            btnLancerJ1.Enabled = false;
            btnLancerJ2.Enabled = false;
            btnRecommencer.Enabled = false;
        }
        #endregion

        #region Méthodes
        private void tbJ1_TextChanged(object sender, EventArgs e)
        {
            if (tbJ1.Text != "")
            {
                btnLancerJ1.Enabled = true;
            }
            else
            {
                btnLancerJ1.Enabled = false;
            }
        }

        private void tbJ2_TextChanged(object sender, EventArgs e)
        {
            if (tbJ2.Text != "")
            {
                btnLancerJ2.Enabled = true;
            }
            else
            {
                btnLancerJ2.Enabled = false;
            }
        }

        private void btnCommencer_Click(object sender, EventArgs e)
        {
            //Pour fermer la fenetre initialisation à l'ouverture de la fenetre jeu
            System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(NouvellePartie));
            monthread.Start();
            this.Close();
        }

        private void NouvellePartie()
        {
            EcranJeu f = new EcranJeu();

            f.lblJoueur1.Text = tbJ1.Text;
            f.lblJoueur2.Text = tbJ2.Text;

            f.lblCommence.Text = nb;

            f.ShowDialog();
        }

        private void btnRecommencer_Click(object sender, EventArgs e)
        {
            btnLancerJ1.Enabled = true;
            btnLancerJ2.Enabled = true;
            btnRecommencer.Enabled = false;
            pbLancementJ1.Image = global::MAES_MAXIME_YATHZEE.Properties.Resources.de6;
            pbLancementJ2.Image = global::MAES_MAXIME_YATHZEE.Properties.Resources.de6;
            nbJ1 = 0;
            nbJ2 = 0;
        }

        private void btnLancerJ1_Click(object sender, EventArgs e)
        {
            nbJ1 = aleatoire.Next(1, 7);

            if (nbJ1 == 1)
            {
                pbLancementJ1.Image = global::MAES_MAXIME_YATHZEE.Properties.Resources.de1;
            }
            else if (nbJ1 == 2)
            {
                pbLancementJ1.Image = global::MAES_MAXIME_YATHZEE.Properties.Resources.de2;
            }
            else if (nbJ1 == 3)
            {
                pbLancementJ1.Image = global::MAES_MAXIME_YATHZEE.Properties.Resources.de3;
            }
            else if (nbJ1 == 4)
            {
                pbLancementJ1.Image = global::MAES_MAXIME_YATHZEE.Properties.Resources.de4;
            }
            else if (nbJ1 == 5)
            {
                pbLancementJ1.Image = global::MAES_MAXIME_YATHZEE.Properties.Resources.de5;
            }
            else if (nbJ1 == 6)
            {
                pbLancementJ1.Image = global::MAES_MAXIME_YATHZEE.Properties.Resources.de6;
            }

            btnLancerJ1.Enabled = false;

            JoueurCommence();
        }

        private void btnLancerJ2_Click(object sender, EventArgs e)
        {
            nbJ2 = aleatoire.Next(1, 7);

            if (nbJ2 == 1)
            {
                pbLancementJ2.Image = global::MAES_MAXIME_YATHZEE.Properties.Resources.de1;
            }
            else if (nbJ2 == 2)
            {
                pbLancementJ2.Image = global::MAES_MAXIME_YATHZEE.Properties.Resources.de2;
            }
            else if (nbJ2 == 3)
            {
                pbLancementJ2.Image = global::MAES_MAXIME_YATHZEE.Properties.Resources.de3;
            }
            else if (nbJ2 == 4)
            {
                pbLancementJ2.Image = global::MAES_MAXIME_YATHZEE.Properties.Resources.de4;
            }
            else if (nbJ2 == 5)
            {
                pbLancementJ2.Image = global::MAES_MAXIME_YATHZEE.Properties.Resources.de5;
            }
            else if (nbJ2 == 6)
            {
                pbLancementJ2.Image = global::MAES_MAXIME_YATHZEE.Properties.Resources.de6;
            }

            btnLancerJ2.Enabled = false;

            JoueurCommence();
        }

        private void btnChargeSauvegarde_Click(object sender, EventArgs e)
        {
            System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(SauvegardePartie));
            monthread.Start();
            this.Close();
        }
     
        private void SauvegardePartie()
        {
            EcranJeu f = new EcranJeu();

            f.flag = 1;
            f.ShowDialog();
        }


        private void EcranInitialisationJeu_Load(object sender, EventArgs e)
        {
            if (File.Exists("saveJ1.txt") && File.Exists("saveJ2.txt"))
            {
                btnChargeSauvegarde.Enabled = true;
            }
            else
            {
                btnChargeSauvegarde.Enabled = false;
            }
        }

        private void JoueurCommence()
        {
            if (btnLancerJ1.Enabled == false && btnLancerJ2.Enabled == false)
            {
                if (nbJ1 > nbJ2)
                {
                    btnCommencer.Enabled = true;
                    lblResultat.Text = "Résultat : J1 Commence";
                    nb = "1";
                }
                else if (nbJ1 < nbJ2)
                {
                    btnCommencer.Enabled = true;
                    lblResultat.Text = "Résultat : J2 Commence";
                    nb = "2";
                }
                else if (nbJ1 == nbJ2)
                {
                    lblResultat.Text += " Résultat : Egalité -> Recommencer ";
                    btnRecommencer.Enabled = true;
                }
            }
        }
        #endregion
    }
}
