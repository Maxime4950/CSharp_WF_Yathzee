using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MAES_MAXIME_YATHZEE
{
    public partial class EcranJeu : Form
    {
        #region Initialisation des variables

        DesactiveActiveLbl desactiveActive = new DesactiveActiveLbl();

        Vainqueur vainq = new Vainqueur();

        Save sauvegarde = new Save();

        JoueurUn J1 = new JoueurUn();
        JoueurDeux J2 = new JoueurDeux();

        Start start = new Start();

        Random aleatoire = new Random();

        public int flag;

        int cptD1 = 0; //Pour cick sur dé
        int cptD2 = 0;
        int cptD3 = 0;
        int cptD4 = 0;
        int cptD5 = 0;

        int cptD1J2 = 0; //Pour cick sur dé J2
        int cptD2J2 = 0;
        int cptD3J2 = 0;
        int cptD4J2 = 0;
        int cptD5J2 = 0;

        #endregion

        #region Constructeur EcranJeu()
        public EcranJeu()
        {
            InitializeComponent();

                #region Initialisation Joueur 1
                start.InitialisationStart(lblJoueur1, lblJoueur1.Text, lblNbLancerJ1, J1.nbLancerRestJ1,  pbDe1J1, pbDe2J1, pbDe3J1, pbDe4J1, pbDe5J1, btnValiderJ1,
                    lblSomme1J1, lblSomme2J1, lblSomme3J1, lblSomme4J1, lblSomme5J1, lblSomme6J1, lblTotalSommesJ1, lblPrimeJ1, lblTotalFinalGaucheJ1, lblBrelanJ1,
                    lblCarreJ1, lblFullJ1, lblPetiteSuiteJ1, lblGrandeSuiteJ1, lblYathzeeJ1, lblChanceJ1, "J1");

                #endregion
                #region Initialisation Joueur 2
                start.InitialisationStart(lblJoueur2, lblJoueur2.Text, lblNbLancerJ2, J2.nbLancerRestJ2, pbDe1J1, pbDe2J1, pbDe3J1, pbDe4J1, pbDe5J1, btnValiderJ2,
                    lblSomme1J2, lblSomme2J2, lblSomme3J2, lblSomme4J2, lblSomme5J2, lblSomme6J2, lblTotalSommesJ2, lblPrimeJ2, lblTotalFinalGaucheJ2, lblBrelanJ2,
                    lblCarreJ2, lblFullJ2, lblPetiteSuiteJ2, lblGrandeSuiteJ2, lblYathzeeJ2, lblChanceJ2, "J2");

                #endregion
        }
        #endregion

        #region Méthodes

        #region JOUEUR 1
        private void btnLancerJ1_Click(object sender, EventArgs e)
        {
            #region Activation des picture box J1
            pbDe1J1.Enabled = true;
            pbDe2J1.Enabled = true;
            pbDe3J1.Enabled = true;
            pbDe4J1.Enabled = true;
            pbDe5J1.Enabled = true;
            #endregion


            if (J1.nbLancerRestJ1 == 1) //Pour éviter de faire 4 lancers
            {
                J1.LancerJ1(chBoxD1J1, chBoxD2J1, chBoxD3J1, chBoxD4J1, chBoxD5J1,
                pbDe1J1, pbDe2J1, pbDe3J1, pbDe4J1, pbDe5J1,
                lblD1J1, lblD2J1, lblD3J1, lblD4J1, lblD5J1, aleatoire);

                J1.nbLancerRestJ1 = 0;

                btnValiderJ1.Visible = false;

                { btnValiderJ1_Click(null, null); } //Pour valider directement au 3ème tour

                lblNbLancerJ1.Text = ("Nombre de lancer(s) restant(s) : 0");

                btnLancerJ1.Enabled = false;
               
            }
            else
            {
                J1.nbLancerRestJ1--;

                J1.LancerJ1(chBoxD1J1, chBoxD2J1, chBoxD3J1, chBoxD4J1, chBoxD5J1,
                pbDe1J1, pbDe2J1, pbDe3J1, pbDe4J1, pbDe5J1,
                lblD1J1, lblD2J1, lblD3J1, lblD4J1, lblD5J1, aleatoire);

                lblNbLancerJ1.Text = ("Nombre de lancer(s) restant(s) : " + J1.nbLancerRestJ1);
            }

        }

        private void btnValiderJ1_Click(object sender, EventArgs e)
        {
            desactiveActive.desactivationLbl(lblSomme1J1,lblSomme2J1,lblSomme3J1,lblSomme4J1,lblSomme5J1,lblSomme6J1,lblBrelanJ1,
                lblCarreJ1,lblFullJ1,lblPetiteSuiteJ1,lblGrandeSuiteJ1,lblYathzeeJ1,lblChanceJ1,chBoxD1J1,chBoxD2J1,chBoxD3J1,chBoxD4J1,chBoxD5J1); //Bloquer les autres labels

            lblTotalSommesJ1.Enabled = true;
            lblPrimeJ1.Enabled = true;
            lblTotalFinalGaucheJ1.Enabled = true;
            lblTotalFinalDroiteJ1.Enabled = true;

            btnValiderJ1.Enabled = false;
        }

        #region Changement états des 5 dés J1



        #endregion

        #region Click partie droite sommes J1 (1 à 6)
        private void lblSomme1J1_Click(object sender, EventArgs e)
        {
            if ((J1.Somme1(lblSomme1J1, lblTotalSommesJ1, btnValiderJ1)) == true)
            {
                J1.Valider("J1", lblNbLancerJ1, chBoxD1J1, chBoxD2J1, chBoxD3J1, chBoxD4J1, chBoxD5J1,
               lblD1J1, lblD2J1, lblD3J1, lblD4J1, lblD5J1, lblSomme1J1, lblSomme2J1, lblSomme3J1, lblSomme4J1, lblSomme5J1, lblSomme6J1, lblBrelanJ1,
               lblCarreJ1, lblFullJ1, lblPetiteSuiteJ1, lblGrandeSuiteJ1, lblYathzeeJ1, lblChanceJ1, btnLancerJ1, pbDe1J1, pbDe2J1, pbDe3J1,
               pbDe4J1, pbDe5J1);


                J1.DefinirPrime(lblSomme1J1, lblSomme2J1, lblSomme3J1, lblSomme4J1, lblSomme5J1, lblSomme6J1, lblTotalSommesJ1, lblTotalFinalGaucheJ1, lblPrimeJ1);

                J1.CalculSommeFinale(lblSomme1J1, lblSomme2J1, lblSomme3J1, lblSomme4J1, lblSomme5J1, lblSomme6J1, lblBrelanJ1,
                lblCarreJ1, lblFullJ1, lblPetiteSuiteJ1, lblGrandeSuiteJ1, lblYathzeeJ1, lblChanceJ1, lblTotalFinalGaucheJ1, lblTotalFinalJ1);

                start.Tours(panelJ1, panelJ2, J1.nbTourJ1, J2.nbTourJ2);

                vainq.DetermineVainqueur(lblTotalFinalJ1, J1.sommeFinalePartieJ1, lblTotalFinalJ2, J2.sommeFinalePartieJ2, lblJoueur1, lblJoueur2, panelJ1, panelJ2,btnRecommencer);
            }
        }

        private void lblSomme2J1_Click(object sender, EventArgs e)
        {
            if((J1.Somme2(lblSomme2J1, lblTotalSommesJ1, btnValiderJ1)) == true)
            {
                J1.Valider("J1", lblNbLancerJ1, chBoxD1J1, chBoxD2J1, chBoxD3J1, chBoxD4J1, chBoxD5J1,
                lblD1J1, lblD2J1, lblD3J1, lblD4J1, lblD5J1, lblSomme1J1, lblSomme2J1, lblSomme3J1, lblSomme4J1, lblSomme5J1, lblSomme6J1, lblBrelanJ1,
                lblCarreJ1, lblFullJ1, lblPetiteSuiteJ1, lblGrandeSuiteJ1, lblYathzeeJ1, lblChanceJ1, btnLancerJ1, pbDe1J1, pbDe2J1, pbDe3J1,
                pbDe4J1, pbDe5J1);

                J1.DefinirPrime(lblSomme1J1, lblSomme2J1, lblSomme3J1, lblSomme4J1, lblSomme5J1, lblSomme6J1, lblTotalSommesJ1, lblTotalFinalGaucheJ1, lblPrimeJ1);

                J1.CalculSommeFinale(lblSomme1J1, lblSomme2J1, lblSomme3J1, lblSomme4J1, lblSomme5J1, lblSomme6J1, lblBrelanJ1,
                lblCarreJ1, lblFullJ1, lblPetiteSuiteJ1, lblGrandeSuiteJ1, lblYathzeeJ1, lblChanceJ1, lblTotalFinalGaucheJ1, lblTotalFinalJ1);

                start.Tours(panelJ1, panelJ2, J1.nbTourJ1, J2.nbTourJ2);

                vainq.DetermineVainqueur(lblTotalFinalJ1, J1.sommeFinalePartieJ1, lblTotalFinalJ2, J2.sommeFinalePartieJ2, lblJoueur1, lblJoueur2, panelJ1, panelJ2, btnRecommencer);
            }
        }

        private void lblSomme3J1_Click(object sender, EventArgs e)
        {
            if((J1.Somme3(lblSomme3J1, lblTotalSommesJ1, btnValiderJ1)) == true)
            {
                J1.Valider("J1", lblNbLancerJ1, chBoxD1J1, chBoxD2J1, chBoxD3J1, chBoxD4J1, chBoxD5J1,
                lblD1J1, lblD2J1, lblD3J1, lblD4J1, lblD5J1, lblSomme1J1, lblSomme2J1, lblSomme3J1, lblSomme4J1, lblSomme5J1, lblSomme6J1, lblBrelanJ1,
                lblCarreJ1, lblFullJ1, lblPetiteSuiteJ1, lblGrandeSuiteJ1, lblYathzeeJ1, lblChanceJ1, btnLancerJ1, pbDe1J1, pbDe2J1, pbDe3J1,
                pbDe4J1, pbDe5J1);

                J1.DefinirPrime(lblSomme1J1, lblSomme2J1, lblSomme3J1, lblSomme4J1, lblSomme5J1, lblSomme6J1, lblTotalSommesJ1, lblTotalFinalGaucheJ1, lblPrimeJ1);

                J1.CalculSommeFinale(lblSomme1J1, lblSomme2J1, lblSomme3J1, lblSomme4J1, lblSomme5J1, lblSomme6J1, lblBrelanJ1,
                lblCarreJ1, lblFullJ1, lblPetiteSuiteJ1, lblGrandeSuiteJ1, lblYathzeeJ1, lblChanceJ1, lblTotalFinalGaucheJ1, lblTotalFinalJ1);

                start.Tours(panelJ1, panelJ2, J1.nbTourJ1, J2.nbTourJ2);

                vainq.DetermineVainqueur(lblTotalFinalJ1, J1.sommeFinalePartieJ1, lblTotalFinalJ2, J2.sommeFinalePartieJ2, lblJoueur1, lblJoueur2, panelJ1, panelJ2, btnRecommencer);
            }
        }

        private void lblSomme4J1_Click(object sender, EventArgs e)
        {
            if ((J1.Somme4(lblSomme4J1, lblTotalSommesJ1, btnValiderJ1)) == true)
            {
                J1.Valider("J1", lblNbLancerJ1, chBoxD1J1, chBoxD2J1, chBoxD3J1, chBoxD4J1, chBoxD5J1,
                lblD1J1, lblD2J1, lblD3J1, lblD4J1, lblD5J1, lblSomme1J1, lblSomme2J1, lblSomme3J1, lblSomme4J1, lblSomme5J1, lblSomme6J1, lblBrelanJ1,
                lblCarreJ1, lblFullJ1, lblPetiteSuiteJ1, lblGrandeSuiteJ1, lblYathzeeJ1, lblChanceJ1, btnLancerJ1, pbDe1J1, pbDe2J1, pbDe3J1,
                pbDe4J1, pbDe5J1);

                J1.DefinirPrime(lblSomme1J1, lblSomme2J1, lblSomme3J1, lblSomme4J1, lblSomme5J1, lblSomme6J1, lblTotalSommesJ1, lblTotalFinalGaucheJ1, lblPrimeJ1);

                J1.CalculSommeFinale(lblSomme1J1, lblSomme2J1, lblSomme3J1, lblSomme4J1, lblSomme5J1, lblSomme6J1, lblBrelanJ1,
                lblCarreJ1, lblFullJ1, lblPetiteSuiteJ1, lblGrandeSuiteJ1, lblYathzeeJ1, lblChanceJ1, lblTotalFinalGaucheJ1, lblTotalFinalJ1);

                start.Tours(panelJ1, panelJ2, J1.nbTourJ1, J2.nbTourJ2);

                vainq.DetermineVainqueur(lblTotalFinalJ1, J1.sommeFinalePartieJ1, lblTotalFinalJ2, J2.sommeFinalePartieJ2, lblJoueur1, lblJoueur2, panelJ1, panelJ2, btnRecommencer);
            }
        }

        private void lblSomme5J1_Click(object sender, EventArgs e)
        {
            if ((J1.Somme5(lblSomme5J1, lblTotalSommesJ1, btnValiderJ1)) == true)
            {
                J1.Valider("J1", lblNbLancerJ1, chBoxD1J1, chBoxD2J1, chBoxD3J1, chBoxD4J1, chBoxD5J1,
                lblD1J1, lblD2J1, lblD3J1, lblD4J1, lblD5J1, lblSomme1J1, lblSomme2J1, lblSomme3J1, lblSomme4J1, lblSomme5J1, lblSomme6J1, lblBrelanJ1,
                lblCarreJ1, lblFullJ1, lblPetiteSuiteJ1, lblGrandeSuiteJ1, lblYathzeeJ1, lblChanceJ1, btnLancerJ1, pbDe1J1, pbDe2J1, pbDe3J1,
                pbDe4J1, pbDe5J1);

                J1.DefinirPrime(lblSomme1J1, lblSomme2J1, lblSomme3J1, lblSomme4J1, lblSomme5J1, lblSomme6J1, lblTotalSommesJ1, lblTotalFinalGaucheJ1, lblPrimeJ1);

                J1.CalculSommeFinale(lblSomme1J1, lblSomme2J1, lblSomme3J1, lblSomme4J1, lblSomme5J1, lblSomme6J1, lblBrelanJ1,
                lblCarreJ1, lblFullJ1, lblPetiteSuiteJ1, lblGrandeSuiteJ1, lblYathzeeJ1, lblChanceJ1, lblTotalFinalGaucheJ1, lblTotalFinalJ1);

                start.Tours(panelJ1, panelJ2, J1.nbTourJ1, J2.nbTourJ2);

                vainq.DetermineVainqueur(lblTotalFinalJ1, J1.sommeFinalePartieJ1, lblTotalFinalJ2, J2.sommeFinalePartieJ2, lblJoueur1, lblJoueur2, panelJ1, panelJ2, btnRecommencer);
            }
        }

        private void lblSomme6J1_Click(object sender, EventArgs e)
        {
            if ((J1.Somme6(lblSomme6J1, lblTotalSommesJ1, btnValiderJ1)) == true)
            {
                J1.Valider("J1", lblNbLancerJ1, chBoxD1J1, chBoxD2J1, chBoxD3J1, chBoxD4J1, chBoxD5J1,
                lblD1J1, lblD2J1, lblD3J1, lblD4J1, lblD5J1, lblSomme1J1, lblSomme2J1, lblSomme3J1, lblSomme4J1, lblSomme5J1, lblSomme6J1, lblBrelanJ1,
                lblCarreJ1, lblFullJ1, lblPetiteSuiteJ1, lblGrandeSuiteJ1, lblYathzeeJ1, lblChanceJ1, btnLancerJ1, pbDe1J1, pbDe2J1, pbDe3J1,
                pbDe4J1, pbDe5J1);

                J1.DefinirPrime(lblSomme1J1, lblSomme2J1, lblSomme3J1, lblSomme4J1, lblSomme5J1, lblSomme6J1, lblTotalSommesJ1, lblTotalFinalGaucheJ1, lblPrimeJ1);

                J1.CalculSommeFinale(lblSomme1J1, lblSomme2J1, lblSomme3J1, lblSomme4J1, lblSomme5J1, lblSomme6J1, lblBrelanJ1,
                lblCarreJ1, lblFullJ1, lblPetiteSuiteJ1, lblGrandeSuiteJ1, lblYathzeeJ1, lblChanceJ1, lblTotalFinalGaucheJ1, lblTotalFinalJ1);

                start.Tours(panelJ1, panelJ2, J1.nbTourJ1, J2.nbTourJ2);

                vainq.DetermineVainqueur(lblTotalFinalJ1, J1.sommeFinalePartieJ1, lblTotalFinalJ2, J2.sommeFinalePartieJ2, lblJoueur1, lblJoueur2, panelJ1, panelJ2, btnRecommencer);
            }
        }
        #endregion

        #region Click partie gauche J1
        private void lblBrelanJ1_Click(object sender, EventArgs e)
        {
            if((J1.Brelan(lblBrelanJ1, lblTotalFinalDroiteJ1, btnValiderJ1)) == true)
            {
                J1.Valider("J1", lblNbLancerJ1, chBoxD1J1, chBoxD2J1, chBoxD3J1, chBoxD4J1, chBoxD5J1,
                lblD1J1, lblD2J1, lblD3J1, lblD4J1, lblD5J1, lblSomme1J1, lblSomme2J1, lblSomme3J1, lblSomme4J1, lblSomme5J1, lblSomme6J1, lblBrelanJ1,
                lblCarreJ1, lblFullJ1, lblPetiteSuiteJ1, lblGrandeSuiteJ1, lblYathzeeJ1, lblChanceJ1, btnLancerJ1, pbDe1J1, pbDe2J1, pbDe3J1,
                pbDe4J1, pbDe5J1);

                J1.CalculSommeFinale(lblSomme1J1, lblSomme2J1, lblSomme3J1, lblSomme4J1, lblSomme5J1, lblSomme6J1, lblBrelanJ1,
                lblCarreJ1, lblFullJ1, lblPetiteSuiteJ1, lblGrandeSuiteJ1, lblYathzeeJ1, lblChanceJ1, lblTotalFinalGaucheJ1, lblTotalFinalJ1);

                start.Tours(panelJ1, panelJ2, J1.nbTourJ1, J2.nbTourJ2);

                vainq.DetermineVainqueur(lblTotalFinalJ1, J1.sommeFinalePartieJ1, lblTotalFinalJ2, J2.sommeFinalePartieJ2, lblJoueur1, lblJoueur2, panelJ1, panelJ2, btnRecommencer);
            }
        }

        private void lblCarreJ1_Click(object sender, EventArgs e)
        {
            if ((J1.Carre(lblCarreJ1, lblTotalFinalDroiteJ1, btnValiderJ1)) == true)
            {
                J1.Valider("J1", lblNbLancerJ1, chBoxD1J1, chBoxD2J1, chBoxD3J1, chBoxD4J1, chBoxD5J1,
                lblD1J1, lblD2J1, lblD3J1, lblD4J1, lblD5J1, lblSomme1J1, lblSomme2J1, lblSomme3J1, lblSomme4J1, lblSomme5J1, lblSomme6J1, lblBrelanJ1,
                lblCarreJ1, lblFullJ1, lblPetiteSuiteJ1, lblGrandeSuiteJ1, lblYathzeeJ1, lblChanceJ1, btnLancerJ1, pbDe1J1, pbDe2J1, pbDe3J1,
                pbDe4J1, pbDe5J1);

                J1.CalculSommeFinale(lblSomme1J1, lblSomme2J1, lblSomme3J1, lblSomme4J1, lblSomme5J1, lblSomme6J1, lblBrelanJ1,
                lblCarreJ1, lblFullJ1, lblPetiteSuiteJ1, lblGrandeSuiteJ1, lblYathzeeJ1, lblChanceJ1, lblTotalFinalGaucheJ1, lblTotalFinalJ1);

                start.Tours(panelJ1, panelJ2, J1.nbTourJ1, J2.nbTourJ2);

                vainq.DetermineVainqueur(lblTotalFinalJ1, J1.sommeFinalePartieJ1, lblTotalFinalJ2, J2.sommeFinalePartieJ2, lblJoueur1, lblJoueur2, panelJ1, panelJ2, btnRecommencer);
            }
        }

        private void lblFullJ1_Click(object sender, EventArgs e)
        {
            if ((J1.Full(lblFullJ1, lblTotalFinalDroiteJ1, btnValiderJ1)) == true)
            {
                J1.Valider("J1", lblNbLancerJ1, chBoxD1J1, chBoxD2J1, chBoxD3J1, chBoxD4J1, chBoxD5J1,
                lblD1J1, lblD2J1, lblD3J1, lblD4J1, lblD5J1, lblSomme1J1, lblSomme2J1, lblSomme3J1, lblSomme4J1, lblSomme5J1, lblSomme6J1, lblBrelanJ1,
                lblCarreJ1, lblFullJ1, lblPetiteSuiteJ1, lblGrandeSuiteJ1, lblYathzeeJ1, lblChanceJ1, btnLancerJ1, pbDe1J1, pbDe2J1, pbDe3J1,
                pbDe4J1, pbDe5J1);

                J1.CalculSommeFinale(lblSomme1J1, lblSomme2J1, lblSomme3J1, lblSomme4J1, lblSomme5J1, lblSomme6J1, lblBrelanJ1,
                lblCarreJ1, lblFullJ1, lblPetiteSuiteJ1, lblGrandeSuiteJ1, lblYathzeeJ1, lblChanceJ1, lblTotalFinalGaucheJ1, lblTotalFinalJ1);

                start.Tours(panelJ1, panelJ2, J1.nbTourJ1, J2.nbTourJ2);

                vainq.DetermineVainqueur(lblTotalFinalJ1, J1.sommeFinalePartieJ1, lblTotalFinalJ2, J2.sommeFinalePartieJ2, lblJoueur1, lblJoueur2, panelJ1, panelJ2, btnRecommencer);
            }
        }

        private void lblPetiteSuiteJ1_Click(object sender, EventArgs e)
        {
            
            if ((J1.PetiteSuite(lblPetiteSuiteJ1, lblTotalFinalDroiteJ1, btnValiderJ1)) == true)
            {
                J1.Valider("J1", lblNbLancerJ1, chBoxD1J1, chBoxD2J1, chBoxD3J1, chBoxD4J1, chBoxD5J1,
                lblD1J1, lblD2J1, lblD3J1, lblD4J1, lblD5J1, lblSomme1J1, lblSomme2J1, lblSomme3J1, lblSomme4J1, lblSomme5J1, lblSomme6J1, lblBrelanJ1,
                lblCarreJ1, lblFullJ1, lblPetiteSuiteJ1, lblGrandeSuiteJ1, lblYathzeeJ1, lblChanceJ1, btnLancerJ1, pbDe1J1, pbDe2J1, pbDe3J1,
                pbDe4J1, pbDe5J1);

                J1.CalculSommeFinale(lblSomme1J1, lblSomme2J1, lblSomme3J1, lblSomme4J1, lblSomme5J1, lblSomme6J1, lblBrelanJ1,
                lblCarreJ1, lblFullJ1, lblPetiteSuiteJ1, lblGrandeSuiteJ1, lblYathzeeJ1, lblChanceJ1, lblTotalFinalGaucheJ1, lblTotalFinalJ1);

                start.Tours(panelJ1, panelJ2, J1.nbTourJ1, J2.nbTourJ2);

                vainq.DetermineVainqueur(lblTotalFinalJ1, J1.sommeFinalePartieJ1, lblTotalFinalJ2, J2.sommeFinalePartieJ2, lblJoueur1, lblJoueur2, panelJ1, panelJ2, btnRecommencer);
            }
        }

        private void lblGrandeSuiteJ1_Click(object sender, EventArgs e)
        {
            
            if ((J1.GrandeSuite(lblGrandeSuiteJ1, lblTotalFinalDroiteJ1, btnValiderJ1)) == true)
            {
                J1.Valider("J1", lblNbLancerJ1, chBoxD1J1, chBoxD2J1, chBoxD3J1, chBoxD4J1, chBoxD5J1,
                lblD1J1, lblD2J1, lblD3J1, lblD4J1, lblD5J1, lblSomme1J1, lblSomme2J1, lblSomme3J1, lblSomme4J1, lblSomme5J1, lblSomme6J1, lblBrelanJ1,
                lblCarreJ1, lblFullJ1, lblPetiteSuiteJ1, lblGrandeSuiteJ1, lblYathzeeJ1, lblChanceJ1, btnLancerJ1, pbDe1J1, pbDe2J1, pbDe3J1,
                pbDe4J1, pbDe5J1);

                J1.CalculSommeFinale(lblSomme1J1, lblSomme2J1, lblSomme3J1, lblSomme4J1, lblSomme5J1, lblSomme6J1, lblBrelanJ1,
                lblCarreJ1, lblFullJ1, lblPetiteSuiteJ1, lblGrandeSuiteJ1, lblYathzeeJ1, lblChanceJ1, lblTotalFinalGaucheJ1, lblTotalFinalJ1);

                start.Tours(panelJ1, panelJ2, J1.nbTourJ1, J2.nbTourJ2);

                vainq.DetermineVainqueur(lblTotalFinalJ1, J1.sommeFinalePartieJ1, lblTotalFinalJ2, J2.sommeFinalePartieJ2, lblJoueur1, lblJoueur2, panelJ1, panelJ2, btnRecommencer);
            }
        }

        private void lblYathzeeJ1_Click(object sender, EventArgs e)
        {
            if ((J1.Yathzee(lblYathzeeJ1, lblTotalFinalDroiteJ1, btnValiderJ1)) == true)
            {
                J1.Valider("J1", lblNbLancerJ1, chBoxD1J1, chBoxD2J1, chBoxD3J1, chBoxD4J1, chBoxD5J1,
                lblD1J1, lblD2J1, lblD3J1, lblD4J1, lblD5J1, lblSomme1J1, lblSomme2J1, lblSomme3J1, lblSomme4J1, lblSomme5J1, lblSomme6J1, lblBrelanJ1,
                lblCarreJ1, lblFullJ1, lblPetiteSuiteJ1, lblGrandeSuiteJ1, lblYathzeeJ1, lblChanceJ1, btnLancerJ1, pbDe1J1, pbDe2J1, pbDe3J1,
                pbDe4J1, pbDe5J1);

                J1.CalculSommeFinale(lblSomme1J1, lblSomme2J1, lblSomme3J1, lblSomme4J1, lblSomme5J1, lblSomme6J1, lblBrelanJ1,
                lblCarreJ1, lblFullJ1, lblPetiteSuiteJ1, lblGrandeSuiteJ1, lblYathzeeJ1, lblChanceJ1, lblTotalFinalGaucheJ1, lblTotalFinalJ1);

                start.Tours(panelJ1, panelJ2, J1.nbTourJ1, J2.nbTourJ2);

                vainq.DetermineVainqueur(lblTotalFinalJ1, J1.sommeFinalePartieJ1, lblTotalFinalJ2, J2.sommeFinalePartieJ2, lblJoueur1, lblJoueur2, panelJ1, panelJ2, btnRecommencer);
            }
        }

        private void lblChanceJ1_Click(object sender, EventArgs e)
        {
            if ((J1.Chance(lblChanceJ1, lblTotalFinalDroiteJ1, btnValiderJ1,chBoxD1J1,chBoxD2J1,chBoxD3J1,chBoxD4J1,chBoxD5J1)) == true)
            {
                J1.Valider("J1", lblNbLancerJ1, chBoxD1J1, chBoxD2J1, chBoxD3J1, chBoxD4J1, chBoxD5J1,
                lblD1J1, lblD2J1, lblD3J1, lblD4J1, lblD5J1, lblSomme1J1, lblSomme2J1, lblSomme3J1, lblSomme4J1, lblSomme5J1, lblSomme6J1, lblBrelanJ1,
                lblCarreJ1, lblFullJ1, lblPetiteSuiteJ1, lblGrandeSuiteJ1, lblYathzeeJ1, lblChanceJ1, btnLancerJ1, pbDe1J1, pbDe2J1, pbDe3J1,
                pbDe4J1, pbDe5J1);

                J1.CalculSommeFinale(lblSomme1J1, lblSomme2J1, lblSomme3J1, lblSomme4J1, lblSomme5J1, lblSomme6J1, lblBrelanJ1,
                lblCarreJ1, lblFullJ1, lblPetiteSuiteJ1, lblGrandeSuiteJ1, lblYathzeeJ1, lblChanceJ1, lblTotalFinalGaucheJ1, lblTotalFinalJ1);

                start.Tours(panelJ1, panelJ2, J1.nbTourJ1, J2.nbTourJ2);

                vainq.DetermineVainqueur(lblTotalFinalJ1, J1.sommeFinalePartieJ1, lblTotalFinalJ2, J2.sommeFinalePartieJ2, lblJoueur1, lblJoueur2, panelJ1, panelJ2, btnRecommencer);
            }
        }

        #endregion
        #endregion

        #region JOUEUR 2
        private void btnLancerJ2_Click(object sender, EventArgs e)
        {

            if (J2.nbLancerRestJ2 == 1)
            {
                J2.LancerJ2(chBoxD1J2, chBoxD2J2, chBoxD3J2, chBoxD4J2, chBoxD5J2,
                pbDe1J2, pbDe2J2, pbDe3J2, pbDe4J2, pbDe5J2,
                lblD1J2, lblD2J2, lblD3J2, lblD4J2, lblD5J2, aleatoire);

                J2.nbLancerRestJ2 = 0;

                btnValiderJ2.Visible = false;

                { btnValiderJ2_Click(null, null); } //Pour valider directement au 3ème tour

                lblNbLancerJ2.Text = ("Nombre de lancer(s) restant(s) : 0");

                btnLancerJ2.Enabled = false;
            }
            else
            {
                J2.nbLancerRestJ2--;

                J2.LancerJ2(chBoxD1J2, chBoxD2J2, chBoxD3J2, chBoxD4J2, chBoxD5J2,
                 pbDe1J2, pbDe2J2, pbDe3J2, pbDe4J2, pbDe5J2,
                 lblD1J2, lblD2J2, lblD3J2, lblD4J2, lblD5J2, aleatoire);

                lblNbLancerJ2.Text = ("Nombre de lancer(s) restant(s) : " + J2.nbLancerRestJ2);
            }
        }

        private void btnValiderJ2_Click(object sender, EventArgs e)
        {
            desactiveActive.desactivationLbl(lblSomme1J2, lblSomme2J2, lblSomme3J2, lblSomme4J2, lblSomme5J2, lblSomme6J2, lblBrelanJ2,
                lblCarreJ2, lblFullJ2, lblPetiteSuiteJ2, lblGrandeSuiteJ2, lblYathzeeJ2, lblChanceJ2, chBoxD1J2, chBoxD2J2, chBoxD3J2, chBoxD4J2, chBoxD5J2); //Bloquer les autres labels

            lblTotalSommesJ2.Enabled = true;
            lblPrimeJ2.Enabled = true;
            lblTotalFinalGaucheJ2.Enabled = true;
            lblTotalFinalDroiteJ2.Enabled = true;

            btnValiderJ2.Enabled = false;
        }

        #region Changement états des 5 dés J2

        #endregion

        #region Click partie gauche sommes J2 (1 à 6)
        private void lblSomme1J2_Click(object sender, EventArgs e)
        {
            if ((J2.Somme1(lblSomme1J2, lblTotalSommesJ2, btnValiderJ2)) == true)
            {
                J2.Valider("J2", lblNbLancerJ2, chBoxD1J2, chBoxD2J2, chBoxD3J2, chBoxD4J2, chBoxD5J2,
               lblD1J2, lblD2J2, lblD3J2, lblD4J2, lblD5J2, lblSomme1J2, lblSomme2J2, lblSomme3J2, lblSomme4J2, lblSomme5J2, lblSomme6J2, lblBrelanJ2,
               lblCarreJ2, lblFullJ2, lblPetiteSuiteJ2, lblGrandeSuiteJ2, lblYathzeeJ2, lblChanceJ2, btnLancerJ2, pbDe1J2, pbDe2J2, pbDe3J2,
               pbDe4J2, pbDe5J2);


                J2.DefinirPrime(lblSomme1J2, lblSomme2J2, lblSomme3J2, lblSomme4J2, lblSomme5J2, lblSomme6J2, lblTotalSommesJ2, lblTotalFinalGaucheJ2, lblPrimeJ2);

                J2.CalculSommeFinale(lblSomme1J2, lblSomme2J2, lblSomme3J2, lblSomme4J2, lblSomme5J2, lblSomme6J2, lblBrelanJ2,
                lblCarreJ2, lblFullJ2, lblPetiteSuiteJ2, lblGrandeSuiteJ2, lblYathzeeJ2, lblChanceJ2, lblTotalFinalGaucheJ2, lblTotalFinalJ2);

                start.Tours(panelJ1, panelJ2, J1.nbTourJ1, J2.nbTourJ2);

                vainq.DetermineVainqueur(lblTotalFinalJ1, J1.sommeFinalePartieJ1, lblTotalFinalJ2, J2.sommeFinalePartieJ2, lblJoueur1, lblJoueur2, panelJ1, panelJ2, btnRecommencer);
            }
        }

        private void lblSomme2J2_Click(object sender, EventArgs e)
        {
            if ((J2.Somme2(lblSomme2J2, lblTotalSommesJ2, btnValiderJ2)) == true)
            {
                J2.Valider("J2", lblNbLancerJ2, chBoxD1J2, chBoxD2J2, chBoxD3J2, chBoxD4J2, chBoxD5J2,
               lblD1J2, lblD2J2, lblD3J2, lblD4J2, lblD5J2, lblSomme1J2, lblSomme2J2, lblSomme3J2, lblSomme4J2, lblSomme5J2, lblSomme6J2, lblBrelanJ2,
               lblCarreJ2, lblFullJ2, lblPetiteSuiteJ2, lblGrandeSuiteJ2, lblYathzeeJ2, lblChanceJ2, btnLancerJ2, pbDe1J2, pbDe2J2, pbDe3J2,
               pbDe4J2, pbDe5J2);


                J2.DefinirPrime(lblSomme1J2, lblSomme2J2, lblSomme3J2, lblSomme4J2, lblSomme5J2, lblSomme6J2, lblTotalSommesJ2, lblTotalFinalGaucheJ2, lblPrimeJ2);

                J2.CalculSommeFinale(lblSomme1J2, lblSomme2J2, lblSomme3J2, lblSomme4J2, lblSomme5J2, lblSomme6J2, lblBrelanJ2,
                lblCarreJ2, lblFullJ2, lblPetiteSuiteJ2, lblGrandeSuiteJ2, lblYathzeeJ2, lblChanceJ2, lblTotalFinalGaucheJ2, lblTotalFinalJ2);

                start.Tours(panelJ1, panelJ2, J1.nbTourJ1, J2.nbTourJ2);

                vainq.DetermineVainqueur(lblTotalFinalJ1, J1.sommeFinalePartieJ1, lblTotalFinalJ2, J2.sommeFinalePartieJ2, lblJoueur1, lblJoueur2, panelJ1, panelJ2, btnRecommencer);
            }
        }

        private void lblSomme3J2_Click(object sender, EventArgs e)
        {
            if ((J2.Somme3(lblSomme3J2, lblTotalSommesJ2, btnValiderJ2)) == true)
            {
                J2.Valider("J2", lblNbLancerJ2, chBoxD1J2, chBoxD2J2, chBoxD3J2, chBoxD4J2, chBoxD5J2,
               lblD1J2, lblD2J2, lblD3J2, lblD4J2, lblD5J2, lblSomme1J2, lblSomme2J2, lblSomme3J2, lblSomme4J2, lblSomme5J2, lblSomme6J2, lblBrelanJ2,
               lblCarreJ2, lblFullJ2, lblPetiteSuiteJ2, lblGrandeSuiteJ2, lblYathzeeJ2, lblChanceJ2, btnLancerJ2, pbDe1J2, pbDe2J2, pbDe3J2,
               pbDe4J2, pbDe5J2);


                J2.DefinirPrime(lblSomme1J2, lblSomme2J2, lblSomme3J2, lblSomme4J2, lblSomme5J2, lblSomme6J2, lblTotalSommesJ2, lblTotalFinalGaucheJ2, lblPrimeJ2);

                J2.CalculSommeFinale(lblSomme1J2, lblSomme2J2, lblSomme3J2, lblSomme4J2, lblSomme5J2, lblSomme6J2, lblBrelanJ2,
                lblCarreJ2, lblFullJ2, lblPetiteSuiteJ2, lblGrandeSuiteJ2, lblYathzeeJ2, lblChanceJ2, lblTotalFinalGaucheJ2, lblTotalFinalJ2);

                start.Tours(panelJ1, panelJ2, J1.nbTourJ1, J2.nbTourJ2);

                vainq.DetermineVainqueur(lblTotalFinalJ1, J1.sommeFinalePartieJ1, lblTotalFinalJ2, J2.sommeFinalePartieJ2, lblJoueur1, lblJoueur2, panelJ1, panelJ2, btnRecommencer);

            }
        }

        private void lblSomme4J2_Click(object sender, EventArgs e)
        {
            if ((J2.Somme4(lblSomme4J2, lblTotalSommesJ2, btnValiderJ2)) == true)
            {
                J2.Valider("J2", lblNbLancerJ2, chBoxD1J2, chBoxD2J2, chBoxD3J2, chBoxD4J2, chBoxD5J2,
               lblD1J2, lblD2J2, lblD3J2, lblD4J2, lblD5J2, lblSomme1J2, lblSomme2J2, lblSomme3J2, lblSomme4J2, lblSomme5J2, lblSomme6J2, lblBrelanJ2,
               lblCarreJ2, lblFullJ2, lblPetiteSuiteJ2, lblGrandeSuiteJ2, lblYathzeeJ2, lblChanceJ2, btnLancerJ2, pbDe1J2, pbDe2J2, pbDe3J2,
               pbDe4J2, pbDe5J2);


                J2.DefinirPrime(lblSomme1J2, lblSomme2J2, lblSomme3J2, lblSomme4J2, lblSomme5J2, lblSomme6J2, lblTotalSommesJ2, lblTotalFinalGaucheJ2, lblPrimeJ2);

                J2.CalculSommeFinale(lblSomme1J2, lblSomme2J2, lblSomme3J2, lblSomme4J2, lblSomme5J2, lblSomme6J2, lblBrelanJ2,
                lblCarreJ2, lblFullJ2, lblPetiteSuiteJ2, lblGrandeSuiteJ2, lblYathzeeJ2, lblChanceJ2, lblTotalFinalGaucheJ2, lblTotalFinalJ2);

                start.Tours(panelJ1, panelJ2, J1.nbTourJ1, J2.nbTourJ2);

                vainq.DetermineVainqueur(lblTotalFinalJ1, J1.sommeFinalePartieJ1, lblTotalFinalJ2, J2.sommeFinalePartieJ2, lblJoueur1, lblJoueur2, panelJ1, panelJ2, btnRecommencer);
            }
        }

        private void lblSomme5J2_Click(object sender, EventArgs e)
        {
            if ((J2.Somme5(lblSomme5J2, lblTotalSommesJ2, btnValiderJ2)) == true)
            {
                J2.Valider("J2", lblNbLancerJ2, chBoxD1J2, chBoxD2J2, chBoxD3J2, chBoxD4J2, chBoxD5J2,
               lblD1J2, lblD2J2, lblD3J2, lblD4J2, lblD5J2, lblSomme1J2, lblSomme2J2, lblSomme3J2, lblSomme4J2, lblSomme5J2, lblSomme6J2, lblBrelanJ2,
               lblCarreJ2, lblFullJ2, lblPetiteSuiteJ2, lblGrandeSuiteJ2, lblYathzeeJ2, lblChanceJ2, btnLancerJ2, pbDe1J2, pbDe2J2, pbDe3J2,
               pbDe4J2, pbDe5J2);


                J2.DefinirPrime(lblSomme1J2, lblSomme2J2, lblSomme3J2, lblSomme4J2, lblSomme5J2, lblSomme6J2, lblTotalSommesJ2, lblTotalFinalGaucheJ2, lblPrimeJ2);

                J2.CalculSommeFinale(lblSomme1J2, lblSomme2J2, lblSomme3J2, lblSomme4J2, lblSomme5J2, lblSomme6J2, lblBrelanJ2,
                lblCarreJ2, lblFullJ2, lblPetiteSuiteJ2, lblGrandeSuiteJ2, lblYathzeeJ2, lblChanceJ2, lblTotalFinalGaucheJ2, lblTotalFinalJ2);

                start.Tours(panelJ1, panelJ2, J1.nbTourJ1, J2.nbTourJ2);

                vainq.DetermineVainqueur(lblTotalFinalJ1, J1.sommeFinalePartieJ1, lblTotalFinalJ2, J2.sommeFinalePartieJ2, lblJoueur1, lblJoueur2, panelJ1, panelJ2, btnRecommencer);
            }
        }

        private void lblSomme6J2_Click(object sender, EventArgs e)
        {
            if ((J2.Somme6(lblSomme6J2, lblTotalSommesJ2, btnValiderJ2)) == true)
            {
                J2.Valider("J2", lblNbLancerJ2, chBoxD1J2, chBoxD2J2, chBoxD3J2, chBoxD4J2, chBoxD5J2,
               lblD1J2, lblD2J2, lblD3J2, lblD4J2, lblD5J2, lblSomme1J2, lblSomme2J2, lblSomme3J2, lblSomme4J2, lblSomme5J2, lblSomme6J2, lblBrelanJ2,
               lblCarreJ2, lblFullJ2, lblPetiteSuiteJ2, lblGrandeSuiteJ2, lblYathzeeJ2, lblChanceJ2, btnLancerJ2, pbDe1J2, pbDe2J2, pbDe3J2,
               pbDe4J2, pbDe5J2);


                J2.DefinirPrime(lblSomme1J2, lblSomme2J2, lblSomme3J2, lblSomme4J2, lblSomme5J2, lblSomme6J2, lblTotalSommesJ2, lblTotalFinalGaucheJ2, lblPrimeJ2);

                J2.CalculSommeFinale(lblSomme1J2, lblSomme2J2, lblSomme3J2, lblSomme4J2, lblSomme5J2, lblSomme6J2, lblBrelanJ2,
                lblCarreJ2, lblFullJ2, lblPetiteSuiteJ2, lblGrandeSuiteJ2, lblYathzeeJ2, lblChanceJ2, lblTotalFinalGaucheJ2, lblTotalFinalJ2);

                start.Tours(panelJ1, panelJ2, J1.nbTourJ1, J2.nbTourJ2);

                vainq.DetermineVainqueur(lblTotalFinalJ1, J1.sommeFinalePartieJ1, lblTotalFinalJ2, J2.sommeFinalePartieJ2, lblJoueur1, lblJoueur2, panelJ1, panelJ2, btnRecommencer);
            }
        }


        #endregion

        #region Click partie droite J2
        private void lblBrelanJ2_Click(object sender, EventArgs e)
        {
            if ((J2.Brelan(lblBrelanJ2, lblTotalFinalDroiteJ2, btnValiderJ2)) == true)
            {
                J2.Valider("J2", lblNbLancerJ2, chBoxD1J2, chBoxD2J2, chBoxD3J2, chBoxD4J2, chBoxD5J2,
               lblD1J2, lblD2J2, lblD3J2, lblD4J2, lblD5J2, lblSomme1J2, lblSomme2J2, lblSomme3J2, lblSomme4J2, lblSomme5J2, lblSomme6J2, lblBrelanJ2,
               lblCarreJ2, lblFullJ2, lblPetiteSuiteJ2, lblGrandeSuiteJ2, lblYathzeeJ2, lblChanceJ2, btnLancerJ2, pbDe1J2, pbDe2J2, pbDe3J2,
               pbDe4J2, pbDe5J2);

               J2.CalculSommeFinale(lblSomme1J2, lblSomme2J2, lblSomme3J2, lblSomme4J2, lblSomme5J2, lblSomme6J2, lblBrelanJ2,
                lblCarreJ2, lblFullJ2, lblPetiteSuiteJ2, lblGrandeSuiteJ2, lblYathzeeJ2, lblChanceJ2, lblTotalFinalGaucheJ2, lblTotalFinalJ2);

                start.Tours(panelJ1, panelJ2, J1.nbTourJ1, J2.nbTourJ2);

                vainq.DetermineVainqueur(lblTotalFinalJ1, J1.sommeFinalePartieJ1, lblTotalFinalJ2, J2.sommeFinalePartieJ2, lblJoueur1, lblJoueur2, panelJ1, panelJ2, btnRecommencer);
            }
        }

        private void lblCarreJ2_Click(object sender, EventArgs e)
        {
            if ((J2.Carre(lblCarreJ2, lblTotalFinalDroiteJ2, btnValiderJ2)) == true)
            {
                J2.Valider("J2", lblNbLancerJ2, chBoxD1J2, chBoxD2J2, chBoxD3J2, chBoxD4J2, chBoxD5J2,
               lblD1J2, lblD2J2, lblD3J2, lblD4J2, lblD5J2, lblSomme1J2, lblSomme2J2, lblSomme3J2, lblSomme4J2, lblSomme5J2, lblSomme6J2, lblBrelanJ2,
               lblCarreJ2, lblFullJ2, lblPetiteSuiteJ2, lblGrandeSuiteJ2, lblYathzeeJ2, lblChanceJ2, btnLancerJ2, pbDe1J2, pbDe2J2, pbDe3J2,
               pbDe4J2, pbDe5J2);

                J2.CalculSommeFinale(lblSomme1J2, lblSomme2J2, lblSomme3J2, lblSomme4J2, lblSomme5J2, lblSomme6J2, lblBrelanJ2,
                 lblCarreJ2, lblFullJ2, lblPetiteSuiteJ2, lblGrandeSuiteJ2, lblYathzeeJ2, lblChanceJ2, lblTotalFinalGaucheJ2, lblTotalFinalJ2);

                start.Tours(panelJ1, panelJ2, J1.nbTourJ1, J2.nbTourJ2);

                vainq.DetermineVainqueur(lblTotalFinalJ1, J1.sommeFinalePartieJ1, lblTotalFinalJ2, J2.sommeFinalePartieJ2, lblJoueur1, lblJoueur2, panelJ1, panelJ2, btnRecommencer);
            }
        }

        private void lblFullJ2_Click(object sender, EventArgs e)
        {
            if ((J2.Full(lblFullJ2, lblTotalFinalDroiteJ2, btnValiderJ2)) == true)
            {
                J2.Valider("J2", lblNbLancerJ2, chBoxD1J2, chBoxD2J2, chBoxD3J2, chBoxD4J2, chBoxD5J2,
               lblD1J2, lblD2J2, lblD3J2, lblD4J2, lblD5J2, lblSomme1J2, lblSomme2J2, lblSomme3J2, lblSomme4J2, lblSomme5J2, lblSomme6J2, lblBrelanJ2,
               lblCarreJ2, lblFullJ2, lblPetiteSuiteJ2, lblGrandeSuiteJ2, lblYathzeeJ2, lblChanceJ2, btnLancerJ2, pbDe1J2, pbDe2J2, pbDe3J2,
               pbDe4J2, pbDe5J2);

                J2.CalculSommeFinale(lblSomme1J2, lblSomme2J2, lblSomme3J2, lblSomme4J2, lblSomme5J2, lblSomme6J2, lblBrelanJ2,
                 lblCarreJ2, lblFullJ2, lblPetiteSuiteJ2, lblGrandeSuiteJ2, lblYathzeeJ2, lblChanceJ2, lblTotalFinalGaucheJ2, lblTotalFinalJ2);

                start.Tours(panelJ1, panelJ2, J1.nbTourJ1, J2.nbTourJ2);

                vainq.DetermineVainqueur(lblTotalFinalJ1, J1.sommeFinalePartieJ1, lblTotalFinalJ2, J2.sommeFinalePartieJ2, lblJoueur1, lblJoueur2, panelJ1, panelJ2, btnRecommencer);
            }
        }

        private void lblPetiteSuiteJ2_Click(object sender, EventArgs e)
        {
            if ((J2.PetiteSuite(lblPetiteSuiteJ2, lblTotalFinalDroiteJ2, btnValiderJ2)) == true)
            {
                J2.Valider("J2", lblNbLancerJ2, chBoxD1J2, chBoxD2J2, chBoxD3J2, chBoxD4J2, chBoxD5J2,
               lblD1J2, lblD2J2, lblD3J2, lblD4J2, lblD5J2, lblSomme1J2, lblSomme2J2, lblSomme3J2, lblSomme4J2, lblSomme5J2, lblSomme6J2, lblBrelanJ2,
               lblCarreJ2, lblFullJ2, lblPetiteSuiteJ2, lblGrandeSuiteJ2, lblYathzeeJ2, lblChanceJ2, btnLancerJ2, pbDe1J2, pbDe2J2, pbDe3J2,
               pbDe4J2, pbDe5J2);

                J2.CalculSommeFinale(lblSomme1J2, lblSomme2J2, lblSomme3J2, lblSomme4J2, lblSomme5J2, lblSomme6J2, lblBrelanJ2,
                 lblCarreJ2, lblFullJ2, lblPetiteSuiteJ2, lblGrandeSuiteJ2, lblYathzeeJ2, lblChanceJ2, lblTotalFinalGaucheJ2, lblTotalFinalJ2);

                start.Tours(panelJ1, panelJ2, J1.nbTourJ1, J2.nbTourJ2);

                vainq.DetermineVainqueur(lblTotalFinalJ1, J1.sommeFinalePartieJ1, lblTotalFinalJ2, J2.sommeFinalePartieJ2, lblJoueur1, lblJoueur2, panelJ1, panelJ2, btnRecommencer);
            }
        }

        private void lblGrandeSuiteJ2_Click(object sender, EventArgs e)
        {
            if ((J2.GrandeSuite(lblGrandeSuiteJ2, lblTotalFinalDroiteJ2, btnValiderJ2)) == true)
            {
                J2.Valider("J2", lblNbLancerJ2, chBoxD1J2, chBoxD2J2, chBoxD3J2, chBoxD4J2, chBoxD5J2,
               lblD1J2, lblD2J2, lblD3J2, lblD4J2, lblD5J2, lblSomme1J2, lblSomme2J2, lblSomme3J2, lblSomme4J2, lblSomme5J2, lblSomme6J2, lblBrelanJ2,
               lblCarreJ2, lblFullJ2, lblPetiteSuiteJ2, lblGrandeSuiteJ2, lblYathzeeJ2, lblChanceJ2, btnLancerJ2, pbDe1J2, pbDe2J2, pbDe3J2,
               pbDe4J2, pbDe5J2);

                J2.CalculSommeFinale(lblSomme1J2, lblSomme2J2, lblSomme3J2, lblSomme4J2, lblSomme5J2, lblSomme6J2, lblBrelanJ2,
                 lblCarreJ2, lblFullJ2, lblPetiteSuiteJ2, lblGrandeSuiteJ2, lblYathzeeJ2, lblChanceJ2, lblTotalFinalGaucheJ2, lblTotalFinalJ2);

                start.Tours(panelJ1, panelJ2, J1.nbTourJ1, J2.nbTourJ2);

                vainq.DetermineVainqueur(lblTotalFinalJ1, J1.sommeFinalePartieJ1, lblTotalFinalJ2, J2.sommeFinalePartieJ2, lblJoueur1, lblJoueur2, panelJ1, panelJ2, btnRecommencer);
            }
        }

        private void lblYathzeeJ2_Click(object sender, EventArgs e)
        {
            if ((J2.Yathzee(lblYathzeeJ2, lblTotalFinalDroiteJ2, btnValiderJ2)) == true)
            {
                J2.Valider("J2", lblNbLancerJ2, chBoxD1J2, chBoxD2J2, chBoxD3J2, chBoxD4J2, chBoxD5J2,
               lblD1J2, lblD2J2, lblD3J2, lblD4J2, lblD5J2, lblSomme1J2, lblSomme2J2, lblSomme3J2, lblSomme4J2, lblSomme5J2, lblSomme6J2, lblBrelanJ2,
               lblCarreJ2, lblFullJ2, lblPetiteSuiteJ2, lblGrandeSuiteJ2, lblYathzeeJ2, lblChanceJ2, btnLancerJ2, pbDe1J2, pbDe2J2, pbDe3J2,
               pbDe4J2, pbDe5J2);

                J2.CalculSommeFinale(lblSomme1J2, lblSomme2J2, lblSomme3J2, lblSomme4J2, lblSomme5J2, lblSomme6J2, lblBrelanJ2,
                 lblCarreJ2, lblFullJ2, lblPetiteSuiteJ2, lblGrandeSuiteJ2, lblYathzeeJ2, lblChanceJ2, lblTotalFinalGaucheJ2, lblTotalFinalJ2);

                start.Tours(panelJ1, panelJ2, J1.nbTourJ1, J2.nbTourJ2);

                vainq.DetermineVainqueur(lblTotalFinalJ1, J1.sommeFinalePartieJ1, lblTotalFinalJ2, J2.sommeFinalePartieJ2, lblJoueur1, lblJoueur2, panelJ1, panelJ2, btnRecommencer);
            }
        }

        private void lblChanceJ2_Click(object sender, EventArgs e)
        {
            if ((J2.Chance(lblChanceJ2, lblTotalFinalDroiteJ2, btnValiderJ2, chBoxD1J2, chBoxD2J2, chBoxD3J2, chBoxD4J2, chBoxD5J2) == true))
            {
                J2.Valider("J2", lblNbLancerJ2, chBoxD1J2, chBoxD2J2, chBoxD3J2, chBoxD4J2, chBoxD5J2,
               lblD1J2, lblD2J2, lblD3J2, lblD4J2, lblD5J2, lblSomme1J2, lblSomme2J2, lblSomme3J2, lblSomme4J2, lblSomme5J2, lblSomme6J2, lblBrelanJ2,
               lblCarreJ2, lblFullJ2, lblPetiteSuiteJ2, lblGrandeSuiteJ2, lblYathzeeJ2, lblChanceJ2, btnLancerJ2, pbDe1J2, pbDe2J2, pbDe3J2,
               pbDe4J2, pbDe5J2);

                J2.CalculSommeFinale(lblSomme1J2, lblSomme2J2, lblSomme3J2, lblSomme4J2, lblSomme5J2, lblSomme6J2, lblBrelanJ2,
                 lblCarreJ2, lblFullJ2, lblPetiteSuiteJ2, lblGrandeSuiteJ2, lblYathzeeJ2, lblChanceJ2, lblTotalFinalGaucheJ2, lblTotalFinalJ2);

                start.Tours(panelJ1, panelJ2, J1.nbTourJ1, J2.nbTourJ2);

                vainq.DetermineVainqueur(lblTotalFinalJ1, J1.sommeFinalePartieJ1, lblTotalFinalJ2, J2.sommeFinalePartieJ2, lblJoueur1, lblJoueur2, panelJ1, panelJ2, btnRecommencer);
            }
        }
        #endregion

        #endregion

        private void btnSauvegarder_Click(object sender, EventArgs e)
        {
            sauvegarde.SauvegardePartieJ1(lblSomme1J1, lblSomme2J1, lblSomme3J1, lblSomme4J1, lblSomme5J1, lblSomme6J1,
            lblTotalSommesJ1, lblPrimeJ1, lblTotalFinalGaucheJ1,
            lblBrelanJ1, lblCarreJ1, lblFullJ1, lblPetiteSuiteJ1, lblGrandeSuiteJ1,
            lblYathzeeJ1, lblChanceJ1, lblTotalFinalDroiteJ1, lblTotalFinalJ1, lblJoueur1, panelJ1);

            sauvegarde.SauvegardePartieJ2(lblSomme1J2, lblSomme2J2, lblSomme3J2, lblSomme4J2, lblSomme5J2, lblSomme6J2,
            lblTotalSommesJ2, lblPrimeJ2, lblTotalFinalGaucheJ2,
            lblBrelanJ2, lblCarreJ2, lblFullJ2, lblPetiteSuiteJ2, lblGrandeSuiteJ2,
            lblYathzeeJ2, lblChanceJ2, lblTotalFinalDroiteJ2, lblTotalFinalJ2, lblJoueur2,panelJ2);
        }

        private void EcranJeu_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Petite indication, une fois la combinaison validée, il suffit de cliquer sur les cases blanches correspondantes pour ajouter les points");
            if (flag == 1) //Si on à cliquer sur charger la sauvegarde dans écran initialisation
            {
               panelJ1.Enabled = false;
               panelJ2.Enabled = false;

                J1.chargeSaveJ1(lblSomme1J1, lblSomme2J1, lblSomme3J1, lblSomme4J1, lblSomme5J1, lblSomme6J1, lblTotalSommesJ1, lblPrimeJ1, lblTotalFinalGaucheJ1, lblBrelanJ1,
               lblCarreJ1, lblFullJ1, lblPetiteSuiteJ1, lblGrandeSuiteJ1, lblYathzeeJ1, lblChanceJ1, lblTotalFinalDroiteJ1, lblTotalFinalJ1, lblJoueur1,panelJ1);

               J2.chargeSaveJ2(lblSomme1J2,lblSomme2J2,lblSomme3J2,lblSomme4J2,lblSomme5J2,lblSomme6J2,lblTotalSommesJ2,lblPrimeJ2,lblTotalFinalGaucheJ2,lblBrelanJ2,
                   lblCarreJ2,lblFullJ2,lblPetiteSuiteJ2,lblGrandeSuiteJ2,lblYathzeeJ2,lblChanceJ2,lblTotalFinalDroiteJ2,lblTotalFinalJ2,lblJoueur2,panelJ2);
            }

            else if (lblCommence.Text == "1")
            {
                panelJ1.Enabled = true;
                panelJ2.Enabled = false;
                J1.nbTourJ1++;

            }
            else if (lblCommence.Text == "2")
            {
                panelJ2.Enabled = true;
                panelJ1.Enabled = false;
                J2.nbTourJ2++;
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnRecommencer_Click(object sender, EventArgs e)
        {
            System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(RecommencerPartie));
            monthread.Start();
            this.Close();
        }

        private void RecommencerPartie()
        {
            EcranInitialisationJeu f = new EcranInitialisationJeu();
            f.ShowDialog();
        }

        private void panelJ2_EnabledChanged(object sender, EventArgs e)
        {
            btnValiderJ2.Visible = true;
        }

        private void panelJ1_EnabledChanged(object sender, EventArgs e)
        {
            btnValiderJ1.Visible = true;
        }

        #endregion



        #region modif click dé J1

        //DE 1 J1
        private void pbDe1J1_Click(object sender, EventArgs e)
        {
            if (cptD1 % 2 == 0)
            {
                int nb = J1.liDe[0];
                J1.CocheCheckBox(nb);
                chBoxD1J1.Checked = true;
                J1.ValiderAvantFinTour(chBoxD1J1, chBoxD2J1, chBoxD3J1, chBoxD4J1, chBoxD5J1, btnValiderJ1);
                cptD1++;
            }
            else if (cptD1 % 2 != 0)
            {
                int nb = J1.liDe[0];
                J1.DecocheCheckbox(nb);
                chBoxD1J1.Checked = false;
                J1.ValiderAvantFinTour(chBoxD1J1, chBoxD2J1, chBoxD3J1, chBoxD4J1, chBoxD5J1, btnValiderJ1);
                cptD1 = 0;
            }
        }

        //DE 2 J1
        private void pbDe2J1_Click(object sender, EventArgs e)
        {
            if (cptD2 % 2 == 0)
            {
                int nb = J1.liDe[1];
                J1.CocheCheckBox(nb);
                chBoxD2J1.Checked = true;
                J1.ValiderAvantFinTour(chBoxD1J1, chBoxD2J1, chBoxD3J1, chBoxD4J1, chBoxD5J1, btnValiderJ1);
                cptD2++;
            }
            else if (cptD2 % 2 != 0)
            {
                int nb = J1.liDe[1];
                J1.DecocheCheckbox(nb);
                chBoxD2J1.Checked = false;
                J1.ValiderAvantFinTour(chBoxD1J1, chBoxD2J1, chBoxD3J1, chBoxD4J1, chBoxD5J1, btnValiderJ1);
                cptD2 = 0;
            }
        }

        //DE 3 J1
        private void pbDe3J1_Click(object sender, EventArgs e)
        {
            if (cptD3 % 2 == 0)
            {
                int nb = J1.liDe[2];
                J1.CocheCheckBox(nb);
                chBoxD3J1.Checked = true;
                J1.ValiderAvantFinTour(chBoxD1J1, chBoxD2J1, chBoxD3J1, chBoxD4J1, chBoxD5J1, btnValiderJ1);
                cptD3++;
            }
            else if (cptD3 % 2 != 0)
            {
                int nb = J1.liDe[2];
                J1.DecocheCheckbox(nb);
                chBoxD3J1.Checked = false;
                J1.ValiderAvantFinTour(chBoxD1J1, chBoxD2J1, chBoxD3J1, chBoxD4J1, chBoxD5J1, btnValiderJ1);
                cptD3 = 0;
            }
        }

        //DE 4 J1

        private void pbDe4J1_Click(object sender, EventArgs e)
        {
            if (cptD4 % 2 == 0)
            {
                int nb = J1.liDe[3];
                J1.CocheCheckBox(nb);
                chBoxD4J1.Checked = true;
                J1.ValiderAvantFinTour(chBoxD1J1, chBoxD2J1, chBoxD3J1, chBoxD4J1, chBoxD5J1, btnValiderJ1);
                cptD4++;
            }
            else if (cptD4 % 2 != 0)
            {
                int nb = J1.liDe[3];
                J1.DecocheCheckbox(nb);
                chBoxD4J1.Checked = false;
                J1.ValiderAvantFinTour(chBoxD1J1, chBoxD2J1, chBoxD3J1, chBoxD4J1, chBoxD5J1, btnValiderJ1);
                cptD4 = 0;
            }
        }

        //DE 5 J1

        private void pbDe5J1_Click(object sender, EventArgs e)
        {
            if (cptD5% 2 == 0)
            {
                int nb = J1.liDe[4];
                J1.CocheCheckBox(nb);
                chBoxD5J1.Checked = true;
                J1.ValiderAvantFinTour(chBoxD1J1, chBoxD2J1, chBoxD3J1, chBoxD4J1, chBoxD5J1, btnValiderJ1);
                cptD5++;
            }
            else if (cptD5 % 2 != 0)
            {
                int nb = J1.liDe[4];
                J1.DecocheCheckbox(nb);
                chBoxD5J1.Checked = false;
                J1.ValiderAvantFinTour(chBoxD1J1, chBoxD2J1, chBoxD3J1, chBoxD4J1, chBoxD5J1, btnValiderJ1);
                cptD5 = 0;
            }
        }
        #endregion


        #region Modif click dé J2
        private void pbDe1J2_Click(object sender, EventArgs e)
        {
            if (cptD1J2 % 2 == 0)
            {
                int nb = J2.liDe[0] ; ;
                J2.CocheCheckBox(nb);
                chBoxD1J2.Checked = true;
                J2.ValiderAvantFinTour(chBoxD1J2, chBoxD2J2, chBoxD3J2, chBoxD4J2, chBoxD5J2, btnValiderJ2);
                cptD1J2++;
            }
            else if (cptD1J2 % 2 != 0)
            {
                int nb = J2.liDe[0];
                J2.DecocheCheckbox(nb);
                chBoxD1J2.Checked = false;
                J2.ValiderAvantFinTour(chBoxD1J2, chBoxD2J2, chBoxD3J2, chBoxD4J2, chBoxD5J2, btnValiderJ2);
                cptD1J2 = 0;
            }
        }

        //DE 2 J2
        private void pbDe2J2_Click(object sender, EventArgs e)
        {
            if (cptD2J2 % 2 == 0)
            {
                int nb = J2.liDe[1];
                J2.CocheCheckBox(nb);
                chBoxD2J2.Checked = true;
                J2.ValiderAvantFinTour(chBoxD1J2, chBoxD2J2, chBoxD3J2, chBoxD4J2, chBoxD5J2, btnValiderJ2);
                cptD2J2++;
            }
            else if (cptD2J2 % 2 != 0)
            {
                int nb = J2.liDe[1];
                J2.DecocheCheckbox(nb);
                chBoxD2J2.Checked = false;
                J2.ValiderAvantFinTour(chBoxD1J2, chBoxD2J2, chBoxD3J2, chBoxD4J2, chBoxD5J2, btnValiderJ2);
                cptD2J2 = 0;
            }
        }

        //DE3 J2
        private void pbDe3J2_Click(object sender, EventArgs e)
        {
            if (cptD3J2 % 2 == 0)
            {
                int nb = J2.liDe[2];
                J2.CocheCheckBox(nb);
                chBoxD3J2.Checked = true;
                J2.ValiderAvantFinTour(chBoxD1J2, chBoxD2J2, chBoxD3J2, chBoxD4J2, chBoxD5J2, btnValiderJ2);
                cptD3J2++;
            }
            else if (cptD3J2 % 2 != 0)
            {
                int nb = J2.liDe[2];
                J2.DecocheCheckbox(nb);
                chBoxD3J2.Checked = false;
                J2.ValiderAvantFinTour(chBoxD1J2, chBoxD2J2, chBoxD3J2, chBoxD4J2, chBoxD5J2, btnValiderJ2);
                cptD3J2 = 0;
            }
        }


        //DE4 J2

        private void pbDe4J2_Click(object sender, EventArgs e)
        {
            if (cptD4J2 % 2 == 0)
            {
                int nb = J2.liDe[3];
                J2.CocheCheckBox(nb);
                chBoxD4J2.Checked = true;
                J2.ValiderAvantFinTour(chBoxD1J2, chBoxD2J2, chBoxD3J2, chBoxD4J2, chBoxD5J2, btnValiderJ2);
                cptD4J2++;
            }
            else if (cptD4J2 % 2 != 0)
            {
                int nb = J2.liDe[3];
                J2.DecocheCheckbox(nb);
                chBoxD4J2.Checked = false;
                J2.ValiderAvantFinTour(chBoxD1J2, chBoxD2J2, chBoxD3J2, chBoxD4J2, chBoxD5J2, btnValiderJ2);
                cptD4J2 = 0;
            }
        }

        //de5 J2
        private void pbDe5J2_Click(object sender, EventArgs e)
        {
            if (cptD5J2 % 2 == 0)
            {
                int nb = J2.liDe[4];
                J2.CocheCheckBox(nb);
                chBoxD5J2.Checked = true;
                J2.ValiderAvantFinTour(chBoxD1J2, chBoxD2J2, chBoxD3J2, chBoxD4J2, chBoxD5J2, btnValiderJ2);
                cptD5J2++;
            }
            else if (cptD5J2 % 2 != 0)
            {
                int nb = J2.liDe[4];
                J2.DecocheCheckbox(nb);
                chBoxD5J2.Checked = false;
                J2.ValiderAvantFinTour(chBoxD1J2, chBoxD2J2, chBoxD3J2, chBoxD4J2, chBoxD5J2, btnValiderJ2);
                cptD5J2 = 0;
            }
        }

        #endregion


    }
}
