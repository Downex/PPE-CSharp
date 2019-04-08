using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class Classement : Form
    {
        private List<Utilisateur> lesUtilisateurs;
        public Classement()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Classement_Load(object sender, EventArgs e)
        {
            lesUtilisateurs = new List<Utilisateur>();

            Utilisateur Dwynox = new Utilisateur("Dwynox", Utilisateur.Hash256("123"), "Cahier", "François", "Novice", "14", "0");
            Utilisateur Downex = new Utilisateur("Downex", Utilisateur.Hash256("123"), "Cahier", "François", "Novice", "0", "0");
            Utilisateur Ozziep = new Utilisateur("Ozziep", Utilisateur.Hash256("123"), "Cahier", "François", "Intermediaire", "84", "0");
            Utilisateur Xyro = new Utilisateur("Xyro", Utilisateur.Hash256("123"), "Cahier","Francois", "Maitre", "100", "0");
            Utilisateur SkynX7 = new Utilisateur("SkyNx7", Utilisateur.Hash256("123"), "Cahier", "Francois", "Maitre", "146", "0");
            Utilisateur Michel = new Utilisateur("Michel", Utilisateur.Hash256("123"), "Cahier", "Francois", "Intermerdiaire", "57", "0");

            lesUtilisateurs.Add(Dwynox);
            lesUtilisateurs.Add(Downex);
            lesUtilisateurs.Add(Ozziep);
            lesUtilisateurs.Add(Xyro);
            lesUtilisateurs.Add(SkynX7);
            lesUtilisateurs.Add(Michel);

            foreach (Utilisateur unUtilisateur in lesUtilisateurs)
            {
                object[] ligne = new object[]
                {
                    unUtilisateur.Login, unUtilisateur.Rang, unUtilisateur.Score
                };
                ClassementGridView.Rows.Add(ligne);
            }

        }
    }
}
