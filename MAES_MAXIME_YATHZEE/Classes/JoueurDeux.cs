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
using System.IO;

namespace MAES_MAXIME_YATHZEE
{
    class JoueurDeux
    {
        #region Initialisation des variables
        DesactiveActiveLbl desactiveActive = new DesactiveActiveLbl(); //

        public string nomJ2;
        public int nbLancerRestJ2;
        public int somme1J2, somme2J2, somme3J2, somme4J2, somme5J2, somme6J2;
        public int primeJ2;
        public int sommeYathzeeJ2, sommeChanceJ2, sommeBrelanJ2, sommeCarreJ2, fullJ2, pSuiteJ2, gSuiteJ2;
        public int totSommeJ2;
        public int totFinalGaucheJ2, totFinalDroiteJ2;
        public int sommeFinalePartieJ2;
        public int nbTourJ2;

        public ArrayList liChoixModifJ2 = new ArrayList(); //Pour stocker les valeurs choisies par le J1

        public int[] liDe = new int[5]; //Pour stocker les valeurs des 5 dés
        #endregion

        #region Constructeur Joueur J1
        public JoueurDeux()
        {
            this.nomJ2 = "J2";
            this.nbLancerRestJ2 = 3;
            this.nbTourJ2 = 0;

            #region Partie gauche (SOMMES 1 à 6 J2 + totSommeJ2 + primeJ2 + totFinalGaucheJ2)
            this.somme1J2 = 0;
            this.somme2J2 = 0;
            this.somme3J2 = 0;
            this.somme4J2 = 0;
            this.somme5J2 = 0;
            this.somme6J2 = 0;

            this.totSommeJ2 = 0;

            this.primeJ2 = 0;

            this.totFinalGaucheJ2 = 0;

            #endregion

            #region Partie droite (BrelanJ2 + CarreJ2 + FullJ2 + pSuiteJ2 + gSuiteJ2 + yathzeeJ2 + chanceJ2)
            this.sommeBrelanJ2 = 0;
            this.sommeCarreJ2 = 0;
            this.fullJ2 = 0;
            this.pSuiteJ2 = 0;
            this.gSuiteJ2 = 0;
            this.sommeYathzeeJ2 = 0;
            this.sommeChanceJ2 = 0;

            this.totFinalDroiteJ2 = 0;

            this.sommeFinalePartieJ2 = 0;
            #endregion

        }
        #endregion

        #region Méthodes
        public void LancerJ2(CheckBox cbD1, CheckBox cbD2, CheckBox cbD3, CheckBox cbD4, CheckBox cbD5,
            PictureBox pb1, PictureBox pb2, PictureBox pb3, PictureBox pb4, PictureBox pb5,
            Label lbl1, Label lbl2, Label lbl3, Label lbl4, Label lbl5, Random aleatoire)
        {
            #region Lancer dé 1 J2
            if (cbD1.Checked == false)
            {
                liDe[0] = aleatoire.Next(1, 7);
                lbl1.Text = liDe[0].ToString();

                if (liDe[0] == 1)
                {
                    pb1.Image = global::MAES_MAXIME_YATHZEE.Properties.Resources.de1;
                }
                else if (liDe[0] == 2)
                {
                    pb1.Image = global::MAES_MAXIME_YATHZEE.Properties.Resources.de2;
                }
                else if (liDe[0] == 3)
                {
                    pb1.Image = global::MAES_MAXIME_YATHZEE.Properties.Resources.de3;
                }
                else if (liDe[0] == 4)
                {
                    pb1.Image = global::MAES_MAXIME_YATHZEE.Properties.Resources.de4;
                }
                else if (liDe[0] == 5)
                {
                    pb1.Image = global::MAES_MAXIME_YATHZEE.Properties.Resources.de5;
                }
                else if (liDe[0] == 6)
                {
                    pb1.Image = global::MAES_MAXIME_YATHZEE.Properties.Resources.de6;
                }
            }
            #endregion

            #region Lancer dé 2 J2
            if (cbD2.Checked == false)
            {
                liDe[1] = aleatoire.Next(1, 7);
                lbl2.Text = liDe[1].ToString();

                if (liDe[1] == 1)
                {
                    pb2.Image = global::MAES_MAXIME_YATHZEE.Properties.Resources.de1;
                }
                else if (liDe[1] == 2)
                {
                    pb2.Image = global::MAES_MAXIME_YATHZEE.Properties.Resources.de2;
                }
                else if (liDe[1] == 3)
                {
                    pb2.Image = global::MAES_MAXIME_YATHZEE.Properties.Resources.de3;
                }
                else if (liDe[1] == 4)
                {
                    pb2.Image = global::MAES_MAXIME_YATHZEE.Properties.Resources.de4;
                }
                else if (liDe[1] == 5)
                {
                    pb2.Image = global::MAES_MAXIME_YATHZEE.Properties.Resources.de5;
                }
                else if (liDe[1] == 6)
                {
                    pb2.Image = global::MAES_MAXIME_YATHZEE.Properties.Resources.de6;
                }
            }
            #endregion

            #region Lancer dé 3 J2
            if (cbD3.Checked == false)
            {
                liDe[2] = aleatoire.Next(1, 7);
                lbl3.Text = liDe[2].ToString();

                if (liDe[2] == 1)
                {
                    pb3.Image = global::MAES_MAXIME_YATHZEE.Properties.Resources.de1;
                }
                else if (liDe[2] == 2)
                {
                    pb3.Image = global::MAES_MAXIME_YATHZEE.Properties.Resources.de2;
                }
                else if (liDe[2] == 3)
                {
                    pb3.Image = global::MAES_MAXIME_YATHZEE.Properties.Resources.de3;
                }
                else if (liDe[2] == 4)
                {
                    pb3.Image = global::MAES_MAXIME_YATHZEE.Properties.Resources.de4;
                }
                else if (liDe[2] == 5)
                {
                    pb3.Image = global::MAES_MAXIME_YATHZEE.Properties.Resources.de5;
                }
                else if (liDe[2] == 6)
                {
                    pb3.Image = global::MAES_MAXIME_YATHZEE.Properties.Resources.de6;
                }
            }
            #endregion

            #region Lancer dé 4 J2
            if (cbD4.Checked == false)
            {
                liDe[3] = aleatoire.Next(1, 7);
                lbl4.Text = liDe[3].ToString();

                if (liDe[3] == 1)
                {
                    pb4.Image = global::MAES_MAXIME_YATHZEE.Properties.Resources.de1;
                }
                else if (liDe[3] == 2)
                {
                    pb4.Image = global::MAES_MAXIME_YATHZEE.Properties.Resources.de2;
                }
                else if (liDe[3] == 3)
                {
                    pb4.Image = global::MAES_MAXIME_YATHZEE.Properties.Resources.de3;
                }
                else if (liDe[3] == 4)
                {
                    pb4.Image = global::MAES_MAXIME_YATHZEE.Properties.Resources.de4;
                }
                else if (liDe[3] == 5)
                {
                    pb4.Image = global::MAES_MAXIME_YATHZEE.Properties.Resources.de5;
                }
                else if (liDe[3] == 6)
                {
                    pb4.Image = global::MAES_MAXIME_YATHZEE.Properties.Resources.de6;
                }
            }
            #endregion

            #region Lancer dé 5 J2
            if (cbD5.Checked == false)
            {
                liDe[4] = aleatoire.Next(1, 7);
                lbl5.Text = liDe[4].ToString();

                if (liDe[4] == 1)
                {
                    pb5.Image = global::MAES_MAXIME_YATHZEE.Properties.Resources.de1;
                }
                else if (liDe[4] == 2)
                {
                    pb5.Image = global::MAES_MAXIME_YATHZEE.Properties.Resources.de2;
                }
                else if (liDe[4] == 3)
                {
                    pb5.Image = global::MAES_MAXIME_YATHZEE.Properties.Resources.de3;
                }
                else if (liDe[4] == 4)
                {
                    pb5.Image = global::MAES_MAXIME_YATHZEE.Properties.Resources.de4;
                }
                else if (liDe[4] == 5)
                {
                    pb5.Image = global::MAES_MAXIME_YATHZEE.Properties.Resources.de5;
                }
                else if (liDe[4] == 6)
                {
                    pb5.Image = global::MAES_MAXIME_YATHZEE.Properties.Resources.de6;
                }
            }
            #endregion
        }

