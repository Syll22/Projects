namespace CatalogApp
{
    partial class FormStudentIntroducere
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
            this.components = new System.ComponentModel.Container();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.lblNume = new System.Windows.Forms.Label();
            this.lblGrupa = new System.Windows.Forms.Label();
            this.catalogDataSet = new CatalogApp.CatalogDataSet();
            this.listaGrupeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaGrupeTableAdapter = new CatalogApp.CatalogDataSetTableAdapters.ListaGrupeTableAdapter();
            this.comboBoxGrupe = new System.Windows.Forms.ComboBox();
            this.listaGrupeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.catalogDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaGrupeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaGrupeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(111, 100);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(243, 20);
            this.txtPrenume.TabIndex = 6;
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.Location = new System.Drawing.Point(50, 100);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(49, 13);
            this.lblPrenume.TabIndex = 10;
            this.lblPrenume.Text = "Prenume";
            // 
            // btnSalvare
            // 
            this.btnSalvare.Location = new System.Drawing.Point(111, 200);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(243, 42);
            this.btnSalvare.TabIndex = 8;
            this.btnSalvare.Text = "Salvare";
            this.btnSalvare.UseVisualStyleBackColor = true;
            this.btnSalvare.Click += new System.EventHandler(this.btnSalvare_Click);
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(111, 48);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(243, 20);
            this.txtNume.TabIndex = 5;
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(50, 50);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(35, 13);
            this.lblNume.TabIndex = 9;
            this.lblNume.Text = "Nume";
            // 
            // lblGrupa
            // 
            this.lblGrupa.AutoSize = true;
            this.lblGrupa.Location = new System.Drawing.Point(50, 150);
            this.lblGrupa.Name = "lblGrupa";
            this.lblGrupa.Size = new System.Drawing.Size(36, 13);
            this.lblGrupa.TabIndex = 11;
            this.lblGrupa.Text = "Grupa";
            // 
            // catalogDataSet
            // 
            this.catalogDataSet.DataSetName = "CatalogDataSet";
            this.catalogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listaGrupeBindingSource
            // 
            this.listaGrupeBindingSource.DataMember = "ListaGrupe";
            this.listaGrupeBindingSource.DataSource = this.catalogDataSet;
            // 
            // listaGrupeTableAdapter
            // 
            this.listaGrupeTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxGrupe
            // 
            this.comboBoxGrupe.DataSource = this.listaGrupeBindingSource1;
            this.comboBoxGrupe.DisplayMember = "NumeGrupa";
            this.comboBoxGrupe.FormattingEnabled = true;
            this.comboBoxGrupe.Location = new System.Drawing.Point(111, 150);
            this.comboBoxGrupe.Name = "comboBoxGrupe";
            this.comboBoxGrupe.Size = new System.Drawing.Size(243, 21);
            this.comboBoxGrupe.TabIndex = 7;
            this.comboBoxGrupe.ValueMember = "IdGrupa";
            // 
            // listaGrupeBindingSource1
            // 
            this.listaGrupeBindingSource1.DataMember = "ListaGrupe";
            this.listaGrupeBindingSource1.DataSource = this.catalogDataSet;
            // 
            // FormStudentIntroducere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 278);
            this.Controls.Add(this.comboBoxGrupe);
            this.Controls.Add(this.lblGrupa);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.lblPrenume);
            this.Controls.Add(this.btnSalvare);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.lblNume);
            this.Name = "FormStudentIntroducere";
            this.Text = "FormStudentIntroducere";
            ((System.ComponentModel.ISupportInitialize)(this.catalogDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaGrupeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaGrupeBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblGrupa;
        private CatalogDataSet catalogDataSet;
        private System.Windows.Forms.BindingSource listaGrupeBindingSource;
        private CatalogDataSetTableAdapters.ListaGrupeTableAdapter listaGrupeTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxGrupe;
        private System.Windows.Forms.BindingSource listaGrupeBindingSource1;
    }
}