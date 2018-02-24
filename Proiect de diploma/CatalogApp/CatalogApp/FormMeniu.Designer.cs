namespace CatalogApp
{
    partial class FormMenu
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
            this.introducereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afisareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.specializareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.specializareToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.notaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.introducereToolStripMenuItem,
            this.afisareToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // introducereToolStripMenuItem
            // 
            this.introducereToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profesorToolStripMenuItem,
            this.materieToolStripMenuItem,
            this.studentToolStripMenuItem,
            this.specializareToolStripMenuItem,
            this.notaToolStripMenuItem});
            this.introducereToolStripMenuItem.Name = "introducereToolStripMenuItem";
            this.introducereToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.introducereToolStripMenuItem.Text = "Introducere";
            // 
            // profesorToolStripMenuItem
            // 
            this.profesorToolStripMenuItem.Name = "profesorToolStripMenuItem";
            this.profesorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.profesorToolStripMenuItem.Text = "Profesor";
            this.profesorToolStripMenuItem.Click += new System.EventHandler(this.profesorToolStripMenuItem_Click);
            // 
            // materieToolStripMenuItem
            // 
            this.materieToolStripMenuItem.Name = "materieToolStripMenuItem";
            this.materieToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.materieToolStripMenuItem.Text = "Materie";
            // 
            // afisareToolStripMenuItem
            // 
            this.afisareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profesoriToolStripMenuItem,
            this.materiiToolStripMenuItem,
            this.studentToolStripMenuItem1,
            this.specializareToolStripMenuItem1,
            this.notaToolStripMenuItem1});
            this.afisareToolStripMenuItem.Name = "afisareToolStripMenuItem";
            this.afisareToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.afisareToolStripMenuItem.Text = "Afisare";
            // 
            // profesoriToolStripMenuItem
            // 
            this.profesoriToolStripMenuItem.Name = "profesoriToolStripMenuItem";
            this.profesoriToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.profesoriToolStripMenuItem.Text = "Profesori";
            this.profesoriToolStripMenuItem.Click += new System.EventHandler(this.profesoriToolStripMenuItem_Click);
            // 
            // materiiToolStripMenuItem
            // 
            this.materiiToolStripMenuItem.Name = "materiiToolStripMenuItem";
            this.materiiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.materiiToolStripMenuItem.Text = "Materii";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.studentToolStripMenuItem.Text = "Student";
            this.studentToolStripMenuItem.Click += new System.EventHandler(this.studentToolStripMenuItem_Click);
            // 
            // specializareToolStripMenuItem
            // 
            this.specializareToolStripMenuItem.Name = "specializareToolStripMenuItem";
            this.specializareToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.specializareToolStripMenuItem.Text = "Specializare";
            // 
            // notaToolStripMenuItem
            // 
            this.notaToolStripMenuItem.Name = "notaToolStripMenuItem";
            this.notaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.notaToolStripMenuItem.Text = "Nota";
            // 
            // studentToolStripMenuItem1
            // 
            this.studentToolStripMenuItem1.Name = "studentToolStripMenuItem1";
            this.studentToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.studentToolStripMenuItem1.Text = "Student";
            // 
            // specializareToolStripMenuItem1
            // 
            this.specializareToolStripMenuItem1.Name = "specializareToolStripMenuItem1";
            this.specializareToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.specializareToolStripMenuItem1.Text = "Specializare";
            // 
            // notaToolStripMenuItem1
            // 
            this.notaToolStripMenuItem1.Name = "notaToolStripMenuItem1";
            this.notaToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.notaToolStripMenuItem1.Text = "Nota";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenu";
            this.Text = "Main Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem introducereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profesorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afisareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profesoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem specializareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem specializareToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem notaToolStripMenuItem1;
    }
}