        public void Valider(string nbJoueur, Label labelNbLancer,
            CheckBox chBoxD1, CheckBox chBoxD2, CheckBox chBoxD3, CheckBox chBoxD4, CheckBox chBoxD5,
            Label lblD1, Label lblD2, Label lblD3, Label lblD4, Label lblD5,
            Label lblSomme1, Label lblSomme2, Label lblSomme3,
            Label lblSomme4, Label lblSomme5, Label lblSomme6, Label lblBrelan,
            Label lblCarre, Label lblFull, Label lblPSuite, Label lblGSuite,
            Label lblYathzee, Label lblChance, Button btnLancer,
            PictureBox pb1, PictureBox pb2, PictureBox pb3, PictureBox pb4, PictureBox pb5)

        {

            //cptJ1++;

            if (nbJoueur == "J2")
            {
                nbLancerRestJ2 = 3;
            }

            labelNbLancer.Text = ("Nombre de lancer(s) restant(s) : 3");

            chBoxD1.Enabled = chBoxD1.Checked = false;
            chBoxD2.Enabled = chBoxD2.Checked = false;
            chBoxD3.Enabled = chBoxD3.Checked = false;
            chBoxD4.Enabled = chBoxD4.Checked = false;
            chBoxD5.Enabled = chBoxD5.Checked = false;


            lblD1.Text = 0.ToString();
            lblD2.Text = 0.ToString();
            lblD3.Text = 0.ToString();
            lblD4.Text = 0.ToString();
            lblD5.Text = 0.ToString();

            desactiveActive.desactiveTout(lblSomme1, lblSomme2, lblSomme3, lblSomme4, lblSomme5, lblSomme6,
                lblBrelan, lblChance, lblFull, lblPSuite, lblGSuite, lblYathzee, lblChance);

            pb1.Image = global::MAES_MAXIME_YATHZEE.Properties.Resources.de6;
            pb2.Image = global::MAES_MAXIME_YATHZEE.Properties.Resources.de6;
            pb3.Image = global::MAES_MAXIME_YATHZEE.Properties.Resources.de6;
            pb4.Image = global::MAES_MAXIME_YATHZEE.Properties.Resources.de6;
            pb5.Image = global::MAES_MAXIME_YATHZEE.Properties.Resources.de6;

            btnLancer.Enabled = true;
        }

        public void CocheCheckBox(int nb) //Ajouter le chiffre cocher dans la liste
        {
            liChoixModifJ2.Add(nb); //Ajout du chiffre dans l'arrayList
        }

