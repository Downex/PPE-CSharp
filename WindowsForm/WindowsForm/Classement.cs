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

            Utilisateur Dwynox = new Utilisateur("Downex", Utilisateur.Hash256("123"), "Cahier", "François", 50, true);
            Utilisateur Ozziep = new Utilisateur("84", Utilisateur.Hash256("123"), "Cahier", "François", 84, true);
            Utilisateur Xyro = new Utilisateur("100", Utilisateur.Hash256("123"), "Cahier", "François", 100, true);
            Utilisateur SkynX7 = new Utilisateur("146", Utilisateur.Hash256("123"), "Cahier", "François", 146, true);
            Utilisateur Michel = new Utilisateur("Downex", Utilisateur.Hash256("123"), "Cahier", "François", 57, true);

            lesUtilisateurs.Add(Dwynox);
            lesUtilisateurs.Add(Ozziep);
            lesUtilisateurs.Add(Xyro);
            lesUtilisateurs.Add(SkynX7);
            lesUtilisateurs.Add(Michel);


            foreach(Utilisateur unUtilisateur in lesUtilisateurs)
            {
                object[] ligne = new object[]
                {
                    unUtilisateur.Login, unUtilisateur.Score
                };
                ClassementGridView.Rows.Add(ligne);
            }

        }
    }
}
