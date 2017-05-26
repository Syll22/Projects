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
            this.textBoxNet = new System.Windows.Forms.TextBox();
            this.textBoxBrut = new System.Windows.Forms.TextBox();
            this.labelNet = new System.Windows.Forms.Label();
            this.labelBrut = new System.Windows.Forms.Label();
            this.buton_calcul = new System.Windows.Forms.Button();
            this.radioButtonScutit = new System.Windows.Forms.RadioButton();
            this.radioButtonNescutit = new System.Windows.Forms.RadioButton();
            this.buton_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNet
            // 
            this.textBoxNet.Location = new System.Drawing.Point(54, 18);
            this.textBoxNet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNet.Name = "textBoxNet";
            this.textBoxNet.Size = new System.Drawing.Size(76, 20);
            this.textBoxNet.TabIndex = 0;
            // 
            // textBoxBrut
            // 
            this.textBoxBrut.Location = new System.Drawing.Point(54, 41);
            this.textBoxBrut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxBrut.Name = "textBoxBrut";
            this.textBoxBrut.Size = new System.Drawing.Size(76, 20);
            this.textBoxBrut.TabIndex = 1;
            // 
            // labelNet
            // 
            this.labelNet.AutoSize = true;
            this.labelNet.Location = new System.Drawing.Point(10, 21);
            this.labelNet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNet.Name = "labelNet";
            this.labelNet.Size = new System.Drawing.Size(24, 13);
            this.labelNet.TabIndex = 4;
            this.labelNet.Text = "Net";
            // 
            // labelBrut
            // 
            this.labelBrut.AutoSize = true;
            this.labelBrut.Location = new System.Drawing.Point(10, 45);
            this.labelBrut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBrut.Name = "labelBrut";
            this.labelBrut.Size = new System.Drawing.Size(26, 13);
            this.labelBrut.TabIndex = 5;
            this.labelBrut.Text = "Brut";
            // 
            // buton_calcul
            // 
            this.buton_calcul.Location = new System.Drawing.Point(54, 72);
            this.buton_calcul.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buton_calcul.Name = "buton_calcul";
            this.buton_calcul.Size = new System.Drawing.Size(75, 19);
            this.buton_calcul.TabIndex = 4;
            this.buton_calcul.Text = "Calculeaza";
            this.buton_calcul.UseVisualStyleBackColor = true;
            this.buton_calcul.Click += new System.EventHandler(this.Button1_Click);
            // 
            // radioButtonScutit
            // 
            this.radioButtonScutit.AutoSize = true;
            this.radioButtonScutit.Location = new System.Drawing.Point(134, 18);
            this.radioButtonScutit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonScutit.Name = "radioButtonScutit";
            this.radioButtonScutit.Size = new System.Drawing.Size(52, 17);
            this.radioButtonScutit.TabIndex = 2;
            this.radioButtonScutit.TabStop = true;
            this.radioButtonScutit.Text = "Scutit";
            this.radioButtonScutit.UseVisualStyleBackColor = true;
            // 
            // radioButtonNescutit
            // 
            this.radioButtonNescutit.AutoSize = true;
            this.radioButtonNescutit.Location = new System.Drawing.Point(134, 41);
            this.radioButtonNescutit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonNescutit.Name = "radioButtonNescutit";
            this.radioButtonNescutit.Size = new System.Drawing.Size(64, 17);
            this.radioButtonNescutit.TabIndex = 3;
            this.radioButtonNescutit.TabStop = true;
            this.radioButtonNescutit.Text = "Nescutit";
            this.radioButtonNescutit.UseVisualStyleBackColor = true;
            // 
            // buton_reset
            // 
            this.buton_reset.Location = new System.Drawing.Point(134, 72);
            this.buton_reset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buton_reset.Name = "buton_reset";
            this.buton_reset.Size = new System.Drawing.Size(56, 19);
            this.buton_reset.TabIndex = 6;
            this.buton_reset.Text = "Reset";
            this.buton_reset.UseVisualStyleBackColor = true;
            this.buton_reset.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 115);
            this.Controls.Add(this.buton_reset);
            this.Controls.Add(this.radioButtonNescutit);
            this.Controls.Add(this.radioButtonScutit);
            this.Controls.Add(this.buton_calcul);
            this.Controls.Add(this.labelBrut);
            this.Controls.Add(this.labelNet);
            this.Controls.Add(this.textBoxBrut);
            this.Controls.Add(this.textBoxNet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Salariu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNet;
        private System.Windows.Forms.TextBox textBoxBrut;
        private System.Windows.Forms.Label labelNet;
        private System.Windows.Forms.Label labelBrut;
        private System.Windows.Forms.Button buton_calcul;
        private System.Windows.Forms.RadioButton radioButtonScutit;
        private System.Windows.Forms.RadioButton radioButtonNescutit;
        private System.Windows.Forms.Button buton_reset;
    }
}

