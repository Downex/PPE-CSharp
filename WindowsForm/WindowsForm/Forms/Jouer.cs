using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm.Forms
{
    public partial class Jouer : Form
    {
        public Jouer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bravo vous avez trouvé le verbe ! Vous gagnez 1 point !");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dommage ! Le verbe était 'est'. Vous perdez 1 point !");
        }
    }
}
