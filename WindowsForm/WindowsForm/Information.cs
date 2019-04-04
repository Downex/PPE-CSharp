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
            label1.Text = utilisateur.getLogin();
        }
    }
}
