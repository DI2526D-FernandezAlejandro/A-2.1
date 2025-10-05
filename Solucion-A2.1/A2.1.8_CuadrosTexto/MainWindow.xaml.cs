using System;
using System.Windows;
using System.Windows.Input;

namespace A2._1._8_CuadrosTexto
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Nombre - ayuda con F1
        private void TxtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {
                lblAyudaNombre.Visibility = lblAyudaNombre.Visibility == Visibility.Visible
                    ? Visibility.Collapsed
                    : Visibility.Visible;
                lblAyudaNombre.Text = "Introduce tu nombre completo.";
            }
        }

        // Apellido - ayuda con F1
        private void TxtApellido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {
                lblAyudaApellido.Visibility = lblAyudaApellido.Visibility == Visibility.Visible
                    ? Visibility.Collapsed
                    : Visibility.Visible;
                lblAyudaApellido.Text = "Introduce tu apellido completo.";
            }
        }

        // Edad - validación con F2
        private void TxtEdad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F2)
            {
                lblErrorEdad.Visibility = Visibility.Collapsed;
                if (!int.TryParse(txtEdad.Text, out _))
                {
                    lblErrorEdad.Visibility = Visibility.Visible;
                    lblErrorEdad.Text = "Debes introducir un número entero.";
                }
            }
        }
    }
}
