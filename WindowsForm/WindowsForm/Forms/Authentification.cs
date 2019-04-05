using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class Authentification : Form
    {
        private List<Utilisateur> lesUtilisateurs;

        public Utilisateur Utilisateur { private set; get; }

        public Authentification(List<Utilisateur> lesUtilisateurs)
        {
            this.lesUtilisateurs = lesUtilisateurs;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtInscription_Click(object sender, EventArgs e)
        {
            Inscription inscription = new Inscription(lesUtilisateurs);
            inscription.ShowDialog();
        }

        private void BtConnexion_Click(object sender, EventArgs e)
        {
            Utilisateur Downex = new Utilisateur("Downex", Utilisateur.Hash256("123"), "Cahier", "François", "Novice", 14, true);
            lesUtilisateurs.Add(Downex);

            foreach (Utilisateur unUtilisateur in lesUtilisateurs)
            {
                if (LoginTextBox.Text == unUtilisateur.Login && Utilisateur.Hash256(MdpTextBox.Text) == unUtilisateur.Password)
                {
                    Utilisateur = unUtilisateur;
                    Dispose();
                }
                else
                {
                    ErrorLabel.Visible = true;
                    ErrorLabel.Text = "Nom de compte ou mot de passe incorrect";
                    MdpTextBox.Clear();
                }
            }
        }

        private void Authentification_Load(object sender, EventArgs e)
        {

        }
    }
}
