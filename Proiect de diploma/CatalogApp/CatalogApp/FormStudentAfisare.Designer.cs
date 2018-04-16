namespace CatalogApp
{
    partial class FormStudentAfisare
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
            this.btnPrintStudent = new System.Windows.Forms.Button();
            this.btnIesire = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.btnModificare = new System.Windows.Forms.Button();
            this.dgvStudenti = new System.Windows.Forms.DataGridView();
            this.btnCautare = new System.Windows.Forms.Button();
            this.cboGrupa = new System.Windows.Forms.ComboBox();
            this.lblGrupa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrintStudent
            // 
            this.btnPrintStudent.Location = new System.Drawing.Point(109, 396);
            this.btnPrintStudent.Name = "btnPrintStudent";
            this.btnPrintStudent.Size = new System.Drawing.Size(242, 42);
            this.btnPrintStudent.TabIndex = 16;
            this.btnPrintStudent.Text = "Afisare";
            this.btnPrintStudent.UseVisualStyleBackColor = true;
            this.btnPrintStudent.Click += new System.EventHandler(this.btnPrintStudent_Click);
            // 
            // btnIesire
            // 
            this.btnIesire.Location = new System.Drawing.Point(510, 380);
            this.btnIesire.Name = "btnIesire";
            this.btnIesire.Size = new System.Drawing.Size(242, 42);
            this.btnIesire.TabIndex = 15;
            this.btnIesire.Text = "Iesire";
            this.btnIesire.UseVisualStyleBackColor = true;
            // 
            // btnStergere
            // 
            this.btnStergere.Location = new System.Drawing.Point(510, 283);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(242, 42);
            this.btnStergere.TabIndex = 14;
            this.btnStergere.Text = "Stergere";
            this.btnStergere.UseVisualStyleBackColor = true;
            // 
            // btnModificare
            // 
            this.btnModificare.Location = new System.Drawing.Point(510, 184);
            this.btnModificare.Name = "btnModificare";
            this.btnModificare.Size = new System.Drawing.Size(242, 42);
            this.btnModificare.TabIndex = 13;
            this.btnModificare.Text = "Modificare";
            this.btnModificare.UseVisualStyleBackColor = true;
            // 
            // dgvStudenti
            // 
            this.dgvStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudenti.Location = new System.Drawing.Point(12, 12);
            this.dgvStudenti.Name = "dgvStudenti";
            this.dgvStudenti.Size = new System.Drawing.Size(394, 347);
            this.dgvStudenti.TabIndex = 12;
            // 
            // btnCautare
            // 
            this.btnCautare.Location = new System.Drawing.Point(510, 79);
            this.btnCautare.Name = "btnCautare";
            this.btnCautare.Size = new System.Drawing.Size(242, 42);
            this.btnCautare.TabIndex = 17;
            this.btnCautare.Text = "Cautare";
            this.btnCautare.UseVisualStyleBackColor = true;
            this.btnCautare.Click += new System.EventHandler(this.btnCautare_Click);
            // 
            // cboGrupa
            // 
            this.cboGrupa.FormattingEnabled = true;
            this.cboGrupa.Location = new System.Drawing.Point(568, 30);
            this.cboGrupa.Name = "cboGrupa";
            this.cboGrupa.Size = new System.Drawing.Size(184, 21);
            this.cboGrupa.TabIndex = 18;
            // 
            // lblGrupa
            // 
            this.lblGrupa.AutoSize = true;
            this.lblGrupa.Location = new System.Drawing.Point(510, 37);
            this.lblGrupa.Name = "lblGrupa";
            this.lblGrupa.Size = new System.Drawing.Size(36, 13);
            this.lblGrupa.TabIndex = 19;
            this.lblGrupa.Text = "Grupa";
            // 
            // FormStudentAfisare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 450);
            this.Controls.Add(this.lblGrupa);
            this.Controls.Add(this.cboGrupa);
            this.Controls.Add(this.btnCautare);
            this.Controls.Add(this.btnPrintStudent);
            this.Controls.Add(this.btnIesire);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnModificare);
            this.Controls.Add(this.dgvStudenti);
            this.Name = "FormStudentAfisare";
            this.Text = "FormStudentAfisare";
            this.Load += new System.EventHandler(this.FormStudentAfisare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrintStudent;
        private System.Windows.Forms.Button btnIesire;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.Button btnModificare;
        private System.Windows.Forms.DataGridView dgvStudenti;
        private System.Windows.Forms.Button btnCautare;
        private System.Windows.Forms.ComboBox cboGrupa;
        private System.Windows.Forms.Label lblGrupa;
    }
}