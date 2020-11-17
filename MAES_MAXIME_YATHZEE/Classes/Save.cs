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
    class Save
    {
        #region Initialisaton des variables
        #endregion

        #region Constructeur Start
        public Save()
        {

        }
        #endregion

        #region Méthodes

        public void SauvegardePartieJ1(Label lblSomme1J1, Label lblSomme2J1, Label lblSomme3J1, Label lblSomme4J1, Label lblSomme5J1, Label lblSomme6J1,
            Label lblTotalSommesJ1, Label lblPrimeJ1,Label lblTotalFinalGaucheJ1,
            Label lblBrelanJ1, Label lblCarreJ1, Label lblFullJ1, Label lblPetiteSuiteJ1, Label lblGrandeSuiteJ1,
            Label lblYathzeeJ1, Label lblChanceJ1, Label lblTotalFinalDroiteJ1, Label lblTotalFinalJ1, Label lblNomJoueur1,Panel pJ1)
        {

            StreamWriter save = new StreamWriter("saveJ1.txt");

            #region Joueur 1
            //SAVE J1

            //Partie gauche
            save.WriteLine(lblSomme1J1.Text.ToString());
            save.WriteLine(lblSomme2J1.Text.ToString());
            save.WriteLine(lblSomme3J1.Text.ToString());
            save.WriteLine(lblSomme4J1.Text.ToString());
            save.WriteLine(lblSomme5J1.Text.ToString());
            save.WriteLine(lblSomme6J1.Text.ToString());
            save.WriteLine(lblTotalSommesJ1.Text.ToString());
            save.WriteLine(lblPrimeJ1.Text.ToString());
            save.WriteLine(lblTotalFinalGaucheJ1.Text.ToString());

            //Partie droite
            save.WriteLine(lblBrelanJ1.Text.ToString());
            save.WriteLine(lblCarreJ1.Text.ToString());
            save.WriteLine(lblFullJ1.Text.ToString());
            save.WriteLine(lblPetiteSuiteJ1.Text.ToString());
            save.WriteLine(lblGrandeSuiteJ1.Text.ToString());
            save.WriteLine(lblYathzeeJ1.Text.ToString());
            save.WriteLine(lblChanceJ1.Text.ToString());
            save.WriteLine(lblTotalFinalDroiteJ1.Text.ToString());
            save.WriteLine(lblTotalFinalJ1.Text.ToString());
            #endregion


            save.WriteLine(pJ1.Enabled.ToString());
            save.WriteLine(lblNomJoueur1.Text.ToString());


            save.WriteLine("STOP"); //Pour marquer un arrêt différent du vide car parfois on sauvegarde du vide dans les champs

            //FIN SAVE

            save.Close();
        }

        public void SauvegardePartieJ2(Label lblSomme1J2, Label lblSomme2J2, Label lblSomme3J2, Label lblSomme4J2, Label lblSomme5J2, Label lblSomme6J2,
            Label lblTotalSommesJ2, Label lblPrimeJ2, Label lblTotalFinalGaucheJ2,
            Label lblBrelanJ2, Label lblCarreJ2, Label lblFullJ2, Label lblPetiteSuiteJ2, Label lblGrandeSuiteJ2,
            Label lblYathzeeJ2, Label lblChanceJ2, Label lblTotalFinalDroiteJ2, Label lblTotalFinalJ2, Label lblNomJoueur2, Panel pJ2)
        {
            StreamWriter save = new StreamWriter("saveJ2.txt");

            #region Joueur 2
            //SAVE J2

            //Partie gauche
            save.WriteLine(lblSomme1J2.Text.ToString());
            save.WriteLine(lblSomme2J2.Text.ToString());
            save.WriteLine(lblSomme3J2.Text.ToString());
            save.WriteLine(lblSomme4J2.Text.ToString());
            save.WriteLine(lblSomme5J2.Text.ToString());
            save.WriteLine(lblSomme6J2.Text.ToString());
            save.WriteLine(lblTotalSommesJ2.Text.ToString());
            save.WriteLine(lblPrimeJ2.Text.ToString());
            save.WriteLine(lblTotalFinalGaucheJ2.Text.ToString());

            //Partie droite
            save.WriteLine(lblBrelanJ2.Text.ToString());
            save.WriteLine(lblCarreJ2.Text.ToString());
            save.WriteLine(lblFullJ2.Text.ToString());
            save.WriteLine(lblPetiteSuiteJ2.Text.ToString());
            save.WriteLine(lblGrandeSuiteJ2.Text.ToString());
            save.WriteLine(lblYathzeeJ2.Text.ToString());
            save.WriteLine(lblChanceJ2.Text.ToString());
            save.WriteLine(lblTotalFinalDroiteJ2.Text.ToString());
            save.WriteLine(lblTotalFinalJ2.Text.ToString());

            save.WriteLine(pJ2.Enabled.ToString());
            save.WriteLine(lblNomJoueur2.Text.ToString());

            #endregion

            save.WriteLine("STOP"); //Pour marquer un arrêt différent du vide car parfois on sauvegarde du vide dans les champs

            //FIN SAVE

            save.Close();
        }
    }
        #endregion
    }
