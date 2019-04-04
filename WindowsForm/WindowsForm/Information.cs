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
        }

        //Affiche le formulaire de modification du mot de passe sinon le cache
        private void BtModif_Click(object sender, EventArgs e)
        {
            AffichageFormulaire();
        }

        private void BtValider_Click(object sender, EventArgs e)
        {
            try
            {
                if (utilisateur.Hash256(AncienMdpTextBox.Text) == utilisateur.Password)
                {
                   if (String.IsNullOrWhiteSpace(MdpTextBox.Text) || String.IsNullOrWhiteSpace(CMdpTextBox.Text))
                   {
                        MessageBox.Show("Veuillez rentrez un mot de passe Valide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   }
                   else if (MdpTextBox.Text == CMdpTextBox.Text)
                   {
                        utilisateur.Password = utilisateur.Hash256(MdpTextBox.Text);
                        MessageBox.Show("Mot de passe modifié", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        AffichageFormulaire();
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

        /// <summary>
        /// Permet d'afficher ou de cacher le formulaire de modification du mot de passe
        /// </summary>
        private void AffichageFormulaire()
        {
            try
            {
                if (label1.Visible == false)
                {
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    AncienMdpTextBox.Visible = true;
                    MdpTextBox.Visible = true;
                    CMdpTextBox.Visible = true;
                    BtValider.Visible = true;
                }
                else
                {
                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    AncienMdpTextBox.Visible = false;
                    MdpTextBox.Visible = false;
                    CMdpTextBox.Visible = false;
                    MdpTextBox.Clear();
                    AncienMdpTextBox.Clear();
                    CMdpTextBox.Clear();
                    BtValider.Visible = false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
