using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForm.Forms;

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
            Jouer jouer = new Jouer();
            jouer.ShowDialog();
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

        private void listeDesUtilisateursToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void classementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Classement classement = new Classement();
            classement.Show();
        }

        private void ajoutDutilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjoutUtilisateur ajoutUtilisateur = new AjoutUtilisateur();
            ajoutUtilisateur.ShowDialog();
        }

        private void listeMotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeMot listeMot = new ListeMot();
            listeMot.ShowDialog();
        }
    }
}
