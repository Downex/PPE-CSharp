using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForm;

namespace WindowsForm.Class_jeux
{
    public class Adjectif : Mot
    {
        public string id { get; set; }
        public string singMasculin { get; set; }
        public string singFeminin { get; set; }
        public string plurMasculin { get; set; }
        public string plurFeminin { get; set; }
        public string fonction { get; set; }

        public Adjectif(String id, String texte, String singFeminin, String plurMasculin, String plurFeminin, String fonction) : base(texte)
        {
            this.id = id;
            singMasculin = texte;
            this.singFeminin = singFeminin;
            this.plurMasculin = plurMasculin;
            this.plurFeminin = plurFeminin;
            this.fonction = fonction;
        }
        public Adjectif()
        {

        }

        public String GetId()
        {
            return id;
        }

        public String GetSingMasculin()
        {
            return singMasculin;
        }

        public String GetSingFeminin()
        {
            return singFeminin;
        }

        public string GetPlurMasculin()
        {
            return plurMasculin;
        }

        public string GetPlurFeminin()
        {
            return plurFeminin;
        }

        public string GetFonction()
        {
            return fonction;
        }
    }
}
