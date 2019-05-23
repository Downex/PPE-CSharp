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
using WindowsForm.Class_gestion;

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
                    //List des utilisateurs
                    List<Utilisateur> listUtilisateur= new List<Utilisateur>(Bdd.SelectAllUser());

                    foreach  (Utilisateur utilisateur in listUtilisateur)
                    {
                        if (LoginTextBox.Text == utilisateur.Login)
                        {
                            MessageBox.Show("Nom d'utilisateur déjà pris", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }
                        else
                        {
                            Bdd.InsertUtilisateur(LoginTextBox.Text, MdpTextBox.Text, PrenomTextBox.Text, NomTextBox.Text, "0");
                            this.Close();
                            break;
                        }
                    }
                    
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
