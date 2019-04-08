using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm.Class_jeux
{
    public class Mot
    {
        private String texte;

        public Mot(String texte)
        {
            this.texte = texte;
        }

        public String getTexte()
        {
            return this.texte;
        }

        public void setTexte(String texte)
        {
            this.texte = texte;
        }
    }
}
