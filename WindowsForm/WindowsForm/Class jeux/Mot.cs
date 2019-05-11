using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm.Class_jeux
{
    public class Mot
    {
        public String texte;

        public Mot(String texte)
        {
            this.texte = texte;
        }
        public Mot()
        {

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
