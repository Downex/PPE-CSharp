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
            this.utilisateurBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bdMotDataSet = new WindowsForm.BdMotDataSet();
            this.ajoutLoginTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btAjout = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ajoutNomTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ajoutAdministrateurCheckBox = new System.Windows.Forms.CheckBox();
            this.ajoutPrenomTextBox = new System.Windows.Forms.TextBox();
            this.ajoutPasswordTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.loginModifLabel = new System.Windows.Forms.Label();
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
            this.loginSuppLabel = new System.Windows.Forms.Label();
            this.btSupprimer = new System.Windows.Forms.Button();
            this.labelSuppression = new System.Windows.Forms.Label();
            this.utilisateurTableAdapter = new WindowsForm.BdMotDataSetTableAdapters.UtilisateurTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource1)).BeginInit();
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
            this.idDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dataGridView1.DataSource = this.utilisateurBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(540, 535);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // utilisateurBindingSource1
            // 
            this.utilisateurBindingSource1.DataMember = "Utilisateur";
            this.utilisateurBindingSource1.DataSource = this.bdMotDataSet;
            // 
            // bdMotDataSet
            // 
            this.bdMotDataSet.DataSetName = "BdMotDataSet";
            this.bdMotDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ajoutLoginTextBox
            // 
            this.ajoutLoginTextBox.Location = new System.Drawing.Point(19, 70);
            this.ajoutLoginTextBox.Name = "ajoutLoginTextBox";
            this.ajoutLoginTextBox.Size = new System.Drawing.Size(100, 20);
            this.ajoutLoginTextBox.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btAjout);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ajoutNomTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ajoutAdministrateurCheckBox);
            this.panel1.Controls.Add(this.ajoutPrenomTextBox);
            this.panel1.Controls.Add(this.ajoutPasswordTextBox);
            this.panel1.Controls.Add(this.ajoutLoginTextBox);
            this.panel1.Location = new System.Drawing.Point(570, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 158);
            this.panel1.TabIndex = 2;
            // 
            // btAjout
            // 
            this.btAjout.Location = new System.Drawing.Point(182, 129);
            this.btAjout.Name = "btAjout";
            this.btAjout.Size = new System.Drawing.Size(75, 23);
            this.btAjout.TabIndex = 10;
            this.btAjout.Text = "Ajouter";
            this.btAjout.UseVisualStyleBackColor = true;
            this.btAjout.Click += new System.EventHandler(this.btAjout_Click);
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
            // ajoutNomTextBox
            // 
            this.ajoutNomTextBox.Location = new System.Drawing.Point(337, 70);
            this.ajoutNomTextBox.Name = "ajoutNomTextBox";
            this.ajoutNomTextBox.Size = new System.Drawing.Size(100, 20);
            this.ajoutNomTextBox.TabIndex = 6;
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
            // ajoutAdministrateurCheckBox
            // 
            this.ajoutAdministrateurCheckBox.AutoSize = true;
            this.ajoutAdministrateurCheckBox.Location = new System.Drawing.Point(193, 106);
            this.ajoutAdministrateurCheckBox.Name = "ajoutAdministrateurCheckBox";
            this.ajoutAdministrateurCheckBox.Size = new System.Drawing.Size(92, 17);
            this.ajoutAdministrateurCheckBox.TabIndex = 4;
            this.ajoutAdministrateurCheckBox.Text = "Administrateur";
            this.ajoutAdministrateurCheckBox.UseVisualStyleBackColor = true;
            // 
            // ajoutPrenomTextBox
            // 
            this.ajoutPrenomTextBox.Location = new System.Drawing.Point(231, 70);
            this.ajoutPrenomTextBox.Name = "ajoutPrenomTextBox";
            this.ajoutPrenomTextBox.Size = new System.Drawing.Size(100, 20);
            this.ajoutPrenomTextBox.TabIndex = 3;
            // 
            // ajoutPasswordTextBox
            // 
            this.ajoutPasswordTextBox.Location = new System.Drawing.Point(125, 70);
            this.ajoutPasswordTextBox.Name = "ajoutPasswordTextBox";
            this.ajoutPasswordTextBox.PasswordChar = '•';
            this.ajoutPasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.ajoutPasswordTextBox.TabIndex = 2;
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
            this.panel2.Visible = false;
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
            // btModifier
            // 
            this.btModifier.Enabled = false;
            this.btModifier.Location = new System.Drawing.Point(182, 132);
            this.btModifier.Name = "btModifier";
            this.btModifier.Size = new System.Drawing.Size(75, 23);
            this.btModifier.TabIndex = 5;
            this.btModifier.Text = "Modfier";
            this.btModifier.UseVisualStyleBackColor = true;
            this.btModifier.Click += new System.EventHandler(this.btModifier_Click);
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
            this.panel3.Visible = false;
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
            // btSupprimer
            // 
            this.btSupprimer.Enabled = false;
            this.btSupprimer.Location = new System.Drawing.Point(183, 50);
            this.btSupprimer.Name = "btSupprimer";
            this.btSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btSupprimer.TabIndex = 4;
            this.btSupprimer.Text = "Supprimer";
            this.btSupprimer.UseVisualStyleBackColor = true;
            this.btSupprimer.Click += new System.EventHandler(this.btSupprimer_Click);
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
            // utilisateurTableAdapter
            // 
            this.utilisateurTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "login";
            this.dataGridViewTextBoxColumn1.HeaderText = "login";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "password";
            this.dataGridViewTextBoxColumn2.HeaderText = "password";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "prenom";
            this.dataGridViewTextBoxColumn3.HeaderText = "prenom";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "nom";
            this.dataGridViewTextBoxColumn4.HeaderText = "nom";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "score";
            this.dataGridViewTextBoxColumn5.HeaderText = "score";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "rang";
            this.dataGridViewTextBoxColumn6.HeaderText = "rang";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "isAdmin";
            this.dataGridViewTextBoxColumn7.HeaderText = "isAdmin";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource1)).EndInit();
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
        // private BdMotDataSetTableAdapters.UtilisateurTableAdapter utilisateurTableAdapter;
        private System.Windows.Forms.TextBox ajoutLoginTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btAjout;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ajoutNomTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ajoutAdministrateurCheckBox;
        private System.Windows.Forms.TextBox ajoutPrenomTextBox;
        private System.Windows.Forms.TextBox ajoutPasswordTextBox;
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
        private BdMotDataSet bdMotDataSet;
        private System.Windows.Forms.BindingSource utilisateurBindingSource1;
        private BdMotDataSetTableAdapters.UtilisateurTableAdapter utilisateurTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}