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
    public partial class Information : Form
    {
        Utilisateur utilisateur;
        public Information(Utilisateur utilisateur)
        {
            this.utilisateur = utilisateur;
            InitializeComponent();
        }

        private void Information_Load(object sender, EventArgs e)
        {
            PseudoLabel.Text = utilisateur.Login;
            PrenomLabel.Text = utilisateur.Prenom;
            NomLabel.Text = utilisateur.Nom;
            ScoreLabel.Text = utilisateur.Score + " Points";
            RangLabel.Text = utilisateur.Rang;
            WelcomeLabel.Text += utilisateur.Login;

        }

        //Affiche le formulaire de modification du mot de passe sinon le cache
        private void BtModif_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            BtModif.Visible = false;
            ClearTextBox();
        }

        private void BtValider_Click(object sender, EventArgs e)
        {
            try
            {
                if (Utilisateur.Hash256(AncienMdpTextBox.Text) == utilisateur.Password)
                {
                    if (String.IsNullOrWhiteSpace(MdpTextBox.Text) || String.IsNullOrWhiteSpace(CMdpTextBox.Text))
                    {
                        MessageBox.Show("Veuillez rentrez un mot de passe Valide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (MdpTextBox.Text == CMdpTextBox.Text)
                    {
                        Bdd.UpdateMotdePasse(utilisateur.Id, Utilisateur.Hash256(MdpTextBox.Text));
                        MessageBox.Show("Mot de passe modifié", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        panel1.Visible = false;
                        BtModif.Visible = true;
                        ClearTextBox();
                    }
                    else if (MdpTextBox.Text != CMdpTextBox.Text)
                    {
                        MessageBox.Show("Les mots de passe ne correspondent pas", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Mot de passe non valide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseLabel_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            BtModif.Visible = true;
            ClearTextBox();
        }

        private void ClearTextBox()
        {
            AncienMdpTextBox.Clear();
            CMdpTextBox.Clear();
            MdpTextBox.Clear();
        }
    }
}
