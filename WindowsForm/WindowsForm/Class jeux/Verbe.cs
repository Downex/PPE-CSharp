using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm.Class_jeux
{
    class Verbe : Mot
    {
        private String infinitif;

        public Verbe(String texte, String infinitif) : base(texte)
        {
            this.infinitif = infinitif;
        }
    }
}
