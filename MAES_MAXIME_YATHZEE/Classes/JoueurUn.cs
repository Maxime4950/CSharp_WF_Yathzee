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

    class JoueurUn
    {
        #region Initialisation des variables
        DesactiveActiveLbl desactiveActive = new DesactiveActiveLbl(); //
        Start start = new Start();

        public string nomJ1;
        public int nbLancerRestJ1;
        public int somme1J1, somme2J1, somme3J1, somme4J1, somme5J1, somme6J1;
        public int primeJ1;
        public int sommeYathzeeJ1, sommeChanceJ1, sommeBrelanJ1, sommeCarreJ1, fullJ1, pSuiteJ1, gSuiteJ1;
        public int totSommeJ1;
        public int totFinalGaucheJ1, totFinalDroiteJ1;
        public int sommeFinalePartieJ1;
        public int nbTourJ1;

        public ArrayList liChoixModifJ1 = new ArrayList(); //Pour stocker les valeurs choisies par le J1

        public int[] liDe = new int[5]; //Pour stocker les valeurs des 5 dés
        #endregion

        #region Constructeur Joueur J1
        public JoueurUn()
        {
            this.nomJ1 = "J1";
            this.nbLancerRestJ1 = 3;
            this.nbTourJ1 = 0;

            #region Partie gauche (SOMMES 1 à 6 J1 + totSommeJ1 + primeJ1 + totFinalGaucheJ1)
            this.somme1J1 = 0;
            this.somme2J1 = 0;
            this.somme3J1 = 0;
            this.somme4J1 = 0;
            this.somme5J1 = 0;
            this.somme6J1 = 0;

            this.totSommeJ1 = 0;

            this.primeJ1 = 0;

            this.totFinalGaucheJ1 = 0;

            #endregion

            #region Partie droite (BrelanJ1 + CarreJ1 + FullJ1 + pSuiteJ1 + gSuiteJ1 + yathzeeJ1 + chanceJ1
            this.sommeBrelanJ1 = 0;
            this.sommeCarreJ1 = 0;
            this.fullJ1 = 0;
            this.pSuiteJ1 = 0;
            this.gSuiteJ1 = 0;
            this.sommeYathzeeJ1 = 0;
            this.sommeChanceJ1 = 0;

            this.totFinalDroiteJ1 = 0;

            this.sommeFinalePartieJ1 = 0;
            #endregion

        }
        #endregion

        #region Méthodes
        public void LancerJ1(CheckBox cbD1, CheckBox cbD2, CheckBox cbD3, CheckBox cbD4, CheckBox cbD5,
            PictureBox pb1, PictureBox pb2, PictureBox pb3, PictureBox pb4, PictureBox pb5,
            Label lbl1, Label lbl2, Label lbl3, Label lbl4, Label lbl5, Random aleatoire)
        {
            #region Lancer dé 1 J1
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

            #region Lancer dé 2 J1
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

            #region Lancer dé 3 J1
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

            #region Lancer dé 4 J1
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

            #region Lancer dé 5 J1
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

            if (nbJoueur == "J1")
            {
                nbLancerRestJ1 = 3;
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
            liChoixModifJ1.Add(nb); //Ajout du chiffre dans l'arrayList
        }

        public void DecocheCheckbox(int nb) //Supprimer le chiffre décoché de la liste
        {
            int nb1 = nb; //Conversion en INT pour permettre de rechercher le chiffre dans l'arrayList
            int nbFois = 0;

            string result = System.String.Concat(liChoixModifJ1.ToArray());

            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] == (char)nb1)
                {
                    nbFois++; //Calcul cb de fois est présent le nb à supprimer
                }
            }

            if (liChoixModifJ1.Contains(nb1))
            {
                liChoixModifJ1.Remove(nb1);
            }

            if (nbFois > 1) //Pour ne pas supprimer tous les 4 si on veut seulement en supprimer un
            {
                for (int h = 0; h < nbFois - 1; h++)
                {
                    liChoixModifJ1.Add(nb1);
                }
            }


        }

        public void chargeSaveJ1(Label lblSomme1J1, Label lblSomme2J1, Label lblSomme3J1, Label lblSomme4J1, Label lblSomme5J1, Label lblSomme6J1,
            Label lblTotalSommesJ1, Label lblPrimeJ1, Label lblTotalFinalGaucheJ1,
            Label lblBrelanJ1, Label lblCarreJ1, Label lblFullJ1, Label lblPetiteSuiteJ1, Label lblGrandeSuiteJ1,
            Label lblYathzeeJ1, Label lblChanceJ1, Label lblTotalFinalDroiteJ1, Label lblTotalFinalJ1, Label lblNomJoueur1, Panel pj1)
        {
            int i = 0;

            using (StreamReader save = new StreamReader("saveJ1.txt"))
            {
                string line;
                // Read and display lines from the file until the end of 
                // the file is reached.
                while ((line = save.ReadLine()) != "STOP")
                {

                    #region JOUEUR 1
                    if (i == 0) //Somme 1 J1
                    {
                        if (line != "")
                        {
                            somme1J1 = int.Parse(line);
                            lblSomme1J1.Text = somme1J1.ToString();
                        }
                    }
                    else if (i == 1) //Somme 2 J1
                    {
                        if (line != "")
                        {
                            somme2J1 = int.Parse(line);
                            lblSomme2J1.Text = somme2J1.ToString();
                        }
                    }
                    else if (i == 2) //Somme 3 J1
                    {
                        if (line != "")
                        {
                            somme3J1 = int.Parse(line);
                            lblSomme3J1.Text = somme3J1.ToString();
                        }
                    }
                    else if (i == 3) //Somme 4 J1
                    {
                        if (line != "")
                        {
                            somme4J1 = int.Parse(line);
                            lblSomme4J1.Text = somme4J1.ToString();
                        }
                    }
                    else if (i == 4) //Somme 5 J1
                    {
                        if (line != "")
                        {
                            somme5J1 = int.Parse(line);
                            lblSomme5J1.Text = somme5J1.ToString();
                        }
                    }
                    else if (i == 5) //Somme 6 J1
                    {
                        if (line != "")
                        {
                            somme6J1 = int.Parse(line);
                            lblSomme6J1.Text = somme6J1.ToString();
                        }
                    }
                    else if (i == 6) //Total sommes J1
                    {
                        if (line != "")
                        {
                            totSommeJ1 = int.Parse(line);
                            lblTotalSommesJ1.Text = totSommeJ1.ToString();
                        }
                    }

                    else if (i == 7) //Prime J1
                    {
                        if (line != "")
                        {
                            lblPrimeJ1.Text = line.ToString();
                        }
                    }

                    else if (i == 8) //totFinalGauche J1
                    {
                        if (line != "")
                        {
                            totFinalGaucheJ1 = int.Parse(line);
                            lblTotalFinalGaucheJ1.Text = totFinalGaucheJ1.ToString();
                        }
                    }

                    else if (i == 9) //Brelan J1
                    {
                        if (line != "")
                        {
                            sommeBrelanJ1 = int.Parse(line);
                            lblBrelanJ1.Text = sommeBrelanJ1.ToString();
                        }
                    }

                    else if (i == 10) //Carre J1
                    {
                        if (line != "")
                        {
                            sommeCarreJ1 = int.Parse(line);
                            lblCarreJ1.Text = sommeCarreJ1.ToString();
                        }
                    }

                    else if (i == 11) //Full J1
                    {
                        if (line != "")
                        {
                            lblFullJ1.Text = line;
                        }
                    }

                    else if (i == 12) //Petite suite J1
                    {
                        if (line != "")
                        {
                            lblPetiteSuiteJ1.Text = line;
                        }
                    }

                    else if (i == 13) //Grande suite J1
                    {
                        if (line != "")
                        {
                            lblGrandeSuiteJ1.Text = line;
                        }
                    }

                    else if (i == 14) //Yathzee J1
                    {
                        if (line != "")
                        {
                            lblYathzeeJ1.Text = line;
                        }
                    }

                    else if (i == 15) //Chance J1
                    {
                        if (line != "")
                        {
                            sommeChanceJ1 = int.Parse(line);
                            lblChanceJ1.Text = sommeChanceJ1.ToString();
                        }
                    }

                    else if (i == 16) //Tot final droite J1
                    {
                        if (line != "")
                        {
                            totFinalDroiteJ1 = int.Parse(line);
                            lblTotalFinalDroiteJ1.Text = totFinalDroiteJ1.ToString();
                        }
                    }

                    else if (i == 17) //Tot final J1
                    {
                        if (line != "")
                        {
                            sommeFinalePartieJ1 = int.Parse(line);
                            lblTotalFinalJ1.Text = sommeFinalePartieJ1.ToString();
                        }
                    }

                    else if (i == 18) //Panel J1
                    {
                        if (line == "True")
                        {
                            pj1.Enabled = true;
                        }
                        else if(line == "False")
                        {
                            pj1.Enabled = false;
                        }
                    }

                    else if (i == 19) //Nom J1
                    {
                        if (line != "")
                        {
                            lblNomJoueur1.Text = line;
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
            else if(chBox1.Checked == false || chBox2.Checked == false || chBox3.Checked == false || chBox4.Checked == false || chBox5.Checked == false)
            {
                if(nbLancerRestJ1 == 0)
                {
                    btnValider.Enabled = true;
                }
                else
                {
                    btnValider.Enabled = false;
                }
            }
        }

        #region Fonctions partie Gauche Sommes de 1 à 6 + PRIME (J1 et J2)

        public bool Somme1(Label lblSomme1, Label lblTotalSommes, Button btnValider)
        {
            string result = System.String.Concat(liChoixModifJ1.ToArray());

            if (result.Contains('1'))
            {
                for (int i = 0; i < result.Length; i++)
                {
                    if (result[i] == '1')
                    {
                        somme1J1++;
                    }
                }

                lblSomme1.Text = somme1J1.ToString();
                lblSomme1.Enabled = false;
                btnValider.Enabled = false;
                totSommeJ1 += somme1J1;
                lblTotalSommes.Text = totSommeJ1.ToString();
                return true;
            }
            else
            {
                EcranZeroPoint f = new EcranZeroPoint();
                f.lblZero.Text = "Il n'y a pas de 1 dans votre sélection de chiffre, voulez vous confirmer les 0 points pour cette case?";
                f.ShowDialog();
                if (f.choix == 1)
                {
                    somme1J1 = 0;
                    lblSomme1.Text = somme1J1.ToString();
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
            string result = System.String.Concat(liChoixModifJ1.ToArray());

            if (result.Contains('2'))
            {
                for (int i = 0; i < result.Length; i++)
                {
                    if (result[i] == '2')
                    {
                        somme2J1 += 2;
                    }
                }

                lblSomme2.Text = somme2J1.ToString();
                lblSomme2.Enabled = false;
                btnValider.Enabled = false;
                totSommeJ1 += somme2J1;
                lblTotalSommes.Text = totSommeJ1.ToString();
                return true;
            }
            else
            {
                EcranZeroPoint f = new EcranZeroPoint();
                f.lblZero.Text = "Il n'y a pas de 2 dans votre sélection de chiffre, voulez vous confirmer les 0 points pour cette case?";
                f.ShowDialog();
                if (f.choix == 1)
                {
                    somme2J1 = 0;
                    lblSomme2.Text = somme2J1.ToString();
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
            string result = System.String.Concat(liChoixModifJ1.ToArray());

            if (result.Contains('3'))
            {
                for (int i = 0; i < result.Length; i++)
                {
                    if (result[i] == '3')
                    {
                        somme3J1 += 3;
                    }
                }

                lblSomme3.Text = somme3J1.ToString();
                lblSomme3.Enabled = false;
                btnValider.Enabled = false;
                totSommeJ1 += somme3J1;
                lblTotalSommes.Text = totSommeJ1.ToString();
                return true;
            }
            else
            {
                EcranZeroPoint f = new EcranZeroPoint();
                f.lblZero.Text = "Il n'y a pas de 3 dans votre sélection de chiffre, voulez vous confirmer les 0 points pour cette case?";
                f.ShowDialog();
                if (f.choix == 1)
                {
                    somme2J1 = 0;
                    lblSomme3.Text = somme2J1.ToString();
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
            string result = System.String.Concat(liChoixModifJ1.ToArray());

            if (result.Contains('4'))
            {
                for (int i = 0; i < result.Length; i++)
                {
                    if (result[i] == '4')
                    {
                        somme4J1 += 4;
                    }
                }

                lblSomme4.Text = somme4J1.ToString();
                lblSomme4.Enabled = false;
                btnValider.Enabled = false;
                totSommeJ1 += somme4J1;
                lblTotalSommes.Text = totSommeJ1.ToString();
                return true;
            }
            else
            {
                EcranZeroPoint f = new EcranZeroPoint();
                f.lblZero.Text = "Il n'y a pas de 4 dans votre sélection de chiffre, voulez vous confirmer les 0 points pour cette case?";
                f.ShowDialog();
                if (f.choix == 1)
                {
                    somme4J1 = 0;
                    lblSomme4.Text = somme4J1.ToString();
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
            string result = System.String.Concat(liChoixModifJ1.ToArray());

            if (result.Contains('5'))
            {
                for (int i = 0; i < result.Length; i++)
                {
                    if (result[i] == '5')
                    {
                        somme5J1 += 5;
                    }
                }

                lblSomme5.Text = somme5J1.ToString();
                lblSomme5.Enabled = false;
                btnValider.Enabled = false;
                totSommeJ1 += somme5J1;
                lblTotalSommes.Text = totSommeJ1.ToString();
                return true;
            }
            else
            {
                EcranZeroPoint f = new EcranZeroPoint();
                f.lblZero.Text = "Il n'y a pas de 5 dans votre sélection de chiffre, voulez vous confirmer les 0 points pour cette case?";
                f.ShowDialog();
                if (f.choix == 1)
                {
                    somme5J1 = 0;
                    lblSomme5.Text = somme5J1.ToString();
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
            string result = System.String.Concat(liChoixModifJ1.ToArray());

            if (result.Contains('6'))
            {
                for (int i = 0; i < result.Length; i++)
                {
                    if (result[i] == '6')
                    {
                        somme6J1 += 6;
                    }
                }

                lblSomme6.Text = somme6J1.ToString();
                lblSomme6.Enabled = false;
                btnValider.Enabled = false;
                totSommeJ1 += somme6J1;
                lblTotalSommes.Text = totSommeJ1.ToString();
                return true;
            }
            else
            {
                EcranZeroPoint f = new EcranZeroPoint();
                f.lblZero.Text = "Il n'y a pas de 6 dans votre sélection de chiffre, voulez vous confirmer les 0 points pour cette case?";
                f.ShowDialog();
                if (f.choix == 1)
                {
                    somme6J1 = 0;
                    lblSomme6.Text = somme6J1.ToString();
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
                    lblTotalSommes.Text = totSommeJ1.ToString();
                    totFinalGaucheJ1 = totSommeJ1 + 35;
                    lblTotFinalGauche.Text = totFinalGaucheJ1.ToString();
                }
                else if (nbPoints < 63)
                {
                    lblPrime.Text = "/";
                    totFinalGaucheJ1 = totSommeJ1;
                    lblTotFinalGauche.Text = totSommeJ1.ToString();
                }
            }
        }

        #endregion

        #region Fonctions partie Droite (J1)
        public bool Brelan(Label lblBrelan, Label lblTotalFinalDroite, Button btnValider)
        {
            string result = System.String.Concat(liChoixModifJ1.ToArray());

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
                        sommeBrelanJ1 += int.Parse(result[i].ToString());
                    }

                    lblBrelan.Text = sommeBrelanJ1.ToString();

                    lblBrelan.Enabled = false;
                    btnValider.Enabled = false;
                    totFinalDroiteJ1 += sommeBrelanJ1;
                    lblTotalFinalDroite.Text = totFinalDroiteJ1.ToString();
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
                        totFinalDroiteJ1 += 0;
                        lblTotalFinalDroite.Text = totFinalDroiteJ1.ToString();
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
                    totFinalDroiteJ1 += 0;
                    lblTotalFinalDroite.Text = totFinalDroiteJ1.ToString();
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
            string result = System.String.Concat(liChoixModifJ1.ToArray());

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
                        sommeCarreJ1 += int.Parse(result[i].ToString());
                    }

                    lblCarre.Text = sommeCarreJ1.ToString();

                    lblCarre.Enabled = false;
                    btnValider.Enabled = false;
                    totFinalDroiteJ1 += sommeCarreJ1;
                    lblTotalFinalDroite.Text = totFinalDroiteJ1.ToString();
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
                        totFinalDroiteJ1 += 0;
                        lblTotalFinalDroite.Text = totFinalDroiteJ1.ToString();
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
                    totFinalDroiteJ1 += 0;
                    lblTotalFinalDroite.Text = totFinalDroiteJ1.ToString();
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
            liChoixModifJ1.Sort();

            string result = System.String.Concat(liChoixModifJ1.ToArray());

            if (result.Length == 5)
            {
                if (result[0] == result[1] && (result[2] == result[3] && result[3] == result[4]) ||
                   (result[0] == result[1] && result[1] == result[2]) && result[3] == result[4])
                {
                    lblFull.Text = 25.ToString();
                    lblFull.Enabled = false;
                    btnValider.Enabled = false;
                    totFinalDroiteJ1 += 25;
                    lblTotalFinalDroite.Text = totFinalDroiteJ1.ToString();
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
                        totFinalDroiteJ1 += 0;
                        lblTotalFinalDroite.Text = totFinalDroiteJ1.ToString();
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
                    totFinalDroiteJ1 += 0;
                    lblTotalFinalDroite.Text = totFinalDroiteJ1.ToString();
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
            liChoixModifJ1.Sort();

            if (liChoixModifJ1.Count == 4)
            {
                liChoixModifJ1.Add(20); //On ajoute un nombre pour ne pas sortir de l'index lors de la vérification plus bas

                string result = System.String.Concat(liChoixModifJ1.ToArray());

                liChoixModifJ1.Remove(20);

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
                    totFinalDroiteJ1 += 30;
                    lblTotalFinalDroite.Text = totFinalDroiteJ1.ToString();
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
                        totFinalDroiteJ1 += 0;
                        lblTotalFinalDroite.Text = totFinalDroiteJ1.ToString();
                        return true;
                    }
                    else
                    {
                        f.Close();
                        return false;
                    }
                }
            }
            else if(liChoixModifJ1.Count == 5)
            {
                string result = System.String.Concat(liChoixModifJ1.ToArray());


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
                    totFinalDroiteJ1 += 30;
                    lblTotalFinalDroite.Text = totFinalDroiteJ1.ToString();
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
                        totFinalDroiteJ1 += 0;
                        lblTotalFinalDroite.Text = totFinalDroiteJ1.ToString();
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
                    totFinalDroiteJ1 += 0;
                    lblTotalFinalDroite.Text = totFinalDroiteJ1.ToString();
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
            liChoixModifJ1.Sort();

            string result = System.String.Concat(liChoixModifJ1.ToArray());

            if (result.Length == 5)
            {
                if ((result[4] - result[3]) == 1 && (result[3] - result[2]) == 1 &&
                  (result[2] - result[1]) == 1 && (result[1] - result[0]) == 1)
                {
                    lblGrandeSuite.Text = 40.ToString();
                    lblGrandeSuite.Enabled = false;
                    btnValider.Enabled = false;
                    totFinalDroiteJ1 += 40;
                    lblTotalFinalDroite.Text = totFinalDroiteJ1.ToString();
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
                        totFinalDroiteJ1 += 0;
                        lblTotalFinalDroite.Text = totFinalDroiteJ1.ToString();
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
                    totFinalDroiteJ1 += 0;
                    lblTotalFinalDroite.Text = totFinalDroiteJ1.ToString();
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
            string result = System.String.Concat(liChoixModifJ1.ToArray());

            if (result.Length == 5)
            {
                if (result[0] == result[1] && result[1] == result[2] && result[2] == result[3] & result[3] == result[4])
                {

                    if (sommeYathzeeJ1 == 50)
                    {
                        sommeYathzeeJ1 += 100;
                        lblYathzee.Text = sommeYathzeeJ1.ToString();
                        lblYathzee.Enabled = false;
                        btnValider.Enabled = false;
                        totFinalDroiteJ1 += sommeYathzeeJ1;
                        lblTotalFinalDroite.Text = totFinalDroiteJ1.ToString();
                        return true;
                    }
                    else
                    {
                        sommeYathzeeJ1 = 50;
                        lblYathzee.Text = sommeYathzeeJ1.ToString();
                        lblYathzee.Enabled = false;
                        btnValider.Enabled = false;
                        totFinalDroiteJ1 += sommeYathzeeJ1;
                        lblTotalFinalDroite.Text = totFinalDroiteJ1.ToString();
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
                        sommeYathzeeJ1 = 0;
                        totFinalDroiteJ1 += sommeYathzeeJ1;
                        lblTotalFinalDroite.Text = totFinalDroiteJ1.ToString();
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
                    sommeYathzeeJ1 = 0;
                    totFinalDroiteJ1 += sommeYathzeeJ1;
                    lblTotalFinalDroite.Text = totFinalDroiteJ1.ToString();
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
                string result = System.String.Concat(liChoixModifJ1.ToArray());

                for (int i = 0; i < result.Length; i++)
                {
                    sommeChanceJ1 += int.Parse(result[i].ToString());
                }
                lblChance.Text = sommeChanceJ1.ToString();
                lblChance.Enabled = false;
                btnValider.Enabled = false;
                totFinalDroiteJ1 += sommeChanceJ1;
                lblTotalFinalDroite.Text = totFinalDroiteJ1.ToString();
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

                    string result = System.String.Concat(liChoixModifJ1.ToArray());

                    for (int i = 0; i < result.Length; i++)
                    {
                        sommeChanceJ1 += int.Parse(result[i].ToString());
                    }
                    lblChance.Text = sommeChanceJ1.ToString();
                    lblChance.Enabled = false;
                    btnValider.Enabled = false;
                    totFinalDroiteJ1 += sommeChanceJ1;
                    lblTotalFinalDroite.Text = totFinalDroiteJ1.ToString();
                    return true;
                }
                else
                {
                    string result = System.String.Concat(liChoixModifJ1.ToArray());

                    for (int i = 0; i < result.Length; i++)
                    {
                        sommeChanceJ1 += int.Parse(result[i].ToString());
                    }
                    lblChance.Text = sommeChanceJ1.ToString();
                    lblChance.Enabled = false;
                    btnValider.Enabled = false;
                    totFinalDroiteJ1 += sommeChanceJ1;
                    lblTotalFinalDroite.Text = totFinalDroiteJ1.ToString();
                    return true;
                }
            }
        }

        #endregion

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
                sommeFinalePartieJ1 = totFinalGaucheJ1 + totFinalDroiteJ1;
                lblTotFinalJ1.Text = sommeFinalePartieJ1.ToString();
            }
        }

        #endregion
    }
}
