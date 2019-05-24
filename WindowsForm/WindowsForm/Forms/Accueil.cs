using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForm.Class_jeux;
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
            Jouer jouer = new Jouer(unUtilisateur);
            jouer.ShowDialog();
        }

        private void monCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Accueil_Load(object sender, EventArgs e)
        {
            WelcomeLabel.Text += unUtilisateur.Login + " !";
            BtConnexion.Text = unUtilisateur.Login;
            if (unUtilisateur.IsAdmin == "1")
            {
                panelAdmin.Visible = true;
            }
        }

        private void CloseLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            panelAdmin.Visible = false;
            labelAdmin.Visible = true;
        }

        private void BtLogin_Click(object sender, EventArgs e)
        {
            Information information = new Information(unUtilisateur);
            information.Show();
        }

        private void btJouer_Click(object sender, EventArgs e)
        {
            Jouer jouer = new Jouer(unUtilisateur);
            jouer.ShowDialog();
        }

        private void btClassement_Click(object sender, EventArgs e)
        {
            Classement classement = new Classement();
            classement.Show();
        }

        private void btAjoutMot_Click(object sender, EventArgs e)
        {
            ListeMot listeMot = new ListeMot();
            listeMot.ShowDialog();
        }

        private void btPhraseGen_Click(object sender, EventArgs e)
        {
            AjoutPhrase ajoutPhrase = new AjoutPhrase();
            ajoutPhrase.ShowDialog();
        }

        private void btGestionUser_Click(object sender, EventArgs e)
        {
            AjoutUtilisateur ajoutUtilisateur = new AjoutUtilisateur();
            ajoutUtilisateur.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            panelAdmin.Visible = true;
            labelAdmin.Visible = false;
        }
    }
}
