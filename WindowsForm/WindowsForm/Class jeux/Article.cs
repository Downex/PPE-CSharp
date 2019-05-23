using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm.Class_jeux
{
    public class Article : Mot
    {
        public string id { get; set; }
        public string masculin { get; set; }
        public string feminin { get; set; }
        public string pluriel { get; set; }

        public Article(String id, String texte, String feminin, String pluriel) : base(texte)
        {
            this.id = id;
            masculin = texte;
            this.feminin = feminin;
            this.pluriel = pluriel;
        }

        public Article()
        {

        }

        public String GetId()
        {
            return id;
        }
        public String GetMasculin()
        {
            return masculin;
        }

        public String GetFeminin()
        {
            return feminin;
        }

        public String GetPluriel()
        {
            return pluriel;
        }
    }
}
