namespace WindowsForm
{
    partial class AjoutUtilisateur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.utilisateurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdMotDataSet = new WindowsForm.BdMotDataSet();
            this.utilisateurTableAdapter = new WindowsForm.BdMotDataSetTableAdapters.UtilisateurTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Administrateur = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btModifier = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.labelModification = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CheckBoxModifAdmin = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_UpdateNom = new System.Windows.Forms.TextBox();
            this.textBox_UpdateScore = new System.Windows.Forms.TextBox();
            this.textBox_UpdatePrenom = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btSupprimer = new System.Windows.Forms.Button();
            this.labelSuppression = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAdminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginSuppLabel = new System.Windows.Forms.Label();
            this.loginModifLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdMotDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.scoreDataGridViewTextBoxColumn,
            this.rangDataGridViewTextBoxColumn,
            this.isAdminDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.utilisateurBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(540, 535);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // utilisateurBindingSource
            // 
            this.utilisateurBindingSource.DataMember = "Utilisateur";
            this.utilisateurBindingSource.DataSource = this.bdMotDataSet;
            // 
            // bdMotDataSet
            // 
            this.bdMotDataSet.DataSetName = "BdMotDataSet";
            this.bdMotDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // utilisateurTableAdapter
            // 
            this.utilisateurTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Administrateur);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(570, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 158);
            this.panel1.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(182, 129);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Ajouter";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(334, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Prenom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mot de passe";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(337, 70);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ajout d\'un utilisateur";
            // 
            // Administrateur
            // 
            this.Administrateur.AutoSize = true;
            this.Administrateur.Location = new System.Drawing.Point(193, 106);
            this.Administrateur.Name = "Administrateur";
            this.Administrateur.Size = new System.Drawing.Size(92, 17);
            this.Administrateur.TabIndex = 4;
            this.Administrateur.Text = "Administrateur";
            this.Administrateur.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(231, 70);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(125, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.loginModifLabel);
            this.panel2.Controls.Add(this.btModifier);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.labelModification);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.CheckBoxModifAdmin);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.textBox_UpdateNom);
            this.panel2.Controls.Add(this.textBox_UpdateScore);
            this.panel2.Controls.Add(this.textBox_UpdatePrenom);
            this.panel2.Location = new System.Drawing.Point(570, 176);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(470, 158);
            this.panel2.TabIndex = 5;
            // 
            // btModifier
            // 
            this.btModifier.Enabled = false;
            this.btModifier.Location = new System.Drawing.Point(182, 132);
            this.btModifier.Name = "btModifier";
            this.btModifier.Size = new System.Drawing.Size(75, 23);
            this.btModifier.TabIndex = 5;
            this.btModifier.Text = "Modfier";
            this.btModifier.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(289, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Score";
            // 
            // labelModification
            // 
            this.labelModification.AutoSize = true;
            this.labelModification.Location = new System.Drawing.Point(162, 17);
            this.labelModification.Name = "labelModification";
            this.labelModification.Size = new System.Drawing.Size(79, 13);
            this.labelModification.TabIndex = 3;
            this.labelModification.Text = "Modification de";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(180, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Nom";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CheckBoxModifAdmin
            // 
            this.CheckBoxModifAdmin.AutoSize = true;
            this.CheckBoxModifAdmin.Location = new System.Drawing.Point(185, 109);
            this.CheckBoxModifAdmin.Name = "CheckBoxModifAdmin";
            this.CheckBoxModifAdmin.Size = new System.Drawing.Size(92, 17);
            this.CheckBoxModifAdmin.TabIndex = 4;
            this.CheckBoxModifAdmin.Text = "Administrateur";
            this.CheckBoxModifAdmin.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(74, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Prenom";
            // 
            // textBox_UpdateNom
            // 
            this.textBox_UpdateNom.Location = new System.Drawing.Point(183, 67);
            this.textBox_UpdateNom.Name = "textBox_UpdateNom";
            this.textBox_UpdateNom.Size = new System.Drawing.Size(100, 20);
            this.textBox_UpdateNom.TabIndex = 3;
            // 
            // textBox_UpdateScore
            // 
            this.textBox_UpdateScore.Location = new System.Drawing.Point(289, 67);
            this.textBox_UpdateScore.Name = "textBox_UpdateScore";
            this.textBox_UpdateScore.Size = new System.Drawing.Size(100, 20);
            this.textBox_UpdateScore.TabIndex = 2;
            // 
            // textBox_UpdatePrenom
            // 
            this.textBox_UpdatePrenom.Location = new System.Drawing.Point(77, 67);
            this.textBox_UpdatePrenom.Name = "textBox_UpdatePrenom";
            this.textBox_UpdatePrenom.Size = new System.Drawing.Size(100, 20);
            this.textBox_UpdatePrenom.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.loginSuppLabel);
            this.panel3.Controls.Add(this.btSupprimer);
            this.panel3.Controls.Add(this.labelSuppression);
            this.panel3.Location = new System.Drawing.Point(570, 378);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(470, 100);
            this.panel3.TabIndex = 13;
            // 
            // btSupprimer
            // 
            this.btSupprimer.Enabled = false;
            this.btSupprimer.Location = new System.Drawing.Point(183, 50);
            this.btSupprimer.Name = "btSupprimer";
            this.btSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btSupprimer.TabIndex = 4;
            this.btSupprimer.Text = "Supprimer";
            this.btSupprimer.UseVisualStyleBackColor = true;
            // 
            // labelSuppression
            // 
            this.labelSuppression.AutoSize = true;
            this.labelSuppression.Location = new System.Drawing.Point(162, 17);
            this.labelSuppression.Name = "labelSuppression";
            this.labelSuppression.Size = new System.Drawing.Size(83, 13);
            this.labelSuppression.TabIndex = 3;
            this.labelSuppression.Text = "Suppression de ";
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            this.passwordDataGridViewTextBoxColumn.Visible = false;
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "prenom";
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            this.prenomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // scoreDataGridViewTextBoxColumn
            // 
            this.scoreDataGridViewTextBoxColumn.DataPropertyName = "score";
            this.scoreDataGridViewTextBoxColumn.HeaderText = "score";
            this.scoreDataGridViewTextBoxColumn.Name = "scoreDataGridViewTextBoxColumn";
            this.scoreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rangDataGridViewTextBoxColumn
            // 
            this.rangDataGridViewTextBoxColumn.DataPropertyName = "rang";
            this.rangDataGridViewTextBoxColumn.HeaderText = "rang";
            this.rangDataGridViewTextBoxColumn.Name = "rangDataGridViewTextBoxColumn";
            this.rangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isAdminDataGridViewTextBoxColumn
            // 
            this.isAdminDataGridViewTextBoxColumn.DataPropertyName = "isAdmin";
            this.isAdminDataGridViewTextBoxColumn.HeaderText = "isAdmin";
            this.isAdminDataGridViewTextBoxColumn.Name = "isAdminDataGridViewTextBoxColumn";
            this.isAdminDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loginSuppLabel
            // 
            this.loginSuppLabel.AutoSize = true;
            this.loginSuppLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginSuppLabel.Location = new System.Drawing.Point(239, 17);
            this.loginSuppLabel.Name = "loginSuppLabel";
            this.loginSuppLabel.Size = new System.Drawing.Size(0, 13);
            this.loginSuppLabel.TabIndex = 5;
            // 
            // loginModifLabel
            // 
            this.loginModifLabel.AutoSize = true;
            this.loginModifLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginModifLabel.Location = new System.Drawing.Point(239, 17);
            this.loginModifLabel.Name = "loginModifLabel";
            this.loginModifLabel.Size = new System.Drawing.Size(0, 13);
            this.loginModifLabel.TabIndex = 6;
            // 
            // AjoutUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 536);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AjoutUtilisateur";
            this.Text = "AjoutUtilisateur";
            this.Load += new System.EventHandler(this.AjoutUtilisateur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdMotDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private BdMotDataSet bdMotDataSet;
        private System.Windows.Forms.BindingSource utilisateurBindingSource;
        private BdMotDataSetTableAdapters.UtilisateurTableAdapter utilisateurTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Administrateur;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btModifier;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelModification;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox CheckBoxModifAdmin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_UpdateNom;
        private System.Windows.Forms.TextBox textBox_UpdateScore;
        private System.Windows.Forms.TextBox textBox_UpdatePrenom;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btSupprimer;
        private System.Windows.Forms.Label labelSuppression;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isAdminDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label loginModifLabel;
        private System.Windows.Forms.Label loginSuppLabel;
    }
}