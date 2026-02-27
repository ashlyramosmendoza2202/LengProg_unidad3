namespace Diseño_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
         
        {
            // 1. Validar que sea un número válido
            if (!double.TryParse(txtValorEntrada.Text, out double valorEntrada))
            {
                MessageBox.Show("Por favor, ingresa un número válido.", "Error");
                return;
            }

            // 2. Validar que se hayan seleccionado unidades
            if (cmbUnidadEntrada.SelectedItem == null || cmbUnidadSalida.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona las unidades de origen y destino.", "Aviso");
                return;
            }

            string unidadEntrada = cmbUnidadEntrada.SelectedItem.ToString();
            string unidadSalida = cmbUnidadSalida.SelectedItem.ToString();
            double valorEnMetros = 0;
            double resultado = 0;

            // 3. --- LÓGICA DE CONVERSIÓN ---

            // A) Convertir la entrada SIEMPRE a Metros primero (como base)
            switch (unidadEntrada)
            {
                case "Metros": valorEnMetros = valorEntrada; break;
                case "Centímetros": valorEnMetros = valorEntrada / 100; break;
                case "Pulgadas": valorEnMetros = valorEntrada * 0.0254; break;
            }

            // B) Convertir de Metros a la unidad de salida
            switch (unidadSalida)
            {
                case "Metros": resultado = valorEnMetros; break;
                case "Centímetros": resultado = valorEnMetros * 100; break;
                case "Pulgadas": resultado = valorEnMetros / 0.0254; break;
            }

            // 4. Mostrar el resultado
            lblResultado.Text = string.Format("{0} {1} = {2:F4} {3}", valorEntrada, unidadEntrada, resultado, unidadSalida);
        }
    }
    }
}
