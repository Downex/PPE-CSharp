namespace WindowsForm
{
    partial class Accueil
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
            System.Windows.Forms.Button btClassement;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            System.Windows.Forms.Button btAjoutMot;
            System.Windows.Forms.Button btGestionUser;
            System.Windows.Forms.Button btPhraseGen;
            this.btJouer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtConnexion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CloseLabel = new System.Windows.Forms.Label();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelAdmin = new System.Windows.Forms.Label();
            btClassement = new System.Windows.Forms.Button();
            btAjoutMot = new System.Windows.Forms.Button();
            btGestionUser = new System.Windows.Forms.Button();
            btPhraseGen = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btClassement
            // 
            btClassement.FlatAppearance.BorderColor = System.Drawing.Color.White;
            btClassement.FlatAppearance.BorderSize = 0;
            btClassement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            btClassement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            btClassement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btClassement.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btClassement.ForeColor = System.Drawing.Color.White;
            btClassement.Image = ((System.Drawing.Image)(resources.GetObject("btClassement.Image")));
            btClassement.Location = new System.Drawing.Point(0, 282);
            btClassement.Name = "btClassement";
            btClassement.Size = new System.Drawing.Size(207, 45);
            btClassement.TabIndex = 3;
            btClassement.Text = "Classement";
            btClassement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btClassement.UseVisualStyleBackColor = true;
            btClassement.Click += new System.EventHandler(this.btClassement_Click);
            // 
            // btAjoutMot
            // 
            btAjoutMot.BackColor = System.Drawing.Color.Purple;
            btAjoutMot.FlatAppearance.BorderColor = System.Drawing.Color.White;
            btAjoutMot.FlatAppearance.BorderSize = 0;
            btAjoutMot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            btAjoutMot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            btAjoutMot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btAjoutMot.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btAjoutMot.ForeColor = System.Drawing.Color.White;
            btAjoutMot.Image = ((System.Drawing.Image)(resources.GetObject("btAjoutMot.Image")));
            btAjoutMot.Location = new System.Drawing.Point(17, 51);
            btAjoutMot.Name = "btAjoutMot";
            btAjoutMot.Size = new System.Drawing.Size(253, 45);
            btAjoutMot.TabIndex = 4;
            btAjoutMot.Text = "Ajouter un mot";
            btAjoutMot.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btAjoutMot.UseVisualStyleBackColor = false;
            btAjoutMot.Click += new System.EventHandler(this.btAjoutMot_Click);
            // 
            // btGestionUser
            // 
            btGestionUser.BackColor = System.Drawing.Color.Purple;
            btGestionUser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            btGestionUser.FlatAppearance.BorderSize = 0;
            btGestionUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            btGestionUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            btGestionUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btGestionUser.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btGestionUser.ForeColor = System.Drawing.Color.White;
            btGestionUser.Image = ((System.Drawing.Image)(resources.GetObject("btGestionUser.Image")));
            btGestionUser.Location = new System.Drawing.Point(17, 189);
            btGestionUser.Name = "btGestionUser";
            btGestionUser.Size = new System.Drawing.Size(328, 45);
            btGestionUser.TabIndex = 6;
            btGestionUser.Text = "Gestion des utilisateurs";
            btGestionUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btGestionUser.UseVisualStyleBackColor = false;
            btGestionUser.Click += new System.EventHandler(this.btGestionUser_Click);
            // 
            // btPhraseGen
            // 
            btPhraseGen.BackColor = System.Drawing.Color.Purple;
            btPhraseGen.FlatAppearance.BorderColor = System.Drawing.Color.White;
            btPhraseGen.FlatAppearance.BorderSize = 0;
            btPhraseGen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            btPhraseGen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            btPhraseGen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btPhraseGen.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btPhraseGen.ForeColor = System.Drawing.Color.White;
            btPhraseGen.Image = ((System.Drawing.Image)(resources.GetObject("btPhraseGen.Image")));
            btPhraseGen.Location = new System.Drawing.Point(17, 120);
            btPhraseGen.Name = "btPhraseGen";
            btPhraseGen.Size = new System.Drawing.Size(328, 45);
            btPhraseGen.TabIndex = 5;
            btPhraseGen.Text = "Générateur de phrase";
            btPhraseGen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btPhraseGen.UseVisualStyleBackColor = false;
            btPhraseGen.Click += new System.EventHandler(this.btPhraseGen_Click);
            // 
            // btJouer
            // 
            this.btJouer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btJouer.FlatAppearance.BorderSize = 0;
            this.btJouer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btJouer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btJouer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btJouer.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btJouer.ForeColor = System.Drawing.Color.White;
            this.btJouer.Image = ((System.Drawing.Image)(resources.GetObject("btJouer.Image")));
            this.btJouer.Location = new System.Drawing.Point(0, 221);
            this.btJouer.Name = "btJouer";
            this.btJouer.Size = new System.Drawing.Size(207, 45);
            this.btJouer.TabIndex = 2;
            this.btJouer.Text = "S\'exercer";
            this.btJouer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btJouer.UseVisualStyleBackColor = false;
            this.btJouer.Click += new System.EventHandler(this.btJouer_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.BtConnexion);
            this.panel1.Controls.Add(btClassement);
            this.panel1.Controls.Add(this.btJouer);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 541);
            this.panel1.TabIndex = 2;
            // 
            // BtConnexion
            // 
            this.BtConnexion.BackColor = System.Drawing.Color.Purple;
            this.BtConnexion.FlatAppearance.BorderSize = 0;
            this.BtConnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtConnexion.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtConnexion.ForeColor = System.Drawing.Color.White;
            this.BtConnexion.Image = ((System.Drawing.Image)(resources.GetObject("BtConnexion.Image")));
            this.BtConnexion.Location = new System.Drawing.Point(-3, 109);
            this.BtConnexion.Name = "BtConnexion";
            this.BtConnexion.Size = new System.Drawing.Size(207, 58);
            this.BtConnexion.TabIndex = 1;
            this.BtConnexion.Text = "Login";
            this.BtConnexion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtConnexion.UseVisualStyleBackColor = false;
            this.BtConnexion.Click += new System.EventHandler(this.BtLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 79);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // CloseLabel
            // 
            this.CloseLabel.AutoSize = true;
            this.CloseLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseLabel.ForeColor = System.Drawing.Color.Violet;
            this.CloseLabel.Location = new System.Drawing.Point(799, 9);
            this.CloseLabel.Name = "CloseLabel";
            this.CloseLabel.Size = new System.Drawing.Size(28, 28);
            this.CloseLabel.TabIndex = 8;
            this.CloseLabel.Text = "X";
            this.CloseLabel.Click += new System.EventHandler(this.CloseLabel_Click);
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.ForeColor = System.Drawing.Color.Violet;
            this.WelcomeLabel.Location = new System.Drawing.Point(232, 80);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(147, 23);
            this.WelcomeLabel.TabIndex = 13;
            this.WelcomeLabel.Text = "Ravi de te voir ";
            // 
            // panelAdmin
            // 
            this.panelAdmin.Controls.Add(this.label4);
            this.panelAdmin.Controls.Add(this.label1);
            this.panelAdmin.Controls.Add(btPhraseGen);
            this.panelAdmin.Controls.Add(btGestionUser);
            this.panelAdmin.Controls.Add(btAjoutMot);
            this.panelAdmin.Location = new System.Drawing.Point(236, 170);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(552, 250);
            this.panelAdmin.TabIndex = 13;
            this.panelAdmin.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Violet;
            this.label4.Location = new System.Drawing.Point(3, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 23);
            this.label4.TabIndex = 22;
            this.label4.Text = "Panel Administrateur";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Violet;
            this.label1.Location = new System.Drawing.Point(507, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Violet;
            this.label3.Location = new System.Drawing.Point(475, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 32);
            this.label3.TabIndex = 21;
            this.label3.Text = "AsDyx";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Violet;
            this.label2.Location = new System.Drawing.Point(298, 509);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(529, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "Application créée par CAHIER François et CAZIN Nicolas";
            // 
            // labelAdmin
            // 
            this.labelAdmin.AutoSize = true;
            this.labelAdmin.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdmin.ForeColor = System.Drawing.Color.Violet;
            this.labelAdmin.Location = new System.Drawing.Point(239, 139);
            this.labelAdmin.Name = "labelAdmin";
            this.labelAdmin.Size = new System.Drawing.Size(29, 28);
            this.labelAdmin.TabIndex = 24;
            this.labelAdmin.Text = "V";
            this.labelAdmin.Visible = false;
            this.labelAdmin.Click += new System.EventHandler(this.label5_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(839, 541);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CloseLabel);
            this.Controls.Add(this.panelAdmin);
            this.Controls.Add(this.labelAdmin);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Accueil_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelAdmin.ResumeLayout(false);
            this.panelAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label CloseLabel;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelAdmin;
        private System.Windows.Forms.Button BtConnexion;
        private System.Windows.Forms.Button btJouer;
    }
}