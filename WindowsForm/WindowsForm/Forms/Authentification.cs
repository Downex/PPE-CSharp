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
using WindowsForm.Class_gestion;

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
            List<Utilisateur> listUtilisateur = new List<Utilisateur>(Bdd.SelectAllUser());
            foreach (Utilisateur utilisateur in listUtilisateur)
            {
                if (LoginTextBox.Text == utilisateur.Login)
                {
                    if (Utilisateur.Hash256(MdpTextBox.Text) == utilisateur.Password)
                    {
                        Utilisateur = utilisateur;
                        Dispose();
                        break;
                    }
                    labelError();
                    break;
                }
                else
                {
                    labelError();
                }
            }
            MdpTextBox.Clear();
        }

        private void labelError()
        {
            ErrorLabel.Visible = true;
            ErrorLabel.Text = "Nom de compte ou mot de passe incorrect";
        }

        private void Authentification_Load(object sender, EventArgs e)
        {

        }

        private void CloseLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
