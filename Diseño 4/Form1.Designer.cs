namespace Diseño_4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textPalabra = new TextBox();
            btnVerificarPalindromo = new Button();
            SuspendLayout();
            // 
            // textPalabra
            // 
            textPalabra.Location = new Point(162, 143);
            textPalabra.Name = "textPalabra";
            textPalabra.Size = new Size(150, 31);
            textPalabra.TabIndex = 0;
            // 
            // btnVerificarPalindromo
            // 
            btnVerificarPalindromo.BackColor = SystemColors.Info;
            btnVerificarPalindromo.Location = new Point(162, 206);
            btnVerificarPalindromo.Name = "btnVerificarPalindromo";
            btnVerificarPalindromo.Size = new Size(137, 58);
            btnVerificarPalindromo.TabIndex = 1;
            btnVerificarPalindromo.Text = "Ingresar";
            btnVerificarPalindromo.UseVisualStyleBackColor = false;
            btnVerificarPalindromo.Click += btnVerificarPalindromo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVerificarPalindromo);
            Controls.Add(textPalabra);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textPalabra;
        private Button btnVerificarPalindromo;
    }
}
