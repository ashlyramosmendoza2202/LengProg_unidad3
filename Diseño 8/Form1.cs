namespace Diseño_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
         
        {
         
            string oracion = txtOracion.Text.Trim();

         
            if (string.IsNullOrEmpty(oracion))
            {
                lblConteo.Text = "Palabras: 0";
                return;
            }
            string[] palabras = oracion.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int cantidadPalabras = palabras.Length;
            lblConteo.Text = "Palabras: " + cantidadPalabras;
        }
    }
    }
}
