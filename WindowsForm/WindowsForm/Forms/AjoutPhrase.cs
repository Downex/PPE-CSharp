using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForm.Class_gestion;
using WindowsForm.Class_jeux;

namespace WindowsForm.Forms
{
    public partial class AjoutPhrase : Form
    {
        private List<Mot> lesMots;
        private List<LabelPerso> lesLabels;
        
        private String idAdjP = null;
        private String indexAdjP = null;
        private String idArticle = null;
        private String indexArticle = null;
        private String idPronom = null;
        private String indexPronom = null;
        private String idNom = null;
        private String indexNom = null;
        private String indexConjugaison;
        private String idAdjectif = null;
        private String indexAdjectif = null;
        private String idAdverbe = null;

        private String adjPStock;
        private String pronomStock;
        private String nomStock;
        private Verbe verbeStock;
        private String conjugaisonStock;
        private String advStock;
        private String adjStock;

        private String verbeConjugueStock;

        public AjoutPhrase()
        {
            InitializeComponent();
            lesLabels = new List<LabelPerso>();
        }

        /* --- Génération de Phrase --- */
        private void button1_Click(object sender, EventArgs e)
        {
            SuppLabel();
            var random = new Random();
            int num = random.Next(0, 2);
            if (num == 0)
            {
                int choiceFirst = random.Next(0, 2);
                if (choiceFirst == 0)
                {
                    lesMots = Bdd.SelectAllAdjectifsByFonction("possessif");
                    int indexAdjPoss = random.Next(lesMots.Count);
                    Adjectif adj = (Adjectif)Bdd.SelectAdjectifPossessif(lesMots[indexAdjPoss].getTexte());
                    idAdjP = adj.GetId();
                    var genre = random.Next(1, 5);
                    string pluriel;
                    string femMasc;
                    if (genre.ToString() == "1") //SingMasculin
                    {
                        femMasc = "Masculin";
                        pluriel = "0";
                        Nom(pluriel, femMasc);
                        Verbe("il");
                        adjPStock = adj.GetSingMasculin();
                        indexAdjP = "1";
                        if (verbeStock.GetGenre() == "Etat")
                        {
                            Adjectif(femMasc, pluriel);
                            //MessageBox.Show(adj.GetSingMasculin() + " " +
                            //    nomStock + " " +
                            //    conjugaisonStock + " " +
                            //    adjStock);

                            LabelPerso labelAdjP = new LabelPerso(adj.GetSingMasculin());
                            labelAdjP.Text = adj.GetSingMasculin();
                            lesLabels.Add(labelAdjP);

                            LabelPerso labelN = new LabelPerso(nomStock);
                            labelN.Text = nomStock;
                            lesLabels.Add(labelN);

                            LabelPerso labelV = new LabelPerso(conjugaisonStock);
                            labelV.Text = conjugaisonStock;
                            lesLabels.Add(labelV);

                            LabelPerso labelA = new LabelPerso(adjStock);
                            labelA.Text = adjStock;
                            lesLabels.Add(labelA);

                            AfficheLabel();
                        }
                        else if (verbeStock.GetGenre() == "Action" || verbeStock.GetGenre() == "Mouvement")
                        {
                            Adverbe();
                            //MessageBox.Show(adj.GetSingMasculin() + " " +
                            //    nomStock + " " +
                            //    conjugaisonStock + " " +
                            //    advStock);

                            LabelPerso labelAdjP = new LabelPerso(adj.GetSingMasculin());
                            labelAdjP.Text = adj.GetSingMasculin();
                            lesLabels.Add(labelAdjP);

                            LabelPerso labelN = new LabelPerso(nomStock);
                            labelN.Text = nomStock;
                            lesLabels.Add(labelN);

                            LabelPerso labelV = new LabelPerso(conjugaisonStock);
                            labelV.Text = conjugaisonStock;
                            lesLabels.Add(labelV);

                            LabelPerso labelA = new LabelPerso(advStock);
                            labelA.Text = advStock;
                            lesLabels.Add(labelA);

                            AfficheLabel();
                        }
                        else
                        {
                            MessageBox.Show("Erreur de détection du verbe");
                        }
                    }
                    else if (genre.ToString() == "2") //SingFeminin
                    {
                        femMasc = "Feminin";
                        pluriel = "0";
                        Nom(pluriel, femMasc);
                        Verbe("elle");
                        adjPStock = adj.GetSingFeminin();
                        indexAdjP = "2";
                        if (verbeStock.GetGenre() == "Etat")
                        {
                            Adjectif(femMasc, pluriel);
                            //MessageBox.Show(adj.GetSingFeminin() + " " +
                            //    nomStock + " " +
                            //    conjugaisonStock + " " +
                            //    adjStock);

                            LabelPerso labelAdjP = new LabelPerso(adj.GetSingFeminin());
                            labelAdjP.Text = adj.GetSingFeminin();
                            lesLabels.Add(labelAdjP);

                            LabelPerso labelN = new LabelPerso(nomStock);
                            labelN.Text = nomStock;
                            lesLabels.Add(labelN);

                            LabelPerso labelV = new LabelPerso(conjugaisonStock);
                            labelV.Text = conjugaisonStock;
                            lesLabels.Add(labelV);

                            LabelPerso labelA = new LabelPerso(adjStock);
                            labelA.Text = adjStock;
                            lesLabels.Add(labelA);

                            AfficheLabel();
                        }
                        else if (verbeStock.GetGenre() == "Action" || verbeStock.GetGenre() == "Mouvement")
                        {
                            Adverbe();
                            //MessageBox.Show(adj.GetSingFeminin() + " " +
                            //    nomStock + " " +
                            //    conjugaisonStock + " " +
                            //    advStock);

                            LabelPerso labelAdjP = new LabelPerso(adj.GetSingFeminin());
                            labelAdjP.Text = adj.GetSingFeminin();
                            lesLabels.Add(labelAdjP);

                            LabelPerso labelN = new LabelPerso(nomStock);
                            labelN.Text = nomStock;
                            lesLabels.Add(labelN);

                            LabelPerso labelV = new LabelPerso(conjugaisonStock);
                            labelV.Text = conjugaisonStock;
                            lesLabels.Add(labelV);

                            LabelPerso labelA = new LabelPerso(advStock);
                            labelA.Text = advStock;
                            lesLabels.Add(labelA);

                            AfficheLabel();
                        }
                        else
                        {
                            MessageBox.Show("Erreur de détection du verbe");
                        }
                    }
                    else if (genre.ToString() == "3") // PlurMasculin
                    {
                        femMasc = "Masculin";
                        pluriel = "1";
                        Nom(pluriel, femMasc);
                        Verbe("ils");
                        adjPStock = adj.GetPlurMasculin();
                        indexAdjP = "3";
                        if (verbeStock.GetGenre() == "Etat")
                        {
                            Adjectif(femMasc, pluriel);
                            //MessageBox.Show(adj.GetPlurMasculin() + " " +
                            //    nomStock + " " +
                            //    conjugaisonStock + " " +
                            //    adjStock);

                            LabelPerso labelAdjP = new LabelPerso(adj.GetPlurMasculin());
                            labelAdjP.Text = adj.GetPlurMasculin();
                            lesLabels.Add(labelAdjP);

                            LabelPerso labelN = new LabelPerso(nomStock);
                            labelN.Text = nomStock;
                            lesLabels.Add(labelN);

                            LabelPerso labelV = new LabelPerso(conjugaisonStock);
                            labelV.Text = conjugaisonStock;
                            lesLabels.Add(labelV);

                            LabelPerso labelA = new LabelPerso(adjStock);
                            labelA.Text = adjStock;
                            lesLabels.Add(labelA);

                            AfficheLabel();
                        }
                        else if (verbeStock.GetGenre() == "Action" || verbeStock.GetGenre() == "Mouvement")
                        {
                            Adverbe();
                            //MessageBox.Show(adj.GetPlurMasculin() + " " +
                            //    nomStock + " " +
                            //    conjugaisonStock + " " +
                            //    advStock);

                            LabelPerso labelAdjP = new LabelPerso(adj.GetPlurMasculin());
                            labelAdjP.Text = adj.GetPlurMasculin();
                            lesLabels.Add(labelAdjP);

                            LabelPerso labelN = new LabelPerso(nomStock);
                            labelN.Text = nomStock;
                            lesLabels.Add(labelN);

                            LabelPerso labelV = new LabelPerso(conjugaisonStock);
                            labelV.Text = conjugaisonStock;
                            lesLabels.Add(labelV);

                            LabelPerso labelA = new LabelPerso(advStock);
                            labelA.Text = advStock;
                            lesLabels.Add(labelA);

                            AfficheLabel();
                        }
                        else
                        {
                            MessageBox.Show("Erreur de détection du verbe");
                        }
                    }
                    else if (genre.ToString() == "4") //PlurFeminin
                    {
                        femMasc = "Feminin";
                        pluriel = "1";
                        Nom(pluriel, femMasc);
                        Verbe("elles");
                        adjPStock = adj.GetPlurFeminin();
                        indexAdjP = "4";
                        if (verbeStock.GetGenre() == "Etat")
                        {
                            Adjectif(femMasc, pluriel);
                            //MessageBox.Show(adj.GetPlurFeminin() + " " +
                            //    nomStock + " " +
                            //    conjugaisonStock + " " +
                            //    adjStock);

                            LabelPerso labelAdjP = new LabelPerso(adj.GetPlurFeminin());
                            labelAdjP.Text = adj.GetPlurFeminin();
                            lesLabels.Add(labelAdjP);

                            LabelPerso labelN = new LabelPerso(nomStock);
                            labelN.Text = nomStock;
                            lesLabels.Add(labelN);

                            LabelPerso labelV = new LabelPerso(conjugaisonStock);
                            labelV.Text = conjugaisonStock;
                            lesLabels.Add(labelV);

                            LabelPerso labelA = new LabelPerso(adjStock);
                            labelA.Text = adjStock;
                            lesLabels.Add(labelA);

                            AfficheLabel();
                        }
                        else if (verbeStock.GetGenre() == "Action" || verbeStock.GetGenre() == "Mouvement")
                        {
                            Adverbe();
                            //MessageBox.Show(adj.GetPlurFeminin() + " " +
                            //    nomStock + " " +
                            //    conjugaisonStock + " " +
                            //    advStock);

                            LabelPerso labelAdjP = new LabelPerso(adj.GetPlurFeminin());
                            labelAdjP.Text = adj.GetPlurFeminin();
                            lesLabels.Add(labelAdjP);

                            LabelPerso labelN = new LabelPerso(nomStock);
                            labelN.Text = nomStock;
                            lesLabels.Add(labelN);

                            LabelPerso labelV = new LabelPerso(conjugaisonStock);
                            labelV.Text = conjugaisonStock;
                            lesLabels.Add(labelV);

                            LabelPerso labelA = new LabelPerso(advStock);
                            labelA.Text = advStock;
                            lesLabels.Add(labelA);

                            AfficheLabel();
                        }
                        else
                        {
                            MessageBox.Show("Erreur de détection du verbe");
                        }
                    }
                }
                else if(choiceFirst == 1)
                {
                    lesMots = Bdd.SelectAllArticles();
                    int indexArt = random.Next(lesMots.Count);
                    Article article = (Article)lesMots[indexArt];
                    idArticle = article.GetId();
                    int genreArt = random.Next(0, 2);
                    string plurArt = random.Next(0, 2).ToString();
                    if (plurArt == "0")
                    {
                        if (genreArt == 0)
                        {
                            indexArticle = "1";
                            Nom(plurArt, "Masculin");
                            Verbe("il");

                            LabelPerso labelArt = new LabelPerso(article.GetMasculin());
                            labelArt.Text = article.GetMasculin();
                            lesLabels.Add(labelArt);

                            LabelPerso labelN = new LabelPerso(nomStock);
                            labelN.Text = nomStock;
                            lesLabels.Add(labelN);

                            LabelPerso labelV = new LabelPerso(conjugaisonStock);
                            labelV.Text = conjugaisonStock;
                            lesLabels.Add(labelV);

                            if (verbeStock.GetGenre() == "Etat")
                            {
                                Adjectif("Masculin", "0");
                                //MessageBox.Show(article.GetMasculin() + " " + 
                                //    nomStock + " " +
                                //    conjugaisonStock + " " +
                                //    adjStock);
                                
                                LabelPerso labelA = new LabelPerso(adjStock);
                                labelA.Text = adjStock;
                                lesLabels.Add(labelA);

                                AfficheLabel();
                            }
                            else if(verbeStock.GetGenre() == "Action" || verbeStock.GetGenre() == "Mouvement")
                            {
                                Adverbe();
                                //MessageBox.Show(article.GetMasculin() + " " + 
                                //    nomStock + " " + 
                                //    conjugaisonStock + " " + 
                                //    advStock);

                                LabelPerso labelA = new LabelPerso(adjStock);
                                labelA.Text = adjStock;
                                lesLabels.Add(labelA);

                                AfficheLabel();
                            }
                            else
                            {
                                MessageBox.Show("Erreur de détection du verbe");
                            }
                        }
                        else if (genreArt == 1)
                        {
                            indexArticle = "2";
                            Nom(plurArt, "Feminin");
                            Verbe("elle");

                            LabelPerso labelArt = new LabelPerso(article.GetFeminin());
                            labelArt.Text = article.GetFeminin();
                            lesLabels.Add(labelArt);

                            LabelPerso labelN = new LabelPerso(nomStock);
                            labelN.Text = nomStock;
                            lesLabels.Add(labelN);

                            LabelPerso labelV = new LabelPerso(conjugaisonStock);
                            labelV.Text = conjugaisonStock;
                            lesLabels.Add(labelV);
                            
                            if (verbeStock.GetGenre() == "Etat")
                            {
                                Adjectif("Feminin", "0");
                                //MessageBox.Show(article.GetFeminin() + " " + 
                                //    nomStock + " " +
                                //    conjugaisonStock + " " +
                                //    adjStock);

                                LabelPerso labelA = new LabelPerso(adjStock);
                                labelA.Text = adjStock;
                                lesLabels.Add(labelA);

                                AfficheLabel();
                            }
                            else if (verbeStock.GetGenre() == "Action" || verbeStock.GetGenre() == "Mouvement")
                            {
                                Adverbe();
                                //MessageBox.Show(article.GetFeminin() + " " + 
                                //    nomStock + " " + 
                                //    conjugaisonStock + " " +
                                //    advStock);

                                LabelPerso labelA = new LabelPerso(advStock);
                                labelA.Text = advStock;
                                lesLabels.Add(labelA);

                                AfficheLabel();
                            }
                            else
                            {
                                MessageBox.Show("Erreur de détection du verbe");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Erreur lors du choix de l'article ou de l'adjectif possessif");
                        }
                    }
                    else if(plurArt == "1")
                    {
                        indexArticle = "3";
                        if (genreArt == 0)
                        {
                            Nom(plurArt, "Masculin");
                            Verbe("ils");

                            LabelPerso labelArt = new LabelPerso(article.GetPluriel());
                            labelArt.Text = article.GetPluriel();
                            lesLabels.Add(labelArt);

                            LabelPerso labelN = new LabelPerso(nomStock);
                            labelN.Text = nomStock;
                            lesLabels.Add(labelN);

                            LabelPerso labelV = new LabelPerso(conjugaisonStock);
                            labelV.Text = conjugaisonStock;
                            lesLabels.Add(labelV);

                            if (verbeStock.GetGenre() == "Etat")
                            {
                                Adjectif("Masculin", "1");
                                //MessageBox.Show(article.GetPluriel() + " " +
                                //    nomStock + " " +
                                //    conjugaisonStock + " " +
                                //    adjStock);

                                LabelPerso labelA = new LabelPerso(adjStock);
                                labelA.Text = adjStock;
                                lesLabels.Add(labelA);

                                AfficheLabel();
                            }
                            else if (verbeStock.GetGenre() == "Action" || verbeStock.GetGenre() == "Mouvement")
                            {
                                Adverbe();
                                //MessageBox.Show(article.GetPluriel() + " " + 
                                //    nomStock + " " + 
                                //    conjugaisonStock + " " +
                                //    advStock);

                                LabelPerso labelA = new LabelPerso(advStock);
                                labelA.Text = advStock;
                                lesLabels.Add(labelA);

                                AfficheLabel();
                            }
                            else
                            {
                                MessageBox.Show("Erreur de détection du verbe");
                            }
                        }
                        else if(genreArt == 1)
                        {
                            Nom(plurArt, "Feminin");
                            Verbe("elles");

                            LabelPerso labelArt = new LabelPerso(article.GetMasculin());
                            labelArt.Text = article.GetMasculin();
                            lesLabels.Add(labelArt);

                            LabelPerso labelN = new LabelPerso(nomStock);
                            labelN.Text = nomStock;
                            lesLabels.Add(labelN);

                            LabelPerso labelV = new LabelPerso(conjugaisonStock);
                            labelV.Text = conjugaisonStock;
                            lesLabels.Add(labelV);

                            if (verbeStock.GetGenre() == "Etat")
                            {
                                Adjectif("Feminin", "1");
                                //MessageBox.Show(article.GetPluriel() + " " + 
                                //    nomStock + " " +
                                //    conjugaisonStock + " " +
                                //    adjStock);

                                LabelPerso labelA = new LabelPerso(adjStock);
                                labelA.Text = adjStock;
                                lesLabels.Add(labelA);

                                AfficheLabel();
                            }
                            else if (verbeStock.GetGenre() == "Action" || verbeStock.GetGenre() == "Mouvement")
                            {
                                //MessageBox.Show(article.GetPluriel() + " " + 
                                //    nomStock + " " + 
                                //    conjugaisonStock + " " +
                                //    advStock);

                                LabelPerso labelA = new LabelPerso(advStock);
                                labelA.Text = advStock;
                                lesLabels.Add(labelA);

                                AfficheLabel();
                            }
                            else
                            {
                                MessageBox.Show("Erreur de détection du verbe");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Erreur lors du choix de l'article ou de l'adjectif possessif");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Erreur de sélection du pluriel de l'article");
                    }
                }
                else
                {
                    MessageBox.Show("Erreur de sélection de multiplicité de l'article");
                }
            }
            else if(num == 1)
            {
                lesMots = Bdd.SelectAllPronoms();
                int index = random.Next(lesMots.Count);
                Pronom pronom = (Pronom)Bdd.SelectPronomBySingulier(lesMots[index].getTexte());
                idPronom = pronom.GetId();
                pronomStock = pronom.getTexte();
                Verbe(pronom.getTexte());
                string femMasc;
                if (verbeStock.GetGenre() == "Etat")
                {
                    if (pronom.GetPluriel() == "0")
                    {
                        if (pronom.GetGenre() == "Masculin" || pronom.GetGenre() == "Feminin")
                        {
                            femMasc = pronom.GetGenre();
                            Adjectif(femMasc, "0");
                            //MessageBox.Show(pronom.getTexte() + " " +
                            //    conjugaisonStock + " " +
                            //    adjStock);

                            LabelPerso labelP = new LabelPerso(pronom.getTexte());
                            labelP.Text = pronom.getTexte();
                            lesLabels.Add(labelP);

                            LabelPerso labelV = new LabelPerso(conjugaisonStock);
                            labelV.Text = conjugaisonStock;
                            lesLabels.Add(labelV);

                            LabelPerso labelA = new LabelPerso(adjStock);
                            labelA.Text = adjStock;
                            lesLabels.Add(labelA);

                            AfficheLabel();

                        }
                        else if (pronom.GetGenre() == "Indifferent")
                        {
                            if ((pronom.getTexte() == "je" && verbeConjugueStock[0].ToString() == "a") ||
                                (pronom.getTexte() == "je" && verbeConjugueStock[0].ToString() == "e") ||
                                (pronom.getTexte() == "je" && verbeConjugueStock[0].ToString() == "i") ||
                                (pronom.getTexte() == "je" && verbeConjugueStock[0].ToString() == "o") ||
                                (pronom.getTexte() == "je" && verbeConjugueStock[0].ToString() == "u"))
                            {
                                femMasc = "Masculin";
                                Adjectif(femMasc, "0");
                                //MessageBox.Show("j'" +
                                //    conjugaisonStock + " " +
                                //    adjStock);

                                //LabelPerso labelPersoAP = new LabelPerso("j'");
                                //labelPersoAP.Text = "j'";
                                LabelPerso labelP = new LabelPerso("j'");
                                labelP.Text = "j'";
                                lesLabels.Add(labelP);

                                LabelPerso labelV = new LabelPerso(conjugaisonStock);
                                labelV.Text = conjugaisonStock;
                                lesLabels.Add(labelV);

                                LabelPerso labelA = new LabelPerso(adjStock);
                                labelA.Text = adjStock;
                                lesLabels.Add(labelA);

                                AfficheLabel();
                            }
                            int indexChoose = random.Next(0, 2);
                            if (indexChoose == 0)
                            {
                                femMasc = "Masculin";
                                Adjectif(femMasc, "0");
                                //MessageBox.Show(pronom.getTexte() + " " +
                                //    conjugaisonStock + " " +
                                //    adjStock);

                                LabelPerso labelP = new LabelPerso(pronom.getTexte());
                                labelP.Text = pronom.getTexte();
                                lesLabels.Add(labelP);

                                LabelPerso labelV = new LabelPerso(conjugaisonStock);
                                labelV.Text = conjugaisonStock;
                                lesLabels.Add(labelV);

                                LabelPerso labelA = new LabelPerso(adjStock);
                                labelA.Text = adjStock;
                                lesLabels.Add(labelA);

                                AfficheLabel();
                            }
                            else if (indexChoose == 1)
                            {
                                femMasc = "Feminin";
                                Adjectif(femMasc, pronom.GetPluriel());
                                //MessageBox.Show(pronom.getTexte() + " " +
                                //    conjugaisonStock + " " +
                                //    adjStock);

                                LabelPerso labelP = new LabelPerso(pronom.getTexte());
                                labelP.Text = pronom.getTexte();
                                lesLabels.Add(labelP);

                                LabelPerso labelV = new LabelPerso(conjugaisonStock);
                                labelV.Text = conjugaisonStock;
                                lesLabels.Add(labelV);

                                LabelPerso labelA = new LabelPerso(adjStock);
                                labelA.Text = adjStock;
                                lesLabels.Add(labelA);

                                AfficheLabel();
                            }
                            else
                            {
                                MessageBox.Show("Erreur de sélection de genre de l'adjectif : Random number failed");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Erreur de sélection de genre de l'adjectif");
                        }
                    }
                    else if (pronom.GetPluriel() == "1")
                    {
                        if (pronom.GetGenre() == "Masculin" || pronom.GetGenre() == "Feminin")
                        {
                            femMasc = pronom.GetGenre();
                            Adjectif(femMasc, pronom.GetPluriel());
                            //MessageBox.Show(pronom.getTexte() + " " +
                            //    conjugaisonStock + " " +
                            //    adjStock);

                            LabelPerso labelP = new LabelPerso(pronom.getTexte());
                            labelP.Text = pronom.getTexte();
                            lesLabels.Add(labelP);

                            LabelPerso labelV = new LabelPerso(conjugaisonStock);
                            labelV.Text = conjugaisonStock;
                            lesLabels.Add(labelV);

                            LabelPerso labelA = new LabelPerso(adjStock);
                            labelA.Text = adjStock;
                            lesLabels.Add(labelA);

                            AfficheLabel();
                        }
                        else if (pronom.GetGenre() == "Indifferent")
                        {
                            int indexChoose = random.Next(0, 2);
                            if (indexChoose == 0)
                            {
                                femMasc = "Masculin";
                                Adjectif(femMasc, pronom.GetPluriel());
                                //MessageBox.Show(pronom.getTexte() + " " +
                                //    conjugaisonStock + " " +
                                //    adjStock);

                                LabelPerso labelP = new LabelPerso(pronom.getTexte());
                                labelP.Text = pronom.getTexte();
                                lesLabels.Add(labelP);

                                LabelPerso labelV = new LabelPerso(conjugaisonStock);
                                labelV.Text = conjugaisonStock;
                                lesLabels.Add(labelV);

                                LabelPerso labelA = new LabelPerso(adjStock);
                                labelA.Text = adjStock;
                                lesLabels.Add(labelA);

                                AfficheLabel();
                            }
                            else if (indexChoose == 1)
                            {
                                femMasc = "Feminin";
                                Adjectif(femMasc, pronom.GetPluriel());
                                //MessageBox.Show(pronom.getTexte() + " " +
                                //    conjugaisonStock + " " +
                                //    adjStock);

                                LabelPerso labelP = new LabelPerso(pronom.getTexte());
                                labelP.Text = pronom.getTexte();
                                lesLabels.Add(labelP);

                                LabelPerso labelV = new LabelPerso(conjugaisonStock);
                                labelV.Text = conjugaisonStock;
                                lesLabels.Add(labelV);

                                LabelPerso labelA = new LabelPerso(adjStock);
                                labelA.Text = adjStock;
                                lesLabels.Add(labelA);

                                AfficheLabel();
                            }
                            else
                            {
                                MessageBox.Show("Erreur de sélection du genre de l'adjectif : Random number failed");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Erreur de sélection du genre de l'adjectif");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Erreur de sélection de la multiplicité du pronom");
                    }
                }
                else if(verbeStock.GetGenre() == "Action" || verbeStock.GetGenre() == "Mouvement")
                {
                    if ((pronom.getTexte() == "je" && verbeConjugueStock[0].ToString() == "a") ||
                        (pronom.getTexte() == "je" && verbeConjugueStock[0].ToString() == "e") ||
                        (pronom.getTexte() == "je" && verbeConjugueStock[0].ToString() == "i") ||
                        (pronom.getTexte() == "je" && verbeConjugueStock[0].ToString() == "o") ||
                        (pronom.getTexte() == "je" && verbeConjugueStock[0].ToString() == "u"))
                    {
                        femMasc = "Masculin";
                        Adverbe();
                        //MessageBox.Show("j'" +
                        //    conjugaisonStock + " " +
                        //    advStock);

                        LabelPerso labelP = new LabelPerso("j'");
                        labelP.Text = "j'";
                        lesLabels.Add(labelP);

                        LabelPerso labelV = new LabelPerso(conjugaisonStock);
                        labelV.Text = conjugaisonStock;
                        lesLabels.Add(labelV);

                        LabelPerso labelA = new LabelPerso(advStock);
                        labelA.Text = advStock;
                        lesLabels.Add(labelA);

                        AfficheLabel();
                    }
                    else
                    {
                        Adverbe();

                        LabelPerso labelP = new LabelPerso(pronom.getTexte());
                        labelP.Text = pronom.getTexte();
                        lesLabels.Add(labelP);

                        LabelPerso labelV = new LabelPerso(conjugaisonStock);
                        labelV.Text = conjugaisonStock;
                        lesLabels.Add(labelV);

                        LabelPerso labelA = new LabelPerso(advStock);
                        labelA.Text = advStock;
                        lesLabels.Add(labelA);

                        AfficheLabel();
                    }
                }
                else
                {
                    MessageBox.Show("Erreur de détection du verbe");
                }
            }
            else
            {
                MessageBox.Show("Une erreur est survenue");
            }
        }

        private string Nom(string pluriel, string genre)
        {
            lesMots.Clear();
            var random = new Random();
            if (genre == "Feminin")
            {
                lesMots = Bdd.SelectNomsByGenre("Feminin");
                int indexN = random.Next(lesMots.Count);
                Nom nom = (Nom)lesMots[indexN];
                idNom = nom.GetId();
                if (pluriel == "0")
                {
                    nomStock = nom.GetSingulier();
                    indexNom = "1";
                    return nomStock;
                }
                else if(pluriel == "1")
                {
                    nomStock = nom.GetPluriel();
                    indexNom = "2";
                    return nomStock;
                }
                else
                {
                    return "Erreur dans la sélection de la multiplicté du nom";
                }
            }
            else if(genre == "Masculin")
            {
                lesMots = Bdd.SelectNomsByGenre("Masculin");
                int indexN = random.Next(lesMots.Count);
                Nom nom = (Nom)lesMots[indexN];
                idNom = nom.GetId();
                if (pluriel == "0")
                {
                    nomStock = nom.GetSingulier();
                    indexNom = "1";
                    return nomStock;
                }
                else if(pluriel == "1")
                {
                    nomStock = nom.GetPluriel();
                    indexNom = "2";
                    return nomStock;
                }
                else
                {
                    return "Erreur dans la sélection de la multiplicité du nom";
                }
            }
            else
            {
                return "Erreur dans la sélection de genre du nom";
            }
        }

        private string Verbe(string sujet)
        {
            lesMots.Clear();
            var random = new Random();
            lesMots = Bdd.SelectAllVerbes();
            int indexVerbe = random.Next(lesMots.Count);
            Verbe verbe = (Verbe)lesMots[indexVerbe];
            lesMots.Clear();
            Conjugaison conjugaison = (Conjugaison)Bdd.SelectConjugaisonByVerbe(verbe.id);
            verbeStock = verbe;
            if (sujet == "je")
            {
                conjugaisonStock = conjugaison.GetPremierSing();
                verbeConjugueStock = conjugaisonStock;
                indexPronom = "1";
                indexConjugaison = "1";
                return conjugaisonStock;
            }
            else if (sujet == "tu")
            {
                conjugaisonStock = conjugaison.GetDeuxiemeSing();
                verbeConjugueStock = conjugaisonStock;
                indexPronom = "2";
                indexConjugaison = "2";
                return conjugaisonStock;
            }
            else if(sujet == "il" || sujet == "elle" || sujet == "on")
            {
                conjugaisonStock = conjugaison.GetTroisiemeSing();
                verbeConjugueStock = conjugaisonStock;
                indexPronom = "3";
                indexConjugaison = "3";
                return conjugaisonStock;
            }
            else if (sujet == "nous")
            {
                conjugaisonStock = conjugaison.GetPremierPlur();
                verbeConjugueStock = conjugaisonStock;
                indexPronom = "4";
                indexConjugaison = "4";
                return conjugaisonStock;
            }
            else if (sujet == "vous")
            {
                conjugaisonStock = conjugaison.GetDeuxiemePlur();
                verbeConjugueStock = conjugaisonStock;
                indexPronom = "5";
                indexConjugaison = "5";
                return conjugaisonStock;
            }
            else if (sujet == "ils" || sujet == "elles")
            {
                conjugaisonStock = conjugaison.GetTroisiemePlur();
                verbeConjugueStock = conjugaisonStock;
                indexPronom = "6";
                indexConjugaison = "6";
                return conjugaisonStock;
            }
            else
            {
                return "Erreur détermination de la conjugaison";
            }
        }

        private string Adjectif(string genre, string pluriel)
        {
            lesMots.Clear();
            var random = new Random();
            lesMots = Bdd.SelectAllAdjectifsByFonction("qualificatif");
            int indexAdj = random.Next(lesMots.Count);
            Adjectif adj = (Adjectif)lesMots[indexAdj];
            idAdjectif = adj.GetId();
            if (genre == "Masculin")
            {
                if (pluriel == "0")
                {
                    adjStock = adj.GetSingMasculin();
                    indexAdjectif = "1";
                    return adjStock;
                }
                else if (pluriel == "1")
                {
                    adjStock = adj.GetPlurMasculin();
                    indexAdjectif = "3";
                    return adjStock;
                }
                else
                {
                    return "Erreur de sélection de multiplicité de l'adjectif";
                }
            }
            else if (genre == "Feminin")
            {
                if (pluriel == "0")
                {
                    adjStock = adj.GetSingFeminin();
                    indexAdjectif = "2";
                    return adjStock;
                }
                else if (pluriel == "1")
                {
                    adjStock = adj.GetPlurFeminin();
                    indexAdjectif = "4";
                    return adjStock;
                }
                else
                {
                    return "Erreur de sélection de multiplicité de l'adjectif";
                }
            }
            else
            {
                return "Erreur de sélection du genre de l'adjectif";
            }
        }

        private string Adverbe()
        {
            lesMots.Clear();
            var random = new Random();
            lesMots = Bdd.SelectAllAdverbes();
            int index = random.Next(lesMots.Count);
            Adverbe adv = (Adverbe)lesMots[index];
            idAdverbe = adv.GetId();
            advStock = adv.GetAdverbe();
            return advStock;
        }


        private void SuppLabel()
        {
            MessageBox.Show("SuppLabel() lesLabels.Count = " + lesLabels.Count.ToString());
            foreach(LabelPerso unLabel in lesLabels)
            {
                MessageBox.Show("unLabel = " + unLabel.Text);
                //Controls.Remove(Controls["label"]);
            }
            lesLabels.Clear();
        }

        private void AfficheLabel()
        {
            int x = 150;
            //foreach(Label unlabel in lesLabels)
            //{
            //    Label label = new LabelPerso(" ");
            //    label.Text = unlabel.Text;
            //    label.Top = 50;
            //    label.Left = x;
            //    SizeF stringSize = new SizeF();
            //    Graphics g = AjoutPhrase.CreateGraphics();
            //    stringSize = g.MeasureString(unlabel.Text, label.Font);
            //    label.Width = Convert.ToInt32(stringSize.Width) + 5;
            //    this.Controls.Add(label);
            //    x = x + Convert.ToInt32(stringSize.Width) + 5;
            //    MessageBox.Show(Convert.ToString(Convert.ToInt32(stringSize.Width)), "My Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            foreach(LabelPerso unLabel in lesLabels)
            {
                LabelPerso label = new LabelPerso(" ");
                label.Text = unLabel.Text;
                label.Top = 50;
                label.Left = x;
                SizeF stringSize = new SizeF();
                Graphics g = CreateGraphics();
                stringSize = g.MeasureString(label.Text, label.Font);
                label.Width = Convert.ToInt32(stringSize.Width);
                label.AutoSize = true;
                this.Controls.Add(label);
                x = x + Convert.ToInt32(stringSize.Width) + 5;
                //MessageBox.Show(Convert.ToString(Convert.ToInt32(stringSize.Width)), "My Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        /* --- Validation de phrase --- */ 
        private void button2_Click(object sender, EventArgs e)
        {
            Bdd.InsertPhrase(idAdjP, indexAdjP, idArticle, indexArticle, idPronom, indexPronom, idNom, indexNom, verbeStock.GetId(), indexConjugaison, idAdverbe, idAdjectif, indexAdjectif);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
