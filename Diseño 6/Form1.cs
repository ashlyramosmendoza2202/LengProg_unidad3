namespace Diseño_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnVerificarPerfecto_Click(object sender, EventArgs e)
        {

            {
                if (!int.TryParse(mtbNumero.Text, out int numero))
                {
                    MessageBox.Show("Por favor, ingresa un número válido.", "Error");
                    return;
                }

                if (EsPerfecto(numero))
                {
                    MessageBox.Show($"{numero} es un número perfecto.", "Resultado");
                }
                else
                {
                    MessageBox.Show($"{numero} no es un número perfecto.", "Resultado");
                }
            }
        }

        private bool EsPerfecto(int n)
        {
            if (n <= 1) return false;

            int sumaDivisores = 0;

            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    sumaDivisores += i;
                }
            }

            return sumaDivisores == n;
        }
    }
}







