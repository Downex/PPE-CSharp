using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography; // Cryptage

namespace WindowsForm
{
    public partial class Inscription : Form
    {
        private List<Utilisateur> lesUtilisateurs;
        public Inscription(List<Utilisateur> lesUtilisateurs)
        {
            this.lesUtilisateurs = lesUtilisateurs;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MdpTextBox.Text == CMdpTextBox.Text)
            {
                if (String.IsNullOrWhiteSpace(NomTextBox.Text) || String.IsNullOrWhiteSpace(PrenomTextBox.Text) || String.IsNullOrWhiteSpace(MdpTextBox.Text)){
                    MessageBox.Show("Veuillez rentrez des valeurs valide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Utilisateur unUtilisateur = new Utilisateur(LoginTextBox.Text, Utilisateur.Hash256(MdpTextBox.Text), NomTextBox.Text, PrenomTextBox.Text, 0, false);
                    lesUtilisateurs.Add(unUtilisateur);
                    MessageBox.Show("Inscription réussi", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Les mots de passe ne correspondent pas", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Inscription_Load(object sender, EventArgs e)
        {

        }
    }
}
