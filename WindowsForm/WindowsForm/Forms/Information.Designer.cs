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
            this.NomLabel = new System.Windows.Forms.Label();
            this.PrenomLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CMdpTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PseudoLabel = new System.Windows.Forms.Label();
            this.MdpTextBox = new System.Windows.Forms.TextBox();
            this.BtModif = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AncienMdpTextBox = new System.Windows.Forms.TextBox();
            this.BtValider = new System.Windows.Forms.Button();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.RangLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NomLabel
            // 
            this.NomLabel.AutoSize = true;
            this.NomLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.NomLabel.Location = new System.Drawing.Point(29, 115);
            this.NomLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.NomLabel.Name = "NomLabel";
            this.NomLabel.Size = new System.Drawing.Size(47, 21);
            this.NomLabel.TabIndex = 25;
            this.NomLabel.Text = "Nom";
            // 
            // PrenomLabel
            // 
            this.PrenomLabel.AutoSize = true;
            this.PrenomLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PrenomLabel.Location = new System.Drawing.Point(29, 83);
            this.PrenomLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.PrenomLabel.Name = "PrenomLabel";
            this.PrenomLabel.Size = new System.Drawing.Size(69, 21);
            this.PrenomLabel.TabIndex = 23;
            this.PrenomLabel.Text = "Prenom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(43, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 21);
            this.label3.TabIndex = 22;
            this.label3.Text = "Confirmer mot de passe";
            // 
            // CMdpTextBox
            // 
            this.CMdpTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.CMdpTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CMdpTextBox.ForeColor = System.Drawing.Color.White;
            this.CMdpTextBox.Location = new System.Drawing.Point(43, 180);
            this.CMdpTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.CMdpTextBox.Name = "CMdpTextBox";
            this.CMdpTextBox.PasswordChar = '•';
            this.CMdpTextBox.Size = new System.Drawing.Size(339, 20);
            this.CMdpTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(43, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Mot de passe";
            // 
            // PseudoLabel
            // 
            this.PseudoLabel.AutoSize = true;
            this.PseudoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PseudoLabel.Location = new System.Drawing.Point(29, 49);
            this.PseudoLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.PseudoLabel.Name = "PseudoLabel";
            this.PseudoLabel.Size = new System.Drawing.Size(139, 21);
            this.PseudoLabel.TabIndex = 18;
            this.PseudoLabel.Text = "Nom de compte";
            // 
            // MdpTextBox
            // 
            this.MdpTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.MdpTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MdpTextBox.ForeColor = System.Drawing.Color.White;
            this.MdpTextBox.Location = new System.Drawing.Point(43, 129);
            this.MdpTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.MdpTextBox.Name = "MdpTextBox";
            this.MdpTextBox.PasswordChar = '•';
            this.MdpTextBox.Size = new System.Drawing.Size(339, 20);
            this.MdpTextBox.TabIndex = 3;
            // 
            // BtModif
            // 
            this.BtModif.BackColor = System.Drawing.Color.Purple;
            this.BtModif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtModif.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtModif.ForeColor = System.Drawing.Color.White;
            this.BtModif.Location = new System.Drawing.Point(33, 155);
            this.BtModif.Margin = new System.Windows.Forms.Padding(5);
            this.BtModif.Name = "BtModif";
            this.BtModif.Size = new System.Drawing.Size(215, 37);
            this.BtModif.TabIndex = 1;
            this.BtModif.Text = "Modifier mot de passe";
            this.BtModif.UseVisualStyleBackColor = false;
            this.BtModif.Click += new System.EventHandler(this.BtModif_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(43, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 21);
            this.label1.TabIndex = 29;
            this.label1.Text = "Ancien mot de passe";
            // 
            // AncienMdpTextBox
            // 
            this.AncienMdpTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.AncienMdpTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AncienMdpTextBox.ForeColor = System.Drawing.Color.White;
            this.AncienMdpTextBox.Location = new System.Drawing.Point(47, 78);
            this.AncienMdpTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.AncienMdpTextBox.Name = "AncienMdpTextBox";
            this.AncienMdpTextBox.PasswordChar = '•';
            this.AncienMdpTextBox.Size = new System.Drawing.Size(339, 20);
            this.AncienMdpTextBox.TabIndex = 2;
            // 
            // BtValider
            // 
            this.BtValider.BackColor = System.Drawing.Color.Purple;
            this.BtValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtValider.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtValider.ForeColor = System.Drawing.Color.White;
            this.BtValider.Location = new System.Drawing.Point(99, 210);
            this.BtValider.Margin = new System.Windows.Forms.Padding(5);
            this.BtValider.Name = "BtValider";
            this.BtValider.Size = new System.Drawing.Size(215, 37);
            this.BtValider.TabIndex = 5;
            this.BtValider.Text = "Valider";
            this.BtValider.UseVisualStyleBackColor = false;
            this.BtValider.Click += new System.EventHandler(this.BtValider_Click);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ScoreLabel.Location = new System.Drawing.Point(323, 49);
            this.ScoreLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(74, 26);
            this.ScoreLabel.TabIndex = 31;
            this.ScoreLabel.Text = "Score";
            // 
            // RangLabel
            // 
            this.RangLabel.AutoSize = true;
            this.RangLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RangLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.RangLabel.Location = new System.Drawing.Point(323, 93);
            this.RangLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.RangLabel.Name = "RangLabel";
            this.RangLabel.Size = new System.Drawing.Size(68, 26);
            this.RangLabel.TabIndex = 32;
            this.RangLabel.Text = "Rang";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CloseLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.MdpTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.BtValider);
            this.panel1.Controls.Add(this.CMdpTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.AncienMdpTextBox);
            this.panel1.Location = new System.Drawing.Point(249, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 268);
            this.panel1.TabIndex = 33;
            this.panel1.Visible = false;
            // 
            // CloseLabel
            // 
            this.CloseLabel.AutoSize = true;
            this.CloseLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseLabel.ForeColor = System.Drawing.Color.Violet;
            this.CloseLabel.Location = new System.Drawing.Point(370, 11);
            this.CloseLabel.Name = "CloseLabel";
            this.CloseLabel.Size = new System.Drawing.Size(28, 28);
            this.CloseLabel.TabIndex = 32;
            this.CloseLabel.Text = "X";
            this.CloseLabel.Click += new System.EventHandler(this.CloseLabel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Violet;
            this.label5.Location = new System.Drawing.Point(619, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 28);
            this.label5.TabIndex = 33;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.ForeColor = System.Drawing.Color.Violet;
            this.WelcomeLabel.Location = new System.Drawing.Point(208, 5);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(85, 32);
            this.WelcomeLabel.TabIndex = 34;
            this.WelcomeLabel.Text = "Salut ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(238, 93);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 26);
            this.label6.TabIndex = 35;
            this.label6.Text = "Rang :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(238, 49);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 26);
            this.label7.TabIndex = 36;
            this.label7.Text = "Score :";
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(653, 460);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RangLabel);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.BtModif);
            this.Controls.Add(this.NomLabel);
            this.Controls.Add(this.PrenomLabel);
            this.Controls.Add(this.PseudoLabel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Information";
            this.Text = "Information";
            this.Load += new System.EventHandler(this.Information_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Button BtModif;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AncienMdpTextBox;
        private System.Windows.Forms.Button BtValider;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label RangLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CloseLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}