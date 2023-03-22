namespace ParOImpar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var resultados = CAPTURAR();

            bool verificar = resultados.Item1;
            long numero = resultados.Item2;

            if (verificar)
            {
                CALCULAR(numero);
            }
        }

        private (bool, long) CAPTURAR()
        {
            long numero;
            if (long.TryParse(txt1.Text, out numero))
            {
                return (true, numero);
            }
            else
            {
                MENSAJES(1);
                return (false, 0);
            }
        }



        private void MENSAJES(int n)
        {
            if (n == 1)
            {
                MessageBox.Show("INGRESE SOLO NÚMEROS");
            }
            else
            {
                MessageBox.Show("ERROR SISTEMA");
            }
        }

        private void CALCULAR(long numero)
        {
            //Label miLabel = insert1;
            long residuo = numero % 2;
            if (residuo == 0)
            {

                //insert1.Text = $"EL NÚMERO {numero} ES PAR";
                insert1.Text = $"EL NÚMERO ES PAR";
                insert1.ForeColor = Color.Green;
            }
            else
            {
                //insert1.Text = $"EL NÚMERO {numero} ES IMPAR";
                insert1.Text = $"EL NÚMERO ES IMPAR";
                insert1.ForeColor = Color.Blue;
            }

        }
    }
}