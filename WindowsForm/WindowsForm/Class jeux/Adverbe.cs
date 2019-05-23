using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm.Class_jeux
{
    public class Adverbe : Mot
    {
        private String id { get; set; }
        private String adverbe { get; set; }

        public Adverbe(String id, String texte) : base(texte)
        {
            this.id = id;
            adverbe = texte;
        }

        public Adverbe()
        {

        }

        public String GetId()
        {
            return id;
        }

        public String GetAdverbe()
        {
            return adverbe;
        }
    }
}
