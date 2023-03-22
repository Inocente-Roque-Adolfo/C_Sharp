using System;

namespace Bucles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int numero;
            numero = CAPTURAR();
            if (numero != 0)
            {
                TABLA(numero);
            }
            else
            {
                MessageBox.Show("Todo numero multiplicado por cero es 0");
                TABLA(0);
            }

        }

        private int CAPTURAR()
        {
            int n;
            if (int.TryParse(txt1.Text, out n))
            {
                insert1.Items.Clear();
                return n;
            }
            else
            {
                MessageBox.Show("No es un número o es demasiado largo");
                return 0;
            }
        }

        private void TABLA(int num)
        {
            int rpta = 0;
            for (int i = 1; i <= 13; i++)
            {
                rpta = i * num;
                insert1.Items.Add($" * {num} x {i} = {rpta}");
            }
        }
    }
}