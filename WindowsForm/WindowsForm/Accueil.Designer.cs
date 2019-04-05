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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.motToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monCompteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InformationPersonnel = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutDutilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.classementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.motToolStripMenuItem,
            this.monCompteToolStripMenuItem,
            this.classementToolStripMenuItem,
            this.motToolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // motToolStripMenuItem
            // 
            this.motToolStripMenuItem.Name = "motToolStripMenuItem";
            this.motToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.motToolStripMenuItem.Text = "Fichier";
            this.motToolStripMenuItem.Click += new System.EventHandler(this.motToolStripMenuItem_Click);
            // 
            // monCompteToolStripMenuItem
            // 
            this.monCompteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InformationPersonnel,
            this.ajoutDutilisateurToolStripMenuItem});
            this.monCompteToolStripMenuItem.Name = "monCompteToolStripMenuItem";
            this.monCompteToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.monCompteToolStripMenuItem.Text = "Mon compte";
            this.monCompteToolStripMenuItem.Click += new System.EventHandler(this.monCompteToolStripMenuItem_Click);
            // 
            // InformationPersonnel
            // 
            this.InformationPersonnel.Name = "InformationPersonnel";
            this.InformationPersonnel.Size = new System.Drawing.Size(201, 22);
            this.InformationPersonnel.Text = "Information personnelle";
            this.InformationPersonnel.Click += new System.EventHandler(this.InformationPersonnel_Click);
            // 
            // ajoutDutilisateurToolStripMenuItem
            // 
            this.ajoutDutilisateurToolStripMenuItem.Name = "ajoutDutilisateurToolStripMenuItem";
            this.ajoutDutilisateurToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.ajoutDutilisateurToolStripMenuItem.Text = "Ajout d\'utilisateur";
            this.ajoutDutilisateurToolStripMenuItem.Visible = false;
            // 
            // motToolStripMenuItem1
            // 
            this.motToolStripMenuItem1.Name = "motToolStripMenuItem1";
            this.motToolStripMenuItem1.Size = new System.Drawing.Size(41, 20);
            this.motToolStripMenuItem1.Text = "Mot";
            // 
            // classementToolStripMenuItem
            // 
            this.classementToolStripMenuItem.Name = "classementToolStripMenuItem";
            this.classementToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.classementToolStripMenuItem.Text = "Classement";
            this.classementToolStripMenuItem.Click += new System.EventHandler(this.classementToolStripMenuItem_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Accueil_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem motToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monCompteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InformationPersonnel;
        private System.Windows.Forms.ToolStripMenuItem ajoutDutilisateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem classementToolStripMenuItem;
    }
}