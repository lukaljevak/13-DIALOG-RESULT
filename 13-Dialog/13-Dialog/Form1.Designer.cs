namespace _13_Dialog
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
            this.buttonOtvori = new System.Windows.Forms.Button();
            this.textBoxRezultat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonOtvori
            // 
            this.buttonOtvori.Location = new System.Drawing.Point(195, 73);
            this.buttonOtvori.Name = "buttonOtvori";
            this.buttonOtvori.Size = new System.Drawing.Size(176, 44);
            this.buttonOtvori.TabIndex = 0;
            this.buttonOtvori.Text = "Otvorite MessageBox";
            this.buttonOtvori.UseVisualStyleBackColor = true;
            this.buttonOtvori.Click += new System.EventHandler(this.buttonOtvori_Click);
            // 
            // textBoxRezultat
            // 
            this.textBoxRezultat.Location = new System.Drawing.Point(151, 146);
            this.textBoxRezultat.Multiline = true;
            this.textBoxRezultat.Name = "textBoxRezultat";
            this.textBoxRezultat.Size = new System.Drawing.Size(288, 180);
            this.textBoxRezultat.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 369);
            this.Controls.Add(this.textBoxRezultat);
            this.Controls.Add(this.buttonOtvori);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOtvori;
        private System.Windows.Forms.TextBox textBoxRezultat;
    }
}

