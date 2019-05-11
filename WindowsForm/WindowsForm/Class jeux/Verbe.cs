using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm.Class_jeux
{
    public class Verbe : Mot
    {
        public string id { get; set; }
        public string infinitif { get; set; }
        public string genre { get; set; }

        public Verbe(String id, String texte, String genre) : base(texte)
        {
            this.id = id;
            infinitif = texte;
            this.genre = genre;
        }

        public Verbe()
        {

        }

        public string GetId()
        {
            return id;
        }

        public string GetInfinitif()
        {
            return infinitif;
        }

        public string GetGenre()
        {
            return genre;
        }
    }
}