        public void DecocheCheckbox(int nb) //Supprimer le chiffre décoché de la liste
        {
            int nb1 = nb;
            int nbFois = 0;

            string result = System.String.Concat(liChoixModifJ2.ToArray());

            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] == (char)nb1)
                {
                    nbFois++; //Calcul cb de fois est présent le nb à supprimer
                }
            }

            if (liChoixModifJ2.Contains(nb1))
            {
                liChoixModifJ2.Remove(nb1);
            }

            if (nbFois > 1) //Pour ne pas supprimer tous les 4 si on veut seulement en supprimer un
            {
                for (int h = 0; h < nbFois - 1; h++)
                {
                    liChoixModifJ2.Add(nb1);
                }
            }

            string result2 = System.String.Concat(liChoixModifJ2.ToArray());

        }

        public void chargeSaveJ2(Label lblSomme1J2, Label lblSomme2J2, Label lblSomme3J2, Label lblSomme4J2, Label lblSomme5J2, Label lblSomme6J2,
            Label lblTotalSommesJ2, Label lblPrimeJ2, Label lblTotalFinalGaucheJ2,
            Label lblBrelanJ2, Label lblCarreJ2, Label lblFullJ2, Label lblPetiteSuiteJ2, Label lblGrandeSuiteJ2,
            Label lblYathzeeJ2, Label lblChanceJ2, Label lblTotalFinalDroiteJ2, Label lblTotalFinalJ2, Label lblNomJoueur2, Panel pj2)
        {
            int i = 0;

            using (StreamReader save = new StreamReader("saveJ2.txt"))
            {
                string line;
                // Read and display lines from the file until the end of 
                // the file is reached.
                while ((line = save.ReadLine()) != "STOP")
                {
                    #region JOUEUR 2
                    if (i == 0) //Somme 1 J2
                    {
                        if (line != "")
                        {
                            somme1J2 = int.Parse(line);
                            lblSomme1J2.Text = somme1J2.ToString();
                        }
                    }
                    else if (i == 1) //Somme 2 J2
                    {
                        if (line != "")
                        {
                            somme2J2 = int.Parse(line);
                            lblSomme2J2.Text = somme2J2.ToString();
                        }
                    }
                    else if (i == 2) //Somme 3 J2
                    {
                        if (line != "")
                        {
                            somme3J2 = int.Parse(line);
                            lblSomme3J2.Text = somme3J2.ToString();
                        }
                    }
                    else if (i == 3) //Somme 4 J2
                    {
                        if (line != "")
                        {
                            somme4J2 = int.Parse(line);
                            lblSomme4J2.Text = somme4J2.ToString();
                        }
                    }
                    else if (i == 4) //Somme 5 J2
                    {
                        if (line != "")
                        {
                            somme5J2 = int.Parse(line);
                            lblSomme5J2.Text = somme5J2.ToString();
                        }
                    }
                    else if (i == 5) //Somme 6 J2
                    {
                        if (line != "")
                        {
                            somme6J2 = int.Parse(line);
                            lblSomme6J2.Text = somme6J2.ToString();
                        }
                    }
                    else if (i == 6) //Total sommes J2
                    {
                        if (line != "")
                        {
                            totSommeJ2 = int.Parse(line);
                            lblTotalSommesJ2.Text = totSommeJ2.ToString();
                        }
                    }

                    else if (i == 7) //Prime J2
                    {
                        if (line != "")
                        {
                            lblPrimeJ2.Text += line.ToString();
                        }
                    }

                    else if (i == 8) //totFinalGauche J2
                    {
                        if (line != "")
                        {
                            totFinalGaucheJ2 = int.Parse(line);
                            lblTotalFinalGaucheJ2.Text = totFinalGaucheJ2.ToString();
                        }
                    }

                    else if (i == 9) //Brelan J2
                    {
                        if (line != "")
                        {
                            sommeBrelanJ2 = int.Parse(line);
                            lblBrelanJ2.Text = sommeBrelanJ2.ToString();
                        }
                    }

                    else if (i == 10) //Carre J2
                    {
                        if (line != "")
                        {
                            sommeCarreJ2 = int.Parse(line);
                            lblCarreJ2.Text = sommeCarreJ2.ToString();
                        }
                    }

                    else if (i == 11) //Full J2
                    {
                        if (line != "")
                        {
                            lblFullJ2.Text = line;
                        }
                    }

                    else if (i == 12) //Petite suite J2
                    {
                        if (line != "")
                        {
                            lblPetiteSuiteJ2.Text = line;
                        }
                    }

                    else if (i == 13) //Grande suite J2
                    {
                        if (line != "")
                        {
                            lblGrandeSuiteJ2.Text = line;
                        }
                    }

                    else if (i == 14) //Yathzee J2
                    {
                        if (line != "")
                        {
                            lblYathzeeJ2.Text = line;
                        }
                    }

                    else if (i == 15) //Chance J2
                    {
                        if (line != "")
                        {
                            sommeChanceJ2 = int.Parse(line);
                            lblChanceJ2.Text = sommeChanceJ2.ToString();
                        }
                    }

                    else if (i == 16) //Tot final droite J2
                    {
                        if (line != "")
                        {
                            totFinalDroiteJ2 = int.Parse(line);
                            lblTotalFinalDroiteJ2.Text = totFinalDroiteJ2.ToString();
                        }
                    }

                    else if (i == 17) //Tot final J2
                    {
                        if (line != "")
                        {
                            sommeFinalePartieJ2 = int.Parse(line);
                            lblTotalFinalJ2.Text = sommeFinalePartieJ2.ToString();
                        }
                    }

                    else if (i == 18) //Panel J2
                    {
                        if (line == "True")
                        {
                            pj2.Enabled = true;
                        }
                        else if (line == "False")
                        {
                            pj2.Enabled = false;
                        }
                    }

                    else if (i == 19) //Nom J2
                    {
                        if (line != "")
                        {
                            lblNomJoueur2.Text = line;
                        }
                    }


                    i++;
                    // Suspend the screen.  
                    System.Console.ReadLine();
                }
                save.Close();
                #endregion
            }
        }

        public void ValiderAvantFinTour(CheckBox chBox1, CheckBox chBox2, CheckBox chBox3, CheckBox chBox4, CheckBox chBox5, Button btnValider)
        {
            if (chBox1.Checked == true && chBox2.Checked == true && chBox3.Checked == true && chBox4.Checked == true && chBox5.Checked == true)
            {
                btnValider.Enabled = true;
            }
            else if (chBox1.Checked == false || chBox2.Checked == false || chBox3.Checked == false || chBox4.Checked == false || chBox5.Checked == false)
            {

                if (nbLancerRestJ2 == 0)
                {
                    btnValider.Enabled = true;
                }
                else
                {
                    btnValider.Enabled = false;
                }
            }
        }


        #region Fonctions partie Gauche Sommes de 1 à 6 + PRIME (J2)

        public bool Somme1(Label lblSomme1, Label lblTotalSommes, Button btnValider)
        {
            string result = System.String.Concat(liChoixModifJ2.ToArray());

            if (result.Contains('1'))
            {
                for (int i = 0; i < result.Length; i++)
                {
                    if (result[i] == '1')
                    {
                        somme1J2++;
                    }
                }

                lblSomme1.Text = somme1J2.ToString();
                lblSomme1.Enabled = false;
                btnValider.Enabled = false;
                totSommeJ2 += somme1J2;
                lblTotalSommes.Text = totSommeJ2.ToString();
                return true;
            }
            else
            {
                EcranZeroPoint f = new EcranZeroPoint();
                f.lblZero.Text = "Il n'y a pas de 1 dans votre sélection de chiffre, voulez vous confirmer les 0 points pour cette case?";
                f.ShowDialog();
                if (f.choix == 1)
                {
                    somme1J2 = 0;
                    lblSomme1.Text = somme1J2.ToString();
                    lblSomme1.Enabled = false;
                    btnValider.Enabled = false;
                    return true;
                }
                else
                {
                    f.Close();
                    return false;
                }
            }
        }

        public bool Somme2(Label lblSomme2, Label lblTotalSommes, Button btnValider)
        {
            string result = System.String.Concat(liChoixModifJ2.ToArray());

            if (result.Contains('2'))
            {
                for (int i = 0; i < result.Length; i++)
                {
                    if (result[i] == '2')
                    {
                        somme2J2 += 2;
                    }
                }

                lblSomme2.Text = somme2J2.ToString();
                lblSomme2.Enabled = false;
                btnValider.Enabled = false;
                totSommeJ2 += somme2J2;
                lblTotalSommes.Text = totSommeJ2.ToString();
                return true;
            }
            else
            {
                EcranZeroPoint f = new EcranZeroPoint();
                f.lblZero.Text = "Il n'y a pas de 2 dans votre sélection de chiffre, voulez vous confirmer les 0 points pour cette case?";
                f.ShowDialog();
                if (f.choix == 1)
                {
                    somme2J2 = 0;
                    lblSomme2.Text = somme2J2.ToString();
                    lblSomme2.Enabled = false;
                    btnValider.Enabled = false;
                    return true;
                }
                else
                {
                    f.Close();
                    return false;
                }
            }
        }

        public bool Somme3(Label lblSomme3, Label lblTotalSommes, Button btnValider)
        {
            string result = System.String.Concat(liChoixModifJ2.ToArray());

            if (result.Contains('3'))
            {
                for (int i = 0; i < result.Length; i++)
                {
                    if (result[i] == '3')
                    {
                        somme3J2 += 3;
                    }
                }

                lblSomme3.Text = somme3J2.ToString();
                lblSomme3.Enabled = false;
                btnValider.Enabled = false;
                totSommeJ2 += somme3J2;
                lblTotalSommes.Text = totSommeJ2.ToString();
                return true;
            }
            else
            {
                EcranZeroPoint f = new EcranZeroPoint();
                f.lblZero.Text = "Il n'y a pas de 3 dans votre sélection de chiffre, voulez vous confirmer les 0 points pour cette case?";
                f.ShowDialog();
                if (f.choix == 1)
                {
                    somme2J2 = 0;
                    lblSomme3.Text = somme2J2.ToString();
                    lblSomme3.Enabled = false;
                    btnValider.Enabled = false;
                    return true;
                }
                else
                {
                    f.Close();
                    return false;
                }
            }
        }

        public bool Somme4(Label lblSomme4, Label lblTotalSommes, Button btnValider)
        {
            string result = System.String.Concat(liChoixModifJ2.ToArray());

            if (result.Contains('4'))
            {
                for (int i = 0; i < result.Length; i++)
                {
                    if (result[i] == '4')
                    {
                        somme4J2 += 4;
                    }
                }

                lblSomme4.Text = somme4J2.ToString();
                lblSomme4.Enabled = false;
                btnValider.Enabled = false;
                totSommeJ2 += somme4J2;
                lblTotalSommes.Text = totSommeJ2.ToString();
                return true;
            }
            else
            {
                EcranZeroPoint f = new EcranZeroPoint();
                f.lblZero.Text = "Il n'y a pas de 4 dans votre sélection de chiffre, voulez vous confirmer les 0 points pour cette case?";
                f.ShowDialog();
                if (f.choix == 1)
                {
                    somme4J2 = 0;
                    lblSomme4.Text = somme4J2.ToString();
                    lblSomme4.Enabled = false;
                    btnValider.Enabled = false;
                    return true;
                }
                else
                {
                    f.Close();
                    return false;
                }
            }
        }

        public bool Somme5(Label lblSomme5, Label lblTotalSommes, Button btnValider)
        {
            string result = System.String.Concat(liChoixModifJ2.ToArray());

            if (result.Contains('5'))
            {
                for (int i = 0; i < result.Length; i++)
                {
                    if (result[i] == '5')
                    {
                        somme5J2 += 5;
                    }
                }

                lblSomme5.Text = somme5J2.ToString();
                lblSomme5.Enabled = false;
                btnValider.Enabled = false;
                totSommeJ2 += somme5J2;
                lblTotalSommes.Text = totSommeJ2.ToString();
                return true;
            }
            else
            {
                EcranZeroPoint f = new EcranZeroPoint();
                f.lblZero.Text = "Il n'y a pas de 5 dans votre sélection de chiffre, voulez vous confirmer les 0 points pour cette case?";
                f.ShowDialog();
                if (f.choix == 1)
                {
                    somme5J2 = 0;
                    lblSomme5.Text = somme5J2.ToString();
                    lblSomme5.Enabled = false;
                    btnValider.Enabled = false;
                    return true;
                }
                else
                {
                    f.Close();
                    return false;
                }
            }
        }

        public bool Somme6(Label lblSomme6, Label lblTotalSommes, Button btnValider)
        {
            string result = System.String.Concat(liChoixModifJ2.ToArray());

            if (result.Contains('6'))
            {
                for (int i = 0; i < result.Length; i++)
                {
                    if (result[i] == '6')
                    {
                        somme6J2 += 6;
                    }
                }

                lblSomme6.Text = somme6J2.ToString();
                lblSomme6.Enabled = false;
                btnValider.Enabled = false;
                totSommeJ2 += somme6J2;
                lblTotalSommes.Text = totSommeJ2.ToString();
                return true;
            }
            else
            {
                EcranZeroPoint f = new EcranZeroPoint();
                f.lblZero.Text = "Il n'y a pas de 6 dans votre sélection de chiffre, voulez vous confirmer les 0 points pour cette case?";
                f.ShowDialog();
                if (f.choix == 1)
                {
                    somme6J2 = 0;
                    lblSomme6.Text = somme6J2.ToString();
                    lblSomme6.Enabled = false;
                    btnValider.Enabled = false;
                    return true;
                }
                else
                {
                    f.Close();
                    return false;
                }
            }
        }

        public void DefinirPrime(Label lblSomme1, Label lblSomme2, Label lblSomme3,
           Label lblSomme4, Label lblSomme5, Label lblSomme6, Label lblTotalSommes, Label lblTotFinalGauche, Label lblPrime)
        {
            if (lblSomme1.Text != "" && lblSomme2.Text != "" && lblSomme3.Text != "" &&
                lblSomme4.Text != "" && lblSomme5.Text != "" && lblSomme6.Text != "")
            {
                int nbPoints = int.Parse(lblTotalSommes.Text);
                if (nbPoints >= 63)
                {
                    lblPrime.Text = "35";
                    lblTotalSommes.Text = totSommeJ2.ToString();
                    totFinalGaucheJ2 = totSommeJ2 + 35;
                    lblTotFinalGauche.Text = totFinalGaucheJ2.ToString();
                }
                else if (nbPoints < 63)
                {
                    lblPrime.Text = "/";
                    totFinalGaucheJ2 = totSommeJ2;
                    lblTotFinalGauche.Text = totSommeJ2.ToString();
                }
            }
        }

        #endregion

        #region Fonctions partie Droite (J2)
        public bool Brelan(Label lblBrelan, Label lblTotalFinalDroite, Button btnValider)
        {
            string result = System.String.Concat(liChoixModifJ2.ToArray());

            if (result.Length == 5)
            {
                if (result[0] == result[1] && result[1] == result[2] || //11100
                    result[1] == result[2] && result[2] == result[3] || //01110
                    result[2] == result[3] && result[3] == result[4] || //00111
                    result[0] == result[3] && result[3] == result[4] || //10011
                    result[0] == result[1] && result[1] == result[4] || //11001
                    result[0] == result[2] && result[2] == result[3] || //10110
                    result[1] == result[2] && result[2] == result[4] || //01101
                    result[1] == result[2] && result[2] == result[3] || //01110
                    result[0] == result[1] && result[1] == result[3] || //11010
                    result[0] == result[2] && result[2] == result[4]    //10101
                    )
                {
                    for (int i = 0; i < result.Length; i++)
                    {
                        sommeBrelanJ2 += int.Parse(result[i].ToString());
                    }

                    lblBrelan.Text = sommeBrelanJ2.ToString();

                    lblBrelan.Enabled = false;
                    btnValider.Enabled = false;
                    totFinalDroiteJ2 += sommeBrelanJ2;
                    lblTotalFinalDroite.Text = totFinalDroiteJ2.ToString();
                    return true;
                }
                else
                {
                    EcranZeroPoint f = new EcranZeroPoint();
                    f.lblZero.Text = "Vous n'avez pas de brelan voulez vous confirmer les 0 points pour cette case?";
                    f.ShowDialog();
                    if (f.choix == 1)
                    {
                        lblBrelan.Text = "0";
                        lblBrelan.Enabled = false;
                        btnValider.Enabled = false;
                        totFinalDroiteJ2 += 0;
                        lblTotalFinalDroite.Text = totFinalDroiteJ2.ToString();
                        return true;
                    }
                    else
                    {
                        f.Close();
                        return false;
                    }
                }

            }
            else
            {
                EcranZeroPoint f = new EcranZeroPoint();
                f.lblZero.Text = "Vous n'avez pas de brelan voulez vous confirmer les 0 points pour cette case?";
                f.ShowDialog();
                if (f.choix == 1)
                {
                    lblBrelan.Text = "0";
                    lblBrelan.Enabled = false;
                    btnValider.Enabled = false;
                    totFinalDroiteJ2 += 0;
                    lblTotalFinalDroite.Text = totFinalDroiteJ2.ToString();
                    return true;
                }
                else
                {
                    f.Close();
                    return false;
                }
            }
        }

        public bool Carre(Label lblCarre, Label lblTotalFinalDroite, Button btnValider)
        {
            string result = System.String.Concat(liChoixModifJ2.ToArray());

            if (result.Length == 5 || result.Length == 6)
            {
                if (result[0] != result[1] && (result[1] == result[2] && result[2] == result[3] && result[3] == result[4]) || //01111
                    result[1] != result[0] && (result[0] == result[2] && result[2] == result[3] && result[3] == result[4]) || //10111
                    result[2] != result[0] && (result[0] == result[1] && result[1] == result[3] && result[3] == result[4]) || //11011
                    result[3] != result[0] && (result[0] == result[1] && result[1] == result[2] && result[2] == result[4]) || //11101
                    result[4] != result[0] && (result[0] == result[1] && result[1] == result[2] && result[2] == result[3]) || //11110
                    result[0] == result[1] && result[1] == result[2] && result[2] == result[3] && result[3] == result[4])   //11111

                {

                    for (int i = 0; i < result.Length; i++)
                    {
                        sommeCarreJ2 += int.Parse(result[i].ToString());
                    }

                    lblCarre.Text = sommeCarreJ2.ToString();

                    lblCarre.Enabled = false;
                    btnValider.Enabled = false;
                    totFinalDroiteJ2 += sommeCarreJ2;
                    lblTotalFinalDroite.Text = totFinalDroiteJ2.ToString();
                    return true;
                }
                else
                {
                    EcranZeroPoint f = new EcranZeroPoint();
                    f.lblZero.Text = "Vous n'avez pas de carré voulez vous confirmer les 0 points pour cette case?";
                    f.ShowDialog();
                    if (f.choix == 1)
                    {
                        lblCarre.Text = "0";
                        lblCarre.Enabled = false;
                        btnValider.Enabled = false;
                        totFinalDroiteJ2 += 0;
                        lblTotalFinalDroite.Text = totFinalDroiteJ2.ToString();
                        return true;
                    }
                    else
                    {
                        f.Close();
                        return false;
                    }
                }

            }
            else
            {
                EcranZeroPoint f = new EcranZeroPoint();
                f.lblZero.Text = "Vous n'avez pas de carré voulez vous confirmer les 0 points pour cette case?";
                f.ShowDialog();
                if (f.choix == 1)
                {
                    lblCarre.Text = "0";
                    lblCarre.Enabled = false;
                    btnValider.Enabled = false;
                    totFinalDroiteJ2 += 0;
                    lblTotalFinalDroite.Text = totFinalDroiteJ2.ToString();
                    return true;
                }
                else
                {
                    f.Close();
                    return false;
                }
            }
        }

        public bool Full(Label lblFull, Label lblTotalFinalDroite, Button btnValider)
        {
            liChoixModifJ2.Sort();

            string result = System.String.Concat(liChoixModifJ2.ToArray());

            if (result.Length == 5)
            {
                if (result[0] == result[1] && (result[2] == result[3] && result[3] == result[4]) ||
                   (result[0] == result[1] && result[1] == result[2]) && result[3] == result[4])
                {
                    lblFull.Text = 25.ToString();
                    lblFull.Enabled = false;
                    btnValider.Enabled = false;
                    totFinalDroiteJ2 += 25;
                    lblTotalFinalDroite.Text = totFinalDroiteJ2.ToString();
                    return true;
                }
                else
                {
                    EcranZeroPoint f = new EcranZeroPoint();
                    f.lblZero.Text = "Vous n'avez pas de full voulez vous confirmer les 0 points pour cette case?";
                    f.ShowDialog();
                    if (f.choix == 1)
                    {
                        lblFull.Text = "0";
                        lblFull.Enabled = false;
                        btnValider.Enabled = false;
                        totFinalDroiteJ2 += 0;
                        lblTotalFinalDroite.Text = totFinalDroiteJ2.ToString();
                        return true;
                    }
                    else
                    {
                        f.Close();
                        return false;
                    }
                }
            }
            else
            {
                EcranZeroPoint f = new EcranZeroPoint();
                f.lblZero.Text = "Vous n'avez pas de full, voulez vous confirmer les 0 points pour cette case?";
                f.ShowDialog();
                if (f.choix == 1)
                {
                    lblFull.Text = "0";
                    lblFull.Enabled = false;
                    btnValider.Enabled = false;
                    totFinalDroiteJ2 += 0;
                    lblTotalFinalDroite.Text = totFinalDroiteJ2.ToString();
                    return true;
                }
                else
                {
                    f.Close();
                    return false;
                }
            }
        }

        public bool PetiteSuite(Label lblPetiteSuite, Label lblTotalFinalDroite, Button btnValider)
        {
            liChoixModifJ2.Sort();

            if (liChoixModifJ2.Count == 4)
            {
                liChoixModifJ2.Add(20); //On ajoute un nombre pour ne pas sortir de l'index lors de la vérification plus bas

                string result = System.String.Concat(liChoixModifJ2.ToArray());

                liChoixModifJ2.Remove(20);

                if (
                        result[0] == result[1] && (result[4] - result[3]) == 1 && (result[3] - result[2]) == 1 && (result[2] - result[1]) == 1 ||
                        result[1] == result[2] && (result[4] - result[3]) == 1 && (result[3] - result[1]) == 1 && (result[1] - result[0]) == 1 ||
                        result[2] == result[3] && (result[4] - result[2]) == 1 && (result[2] - result[1]) == 1 && (result[1] - result[0]) == 1 ||
                        result[3] == result[4] && (result[3] - result[2]) == 1 && (result[2] - result[1]) == 1 && (result[1] - result[0]) == 1 ||
                        (result[4] - result[3]) == 1 && (result[3] - result[2]) == 1 && (result[2] - result[1]) == 1 && (result[1] - result[0]) == 1 ||
                        result[0] != result[1] && (result[4] - result[3]) == 1 && (result[3] - result[2]) == 1 && (result[2] - result[1]) == 1 ||
                        result[4] != result[3] && (result[3] - result[2]) == 1 && (result[2] - result[1]) == 1 && (result[1] - result[0]) == 1
                        )
                {
                    lblPetiteSuite.Text = 30.ToString();
                    lblPetiteSuite.Enabled = false;
                    btnValider.Enabled = false;
                    totFinalDroiteJ2 += 30;
                    lblTotalFinalDroite.Text = totFinalDroiteJ2.ToString();
                    return true;
                }
                else
                {
                    EcranZeroPoint f = new EcranZeroPoint();
                    f.lblZero.Text = "Vous n'avez pas de petite suite, voulez vous confirmer les 0 points pour cette case?";
                    f.ShowDialog();
                    if (f.choix == 1)
                    {
                        lblPetiteSuite.Text = "0";
                        lblPetiteSuite.Enabled = false;
                        btnValider.Enabled = false;
                        totFinalDroiteJ2 += 0;
                        lblTotalFinalDroite.Text = totFinalDroiteJ2.ToString();
                        return true;
                    }
                    else
                    {
                        f.Close();
                        return false;
                    }
                }
            }
            else if (liChoixModifJ2.Count == 5)
            {
                string result = System.String.Concat(liChoixModifJ2.ToArray());

                if (
                        result[0] == result[1] && (result[4] - result[3]) == 1 && (result[3] - result[2]) == 1 && (result[2] - result[1]) == 1 ||
                        result[1] == result[2] && (result[4] - result[3]) == 1 && (result[3] - result[1]) == 1 && (result[1] - result[0]) == 1 ||
                        result[2] == result[3] && (result[4] - result[2]) == 1 && (result[2] - result[1]) == 1 && (result[1] - result[0]) == 1 ||
                        result[3] == result[4] && (result[3] - result[2]) == 1 && (result[2] - result[1]) == 1 && (result[1] - result[0]) == 1 ||
                        (result[4] - result[3]) == 1 && (result[3] - result[2]) == 1 && (result[2] - result[1]) == 1 && (result[1] - result[0]) == 1 ||
                        result[0] != result[1] && (result[4] - result[3]) == 1 && (result[3] - result[2]) == 1 && (result[2] - result[1]) == 1 ||
                        result[4] != result[3] && (result[3] - result[2]) == 1 && (result[2] - result[1]) == 1 && (result[1] - result[0]) == 1
                        )
                {
                    lblPetiteSuite.Text = 30.ToString();
                    lblPetiteSuite.Enabled = false;
                    btnValider.Enabled = false;
                    totFinalDroiteJ2 += 30;
                    lblTotalFinalDroite.Text = totFinalDroiteJ2.ToString();
                    return true;
                }
                else
                {
                    EcranZeroPoint f = new EcranZeroPoint();
                    f.lblZero.Text = "Vous n'avez pas de petite suite, voulez vous confirmer les 0 points pour cette case?";
                    f.ShowDialog();
                    if (f.choix == 1)
                    {
                        lblPetiteSuite.Text = "0";
                        lblPetiteSuite.Enabled = false;
                        btnValider.Enabled = false;
                        totFinalDroiteJ2 += 0;
                        lblTotalFinalDroite.Text = totFinalDroiteJ2.ToString();
                        return true;
                    }
                    else
                    {
                        f.Close();
                        return false;
                    }
                }
            }
            else
            {
                EcranZeroPoint f = new EcranZeroPoint();
                f.lblZero.Text = "Vous n'avez pas de petite suite, voulez vous confirmer les 0 points pour cette case?";
                f.ShowDialog();
                if (f.choix == 1)
                {
                    lblPetiteSuite.Text = "0";
                    lblPetiteSuite.Enabled = false;
                    btnValider.Enabled = false;
                    totFinalDroiteJ2 += 0;
                    lblTotalFinalDroite.Text = totFinalDroiteJ2.ToString();
                    return true;
                }
                else
                {
                    f.Close();
                    return false;
                }
            }
        }

        public bool GrandeSuite(Label lblGrandeSuite, Label lblTotalFinalDroite, Button btnValider)
        {
            liChoixModifJ2.Sort();

            string result = System.String.Concat(liChoixModifJ2.ToArray());

            if (result.Length == 5)
            {

                if ((result[4] - result[3]) == 1 && (result[3] - result[2]) == 1 &&
                  (result[2] - result[1]) == 1 && (result[1] - result[0]) == 1)
                {
                    lblGrandeSuite.Text = 40.ToString();
                    lblGrandeSuite.Enabled = false;
                    btnValider.Enabled = false;
                    totFinalDroiteJ2 += 40;
                    lblTotalFinalDroite.Text = totFinalDroiteJ2.ToString();
                    return true;
                }
                else
                {
                    EcranZeroPoint f = new EcranZeroPoint();
                    f.lblZero.Text = "Vous n'avez pas de grande suite, voulez vous confirmer les 0 points pour cette case?";
                    f.ShowDialog();
                    if (f.choix == 1)
                    {
                        lblGrandeSuite.Text = "0";
                        lblGrandeSuite.Enabled = false;
                        btnValider.Enabled = false;
                        totFinalDroiteJ2 += 0;
                        lblTotalFinalDroite.Text = totFinalDroiteJ2.ToString();
                        return true;
                    }
                    else
                    {
                        f.Close();
                        return false;
                    }
                }
            }
            else
            {
                EcranZeroPoint f = new EcranZeroPoint();
                f.lblZero.Text = "Vous n'avez pas de grande suite, voulez vous confirmer les 0 points pour cette case?";
                f.ShowDialog();
                if (f.choix == 1)
                {
                    lblGrandeSuite.Text = "0";
                    lblGrandeSuite.Enabled = false;
                    btnValider.Enabled = false;
                    totFinalDroiteJ2 += 0;
                    lblTotalFinalDroite.Text = totFinalDroiteJ2.ToString();
                    return true;
                }
                else
                {
                    f.Close();
                    return false;
                }
            }

        }

        public bool Yathzee(Label lblYathzee, Label lblTotalFinalDroite, Button btnValider)
        {
            string result = System.String.Concat(liChoixModifJ2.ToArray());

            if (result.Length == 5)
            {
                if (result[0] == result[1] && result[1] == result[2] && result[2] == result[3] & result[3] == result[4])
                {

                    if (sommeYathzeeJ2 == 50)
                    {
                        sommeYathzeeJ2 += 100;
                        lblYathzee.Text = sommeYathzeeJ2.ToString();
                        lblYathzee.Enabled = false;
                        btnValider.Enabled = false;
                        totFinalDroiteJ2 += sommeYathzeeJ2;
                        lblTotalFinalDroite.Text = totFinalDroiteJ2.ToString();
                        return true;
                    }
                    else
                    {
                        lblYathzee.Enabled = false;
                        btnValider.Enabled = false;
                        sommeYathzeeJ2 = 50;
                        lblYathzee.Text = sommeYathzeeJ2.ToString();
                        totFinalDroiteJ2 += sommeYathzeeJ2;
                        lblTotalFinalDroite.Text = totFinalDroiteJ2.ToString();
                        return true;
                    }
                }
                else
                {
                    EcranZeroPoint f = new EcranZeroPoint();
                    f.lblZero.Text = "Vous n'avez pas de YATHZEE, voulez vous confirmer les 0 points pour cette case?";
                    f.ShowDialog();
                    if (f.choix == 1)
                    {
                        lblYathzee.Text = "0";
                        lblYathzee.Enabled = false;
                        btnValider.Enabled = false;
                        sommeYathzeeJ2 = 0;
                        totFinalDroiteJ2 += sommeYathzeeJ2;
                        lblTotalFinalDroite.Text = totFinalDroiteJ2.ToString();
                        return true;
                    }
                    else
                    {
                        f.Close();
                        return false;
                    }
                }
            }
            else
            {
                EcranZeroPoint f = new EcranZeroPoint();
                f.lblZero.Text = "Vous n'avez pas de YATHZEE, voulez vous confirmer les 0 points pour cette case?";
                f.ShowDialog();
                if (f.choix == 1)
                {
                    lblYathzee.Text = "0";
                    lblYathzee.Enabled = false;
                    btnValider.Enabled = false;
                    sommeYathzeeJ2 = 0;
                    totFinalDroiteJ2 += sommeYathzeeJ2;
                    lblTotalFinalDroite.Text = totFinalDroiteJ2.ToString();
                    return true;
                }
                else
                {
                    f.Close();
                    return false;
                }
            }
        }

        public bool Chance(Label lblChance, Label lblTotalFinalDroite, Button btnValider,
            CheckBox chBox1, CheckBox chBox2, CheckBox chBox3, CheckBox chBox4, CheckBox chBox5)
        {
            if (chBox1.Checked == true && chBox2.Checked == true && chBox3.Checked == true && chBox4.Checked == true && chBox5.Checked == true)
            {
                string result = System.String.Concat(liChoixModifJ2.ToArray());

                for (int i = 0; i < result.Length; i++)
                {
                    sommeChanceJ2 += int.Parse(result[i].ToString());
                }
                lblChance.Text = sommeChanceJ2.ToString();
                lblChance.Enabled = false;
                btnValider.Enabled = false;
                totFinalDroiteJ2 += sommeChanceJ2;
                lblTotalFinalDroite.Text = totFinalDroiteJ2.ToString();
                return true;
            }
            else
            {
                EcranZeroPoint f = new EcranZeroPoint();
                f.lblZero.Text = "Vous n'avez pas coché tous les éléments, voulez-vous tout cocher pour obtenir plus de points?";
                f.ShowDialog();

                if (f.choix == 1)
                {
                    //Valider tous
                    chBox1.Checked = true;
                    chBox2.Checked = true;
                    chBox3.Checked = true;
                    chBox4.Checked = true;
                    chBox5.Checked = true;

                    string result = System.String.Concat(liChoixModifJ2.ToArray());

                    for (int i = 0; i < result.Length; i++)
                    {
                        sommeChanceJ2 += int.Parse(result[i].ToString());
                    }
                    lblChance.Text = sommeChanceJ2.ToString();
                    lblChance.Enabled = false;
                    btnValider.Enabled = false;
                    totFinalDroiteJ2 += sommeChanceJ2;
                    lblTotalFinalDroite.Text = totFinalDroiteJ2.ToString();
                    return true;
                }
                else
                {
                    string result = System.String.Concat(liChoixModifJ2.ToArray());

                    for (int i = 0; i < result.Length; i++)
                    {
                        sommeChanceJ2 += int.Parse(result[i].ToString());
                    }
                    lblChance.Text = sommeChanceJ2.ToString();
                    lblChance.Enabled = false;
                    btnValider.Enabled = false;
                    totFinalDroiteJ2 += sommeChanceJ2;
                    lblTotalFinalDroite.Text = totFinalDroiteJ2.ToString();
                    return true;
                }
            }
        }

        public void CalculSommeFinale(Label lblSomme1, Label lblSomme2, Label lblSomme3,
            Label lblSomme4, Label lblSomme5, Label lblSomme6, Label lblBrelan,
            Label lblCarre, Label lblFull, Label lblPetiteSuite, Label lblGrandeSuite,
            Label lblYathzee, Label lblChance, Label lblTotFinalGauche, Label lblTotFinalJ1)
        {
            if (lblSomme1.Text != "" && lblSomme2.Text != "" && lblSomme3.Text != "" &&
                lblSomme4.Text != "" && lblSomme5.Text != "" && lblSomme6.Text != "" && lblBrelan.Text != "" &&
                lblCarre.Text != "" && lblFull.Text != "" && lblPetiteSuite.Text != "" &&
                lblGrandeSuite.Text != "" && lblYathzee.Text != "" && lblChance.Text != "")
            {
                sommeFinalePartieJ2 = totFinalGaucheJ2 + totFinalDroiteJ2;
                lblTotFinalJ1.Text = sommeFinalePartieJ2.ToString();
            }
        }

        #endregion

        #endregion
    }
}
