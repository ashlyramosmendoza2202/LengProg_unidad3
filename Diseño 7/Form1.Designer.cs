namespace Diseño_7
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
            textInicio = new TextBox();
            textFin = new TextBox();
            lstPrimos = new ListBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // textInicio
            // 
            textInicio.Location = new Point(98, 93);
            textInicio.Name = "textInicio";
            textInicio.Size = new Size(150, 31);
            textInicio.TabIndex = 0;
            // 
            // textFin
            // 
            textFin.Location = new Point(98, 156);
            textFin.Name = "textFin";
            textFin.Size = new Size(150, 31);
            textFin.TabIndex = 1;
            // 
            // lstPrimos
            // 
            lstPrimos.BackColor = Color.Bisque;
            lstPrimos.FormattingEnabled = true;
            lstPrimos.Location = new Point(453, 73);
            lstPrimos.Name = "lstPrimos";
            lstPrimos.Size = new Size(193, 254);
            lstPrimos.TabIndex = 2;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = SystemColors.ControlDark;
            btnCalcular.Location = new Point(89, 228);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(176, 122);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Ingresar";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 523);
            Controls.Add(btnCalcular);
            Controls.Add(lstPrimos);
            Controls.Add(textFin);
            Controls.Add(textInicio);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textInicio;
        private TextBox textFin;
        private ListBox lstPrimos;
        private Button btnCalcular;
    }
}
