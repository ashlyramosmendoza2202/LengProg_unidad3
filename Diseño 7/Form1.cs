namespace Diseño_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            {

                lstPrimos.Items.Clear();

                if (!int.TryParse(textInicio.Text, out int inicio) || !int.TryParse(textFin.Text, out int fin))
                {
                    MessageBox.Show("Por favor, ingresa números válidos en los campos de rango.", "Error");
                    return;
                }


                if (inicio > fin)
                {
                    MessageBox.Show("El valor de 'Inicio' debe ser menor o igual al de 'Fin'.", "Error");
                    return;
                }

                for (int i = inicio; i <= fin; i++)
                {
                    if (EsPrimo(i))
                    {
                        lstPrimos.Items.Add(i);
                    }
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
    }
    }

