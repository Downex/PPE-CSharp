using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm.Class_jeux
{
    class Nom : Mot
    {
        private String singulier;
        private String pluriel;
        private String genre;

        public Nom(String texte, String singulier, String pluriel, String genre) : base(texte)
        {
            this.singulier = singulier;
            this.pluriel = pluriel;
            this.genre = genre;
        }

        public String getSingulier()
        {

            return singulier;
        }

        public String getPluriel()
        {
            return pluriel;
        }

        public String getGenre()
        {
            return genre;
        }
    }
}
