namespace CatalogApp
{
    partial class FormProfesorAfisare
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
            this.dgvProfesori = new System.Windows.Forms.DataGridView();
            this.btnModificare = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.btnIesire = new System.Windows.Forms.Button();
            this.pd1 = new System.Windows.Forms.PrintDialog();
            this.btnPrintProfesor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesori)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProfesori
            // 
            this.dgvProfesori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfesori.Location = new System.Drawing.Point(12, 12);
            this.dgvProfesori.Name = "dgvProfesori";
            this.dgvProfesori.Size = new System.Drawing.Size(394, 347);
            this.dgvProfesori.TabIndex = 0;
            // 
            // btnModificare
            // 
            this.btnModificare.Location = new System.Drawing.Point(478, 75);
            this.btnModificare.Name = "btnModificare";
            this.btnModificare.Size = new System.Drawing.Size(242, 42);
            this.btnModificare.TabIndex = 8;
            this.btnModificare.Text = "Modificare";
            this.btnModificare.UseVisualStyleBackColor = true;
            this.btnModificare.Click += new System.EventHandler(this.btnModificare_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.Location = new System.Drawing.Point(478, 174);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(242, 42);
            this.btnStergere.TabIndex = 9;
            this.btnStergere.Text = "Stergere";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // btnIesire
            // 
            this.btnIesire.Location = new System.Drawing.Point(478, 271);
            this.btnIesire.Name = "btnIesire";
            this.btnIesire.Size = new System.Drawing.Size(242, 42);
            this.btnIesire.TabIndex = 10;
            this.btnIesire.Text = "Iesire";
            this.btnIesire.UseVisualStyleBackColor = true;
            this.btnIesire.Click += new System.EventHandler(this.btnIesire_Click);
            // 
            // pd1
            // 
            this.pd1.UseEXDialog = true;
            // 
            // btnPrintProfesor
            // 
            this.btnPrintProfesor.Location = new System.Drawing.Point(294, 407);
            this.btnPrintProfesor.Name = "btnPrintProfesor";
            this.btnPrintProfesor.Size = new System.Drawing.Size(242, 42);
            this.btnPrintProfesor.TabIndex = 11;
            this.btnPrintProfesor.Text = "Afisare";
            this.btnPrintProfesor.UseVisualStyleBackColor = true;
            this.btnPrintProfesor.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // FormProfesorAfisare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 498);
            this.Controls.Add(this.btnPrintProfesor);
            this.Controls.Add(this.btnIesire);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnModificare);
            this.Controls.Add(this.dgvProfesori);
            this.Name = "FormProfesorAfisare";
            this.Text = "FormProfesori";
            this.Activated += new System.EventHandler(this.FormProfesorAfisare_Activated);
            this.Load += new System.EventHandler(this.FormProfesori_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesori)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProfesori;
        private System.Windows.Forms.Button btnModificare;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.Button btnIesire;
        private System.Windows.Forms.PrintDialog pd1;
        private System.Windows.Forms.Button btnPrintProfesor;
    }
}