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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.CloseLabel = new System.Windows.Forms.Label();
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
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(543, 659);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.ajoutLoginTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.ajoutLoginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ajoutLoginTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajoutLoginTextBox.ForeColor = System.Drawing.Color.White;
            this.ajoutLoginTextBox.Location = new System.Drawing.Point(17, 92);
            this.ajoutLoginTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ajoutLoginTextBox.Name = "ajoutLoginTextBox";
            this.ajoutLoginTextBox.Size = new System.Drawing.Size(117, 20);
            this.ajoutLoginTextBox.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
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
            this.panel1.Location = new System.Drawing.Point(608, 48);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 214);
            this.panel1.TabIndex = 2;
            // 
            // btAjout
            // 
            this.btAjout.BackColor = System.Drawing.Color.Purple;
            this.btAjout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAjout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAjout.ForeColor = System.Drawing.Color.White;
            this.btAjout.Location = new System.Drawing.Point(201, 165);
            this.btAjout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btAjout.Name = "btAjout";
            this.btAjout.Size = new System.Drawing.Size(131, 38);
            this.btAjout.TabIndex = 6;
            this.btAjout.Text = "Ajouter";
            this.btAjout.UseVisualStyleBackColor = false;
            this.btAjout.Click += new System.EventHandler(this.btAjout_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(384, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(264, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Prénom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(137, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mot de passe";
            // 
            // ajoutNomTextBox
            // 
            this.ajoutNomTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.ajoutNomTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ajoutNomTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajoutNomTextBox.ForeColor = System.Drawing.Color.White;
            this.ajoutNomTextBox.Location = new System.Drawing.Point(389, 92);
            this.ajoutNomTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ajoutNomTextBox.Name = "ajoutNomTextBox";
            this.ajoutNomTextBox.Size = new System.Drawing.Size(117, 20);
            this.ajoutNomTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(189, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ajout d\'un utilisateur";
            // 
            // ajoutAdministrateurCheckBox
            // 
            this.ajoutAdministrateurCheckBox.AutoSize = true;
            this.ajoutAdministrateurCheckBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajoutAdministrateurCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ajoutAdministrateurCheckBox.Location = new System.Drawing.Point(194, 129);
            this.ajoutAdministrateurCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ajoutAdministrateurCheckBox.Name = "ajoutAdministrateurCheckBox";
            this.ajoutAdministrateurCheckBox.Size = new System.Drawing.Size(140, 23);
            this.ajoutAdministrateurCheckBox.TabIndex = 5;
            this.ajoutAdministrateurCheckBox.Text = "Administrateur";
            this.ajoutAdministrateurCheckBox.UseVisualStyleBackColor = true;
            // 
            // ajoutPrenomTextBox
            // 
            this.ajoutPrenomTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.ajoutPrenomTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ajoutPrenomTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajoutPrenomTextBox.ForeColor = System.Drawing.Color.White;
            this.ajoutPrenomTextBox.Location = new System.Drawing.Point(264, 92);
            this.ajoutPrenomTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ajoutPrenomTextBox.Name = "ajoutPrenomTextBox";
            this.ajoutPrenomTextBox.Size = new System.Drawing.Size(117, 20);
            this.ajoutPrenomTextBox.TabIndex = 3;
            // 
            // ajoutPasswordTextBox
            // 
            this.ajoutPasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.ajoutPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ajoutPasswordTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajoutPasswordTextBox.ForeColor = System.Drawing.Color.White;
            this.ajoutPasswordTextBox.Location = new System.Drawing.Point(142, 92);
            this.ajoutPasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ajoutPasswordTextBox.Name = "ajoutPasswordTextBox";
            this.ajoutPasswordTextBox.PasswordChar = '•';
            this.ajoutPasswordTextBox.Size = new System.Drawing.Size(117, 20);
            this.ajoutPasswordTextBox.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
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
            this.panel2.Location = new System.Drawing.Point(608, 269);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(548, 221);
            this.panel2.TabIndex = 5;
            this.panel2.Visible = false;
            // 
            // loginModifLabel
            // 
            this.loginModifLabel.AutoSize = true;
            this.loginModifLabel.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginModifLabel.ForeColor = System.Drawing.Color.Purple;
            this.loginModifLabel.Location = new System.Drawing.Point(338, 21);
            this.loginModifLabel.Name = "loginModifLabel";
            this.loginModifLabel.Size = new System.Drawing.Size(52, 21);
            this.loginModifLabel.TabIndex = 6;
            this.loginModifLabel.Text = "Login";
            this.loginModifLabel.Click += new System.EventHandler(this.loginModifLabel_Click);
            // 
            // btModifier
            // 
            this.btModifier.BackColor = System.Drawing.Color.Purple;
            this.btModifier.Enabled = false;
            this.btModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btModifier.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btModifier.ForeColor = System.Drawing.Color.White;
            this.btModifier.Location = new System.Drawing.Point(201, 170);
            this.btModifier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btModifier.Name = "btModifier";
            this.btModifier.Size = new System.Drawing.Size(131, 38);
            this.btModifier.TabIndex = 5;
            this.btModifier.Text = "Modfier";
            this.btModifier.UseVisualStyleBackColor = false;
            this.btModifier.Click += new System.EventHandler(this.btModifier_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(338, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Score";
            // 
            // labelModification
            // 
            this.labelModification.AutoSize = true;
            this.labelModification.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labelModification.Location = new System.Drawing.Point(189, 21);
            this.labelModification.Name = "labelModification";
            this.labelModification.Size = new System.Drawing.Size(130, 19);
            this.labelModification.TabIndex = 3;
            this.labelModification.Text = "Modification de";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(210, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "Nom";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CheckBoxModifAdmin
            // 
            this.CheckBoxModifAdmin.AutoSize = true;
            this.CheckBoxModifAdmin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxModifAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.CheckBoxModifAdmin.Location = new System.Drawing.Point(194, 134);
            this.CheckBoxModifAdmin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheckBoxModifAdmin.Name = "CheckBoxModifAdmin";
            this.CheckBoxModifAdmin.Size = new System.Drawing.Size(140, 23);
            this.CheckBoxModifAdmin.TabIndex = 4;
            this.CheckBoxModifAdmin.Text = "Administrateur";
            this.CheckBoxModifAdmin.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label9.Location = new System.Drawing.Point(86, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 19);
            this.label9.TabIndex = 10;
            this.label9.Text = "Prenom";
            // 
            // textBox_UpdateNom
            // 
            this.textBox_UpdateNom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.textBox_UpdateNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_UpdateNom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_UpdateNom.ForeColor = System.Drawing.Color.White;
            this.textBox_UpdateNom.Location = new System.Drawing.Point(215, 90);
            this.textBox_UpdateNom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_UpdateNom.Name = "textBox_UpdateNom";
            this.textBox_UpdateNom.Size = new System.Drawing.Size(117, 20);
            this.textBox_UpdateNom.TabIndex = 2;
            // 
            // textBox_UpdateScore
            // 
            this.textBox_UpdateScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.textBox_UpdateScore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_UpdateScore.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_UpdateScore.ForeColor = System.Drawing.Color.White;
            this.textBox_UpdateScore.Location = new System.Drawing.Point(338, 90);
            this.textBox_UpdateScore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_UpdateScore.Name = "textBox_UpdateScore";
            this.textBox_UpdateScore.Size = new System.Drawing.Size(117, 20);
            this.textBox_UpdateScore.TabIndex = 3;
            // 
            // textBox_UpdatePrenom
            // 
            this.textBox_UpdatePrenom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.textBox_UpdatePrenom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_UpdatePrenom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_UpdatePrenom.ForeColor = System.Drawing.Color.White;
            this.textBox_UpdatePrenom.Location = new System.Drawing.Point(91, 90);
            this.textBox_UpdatePrenom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_UpdatePrenom.Name = "textBox_UpdatePrenom";
            this.textBox_UpdatePrenom.Size = new System.Drawing.Size(117, 20);
            this.textBox_UpdatePrenom.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panel3.Controls.Add(this.loginSuppLabel);
            this.panel3.Controls.Add(this.btSupprimer);
            this.panel3.Controls.Add(this.labelSuppression);
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(608, 498);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(548, 123);
            this.panel3.TabIndex = 13;
            this.panel3.Visible = false;
            // 
            // loginSuppLabel
            // 
            this.loginSuppLabel.AutoSize = true;
            this.loginSuppLabel.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginSuppLabel.ForeColor = System.Drawing.Color.Purple;
            this.loginSuppLabel.Location = new System.Drawing.Point(334, 19);
            this.loginSuppLabel.Name = "loginSuppLabel";
            this.loginSuppLabel.Size = new System.Drawing.Size(52, 21);
            this.loginSuppLabel.TabIndex = 5;
            this.loginSuppLabel.Text = "Login";
            // 
            // btSupprimer
            // 
            this.btSupprimer.BackColor = System.Drawing.Color.Purple;
            this.btSupprimer.Enabled = false;
            this.btSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSupprimer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSupprimer.ForeColor = System.Drawing.Color.White;
            this.btSupprimer.Location = new System.Drawing.Point(201, 61);
            this.btSupprimer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSupprimer.Name = "btSupprimer";
            this.btSupprimer.Size = new System.Drawing.Size(131, 38);
            this.btSupprimer.TabIndex = 4;
            this.btSupprimer.Text = "Supprimer";
            this.btSupprimer.UseVisualStyleBackColor = false;
            this.btSupprimer.Click += new System.EventHandler(this.btSupprimer_Click);
            // 
            // labelSuppression
            // 
            this.labelSuppression.AutoSize = true;
            this.labelSuppression.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSuppression.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labelSuppression.Location = new System.Drawing.Point(189, 19);
            this.labelSuppression.Name = "labelSuppression";
            this.labelSuppression.Size = new System.Drawing.Size(125, 19);
            this.labelSuppression.TabIndex = 3;
            this.labelSuppression.Text = "Suppression de";
            // 
            // utilisateurTableAdapter
            // 
            this.utilisateurTableAdapter.ClearBeforeFill = true;
            // 
            // CloseLabel
            // 
            this.CloseLabel.AutoSize = true;
            this.CloseLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseLabel.ForeColor = System.Drawing.Color.Violet;
            this.CloseLabel.Location = new System.Drawing.Point(1199, 9);
            this.CloseLabel.Name = "CloseLabel";
            this.CloseLabel.Size = new System.Drawing.Size(28, 28);
            this.CloseLabel.TabIndex = 21;
            this.CloseLabel.Text = "X";
            this.CloseLabel.Click += new System.EventHandler(this.CloseLabel_Click);
            // 
            // AjoutUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1239, 660);
            this.Controls.Add(this.CloseLabel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.PerformLayout();

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
        private System.Windows.Forms.Label CloseLabel;
    }
}