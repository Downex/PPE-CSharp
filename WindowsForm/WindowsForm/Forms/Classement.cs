﻿using System;
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
    public partial class Classement : Form
    {
        private List<Utilisateur> utilisateurs;
        public Classement()
        {
            InitializeComponent();
        }

        private void Classement_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bdMotDataSet.Utilisateur'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.utilisateurTableAdapter.Fill(this.bdMotDataSet.Utilisateur);
            this.utilisateurs = Bdd.SelectAllUser();
            ClassementGridView.DataSource = utilisateurs;
        }

        private void ClassementGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CloseLabel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
