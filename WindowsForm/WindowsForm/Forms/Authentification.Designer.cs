namespace WindowsForm
{
    partial class Authentification
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authentification));
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.MdpTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtConnexion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtInscription = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(92, 127);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(205, 20);
            this.LoginTextBox.TabIndex = 0;
            // 
            // MdpTextBox
            // 
            this.MdpTextBox.Location = new System.Drawing.Point(92, 155);
            this.MdpTextBox.Name = "MdpTextBox";
            this.MdpTextBox.PasswordChar = '•';
            this.MdpTextBox.Size = new System.Drawing.Size(205, 20);
            this.MdpTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom de compte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mot de passe";
            // 
            // BtConnexion
            // 
            this.BtConnexion.Location = new System.Drawing.Point(28, 181);
            this.BtConnexion.Name = "BtConnexion";
            this.BtConnexion.Size = new System.Drawing.Size(75, 23);
            this.BtConnexion.TabIndex = 5;
            this.BtConnexion.Text = "Connexion";
            this.BtConnexion.UseVisualStyleBackColor = true;
            this.BtConnexion.Click += new System.EventHandler(this.BtConnexion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(113, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // BtInscription
            // 
            this.BtInscription.Location = new System.Drawing.Point(222, 181);
            this.BtInscription.Name = "BtInscription";
            this.BtInscription.Size = new System.Drawing.Size(75, 23);
            this.BtInscription.TabIndex = 8;
            this.BtInscription.Text = "Inscription";
            this.BtInscription.UseVisualStyleBackColor = true;
            this.BtInscription.Click += new System.EventHandler(this.BtInscription_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.Location = new System.Drawing.Point(40, 111);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(246, 13);
            this.ErrorLabel.TabIndex = 9;
            this.ErrorLabel.Text = "Nom de compte ou mot de passe incorrect";
            this.ErrorLabel.Visible = false;
            // 
            // Authentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 219);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.BtInscription);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtConnexion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MdpTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Name = "Authentification";
            this.Text = "Authentification";
            this.Load += new System.EventHandler(this.Authentification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TextBox MdpTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtConnexion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtInscription;
        private System.Windows.Forms.Label ErrorLabel;
    }
}

