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
    public partial class Jouer : Form
    {
        public String typeQuestion;
        public String phraseId;
        public String phraseIdAP;
        public String phraseAP = null;
        public String phraseIdArt;
        public String phraseArt = null;
        public String phraseIdP;
        public String phraseP = null;
        public String phraseIdN;
        public String phraseN = null;
        public String phraseIdV;
        public String phraseC = null;
        public String phraseIdAdv;
        public String phraseAdv = null;
        public String phraseIdAdj;
        public String phraseAdj = null;

        private List<Phrase> lesPhrases;
        private List<LabelPerso> lesLabels;
        private List<Mot> lesMots;
        private Utilisateur utilisateur;
        private int score;

        public Jouer(Utilisateur utilisateur)
        {
            this.utilisateur = utilisateur;
            InitializeComponent();
            lesLabels = new List<LabelPerso>();
            lesMots = new List<Mot>();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bravo vous avez trouvé le verbe ! Vous gagnez 1 point !");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dommage ! Le verbe était 'est'. Vous perdez 1 point !");
        }

        private void Jouer_Load(object sender, EventArgs e)
        {
            StartGame();
            score = Convert.ToInt32(utilisateur.Score);
            ScoreLabel.Text = score.ToString();

        }

        public void StartGame() { 
            var random = new Random();
            //Affiche une question aléatoire
            int numberOfQuestions = Bdd.SelectAllQuestion().Count;
            if (numberOfQuestions != 0)
            {
                int indexQuestion = random.Next(numberOfQuestions);
                Question question = Bdd.SelectAllQuestion().ElementAt(indexQuestion);
                typeQuestion = question.GetTypeQuestion();
                int x;
                if (question.GetLibelle().Length <= 19)
                {
                    x = 170;
                }
                else
                {
                    x = 80;
                }
                LabelPerso labelQ = new LabelPerso();
                labelQ.Text = question.GetLibelle().ToString();
                labelQ.AutoSize = true;
                labelQ.Top = 70;
                labelQ.Left = x;
                labelQ.ForeColor = Color.FromArgb(128, 128, 255);
                labelQ.Font = new Font("Arial", 28);
                SizeF stringSize = new SizeF();
                Graphics g = CreateGraphics();
                stringSize = g.MeasureString(labelQ.Text, labelQ.Font);
                labelQ.Width = Convert.ToInt32(stringSize.Width);
                Controls.Add(labelQ);
            }
            else
            {
                MessageBox.Show("Erreur: Échec lors de la récupération des questions !");
            }



            lesPhrases = Bdd.SelectAllPhrases();
            int indexPhrase = random.Next(lesPhrases.Count);
            Phrase phrase = (Phrase)lesPhrases[indexPhrase];
            if(phrase.GetIdAdjectifPossessif().ToString().Length != 0)
            {
                phraseIdAP = phrase.GetIdAdjectifPossessif();
                Adjectif adj = Bdd.SelectAdjectifById(phrase.GetIdAdjectifPossessif().ToString());
                if(phrase.GetAdjectifPossessif().ToString() == "1")
                {
                    phraseAP = adj.GetSingMasculin();
                    LabelPerso labelAP = new LabelPerso();
                    labelAP.Text = adj.GetSingMasculin();
                    lesLabels.Add(labelAP);
                }
                else if (phrase.GetAdjectifPossessif().ToString() == "2")
                {
                    phraseAP = adj.GetSingFeminin();
                    LabelPerso labelAP = new LabelPerso();
                    labelAP.Text = adj.GetSingFeminin();
                    lesLabels.Add(labelAP);
                }
                else if (phrase.GetAdjectifPossessif().ToString() == "3")
                {
                    phraseAP = adj.GetPlurMasculin();
                    LabelPerso labelAP = new LabelPerso();
                    labelAP.Text = adj.GetPlurMasculin();
                    lesLabels.Add(labelAP);
                }
                else if (phrase.GetAdjectifPossessif().ToString() == "4")
                {
                    phraseAP = adj.GetPlurFeminin();
                    LabelPerso labelAP = new LabelPerso();
                    labelAP.Text = adj.GetPlurFeminin();
                    lesLabels.Add(labelAP);
                }
            }

            if (phrase.GetIdArticle().ToString().Length != 0)
            {
                Article article = Bdd.SelectArticleById(phrase.GetIdArticle().ToString());
                phraseIdArt = article.GetId();
                if (phrase.GetArticle().ToString() == "1")
                {
                    phraseArt = article.GetMasculin();
                    LabelPerso labelArt = new LabelPerso();
                    labelArt.Text = article.GetMasculin();
                    lesLabels.Add(labelArt);
                }
                else if (phrase.GetArticle().ToString() == "2")
                {
                    phraseArt = article.GetFeminin();
                    LabelPerso labelArt = new LabelPerso();
                    labelArt.Text = article.GetFeminin();
                    lesLabels.Add(labelArt);
                }
                else if(phrase.GetArticle().ToString() == "3")
                {
                    phraseArt = article.GetPluriel();
                    LabelPerso labelArt = new LabelPerso();
                    labelArt.Text = article.GetPluriel();
                    lesLabels.Add(labelArt);
                }
            }

            if(phrase.GetIdPronom().ToString().Length != 0)
            {
                Pronom pronom = Bdd.SelectPronomById(phrase.GetIdPronom().ToString());
                phraseIdP = pronom.GetId();
                phraseP = pronom.getTexte();
                LabelPerso labelP = new LabelPerso();
                labelP.Text = pronom.getTexte();
                lesLabels.Add(labelP);                
            }

            if (phrase.GetIdNom().ToString().Length != 0)
            {
                Nom nom = Bdd.SelectNomById(phrase.GetIdNom().ToString());
                phraseIdN = nom.GetId();
                if (phrase.GetNom().ToString() == "1")
                {
                    phraseN = nom.GetSingulier();
                    LabelPerso labelN = new LabelPerso();
                    labelN.Text = nom.GetSingulier();
                    lesLabels.Add(labelN);
                }
                else if(phrase.GetNom().ToString() == "2")
                {
                    phraseN = nom.GetPluriel();
                    LabelPerso labelN = new LabelPerso();
                    labelN.Text = nom.GetPluriel();
                    lesLabels.Add(labelN);
                }
            }

            Conjugaison conjugaison = (Conjugaison)Bdd.SelectConjugaisonById(phrase.GetIdVerbe().ToString());
            if(phrase.GetConjugaison().ToString() == "1")
            {
                phraseIdV = conjugaison.GetIdverbe();
                phraseC = conjugaison.GetPremierSing();
                LabelPerso labelV = new LabelPerso();
                labelV.Text = conjugaison.premierSing;
                lesLabels.Add(labelV);
            }
            else if(phrase.GetConjugaison().ToString() == "2")
            {
                phraseIdV = conjugaison.GetIdverbe();
                phraseC = conjugaison.GetDeuxiemeSing();
                LabelPerso labelV = new LabelPerso();
                labelV.Text = conjugaison.deuxiemeSing;
                lesLabels.Add(labelV);
            }
            else if (phrase.GetConjugaison().ToString() == "3")
            {
                phraseIdV = conjugaison.GetIdverbe();
                phraseC = conjugaison.GetTroisiemeSing();
                LabelPerso labelV = new LabelPerso();
                labelV.Text = conjugaison.troisiemeSing;
                lesLabels.Add(labelV);
            }
            else if (phrase.GetConjugaison().ToString() == "4")
            {
                phraseIdV = conjugaison.GetIdverbe();
                phraseC = conjugaison.GetPremierPlur();
                LabelPerso labelV = new LabelPerso();
                labelV.Text = conjugaison.premierPlur;
                lesLabels.Add(labelV);
            }
            else if (phrase.GetConjugaison().ToString() == "5")
            {
                phraseIdV = conjugaison.GetIdverbe();
                phraseC = conjugaison.GetDeuxiemePlur();
                LabelPerso labelV = new LabelPerso();
                labelV.Text = conjugaison.deuxiemePlur;
                lesLabels.Add(labelV);
            }
            else if (phrase.GetConjugaison().ToString() == "6")
            {
                phraseIdV = conjugaison.GetIdverbe();
                phraseC = conjugaison.GetTroisiemePlur();
                LabelPerso labelV = new LabelPerso();
                labelV.Name = "labelV";
                labelV.Text = conjugaison.troisiemePlur;
                lesLabels.Add(labelV);
            }
            else
            {
                MessageBox.Show("Une erreur est survenue lors de la récupération de la phrase");
            }

            if(phrase.GetIdAdjectif().ToString().Length != 0)
            {
                phraseIdAdj = phrase.GetIdAdjectif();
                Adjectif adj = Bdd.SelectAdjectifById(phrase.GetIdAdjectif().ToString());
                Adjectif adjectif = new Adjectif(adj.GetId(), adj.GetSingMasculin(), adj.GetSingFeminin(), adj.GetPlurMasculin(), adj.GetPlurFeminin(), adj.GetFonction());
                lesMots.Add(adjectif);
                if (phrase.GetAdjectif().ToString() == "1")
                {
                    phraseAdj = adj.GetSingMasculin();
                    LabelPerso labelA = new LabelPerso();
                    labelA.Text = adj.GetSingMasculin();
                    lesLabels.Add(labelA);
                }
                else if (phrase.GetAdjectif().ToString() == "2")
                {
                    phraseAdj = adj.GetSingFeminin();
                    LabelPerso labelA = new LabelPerso();
                    labelA.Text = adj.GetSingFeminin();
                    lesLabels.Add(labelA);
                }
                else if (phrase.GetAdjectif().ToString() == "3")
                {
                    phraseAdj = adj.GetPlurMasculin();
                    LabelPerso labelA = new LabelPerso();
                    labelA.Text = adj.GetPlurMasculin();
                    lesLabels.Add(labelA);
                }
                else if (phrase.GetAdjectif().ToString() == "4")
                {
                    phraseAdj = adj.GetPlurFeminin();
                    LabelPerso labelA = new LabelPerso();
                    labelA.Text = adj.GetPlurFeminin();
                    lesLabels.Add(labelA);
                }
            }
            if(phrase.GetIdAdverbe().ToString().Length != 0)
            {
                Adverbe adverbe = Bdd.SelectAdverbeById(phrase.GetIdAdverbe().ToString());
                phraseIdAdv = adverbe.GetId();
                phraseAdv = adverbe.getTexte();
                LabelPerso labelAdv = new LabelPerso();
                labelAdv.Text = adverbe.getTexte();
                lesLabels.Add(labelAdv);
            }
            
            AfficheLabel();
        }


        private void AfficheLabel()
        {
            int x;
            if (lesLabels.Count <= 4)
            {
                x = 140;
            }
            else
            {
                x = 60;
            }
            int index = 0;
            foreach (LabelPerso unLabel in lesLabels)
            {
                if (unLabel.Text == phraseAP || unLabel.Text == phraseAdj)
                {
                    if (unLabel.Text == phraseAP)
                    {
                        Adjectif adj = Bdd.SelectAdjectifById(phraseIdAP);
                        Adjectif adjectif = new Adjectif(adj.GetId(), adj.GetSingMasculin(), adj.GetSingFeminin(), adj.GetPlurMasculin(), adj.GetPlurFeminin(), adj.GetFonction());
                        lesMots.Add(adjectif);
                        int i = lesMots.IndexOf(adjectif);
                        Adjectif adjPhrase = (Adjectif)lesMots[i];
                        if (typeQuestion == "adjectif possessif")
                        {
                            LabelPerso label = new LabelPerso(adjPhrase);
                            if (index == 0)
                            {
                                label.Text = char.ToUpper(unLabel.Text[0]) + unLabel.Text.Substring(1);
                            }
                            else if (index == lesLabels.Count - 1)
                            {
                                label.Text = unLabel.Text + ".";
                            }
                            else
                            {
                                label.Text = unLabel.Text;
                            }
                            label.Font = new Font("Arial", 24);
                            label.Top = 150;
                            label.Left = x;
                            SizeF stringSize = new SizeF();
                            Graphics g = CreateGraphics();
                            stringSize = g.MeasureString(label.Text, label.Font);
                            label.Width = Convert.ToInt32(stringSize.Width);
                            label.AutoSize = true;
                            this.Controls.Add(label);
                            x = x + Convert.ToInt32(stringSize.Width) + 3;
                            index = index + 1;
                        }
                        else
                        {
                            LabelPerso label = new LabelPerso();
                            if (index == 0)
                            {
                                label.Text = char.ToUpper(unLabel.Text[0]) + unLabel.Text.Substring(1);
                            }
                            else if (index == lesLabels.Count - 1)
                            {
                                label.Text = unLabel.Text + ".";
                            }
                            else
                            {
                                label.Text = unLabel.Text;
                            }
                            label.Font = new Font("Arial", 24);
                            label.Top = 150;
                            label.Left = x;
                            SizeF stringSize = new SizeF();
                            Graphics g = CreateGraphics();
                            stringSize = g.MeasureString(label.Text, label.Font);
                            label.Width = Convert.ToInt32(stringSize.Width);
                            label.AutoSize = true;
                            this.Controls.Add(label);
                            x = x + Convert.ToInt32(stringSize.Width) + 3;
                            index = index + 1;
                        }
                    }
                    else if (unLabel.Text == phraseAdj)
                    {
                        Adjectif adj = Bdd.SelectAdjectifById(phraseIdAdj);
                        Adjectif adjectif = new Adjectif(adj.GetId(), adj.GetSingMasculin(), adj.GetSingFeminin(), adj.GetPlurMasculin(), adj.GetPlurFeminin(), adj.GetFonction());
                        lesMots.Add(adjectif);
                        int i = lesMots.IndexOf(adjectif);
                        Adjectif adjPhrase = (Adjectif)lesMots[i];
                        if (typeQuestion == "adjectif")
                        {
                            LabelPerso label = new LabelPerso(adjPhrase);
                            if (index == 0)
                            {
                                label.Text = char.ToUpper(unLabel.Text[0]) + unLabel.Text.Substring(1);
                            }
                            else if (index == lesLabels.Count - 1)
                            {
                                label.Text = unLabel.Text + ".";
                            }
                            else
                            {
                                label.Text = unLabel.Text;
                            }
                            label.Font = new Font("Arial", 24);
                            label.Top = 150;
                            label.Left = x;
                            SizeF stringSize = new SizeF();
                            Graphics g = CreateGraphics();
                            stringSize = g.MeasureString(label.Text, label.Font);
                            label.Width = Convert.ToInt32(stringSize.Width);
                            label.AutoSize = true;
                            this.Controls.Add(label);
                            x = x + Convert.ToInt32(stringSize.Width) + 3;
                            index = index + 1;
                        }
                        else
                        {
                            LabelPerso label = new LabelPerso();
                            if (index == 0)
                            {
                                label.Text = char.ToUpper(unLabel.Text[0]) + unLabel.Text.Substring(1);
                            }
                            else if (index == lesLabels.Count - 1)
                            {
                                label.Text = unLabel.Text + ".";
                            }
                            else
                            {
                                label.Text = unLabel.Text;
                            }
                            label.Font = new Font("Arial", 24);
                            label.Top = 150;
                            label.Left = x;
                            SizeF stringSize = new SizeF();
                            Graphics g = CreateGraphics();
                            stringSize = g.MeasureString(label.Text, label.Font);
                            label.Width = Convert.ToInt32(stringSize.Width);
                            label.AutoSize = true;
                            this.Controls.Add(label);
                            x = x + Convert.ToInt32(stringSize.Width) + 3;
                            index = index + 1;
                        }
                    }
                }
                else if(unLabel.Text == phraseArt)
                {
                    Article art = Bdd.SelectArticleById(phraseIdArt);
                    Article article = new Article(art.GetId(), art.GetMasculin(), art.GetFeminin(), art.GetPluriel());
                    lesMots.Add(article);
                    int i = lesMots.IndexOf(article);
                    Article articlePhrase = (Article)lesMots[i];
                    if (typeQuestion == "article")
                    {
                        LabelPerso label = new LabelPerso(articlePhrase);
                        if (index == 0)
                        {
                            label.Text = char.ToUpper(unLabel.Text[0]) + unLabel.Text.Substring(1);
                        }
                        else if (index == lesLabels.Count - 1)
                        {
                            label.Text = unLabel.Text + ".";
                        }
                        else
                        {
                            label.Text = unLabel.Text;
                        }
                        label.Font = new Font("Arial", 24);
                        label.Top = 150;
                        label.Left = x;
                        SizeF stringSize = new SizeF();
                        Graphics g = CreateGraphics();
                        stringSize = g.MeasureString(label.Text, label.Font);
                        label.Width = Convert.ToInt32(stringSize.Width);
                        label.AutoSize = true;
                        this.Controls.Add(label);
                        x = x + Convert.ToInt32(stringSize.Width) + 3;
                        index = index + 1;
                    }
                    else
                    {
                        LabelPerso label = new LabelPerso();
                        if (index == 0)
                        {
                            label.Text = char.ToUpper(unLabel.Text[0]) + unLabel.Text.Substring(1);
                        }
                        else if (index == lesLabels.Count - 1)
                        {
                            label.Text = unLabel.Text + ".";
                        }
                        else
                        {
                            label.Text = unLabel.Text;
                        }
                        label.Text = unLabel.Text;
                        label.Font = new Font("Arial", 24);
                        label.Top = 150;
                        label.Left = x;
                        SizeF stringSize = new SizeF();
                        Graphics g = CreateGraphics();
                        stringSize = g.MeasureString(label.Text, label.Font);
                        label.Width = Convert.ToInt32(stringSize.Width);
                        label.AutoSize = true;
                        this.Controls.Add(label);
                        x = x + Convert.ToInt32(stringSize.Width) + 3;
                        index = index + 1;
                    }
                }
                else if (unLabel.Text == phraseP)
                {
                    Pronom p = Bdd.SelectPronomById(phraseIdP);
                    Pronom pronom = new Pronom(p.GetId(), p.getTexte(), p.GetPluriel(), p.GetGenre());
                    lesMots.Add(pronom);
                    int i = lesMots.IndexOf(pronom);
                    Pronom pronomPhrase = (Pronom)lesMots[i];
                    if (typeQuestion == "pronom")
                    {
                        LabelPerso label = new LabelPerso(pronomPhrase);
                        if (index == 0)
                        {
                            label.Text = char.ToUpper(unLabel.Text[0]) + unLabel.Text.Substring(1);
                        }
                        else if (index == lesLabels.Count - 1)
                        {
                            label.Text = unLabel.Text + ".";
                        }
                        else
                        {
                            label.Text = unLabel.Text;
                        }
                        label.Font = new Font("Arial", 24);
                        label.Top = 150;
                        label.Left = x;
                        SizeF stringSize = new SizeF();
                        Graphics g = CreateGraphics();
                        stringSize = g.MeasureString(label.Text, label.Font);
                        label.Width = Convert.ToInt32(stringSize.Width);
                        label.AutoSize = true;
                        this.Controls.Add(label);
                        x = x + Convert.ToInt32(stringSize.Width) + 3;
                        index = index + 1;
                    }
                    else
                    {
                        LabelPerso label = new LabelPerso();
                        if (index == 0)
                        {
                            label.Text = char.ToUpper(unLabel.Text[0]) + unLabel.Text.Substring(1);
                        }
                        else if (index == lesLabels.Count - 1)
                        {
                            label.Text = unLabel.Text + ".";
                        }
                        else
                        {
                            label.Text = unLabel.Text;
                        }
                        label.Font = new Font("Arial", 24);
                        label.Top = 150;
                        label.Left = x;
                        SizeF stringSize = new SizeF();
                        Graphics g = CreateGraphics();
                        stringSize = g.MeasureString(label.Text, label.Font);
                        label.Width = Convert.ToInt32(stringSize.Width);
                        label.AutoSize = true;
                        this.Controls.Add(label);
                        x = x + Convert.ToInt32(stringSize.Width) + 3;
                        index = index + 1;
                    }
                }
                else if (unLabel.Text == phraseN)
                {
                    Nom n = Bdd.SelectNomById(phraseIdN);
                    Nom nom = new Nom(n.GetId(), n.GetSingulier(), n.GetPluriel(), n.GetGenre());
                    lesMots.Add(nom);
                    int i = lesMots.IndexOf(nom);
                    Nom nomPhrase = (Nom)lesMots[i];
                    if (typeQuestion == "nom")
                    {
                        LabelPerso label = new LabelPerso(nomPhrase);
                        if (index == 0)
                        {
                            label.Text = char.ToUpper(unLabel.Text[0]) + unLabel.Text.Substring(1);
                        }
                        else if (index == lesLabels.Count - 1)
                        {
                            label.Text = unLabel.Text + ".";
                        }
                        else
                        {
                            label.Text = unLabel.Text;
                        }
                        label.Font = new Font("Arial", 24);
                        label.Top = 150;
                        label.Left = x;
                        SizeF stringSize = new SizeF();
                        Graphics g = CreateGraphics();
                        stringSize = g.MeasureString(label.Text, label.Font);
                        label.Width = Convert.ToInt32(stringSize.Width);
                        label.AutoSize = true;
                        this.Controls.Add(label);
                        x = x + Convert.ToInt32(stringSize.Width) + 3;
                        index = index + 1;
                    }
                    else
                    {
                        LabelPerso label = new LabelPerso();
                        if (index == 0)
                        {
                            label.Text = char.ToUpper(unLabel.Text[0]) + unLabel.Text.Substring(1);
                        }
                        else if (index == lesLabels.Count - 1)
                        {
                            label.Text = unLabel.Text + ".";
                        }
                        else
                        {
                            label.Text = unLabel.Text;
                        }
                        label.Font = new Font("Arial", 24);
                        label.Top = 150;
                        label.Left = x;
                        SizeF stringSize = new SizeF();
                        Graphics g = CreateGraphics();
                        stringSize = g.MeasureString(label.Text, label.Font);
                        label.Width = Convert.ToInt32(stringSize.Width);
                        label.AutoSize = true;
                        this.Controls.Add(label);
                        x = x + Convert.ToInt32(stringSize.Width) + 3;
                        index = index + 1;
                    }
                }
                else if(unLabel.Text == phraseC)
                {
                    Conjugaison c = Bdd.SelectConjugaisonByVerbe(phraseIdV);
                    Verbe v = Bdd.SelectVerbeById(phraseIdV);
                    lesMots.Add(v);
                    int i = lesMots.IndexOf(v);
                    Verbe verbePhrase = (Verbe)lesMots[i];
                    if (typeQuestion == "verbe")
                    {
                        LabelPerso label = new LabelPerso(verbePhrase);
                        if (index == 0)
                        {
                            label.Text = char.ToUpper(unLabel.Text[0]) + unLabel.Text.Substring(1);
                        }
                        else if (index == lesLabels.Count - 1)
                        {
                            label.Text = unLabel.Text + ".";
                        }
                        else
                        {
                            label.Text = unLabel.Text;
                        }
                        label.Font = new Font("Arial", 24);
                        label.Top = 150;
                        label.Left = x;
                        SizeF stringSize = new SizeF();
                        Graphics g = CreateGraphics();
                        stringSize = g.MeasureString(label.Text, label.Font);
                        label.Width = Convert.ToInt32(stringSize.Width);
                        label.AutoSize = true;
                        this.Controls.Add(label);
                        x = x + Convert.ToInt32(stringSize.Width) + 3;
                        index = index + 1;
                    }
                    else
                    {
                        LabelPerso label = new LabelPerso();
                        if (index == 0)
                        {
                            label.Text = char.ToUpper(unLabel.Text[0]) + unLabel.Text.Substring(1);
                        }
                        else if (index == lesLabels.Count - 1)
                        {
                            label.Text = unLabel.Text + ".";
                        }
                        else
                        {
                            label.Text = unLabel.Text;
                        }
                        label.Font = new Font("Arial", 24);
                        label.Top = 150;
                        label.Left = x;
                        SizeF stringSize = new SizeF();
                        Graphics g = CreateGraphics();
                        stringSize = g.MeasureString(label.Text, label.Font);
                        label.Width = Convert.ToInt32(stringSize.Width);
                        label.AutoSize = true;
                        this.Controls.Add(label);
                        x = x + Convert.ToInt32(stringSize.Width) + 3;
                        index = index + 1;
                    }
                }
                else if(unLabel.Text == phraseAdv)
                {
                    Adverbe adv = Bdd.SelectAdverbeById(phraseIdAdv);
                    Adverbe adverbe = new Adverbe(adv.GetId(), adv.getTexte());
                    lesMots.Add(adverbe);
                    int i = lesMots.IndexOf(adverbe);
                    Adverbe adverbePhrase = (Adverbe)lesMots[i];
                    if (typeQuestion == "adverbe")
                    {
                        LabelPerso label = new LabelPerso(adverbePhrase);
                        if (index == 0)
                        {
                            label.Text = char.ToUpper(unLabel.Text[0]) + unLabel.Text.Substring(1);
                        }
                        else if (index == lesLabels.Count - 1)
                        {
                            label.Text = unLabel.Text + ".";
                        }
                        else
                        {
                            label.Text = unLabel.Text;
                        }
                        label.Font = new Font("Arial", 24);
                        label.Top = 150;
                        label.Left = x;
                        SizeF stringSize = new SizeF();
                        Graphics g = CreateGraphics();
                        stringSize = g.MeasureString(label.Text, label.Font);
                        label.Width = Convert.ToInt32(stringSize.Width);
                        label.AutoSize = true;
                        this.Controls.Add(label);
                        x = x + Convert.ToInt32(stringSize.Width) + 3;
                        index = index + 1;
                    }
                    else
                    {
                        LabelPerso label = new LabelPerso();
                        if (index == 0)
                        {
                            label.Text = char.ToUpper(unLabel.Text[0]) + unLabel.Text.Substring(1);
                        }
                        else if (index == lesLabels.Count - 1)
                        {
                            label.Text = unLabel.Text + ".";
                        }
                        else
                        {
                            label.Text = unLabel.Text;
                        }
                        label.Font = new Font("Arial", 24);
                        label.Top = 150;
                        label.Left = x;
                        SizeF stringSize = new SizeF();
                        Graphics g = CreateGraphics();
                        stringSize = g.MeasureString(label.Text, label.Font);
                        label.Width = Convert.ToInt32(stringSize.Width);
                        label.AutoSize = true;
                        this.Controls.Add(label);
                        x = x + Convert.ToInt32(stringSize.Width) + 3;
                        index = index + 1;
                    }
                }
            }
            LabelGame();
        }

        private void LabelGame()
        {
            var lesLabels = this.Controls.OfType<LabelPerso>().ToList();

            foreach (LabelPerso u in lesLabels)
            {
                if (u.Text.Length <= 15)
                {
                    this.Controls.Add(u);

                    u.Click += (sender, args) =>
                    {
                        if (phraseP != null && (u.Text == char.ToUpper(phraseP[0]) + phraseP.Substring(1)
                        || u.Text == phraseP || u.Text == phraseP + "."))
                        {
                            if (typeQuestion == "pronom")
                            {
                                MessageBox.Show("Bravo vous avez trouvé le pronom !" + "\n" + "Vous gagnez 1 point !", "Félicitations",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Dommage ! Ce n'était pas le bon mot." + "\n" + "Vous perdez 1 point !", "Dommage",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else if (phraseAP != null && (u.Text == char.ToUpper(phraseAP[0]) + phraseAP.Substring(1)
                            || u.Text == phraseAP || u.Text == phraseAP + "."))
                        {
                            if (typeQuestion == "adjectif possessif")
                            {
                                MessageBox.Show("Bravo vous avez trouvé l'adjectif possessif !" + "\n" + "Vous gagnez 1 point !", "Félicitations",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Dommage ! Ce n'était pas le bon mot." + "\n" + "Vous perdez 1 point !", "Dommage",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else if (phraseArt != null && (u.Text == char.ToUpper(phraseArt[0]) + phraseArt.Substring(1)
                            || u.Text == phraseArt || u.Text == phraseArt + "."))
                        {
                            if (typeQuestion == "article")
                            {
                                MessageBox.Show("Bravo vous avez trouvé l'article !" + "\n" + "Vous gagnez 1 point !", "Félicitations",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Dommage ! Ce n'était pas le bon mot." + "\n" + "Vous perdez 1 point !", "Dommage",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else if (phraseN != null && (u.Text == char.ToUpper(phraseN[0]) + phraseN.Substring(1)
                            || u.Text == phraseN || u.Text == phraseN + "."))
                        {
                            if (typeQuestion == "nom")
                            {
                                MessageBox.Show("Bravo vous avez trouvé le nom !" + "\n" + "Vous gagnez 1 point !", "Félicitations",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Dommage ! Ce n'était pas le bon mot." + "\n" + "Vous perdez 1 point !", "Dommage",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else if (phraseC != null && (u.Text == char.ToUpper(phraseC[0]) + phraseC.Substring(1)
                            || u.Text == phraseC || u.Text == phraseC + "."))
                        {
                            if (typeQuestion == "verbe")
                            {
                                MessageBox.Show("Bravo vous avez trouvé le verbe !" + "\n" + "Vous gagnez 1 point !", "Félicitations",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Dommage ! Ce n'était pas le bon mot." + "\n" + "Vous perdez 1 point !", "Dommage",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else if (phraseAdv != null && (u.Text == char.ToUpper(phraseAdv[0]) + phraseAdv.Substring(1)
                            || u.Text == phraseAdv || u.Text == phraseAdv + "."))
                        {
                            if (typeQuestion == "adverbe")
                            {
                                MessageBox.Show("Bravo vous avez trouvé l'adverbe !" + "\n" + "Vous gagnez 1 point !", "Félicitations",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Dommage ! Ce n'était pas le bon mot." + "\n" + "Vous perdez 1 point !", "Dommage",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else if (phraseAdj != null && (u.Text == char.ToUpper(phraseAdj[0]) + phraseAdj.Substring(1)
                            || u.Text == phraseAdj || u.Text == phraseAdj + "."))
                        {
                            if (typeQuestion == "adjectif")
                            {
                                MessageBox.Show("Bravo vous avez trouvé l'adjectif !" + "\n" + "Vous gagnez 1 point !", "Félicitations",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Dommage ! Ce n'était pas le bon mot." + "\n" + "Vous perdez 1 point !", "Dommage",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        removeLabels();
                    };
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(typeQuestion == "article" && phraseArt == null)
            {
                MessageBox.Show("Bien joué ! La phrase ne contenait pas d'article." + "\n" + "Vous gagnez 1 point !", "Félicitations",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                removeLabels();
            }
            else if(typeQuestion == "adjectif possessif" && phraseAP == null)
            {
                MessageBox.Show("Bien joué ! La phrase ne contenait pas d'adjectif possessif." + "\n" + "Vous gagnez 1 point !", "Félicitations",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                removeLabels();
            }
            else if(typeQuestion == "pronom" && phraseP == null)
            {
                MessageBox.Show("Bien joué ! La phrase ne contenait pas de pronom." + "\n" + "Vous gagnez 1 point !", "Félicitations",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                removeLabels();
            }
            else if(typeQuestion == "nom" && phraseN == null)
            {
                MessageBox.Show("Bien joué ! La phrase ne contenait pas de nom." + "\n" + "Vous gagnez 1 point !", "Félicitations",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                removeLabels();
            }
            else if(typeQuestion == "verbe" && phraseC == null)
            {
                MessageBox.Show("Bien joué ! La phrase ne contenait pas de verbe." + "\n" + "Vous gagnez 1 point !", "Félicitations",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                removeLabels();
            }
            else if(typeQuestion == "adjectif" && phraseAdj == null)
            {
                MessageBox.Show("Bien joué ! La phrase ne contenait pas d'adjectif." + "\n" + "Vous gagnez 1 point !", "Félicitations",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                removeLabels();
            }
            else if(typeQuestion == "adverbe" && phraseAdv == null)
            {
                MessageBox.Show("Bien joué ! La phrase ne contenait pas d'adverbe." + "\n" + "Vous gagnez 1 point !", "Félicitations",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                removeLabels();
            }
            else
            {
                MessageBox.Show("Dommage ! Le mot était bien dans la phrase." + "\n" + "Vous perdez 1 point !", "Dommage",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                removeLabels();
            }
        }

        public void removeLabels()
        {
            var label = this.Controls.OfType<LabelPerso>().ToList();
            foreach(LabelPerso l in label)
            {
                l.Dispose();
            }
            lesLabels.Clear();
            StartGame();
        }
    }
}
