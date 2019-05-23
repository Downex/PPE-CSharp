using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForm.Class_gestion;
using WindowsForm.Class_jeux;
using WindowsForm.Forms;

namespace WindowsForm
{
    public class LabelPerso : Label
    {
        private Mot mot;

        public LabelPerso(Mot mot)
        {
            this.mot = mot;
        }

        public LabelPerso()
        {

        }
    }
}
