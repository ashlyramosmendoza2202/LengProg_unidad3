namespace Diseño1
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
            listTabla = new ListBox();
            textNumero = new TextBox();
            buttonCalcular = new Button();
            SuspendLayout();
            // 
            // listTabla
            // 
            listTabla.BackColor = SystemColors.Info;
            listTabla.FormattingEnabled = true;
            listTabla.Location = new Point(341, 88);
            listTabla.Name = "listTabla";
            listTabla.Size = new Size(268, 429);
            listTabla.TabIndex = 0;
            listTabla.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // textNumero
            // 
            textNumero.Location = new Point(58, 112);
            textNumero.Name = "textNumero";
            textNumero.Size = new Size(150, 31);
            textNumero.TabIndex = 1;
            textNumero.TextChanged += textBox1_TextChanged;
            // 
            // buttonCalcular
            // 
            buttonCalcular.BackColor = SystemColors.GradientActiveCaption;
            buttonCalcular.Location = new Point(72, 170);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(112, 76);
            buttonCalcular.TabIndex = 2;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = false;
            buttonCalcular.Click += btnCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 631);
            Controls.Add(buttonCalcular);
            Controls.Add(textNumero);
            Controls.Add(listTabla);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listTabla;
        private TextBox textNumero;
        private Button buttonCalcular;
    }
}
