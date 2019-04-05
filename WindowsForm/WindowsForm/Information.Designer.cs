namespace WindowsForm
{
    partial class Information
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Information));
            this.NomLabel = new System.Windows.Forms.Label();
            this.PrenomLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CMdpTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PseudoLabel = new System.Windows.Forms.Label();
            this.MdpTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtModif = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AncienMdpTextBox = new System.Windows.Forms.TextBox();
            this.BtValider = new System.Windows.Forms.Button();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.RangLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NomLabel
            // 
            this.NomLabel.AutoSize = true;
            this.NomLabel.Location = new System.Drawing.Point(221, 62);
            this.NomLabel.Name = "NomLabel";
            this.NomLabel.Size = new System.Drawing.Size(29, 13);
            this.NomLabel.TabIndex = 25;
            this.NomLabel.Text = "Nom";
            // 
            // PrenomLabel
            // 
            this.PrenomLabel.AutoSize = true;
            this.PrenomLabel.Location = new System.Drawing.Point(138, 62);
            this.PrenomLabel.Name = "PrenomLabel";
            this.PrenomLabel.Size = new System.Drawing.Size(43, 13);
            this.PrenomLabel.TabIndex = 23;
            this.PrenomLabel.Text = "Prenom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Confirmer mot de passe";
            this.label3.Visible = false;
            // 
            // CMdpTextBox
            // 
            this.CMdpTextBox.Location = new System.Drawing.Point(132, 211);
            this.CMdpTextBox.Name = "CMdpTextBox";
            this.CMdpTextBox.PasswordChar = '•';
            this.CMdpTextBox.Size = new System.Drawing.Size(205, 20);
            this.CMdpTextBox.TabIndex = 20;
            this.CMdpTextBox.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Mot de passe";
            this.label2.Visible = false;
            // 
            // PseudoLabel
            // 
            this.PseudoLabel.AutoSize = true;
            this.PseudoLabel.Location = new System.Drawing.Point(138, 21);
            this.PseudoLabel.Name = "PseudoLabel";
            this.PseudoLabel.Size = new System.Drawing.Size(82, 13);
            this.PseudoLabel.TabIndex = 18;
            this.PseudoLabel.Text = "Nom de compte";
            // 
            // MdpTextBox
            // 
            this.MdpTextBox.Location = new System.Drawing.Point(132, 185);
            this.MdpTextBox.Name = "MdpTextBox";
            this.MdpTextBox.PasswordChar = '•';
            this.MdpTextBox.Size = new System.Drawing.Size(205, 20);
            this.MdpTextBox.TabIndex = 17;
            this.MdpTextBox.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // BtModif
            // 
            this.BtModif.Location = new System.Drawing.Point(132, 90);
            this.BtModif.Name = "BtModif";
            this.BtModif.Size = new System.Drawing.Size(129, 23);
            this.BtModif.TabIndex = 27;
            this.BtModif.Text = "Modifier mot de passe";
            this.BtModif.UseVisualStyleBackColor = true;
            this.BtModif.Click += new System.EventHandler(this.BtModif_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Ancien mot de passe";
            this.label1.Visible = false;
            // 
            // AncienMdpTextBox
            // 
            this.AncienMdpTextBox.Location = new System.Drawing.Point(132, 144);
            this.AncienMdpTextBox.Name = "AncienMdpTextBox";
            this.AncienMdpTextBox.PasswordChar = '•';
            this.AncienMdpTextBox.Size = new System.Drawing.Size(205, 20);
            this.AncienMdpTextBox.TabIndex = 28;
            this.AncienMdpTextBox.Visible = false;
            // 
            // BtValider
            // 
            this.BtValider.Location = new System.Drawing.Point(132, 256);
            this.BtValider.Name = "BtValider";
            this.BtValider.Size = new System.Drawing.Size(129, 23);
            this.BtValider.TabIndex = 30;
            this.BtValider.Text = "Valider";
            this.BtValider.UseVisualStyleBackColor = true;
            this.BtValider.Visible = false;
            this.BtValider.Click += new System.EventHandler(this.BtValider_Click);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.Location = new System.Drawing.Point(311, 21);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(74, 26);
            this.ScoreLabel.TabIndex = 31;
            this.ScoreLabel.Text = "Score";
            // 
            // RangLabel
            // 
            this.RangLabel.AutoSize = true;
            this.RangLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RangLabel.Location = new System.Drawing.Point(311, 86);
            this.RangLabel.Name = "RangLabel";
            this.RangLabel.Size = new System.Drawing.Size(68, 26);
            this.RangLabel.TabIndex = 32;
            this.RangLabel.Text = "Rang";
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 303);
            this.Controls.Add(this.RangLabel);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.BtValider);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AncienMdpTextBox);
            this.Controls.Add(this.BtModif);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NomLabel);
            this.Controls.Add(this.PrenomLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CMdpTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PseudoLabel);
            this.Controls.Add(this.MdpTextBox);
            this.Name = "Information";
            this.Text = "Information";
            this.Load += new System.EventHandler(this.Information_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NomLabel;
        private System.Windows.Forms.Label PrenomLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CMdpTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PseudoLabel;
        private System.Windows.Forms.TextBox MdpTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtModif;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AncienMdpTextBox;
        private System.Windows.Forms.Button BtValider;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label RangLabel;
    }
}