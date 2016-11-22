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
            this.textBoxNet = new System.Windows.Forms.TextBox();
            this.textBoxBrut = new System.Windows.Forms.TextBox();
            this.labelNet = new System.Windows.Forms.Label();
            this.labelBrut = new System.Windows.Forms.Label();
            this.buton_calcul = new System.Windows.Forms.Button();
            this.radioButtonScutit = new System.Windows.Forms.RadioButton();
            this.radioButtonNescutit = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNet
            // 
            this.textBoxNet.Location = new System.Drawing.Point(72, 22);
            this.textBoxNet.Name = "textBoxNet";
            this.textBoxNet.Size = new System.Drawing.Size(100, 22);
            this.textBoxNet.TabIndex = 0;
            // 
            // textBoxBrut
            // 
            this.textBoxBrut.Location = new System.Drawing.Point(72, 50);
            this.textBoxBrut.Name = "textBoxBrut";
            this.textBoxBrut.Size = new System.Drawing.Size(100, 22);
            this.textBoxBrut.TabIndex = 1;
            // 
            // labelNet
            // 
            this.labelNet.AutoSize = true;
            this.labelNet.Location = new System.Drawing.Point(13, 26);
            this.labelNet.Name = "labelNet";
            this.labelNet.Size = new System.Drawing.Size(30, 17);
            this.labelNet.TabIndex = 4;
            this.labelNet.Text = "Net";
            // 
            // labelBrut
            // 
            this.labelBrut.AutoSize = true;
            this.labelBrut.Location = new System.Drawing.Point(13, 55);
            this.labelBrut.Name = "labelBrut";
            this.labelBrut.Size = new System.Drawing.Size(34, 17);
            this.labelBrut.TabIndex = 5;
            this.labelBrut.Text = "Brut";
            // 
            // buton_calcul
            // 
            this.buton_calcul.Location = new System.Drawing.Point(72, 89);
            this.buton_calcul.Name = "buton_calcul";
            this.buton_calcul.Size = new System.Drawing.Size(100, 23);
            this.buton_calcul.TabIndex = 4;
            this.buton_calcul.Text = "Calculeaza";
            this.buton_calcul.UseVisualStyleBackColor = true;
            this.buton_calcul.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButtonScutit
            // 
            this.radioButtonScutit.AutoSize = true;
            this.radioButtonScutit.Location = new System.Drawing.Point(178, 22);
            this.radioButtonScutit.Name = "radioButtonScutit";
            this.radioButtonScutit.Size = new System.Drawing.Size(64, 21);
            this.radioButtonScutit.TabIndex = 2;
            this.radioButtonScutit.TabStop = true;
            this.radioButtonScutit.Text = "Scutit";
            this.radioButtonScutit.UseVisualStyleBackColor = true;
            // 
            // radioButtonNescutit
            // 
            this.radioButtonNescutit.AutoSize = true;
            this.radioButtonNescutit.Location = new System.Drawing.Point(178, 50);
            this.radioButtonNescutit.Name = "radioButtonNescutit";
            this.radioButtonNescutit.Size = new System.Drawing.Size(80, 21);
            this.radioButtonNescutit.TabIndex = 3;
            this.radioButtonNescutit.TabStop = true;
            this.radioButtonNescutit.Text = "Nescutit";
            this.radioButtonNescutit.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 141);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButtonNescutit);
            this.Controls.Add(this.radioButtonScutit);
            this.Controls.Add(this.buton_calcul);
            this.Controls.Add(this.labelBrut);
            this.Controls.Add(this.labelNet);
            this.Controls.Add(this.textBoxBrut);
            this.Controls.Add(this.textBoxNet);
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
        private System.Windows.Forms.Button button1;
    }
}

