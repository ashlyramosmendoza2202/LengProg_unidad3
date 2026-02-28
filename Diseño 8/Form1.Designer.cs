namespace Diseño_8
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
            txtOracion = new TextBox();
            lblConteo = new Label();
            btnContar = new Button();
            SuspendLayout();
            // 
            // txtOracion
            // 
            txtOracion.Location = new Point(96, 100);
            txtOracion.Name = "txtOracion";
            txtOracion.Size = new Size(230, 31);
            txtOracion.TabIndex = 0;
            // 
            // lblConteo
            // 
            lblConteo.AutoSize = true;
            lblConteo.Location = new Point(165, 169);
            lblConteo.Name = "lblConteo";
            lblConteo.Size = new Size(59, 25);
            lblConteo.TabIndex = 1;
            lblConteo.Text = "label1";
            // 
            // btnContar
            // 
            btnContar.BackColor = Color.DarkSeaGreen;
            btnContar.Location = new Point(111, 224);
            btnContar.Name = "btnContar";
            btnContar.Size = new Size(173, 63);
            btnContar.TabIndex = 2;
            btnContar.Text = "Aceptar";
            btnContar.UseVisualStyleBackColor = false;
            btnContar.Click += btnContar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnContar);
            Controls.Add(lblConteo);
            Controls.Add(txtOracion);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOracion;
        private Label lblConteo;
        private Button btnContar;
    }
}
