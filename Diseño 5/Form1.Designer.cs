namespace Diseño_5
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
            mtbNumero = new MaskedTextBox();
            btnVerificarPrimo = new Button();
            SuspendLayout();
            // 
            // mtbNumero
            // 
            mtbNumero.Location = new Point(110, 123);
            mtbNumero.Name = "mtbNumero";
            mtbNumero.Size = new Size(150, 31);
            mtbNumero.TabIndex = 0;
            // 
            // btnVerificarPrimo
            // 
            btnVerificarPrimo.BackColor = Color.RosyBrown;
            btnVerificarPrimo.Location = new Point(92, 196);
            btnVerificarPrimo.Name = "btnVerificarPrimo";
            btnVerificarPrimo.Size = new Size(216, 89);
            btnVerificarPrimo.TabIndex = 1;
            btnVerificarPrimo.Text = "Ingresar numero aqui.";
            btnVerificarPrimo.UseVisualStyleBackColor = false;
            btnVerificarPrimo.Click += btnVerificarPrimo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVerificarPrimo);
            Controls.Add(mtbNumero);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox mtbNumero;
        private Button btnVerificarPrimo;
    }
}
