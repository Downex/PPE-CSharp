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

        private string isAdmin;

        public AjoutUtilisateur()
        {
            InitializeComponent();
        }

        private void AjoutUtilisateur_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bdMotDataSet.Utilisateur'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.utilisateurTableAdapter.Fill(this.bdMotDataSet.Utilisateur);
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

            }
        }

        private void btAjout_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(ajoutLoginTextBox.Text) || String.IsNullOrWhiteSpace(ajoutPrenomTextBox.Text) || String.IsNullOrWhiteSpace(ajoutPasswordTextBox.Text) || String.IsNullOrWhiteSpace(ajoutNomTextBox.Text))
            {
                MessageBox.Show("Veuillez rentrez des valeurs valide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //List des utilisateurs
                List<Utilisateur> listUtilisateur = new List<Utilisateur>(Bdd.SelectAllUser());

                foreach (Utilisateur utilisateur in listUtilisateur)
                {
                    if (ajoutLoginTextBox.Text == utilisateur.Login)
                    {
                        MessageBox.Show("Nom d'utilisateur déjà pris", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
                    else
                    {
                        if (ajoutAdministrateurCheckBox.Checked == true)
                        {
                            isAdmin = "1";
                        }
                        else
                        {
                             isAdmin = "0";
                        }
                        Bdd.InsertUtilisateur(ajoutLoginTextBox.Text, ajoutPasswordTextBox.Text, ajoutPrenomTextBox.Text, ajoutNomTextBox.Text, isAdmin);
                        break;
                    }
                }

            }
        }
    }
}
