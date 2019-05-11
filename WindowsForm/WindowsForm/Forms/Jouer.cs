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
using WindowsForm.Class_jeux;

namespace WindowsForm.Forms
{
    public partial class Jouer : Form
    {
        public Jouer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bravo vous avez trouvé le verbe ! Vous gagnez 1 point !");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dommage ! Le verbe était 'est'. Vous perdez 1 point !");
        }

        private void Jouer_Load(object sender, EventArgs e)
        {
            //Affiche une question aléatoire    
            Random randomQuestion = new Random();
            int index = randomQuestion.Next(Bdd.SelectAllQuestion().Count);
            Question question = Bdd.SelectAllQuestion().ElementAt(index);
            label5.Text = question.Libelle;
        }
    }
}
