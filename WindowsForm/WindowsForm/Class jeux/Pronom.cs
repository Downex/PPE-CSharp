using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm.Class_jeux
{
    public class Pronom : Mot
    {
        public string id { get; set; }
        public string singulier { get; set; }
        public string pluriel { get; set; }
        public string genre { get; set; }

        public Pronom(String id, String texte, String pluriel, String genre) : base(texte)
        {
            this.id = id;
            singulier = texte;
            this.pluriel = pluriel;
            this.genre = genre;
        }

        public Pronom()
        {

        }

        public String GetId()
        {
            return id;
        }

        public String GetPluriel()
        {
            return pluriel;
        }

        public String GetGenre()
        {
            return genre;
        }
    }
}
