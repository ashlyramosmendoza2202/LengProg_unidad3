namespace Diseño_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificarPrimo_Click(object sender, EventArgs e)
        {

            {
                if (!int.TryParse(mtbNumero.Text, out int numero))
                {
                    MessageBox.Show("Por favor, ingresa un número válido.", "Error");
                    return;
                }

                if (EsPrimo(numero))
                {
                    MessageBox.Show($"{numero} es un número primo.", "Resultado");
                }
                else
                {
                    MessageBox.Show($"{numero} no es un número primo.", "Resultado");
                }
            }
        }

        private bool EsPrimo(int n)
        {
            if (n <= 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            var limite = (int)Math.Floor(Math.Sqrt(n));
            for (int i = 3; i <= limite; i += 2)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

