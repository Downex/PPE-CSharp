using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForm.Class_gestion;
using WindowsForm.Class_jeux;
using WindowsForm.Forms;

namespace WindowsForm
{
    public class LabelPerso : Label
    {
        private Mot mot;
        private List<LabelPerso> lesLabels;
        private List<Conjugaison> lesConjugaisons;

        public LabelPerso(Mot mot)
        {
            this.mot = mot;
        }

        public LabelPerso()
        {

        }
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            if(mot is Adjectif)
            {
                Adjectif adj = (Adjectif)mot;
                if(adj.GetFonction() == "possessif")
                {
                    MessageBox.Show("Bravo vous avez trouvé l'adjectif possessif !" + "\n" + "Vous gagnez 1 point !", "Félicitations",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Bravo vous avez trouvé l'adjectif !" + "\n" + "Vous gagnez 1 point !", "Félicitations",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if(mot is Article)
            {
                Article art = (Article)mot;
                MessageBox.Show("Bravo vous avez trouvé l'article !" + "\n" + "Vous gagnez 1 point !", "Félicitations",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(mot is Pronom)
            {
                Pronom p = (Pronom)mot;
                MessageBox.Show("Bravo vous avez trouvé le pronom !" + "\n" + "Vous gagnez 1 point !", "Félicitations",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (mot is Nom)
            {
                Nom n = (Nom)mot;
                MessageBox.Show("Bravo vous avez trouvé le nom !" + "\n" + "Vous gagnez 1 point !", "Félicitations",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(mot is Verbe)
            {
                Verbe v = (Verbe)mot;
                MessageBox.Show("Bravo vous avez trouvé le verbe !" + "\n" + "Vous gagnez 1 point !", "Félicitations",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(mot is Adverbe)
            {
                Adverbe adv = (Adverbe)mot;
                MessageBox.Show("Bravo vous avez trouvé l'adverbe !" + "\n" + "Vous gagnez 1 point !", "Félicitations",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Dommage ! Ce n'était pas le bon mot." + "\n" + "Vous perdez 1 point !", "Dommage",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //if(Text == adj.GetSingMasculin() || Text == adj.GetSingFeminin() 
            //    || Text == adj.GetPlurMasculin() || Text == adj.GetPlurFeminin())
            //{
            //    MessageBox.Show("Adjectif !!");
            //}
            //else
            //{
            //    MessageBox.Show("Faux !");
            //}
            //foreach(Adjectif c in lesMots)
            //{
            //    if(c.GetSingMasculin() == Text || c.GetSingFeminin() == Text || 
            //        c.GetPlurMasculin() == Text || c.GetPlurFeminin() == Text)
            //    {
            //        MessageBox.Show("C'est bien un adjectif !");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Ce n'est pas un adjectif");
            //    }
            //}
            //if (mot is Nom)
            //{
            //    Nom n = (Nom)mot;
            //    MessageBox.Show("Nom");
            //}
            //else if(mot is Verbe)
            //{
            //    Verbe c = (Verbe)mot;
            //    MessageBox.Show("Conjugaison");
            //}
            //else
            //{
            //    MessageBox.Show("LabelPerso !");
            //}


            //if (c.GetPremierSing() == Text || c.GetDeuxiemeSing() == Text || c.GetTroisiemeSing() == Text ||
            //        c.GetPremierPlur() == Text || c.GetDeuxiemePlur() == Text || c.GetTroisiemePlur() == Text)
            //{
            //    MessageBox.Show("C'est bien le verbe !");
            //}
            //else
            //{
            //    MessageBox.Show("Ce n'est pas le verbe");
            //}
        }
    }
}
