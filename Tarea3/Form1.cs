using System;
using System.Windows.Forms;

namespace DevolucionMinimaMonedas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularDevolucion_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtCantidad.Text) || String.IsNullOrWhiteSpace(txtPago.Text))
            {
                MessageBox.Show("Por favor, ingresa valores válidos en los campos de devolución.");
                return;
            }

            if (!Decimal.TryParse(txtCantidad.Text, out decimal cantidad) || !Decimal.TryParse(txtPago.Text, out decimal pago))
            {
                MessageBox.Show("Por favor, ingresa números válidos en los campos de devolución.");
                return;
            }

            decimal devolucion = pago - cantidad;

            decimal[] denominaciones = { 100, 50, 20, 10, 5, 1, 0.5m, 0.2m, 0.01m };
            int[] contadorMonedas = new int[denominaciones.Length];

            CalcularDevolucion(devolucion, denominaciones, contadorMonedas, 0);

            txtResultados.Text = "Devolución: " + (pago - cantidad).ToString("C2") +", " + "\n\n";
            for (int i = 0; i < denominaciones.Length; i++)
            {
                if (contadorMonedas[i] > 0)
                {
                    txtResultados.Text += contadorMonedas[i] + " monedas de " + denominaciones[i].ToString("C2") + "  ";
                }
            }
        }

        private void btnResolverTorres_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtDiscos.Text))
            {
                MessageBox.Show("Por favor, ingresa el número de discos para las Torres de Hanói.");
                return;
            }

            if (!Int32.TryParse(txtDiscos.Text, out int discos) || discos < 1)
            {
                MessageBox.Show("Por favor, ingresa un número entero válido (mayor o igual a 1) para los discos.");
                return;
            }

            txtResultados.Text = $"Movimientos para resolver las Torres de Hanói con {discos} discos: ";
            ResolverTorresDeHanoi(discos, 'A', 'C', 'B');
        }

        private void CalcularDevolucion(decimal devolucion, decimal[] denominaciones, int[] contadorMonedas, int index)
        {
            if (index >= denominaciones.Length)
                return;

            while (devolucion >= denominaciones[index])
            {
                devolucion -= denominaciones[index];
                contadorMonedas[index]++;
            }

            CalcularDevolucion(devolucion, denominaciones, contadorMonedas, index + 1);
        }

        private void ResolverTorresDeHanoi(int numDiscos, char origen, char destino, char auxiliar)
        {
            if (numDiscos == 1)
            {
                txtResultados.Text += $"Mover disco {numDiscos} de {origen} a {destino}  ";
            }
            else
            {
                ResolverTorresDeHanoi(numDiscos - 1, origen, auxiliar, destino);
                txtResultados.Text += $"Mover disco {numDiscos} de {origen} a {destino}  ";
                ResolverTorresDeHanoi(numDiscos - 1, auxiliar, destino, origen);
            }
        }
    }
}
