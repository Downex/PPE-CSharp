using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForm.Class_jeux;

namespace WindowsForm
{
    class LabelPerso : Label
    {
        private String mot;

        public LabelPerso(String mot)
        {
            this.mot = mot;
        }
        //protected override void OnClick(EventArgs e)
        //{
        //    base.OnClick(e);
        //    if (mot is Nom)
        //    {
        //        Nom n = (Nom)mot;
        //        MessageBox.Show("Nom");
        //    }
        //    else if (mot is Adjectif)
        //    {
        //        Adjectif adj = (Adjectif)mot;
        //        MessageBox.Show("Adjectif");
        //    }
        //    else if(mot is Pronom)
        //    {
        //        MessageBox.Show("Pronom");
        //    }
        //    else if(mot is Article)
        //    {
        //        MessageBox.Show("Article");
        //    }
        //    else if(mot is Verbe)
        //    {
        //        MessageBox.Show("Verbe");
        //    }
        //}
    }
}
