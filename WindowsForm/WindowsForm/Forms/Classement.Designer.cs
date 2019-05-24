namespace WindowsForm
{
    partial class Classement
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
            this.ClassementGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAdminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utilisateurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdMotDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdMotDataSet = new WindowsForm.BdMotDataSet();
            this.utilisateurTableAdapter = new WindowsForm.BdMotDataSetTableAdapters.UtilisateurTableAdapter();
            this.CloseLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ClassementGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdMotDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdMotDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ClassementGridView
            // 
            this.ClassementGridView.AllowUserToAddRows = false;
            this.ClassementGridView.AllowUserToDeleteRows = false;
            this.ClassementGridView.AllowUserToOrderColumns = true;
            this.ClassementGridView.AutoGenerateColumns = false;
            this.ClassementGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClassementGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClassementGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.rangDataGridViewTextBoxColumn,
            this.scoreDataGridViewTextBoxColumn,
            this.isAdminDataGridViewTextBoxColumn});
            this.ClassementGridView.DataSource = this.utilisateurBindingSource;
            this.ClassementGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClassementGridView.Location = new System.Drawing.Point(0, 0);
            this.ClassementGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClassementGridView.Name = "ClassementGridView";
            this.ClassementGridView.ReadOnly = true;
            this.ClassementGridView.Size = new System.Drawing.Size(401, 662);
            this.ClassementGridView.TabIndex = 0;
            this.ClassementGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClassementGridView_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
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
            this.prenomDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomDataGridViewTextBoxColumn.Visible = false;
            // 
            // rangDataGridViewTextBoxColumn
            // 
            this.rangDataGridViewTextBoxColumn.DataPropertyName = "rang";
            this.rangDataGridViewTextBoxColumn.HeaderText = "rang";
            this.rangDataGridViewTextBoxColumn.Name = "rangDataGridViewTextBoxColumn";
            this.rangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // scoreDataGridViewTextBoxColumn
            // 
            this.scoreDataGridViewTextBoxColumn.DataPropertyName = "score";
            this.scoreDataGridViewTextBoxColumn.HeaderText = "score";
            this.scoreDataGridViewTextBoxColumn.Name = "scoreDataGridViewTextBoxColumn";
            this.scoreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isAdminDataGridViewTextBoxColumn
            // 
            this.isAdminDataGridViewTextBoxColumn.DataPropertyName = "isAdmin";
            this.isAdminDataGridViewTextBoxColumn.HeaderText = "isAdmin";
            this.isAdminDataGridViewTextBoxColumn.Name = "isAdminDataGridViewTextBoxColumn";
            this.isAdminDataGridViewTextBoxColumn.ReadOnly = true;
            this.isAdminDataGridViewTextBoxColumn.Visible = false;
            // 
            // utilisateurBindingSource
            // 
            this.utilisateurBindingSource.DataMember = "Utilisateur";
            this.utilisateurBindingSource.DataSource = this.bdMotDataSetBindingSource;
            // 
            // bdMotDataSetBindingSource
            // 
            this.bdMotDataSetBindingSource.DataSource = this.bdMotDataSet;
            this.bdMotDataSetBindingSource.Position = 0;
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
            // CloseLabel
            // 
            this.CloseLabel.AutoSize = true;
            this.CloseLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.CloseLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseLabel.ForeColor = System.Drawing.Color.Violet;
            this.CloseLabel.Location = new System.Drawing.Point(361, 9);
            this.CloseLabel.Name = "CloseLabel";
            this.CloseLabel.Size = new System.Drawing.Size(28, 28);
            this.CloseLabel.TabIndex = 22;
            this.CloseLabel.Text = "X";
            this.CloseLabel.Click += new System.EventHandler(this.CloseLabel_Click_1);
            // 
            // Classement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 662);
            this.Controls.Add(this.CloseLabel);
            this.Controls.Add(this.ClassementGridView);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Classement";
            this.Text = "Classement";
            this.Load += new System.EventHandler(this.Classement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClassementGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdMotDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdMotDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ClassementGridView;
        private System.Windows.Forms.BindingSource bdMotDataSetBindingSource;
        private BdMotDataSet bdMotDataSet;
        private System.Windows.Forms.BindingSource utilisateurBindingSource;
        private BdMotDataSetTableAdapters.UtilisateurTableAdapter utilisateurTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isAdminDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label CloseLabel;
    }
}