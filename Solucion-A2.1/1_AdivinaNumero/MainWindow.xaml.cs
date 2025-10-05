using System;
using System.Windows;

namespace _1_AdivinaNumero
{
    public partial class MainWindow : Window
    {
        private int numeroSecreto;
        private Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();
            GenerarNuevoNumero();
        }

        private void GenerarNuevoNumero()
        {
            numeroSecreto = random.Next(0, 101);
            lblResultado.Text = "";
            txtNumero.Text = "";
        }

        private void btnComprobar_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtNumero.Text, out int numeroUsuario))
            {
                if (numeroUsuario < 0 || numeroUsuario > 100)
                {
                    lblResultado.Text = "Introduce un número entre 0 y 100.";
                }
                else if (numeroUsuario < numeroSecreto)
                {
                    lblResultado.Text = "Demasiado bajo";
                }
                else if (numeroUsuario > numeroSecreto)
                {
                    lblResultado.Text = "Demasiado alto";
                }
                else
                {
                    lblResultado.Text = "¡Has acertado!";
                }
            }
            else
            {
                lblResultado.Text = "Introduce un número válido.";
            }
        }

        private void btnReiniciar_Click(object sender, RoutedEventArgs e)
        {
            GenerarNuevoNumero();
        }
    }
}
