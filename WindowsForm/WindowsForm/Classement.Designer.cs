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
            this.ClassementGridView = new System.Windows.Forms.DataGridView();
            this.Pseudo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ClassementGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ClassementGridView
            // 
            this.ClassementGridView.AllowUserToAddRows = false;
            this.ClassementGridView.AllowUserToDeleteRows = false;
            this.ClassementGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClassementGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pseudo,
            this.Score});
            this.ClassementGridView.Location = new System.Drawing.Point(0, 0);
            this.ClassementGridView.Name = "ClassementGridView";
            this.ClassementGridView.ReadOnly = true;
            this.ClassementGridView.Size = new System.Drawing.Size(409, 292);
            this.ClassementGridView.TabIndex = 0;
            this.ClassementGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Pseudo
            // 
            this.Pseudo.HeaderText = "Pseudo";
            this.Pseudo.Name = "Pseudo";
            this.Pseudo.ReadOnly = true;
            // 
            // Score
            // 
            this.Score.HeaderText = "Score";
            this.Score.Name = "Score";
            this.Score.ReadOnly = true;
            // 
            // Classement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 294);
            this.Controls.Add(this.ClassementGridView);
            this.Name = "Classement";
            this.Text = "Classement";
            this.Load += new System.EventHandler(this.Classement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClassementGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ClassementGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pseudo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
    }
}