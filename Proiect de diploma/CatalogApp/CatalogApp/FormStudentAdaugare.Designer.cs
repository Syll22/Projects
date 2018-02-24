namespace CatalogApp
{
    partial class FormStudentAdaugare
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
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.lblNume = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(106, 91);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(243, 20);
            this.txtPrenume.TabIndex = 6;
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.Location = new System.Drawing.Point(45, 93);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(49, 13);
            this.lblPrenume.TabIndex = 9;
            this.lblPrenume.Text = "Prenume";
            // 
            // btnSalvare
            // 
            this.btnSalvare.Location = new System.Drawing.Point(106, 170);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(242, 42);
            this.btnSalvare.TabIndex = 7;
            this.btnSalvare.Text = "Salvare";
            this.btnSalvare.UseVisualStyleBackColor = true;
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(106, 48);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(243, 20);
            this.txtNume.TabIndex = 5;
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(45, 50);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(35, 13);
            this.lblNume.TabIndex = 8;
            this.lblNume.Text = "Nume";
            // 
            // FormStudentAdaugare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 331);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.lblPrenume);
            this.Controls.Add(this.btnSalvare);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.lblNume);
            this.Name = "FormStudentAdaugare";
            this.Text = "FormStudentAdaugare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label lblNume;
    }
}