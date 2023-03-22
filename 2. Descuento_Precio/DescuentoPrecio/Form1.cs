namespace DescuentoPrecio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            CAPTURAR();
        }

        private void CAPTURAR()
        {
            double precioInicial, rango, descuento;
            if (double.TryParse(txt1.Text, out precioInicial))
            {

                rango = RANGO(precioInicial);
                descuento = MENSAJE(rango);
                DESCONTAR(precioInicial, descuento);
            }
            else
            {
                MessageBox.Show("SOLO NUMEROS; REINTENTE...");
            }
        }


        private double RANGO(double n)
        {
            if (n >= 101 && n <= 149)
            {
                return 1;
            }
            else if (n >= 150 && n <= 199)
            {
                return 2;
            }
            else if (n >= 200)
            {
                return 3;
            }
            else
            {
                return 0;
            }
        }

        private double MENSAJE(double indicador)
        {
            Label miLabel1 = insert1;

            if (indicador == 1)
            {
                insert1.Text = "Descuento del 5%";
                insert1.ForeColor = Color.Violet;
                return 5;
            }
            else if (indicador == 2)
            {
                insert1.Text = "Descuento del 10%";
                insert1.ForeColor = Color.Green;
                return 10;
            }
            else if (indicador == 3)
            {
                insert1.Text = "Descuento del 15%";
                insert1.ForeColor = Color.Blue;
                return 15;
            }
            else
            {
                insert1.Text = "No alcanza el descuento";
                insert1.ForeColor = Color.Red;
                return 0;
            }
        }

        private void DESCONTAR(double precioActual, double descontar)
        {
            double precioFinal, descuento;
            Label miLabel2 = insert2;
            Label miLabel3 = insert3;

            descuento = precioActual * (descontar / 100);
            precioFinal = precioActual - descuento;
            insert3.Text = $"{Math.Round(descuento,2)}";
            insert2.Text = $"{Math.Round(precioFinal, 2)}";
        }

    }
}