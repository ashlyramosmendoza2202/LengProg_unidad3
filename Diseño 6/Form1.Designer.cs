namespace Diseño_6
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
            btnVerificarPerfecto = new Button();
            mtbNumero = new MaskedTextBox();
            SuspendLayout();
            // 
            // btnVerificarPerfecto
            // 
            btnVerificarPerfecto.BackColor = Color.Silver;
            btnVerificarPerfecto.Location = new Point(122, 196);
            btnVerificarPerfecto.Name = "btnVerificarPerfecto";
            btnVerificarPerfecto.Size = new Size(216, 89);
            btnVerificarPerfecto.TabIndex = 2;
            btnVerificarPerfecto.Text = "Ingrese aqui.";
            btnVerificarPerfecto.UseVisualStyleBackColor = false;
            btnVerificarPerfecto.Click += btnVerificarPerfecto_Click;
            // 
            // mtbNumero
            // 
            mtbNumero.Location = new Point(145, 121);
            mtbNumero.Name = "mtbNumero";
            mtbNumero.Size = new Size(150, 31);
            mtbNumero.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mtbNumero);
            Controls.Add(btnVerificarPerfecto);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVerificarPerfecto;
        private MaskedTextBox mtbNumero;
    }
}
