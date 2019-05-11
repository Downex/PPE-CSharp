using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm.Class_jeux
{
    class Adjectif : Mot
    {
        private String singMasculin;
        private String singFeminin;
        private String plurMasculin;
        private String plurFeminin;

        public Adjectif(String texte, String singMasculin, String singFeminin, String plurMasculin, String plurFeminin) : base(texte)
        {
            this.singMasculin = singMasculin;
            this.singFeminin = singFeminin;
            this.plurMasculin = plurMasculin;
            this.plurFeminin = plurFeminin;
        }

        public String getSingMasculin()
        {

            return singMasculin;
        }

        public String getSingFeminin()
        {
            return singFeminin;
        }

        public String getPlurMasculin()
        {
            return plurMasculin;
        }

        public String getPlurFeminin()
        {
            return plurFeminin;
        }
    }
}
