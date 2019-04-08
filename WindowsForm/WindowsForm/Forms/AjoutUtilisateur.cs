using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForm.Class_gestion;

namespace WindowsForm
{
    public partial class AjoutUtilisateur : Form
    {
        private List<Utilisateur> utilisateurs;
        private Utilisateur utilisateur = new Utilisateur();

        public AjoutUtilisateur()
        {
            InitializeComponent();
        }

        private void AjoutUtilisateur_Load(object sender, EventArgs e)
        {
            this.utilisateurs = Bdd.SelectAllUser();
            dataGridView1.DataSource = utilisateurs;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            else
            {
                //Récupèration des données 
                DataGridViewRow selectedRow = dataGridView1.CurrentRow;
                utilisateur.Id = selectedRow.Cells[0].Value.ToString();
                utilisateur.Login = selectedRow.Cells[1].Value.ToString();
                utilisateur.Prenom = selectedRow.Cells[3].Value.ToString();
                utilisateur.Nom = selectedRow.Cells[4].Value.ToString();
                utilisateur.Score = selectedRow.Cells[5].Value.ToString();
                utilisateur.IsAdmin = selectedRow.Cells[7].Value.ToString();

                //Ajout des données dans LabelModif
                loginModifLabel.Text = utilisateur.Login;
                textBox_UpdatePrenom.Text = utilisateur.Prenom;
                textBox_UpdateNom.Text = utilisateur.Nom;
                textBox_UpdateScore.Text = utilisateur.Score;
                if (utilisateur.IsAdmin == "0")
                {
                    CheckBoxModifAdmin.Checked = true;
                } else
                {
                    CheckBoxModifAdmin.Checked = false;
                }
                btModifier.Enabled = true;

                //Suppression
                loginSuppLabel.Text = utilisateur.Login;
                btSupprimer.Enabled = true;

                //textBox_UpdatePseudo.Enabled = true;
                //radioButton_UpdateAdministrateur.Enabled = true;
                //radioButton_UpdateUtilisateur.Enabled = true;
                //button_UpdateUtilisateur.Enabled = true;
                //button_DeleteUtilisateur.Enabled = true;

                //textBox_UpdatePseudo.Text = utilisateur.Pseudo;
                //textBox_DeleteUtilisateur.Text = utilisateur.Pseudo;

                //if (utilisateur.IdRole == Consts.Administrateur)
                //    radioButton_UpdateAdministrateur.Checked = true;
                //else if (utilisateur.IdRole == Consts.Utilisateur)
                //    radioButton_UpdateUtilisateur.Checked = true;
            }
        }
    }
}
