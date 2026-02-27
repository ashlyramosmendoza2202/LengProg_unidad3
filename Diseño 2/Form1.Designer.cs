namespace Diseño_2
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
            txtValorEntrada = new TextBox();
            cmbUnidadEntrada = new ComboBox();
            cmbUnidadSalida = new ComboBox();
            btnConvertir = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // txtValorEntrada
            // 
            txtValorEntrada.Location = new Point(104, 106);
            txtValorEntrada.Name = "txtValorEntrada";
            txtValorEntrada.Size = new Size(150, 31);
            txtValorEntrada.TabIndex = 0;
            // 
            // cmbUnidadEntrada
            // 
            cmbUnidadEntrada.FormattingEnabled = true;
            cmbUnidadEntrada.Items.AddRange(new object[] { "Metros", "Centímetros", "Pulgadas" });
            cmbUnidadEntrada.Location = new Point(104, 56);
            cmbUnidadEntrada.Name = "cmbUnidadEntrada";
            cmbUnidadEntrada.Size = new Size(182, 33);
            cmbUnidadEntrada.TabIndex = 1;
            // 
            // cmbUnidadSalida
            // 
            cmbUnidadSalida.FormattingEnabled = true;
            cmbUnidadSalida.Items.AddRange(new object[] { "Metros", "Centímetros", "Pulgadas" });
            cmbUnidadSalida.Location = new Point(367, 72);
            cmbUnidadSalida.Name = "cmbUnidadSalida";
            cmbUnidadSalida.Size = new Size(182, 33);
            cmbUnidadSalida.TabIndex = 2;
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(118, 206);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(112, 34);
            btnConvertir.TabIndex = 3;
            btnConvertir.Text = "button1";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(118, 256);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(59, 25);
            lblResultado.TabIndex = 4;
            lblResultado.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(btnConvertir);
            Controls.Add(cmbUnidadSalida);
            Controls.Add(cmbUnidadEntrada);
            Controls.Add(txtValorEntrada);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtValorEntrada;
        private ComboBox cmbUnidadEntrada;
        private ComboBox cmbUnidadSalida;
        private Button btnConvertir;
        private Label lblResultado;
    }
}
