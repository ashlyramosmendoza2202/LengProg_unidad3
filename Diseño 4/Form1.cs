namespace Diseño_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificarPalindromo_Click(object sender, EventArgs e)
        {
            
            string palabra = textPalabra.Text.ToLower().Replace(" ", ""); 


            char[] caracteres = palabra.ToCharArray();
            Array.Reverse(caracteres);
            string palabraInvertida = new string(caracteres);

            if (palabra == palabraInvertida && palabra.Length > 0)
            {
                MessageBox.Show($"'{textPalabra.Text}' es palíndroma.");
            }
            else
            {
                MessageBox.Show($"'{textPalabra.Text}' no es palíndroma.");
            }
        }
    }
    }

