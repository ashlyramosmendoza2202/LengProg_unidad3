namespace Diseño1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            listTabla.Items.Clear();

            if (int.TryParse(textNumero.Text, out int numero))
            {
  
                for (int i = 1; i <= 10; i++)
                {
                    int resultado = numero * i;

                    listTabla.Items.Add($"{numero} x {i} = {resultado}");
                }
            }
            else
            {
                
                MessageBox.Show("Por favor, ingresa un número válido.", "Error");
            }
        }
    }
    }


  
