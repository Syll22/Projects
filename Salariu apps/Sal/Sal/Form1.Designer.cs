namespace Sal
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxNet_old = new System.Windows.Forms.TextBox();
            this.textBoxBrut_old = new System.Windows.Forms.TextBox();
            this.labelNet_old = new System.Windows.Forms.Label();
            this.labelBrut_old = new System.Windows.Forms.Label();
            this.buton_calcul_old = new System.Windows.Forms.Button();
            this.radioButtonScutit_old = new System.Windows.Forms.RadioButton();
            this.radioButtonNescutit_old = new System.Windows.Forms.RadioButton();
            this.buton_reset_old = new System.Windows.Forms.Button();
            this.label_old = new System.Windows.Forms.Label();
            this.label_new = new System.Windows.Forms.Label();
            this.button_reset_new = new System.Windows.Forms.Button();
            this.radioButtonNescutit_new = new System.Windows.Forms.RadioButton();
            this.radioButtonScutit_new = new System.Windows.Forms.RadioButton();
            this.button_calcul_new = new System.Windows.Forms.Button();
            this.labelBrut_new = new System.Windows.Forms.Label();
            this.labelNet_new = new System.Windows.Forms.Label();
            this.textBoxBrut_new = new System.Windows.Forms.TextBox();
            this.textBoxNet_new = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // textBoxNet_old
            // 
            this.textBoxNet_old.Location = new System.Drawing.Point(54, 75);
            this.textBoxNet_old.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNet_old.Name = "textBoxNet_old";
            this.textBoxNet_old.Size = new System.Drawing.Size(76, 20);
            this.textBoxNet_old.TabIndex = 0;
            // 
            // textBoxBrut_old
            // 
            this.textBoxBrut_old.Location = new System.Drawing.Point(54, 98);
            this.textBoxBrut_old.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBrut_old.Name = "textBoxBrut_old";
            this.textBoxBrut_old.Size = new System.Drawing.Size(76, 20);
            this.textBoxBrut_old.TabIndex = 1;
            // 
            // labelNet_old
            // 
            this.labelNet_old.AutoSize = true;
            this.labelNet_old.Location = new System.Drawing.Point(10, 78);
            this.labelNet_old.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNet_old.Name = "labelNet_old";
            this.labelNet_old.Size = new System.Drawing.Size(24, 13);
            this.labelNet_old.TabIndex = 4;
            this.labelNet_old.Text = "Net";
            // 
            // labelBrut_old
            // 
            this.labelBrut_old.AutoSize = true;
            this.labelBrut_old.Location = new System.Drawing.Point(10, 102);
            this.labelBrut_old.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBrut_old.Name = "labelBrut_old";
            this.labelBrut_old.Size = new System.Drawing.Size(26, 13);
            this.labelBrut_old.TabIndex = 5;
            this.labelBrut_old.Text = "Brut";
            // 
            // buton_calcul_old
            // 
            this.buton_calcul_old.Location = new System.Drawing.Point(54, 129);
            this.buton_calcul_old.Margin = new System.Windows.Forms.Padding(2);
            this.buton_calcul_old.Name = "buton_calcul_old";
            this.buton_calcul_old.Size = new System.Drawing.Size(75, 19);
            this.buton_calcul_old.TabIndex = 4;
            this.buton_calcul_old.Text = "Calculeaza";
            this.buton_calcul_old.UseVisualStyleBackColor = true;
            this.buton_calcul_old.Click += new System.EventHandler(this.CalculeazaButton_old);
            // 
            // radioButtonScutit_old
            // 
            this.radioButtonScutit_old.AutoSize = true;
            this.radioButtonScutit_old.Location = new System.Drawing.Point(134, 75);
            this.radioButtonScutit_old.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonScutit_old.Name = "radioButtonScutit_old";
            this.radioButtonScutit_old.Size = new System.Drawing.Size(52, 17);
            this.radioButtonScutit_old.TabIndex = 2;
            this.radioButtonScutit_old.TabStop = true;
            this.radioButtonScutit_old.Text = "Scutit";
            this.radioButtonScutit_old.UseVisualStyleBackColor = true;
            // 
            // radioButtonNescutit_old
            // 
            this.radioButtonNescutit_old.AutoSize = true;
            this.radioButtonNescutit_old.Location = new System.Drawing.Point(134, 98);
            this.radioButtonNescutit_old.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonNescutit_old.Name = "radioButtonNescutit_old";
            this.radioButtonNescutit_old.Size = new System.Drawing.Size(64, 17);
            this.radioButtonNescutit_old.TabIndex = 3;
            this.radioButtonNescutit_old.TabStop = true;
            this.radioButtonNescutit_old.Text = "Nescutit";
            this.radioButtonNescutit_old.UseVisualStyleBackColor = true;
            // 
            // buton_reset_old
            // 
            this.buton_reset_old.Location = new System.Drawing.Point(134, 129);
            this.buton_reset_old.Margin = new System.Windows.Forms.Padding(2);
            this.buton_reset_old.Name = "buton_reset_old";
            this.buton_reset_old.Size = new System.Drawing.Size(56, 19);
            this.buton_reset_old.TabIndex = 6;
            this.buton_reset_old.Text = "Reset";
            this.buton_reset_old.UseVisualStyleBackColor = true;
            this.buton_reset_old.Click += new System.EventHandler(this.ResetButton_old);
            // 
            // label_old
            // 
            this.label_old.AutoSize = true;
            this.label_old.Location = new System.Drawing.Point(72, 33);
            this.label_old.Name = "label_old";
            this.label_old.Size = new System.Drawing.Size(76, 13);
            this.label_old.TabIndex = 7;
            this.label_old.Text = "Metoda veche";
            // 
            // label_new
            // 
            this.label_new.AutoSize = true;
            this.label_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_new.Location = new System.Drawing.Point(304, 33);
            this.label_new.Name = "label_new";
            this.label_new.Size = new System.Drawing.Size(81, 13);
            this.label_new.TabIndex = 16;
            this.label_new.Text = "Metoda noua";
            // 
            // button_reset_new
            // 
            this.button_reset_new.Location = new System.Drawing.Point(366, 129);
            this.button_reset_new.Margin = new System.Windows.Forms.Padding(2);
            this.button_reset_new.Name = "button_reset_new";
            this.button_reset_new.Size = new System.Drawing.Size(56, 19);
            this.button_reset_new.TabIndex = 15;
            this.button_reset_new.Text = "Reset";
            this.button_reset_new.UseVisualStyleBackColor = true;
            this.button_reset_new.Click += new System.EventHandler(this.button_reset_new_Click);
            // 
            // radioButtonNescutit_new
            // 
            this.radioButtonNescutit_new.AutoSize = true;
            this.radioButtonNescutit_new.Location = new System.Drawing.Point(366, 98);
            this.radioButtonNescutit_new.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonNescutit_new.Name = "radioButtonNescutit_new";
            this.radioButtonNescutit_new.Size = new System.Drawing.Size(64, 17);
            this.radioButtonNescutit_new.TabIndex = 11;
            this.radioButtonNescutit_new.TabStop = true;
            this.radioButtonNescutit_new.Text = "Nescutit";
            this.radioButtonNescutit_new.UseVisualStyleBackColor = true;
            // 
            // radioButtonScutit_new
            // 
            this.radioButtonScutit_new.AutoSize = true;
            this.radioButtonScutit_new.Location = new System.Drawing.Point(366, 75);
            this.radioButtonScutit_new.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonScutit_new.Name = "radioButtonScutit_new";
            this.radioButtonScutit_new.Size = new System.Drawing.Size(52, 17);
            this.radioButtonScutit_new.TabIndex = 10;
            this.radioButtonScutit_new.TabStop = true;
            this.radioButtonScutit_new.Text = "Scutit";
            this.radioButtonScutit_new.UseVisualStyleBackColor = true;
            // 
            // button_calcul_new
            // 
            this.button_calcul_new.Location = new System.Drawing.Point(286, 129);
            this.button_calcul_new.Margin = new System.Windows.Forms.Padding(2);
            this.button_calcul_new.Name = "button_calcul_new";
            this.button_calcul_new.Size = new System.Drawing.Size(75, 19);
            this.button_calcul_new.TabIndex = 12;
            this.button_calcul_new.Text = "Calculeaza";
            this.button_calcul_new.UseVisualStyleBackColor = true;
            this.button_calcul_new.Click += new System.EventHandler(this.button_calcul_new_Click);
            // 
            // labelBrut_new
            // 
            this.labelBrut_new.AutoSize = true;
            this.labelBrut_new.Location = new System.Drawing.Point(242, 102);
            this.labelBrut_new.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBrut_new.Name = "labelBrut_new";
            this.labelBrut_new.Size = new System.Drawing.Size(26, 13);
            this.labelBrut_new.TabIndex = 14;
            this.labelBrut_new.Text = "Brut";
            // 
            // labelNet_new
            // 
            this.labelNet_new.AutoSize = true;
            this.labelNet_new.Location = new System.Drawing.Point(242, 78);
            this.labelNet_new.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNet_new.Name = "labelNet_new";
            this.labelNet_new.Size = new System.Drawing.Size(24, 13);
            this.labelNet_new.TabIndex = 13;
            this.labelNet_new.Text = "Net";
            // 
            // textBoxBrut_new
            // 
            this.textBoxBrut_new.Location = new System.Drawing.Point(286, 98);
            this.textBoxBrut_new.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBrut_new.Name = "textBoxBrut_new";
            this.textBoxBrut_new.Size = new System.Drawing.Size(76, 20);
            this.textBoxBrut_new.TabIndex = 9;
            // 
            // textBoxNet_new
            // 
            this.textBoxNet_new.Location = new System.Drawing.Point(286, 75);
            this.textBoxNet_new.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNet_new.Name = "textBoxNet_new";
            this.textBoxNet_new.Size = new System.Drawing.Size(76, 20);
            this.textBoxNet_new.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Location = new System.Drawing.Point(220, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 179);
            this.panel1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 179);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_new);
            this.Controls.Add(this.button_reset_new);
            this.Controls.Add(this.radioButtonNescutit_new);
            this.Controls.Add(this.radioButtonScutit_new);
            this.Controls.Add(this.button_calcul_new);
            this.Controls.Add(this.labelBrut_new);
            this.Controls.Add(this.labelNet_new);
            this.Controls.Add(this.textBoxBrut_new);
            this.Controls.Add(this.textBoxNet_new);
            this.Controls.Add(this.label_old);
            this.Controls.Add(this.buton_reset_old);
            this.Controls.Add(this.radioButtonNescutit_old);
            this.Controls.Add(this.radioButtonScutit_old);
            this.Controls.Add(this.buton_calcul_old);
            this.Controls.Add(this.labelBrut_old);
            this.Controls.Add(this.labelNet_old);
            this.Controls.Add(this.textBoxBrut_old);
            this.Controls.Add(this.textBoxNet_old);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Salariu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNet_old;
        private System.Windows.Forms.TextBox textBoxBrut_old;
        private System.Windows.Forms.Label labelNet_old;
        private System.Windows.Forms.Label labelBrut_old;
        private System.Windows.Forms.Button buton_calcul_old;
        private System.Windows.Forms.RadioButton radioButtonScutit_old;
        private System.Windows.Forms.RadioButton radioButtonNescutit_old;
        private System.Windows.Forms.Button buton_reset_old;
        private System.Windows.Forms.Label label_old;
        private System.Windows.Forms.Label label_new;
        private System.Windows.Forms.Button button_reset_new;
        private System.Windows.Forms.RadioButton radioButtonNescutit_new;
        private System.Windows.Forms.RadioButton radioButtonScutit_new;
        private System.Windows.Forms.Button button_calcul_new;
        private System.Windows.Forms.Label labelBrut_new;
        private System.Windows.Forms.Label labelNet_new;
        private System.Windows.Forms.TextBox textBoxBrut_new;
        private System.Windows.Forms.TextBox textBoxNet_new;
        private System.Windows.Forms.Panel panel1;
    }
}

