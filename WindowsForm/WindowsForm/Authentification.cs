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
            Utilisateur Downex = new Utilisateur("Downex", "123", "Cahier", "François", 0, true);
            lesUtilisateurs.Add(Downex);

            foreach (Utilisateur unUtilisateur in lesUtilisateurs)
            {
                if (LoginTextBox.Text == unUtilisateur.getLogin() && MdpTextBox.Text == unUtilisateur.getPassword())
                {
                    Utilisateur = unUtilisateur;
                    Dispose();
                }
                else
                {
                    MessageBox.Show("Nom de compte ou mot de passe incorrect", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        /// <summary>
        /// Cryptage mot de passe
        /// </summary>
        /// <param name="rawData">Chaîne de caractère que l'on souhaite crypté</param>
        /// <returns></returns>
        static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
