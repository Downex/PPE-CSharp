using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class Accueil : Form
    {
        Utilisateur unUtilisateur;
        public Accueil(Utilisateur unUtilisateur)
        {
            this.unUtilisateur = unUtilisateur;
            InitializeComponent();
        }

        private void motToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void monCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Accueil_Load(object sender, EventArgs e)
        {
            if (unUtilisateur.IsAdmin == true)
            {
                ajoutDutilisateurToolStripMenuItem.Visible = true;
            }
        }

        private void InformationPersonnel_Click(object sender, EventArgs e)
        {
            Information information = new Information(unUtilisateur);
            information.Show();
        }
    }
}
