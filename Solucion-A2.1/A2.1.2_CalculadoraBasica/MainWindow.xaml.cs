using System;
using System.Windows;

namespace CalculadoraWPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Configurar botones por defecto
            btnCalcular.IsDefault = true; // Enter
            btnLimpiar.IsCancel = true;   // Escape
        }

        private void txtOperador_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            string operador = txtOperador.Text.Trim();
            btnCalcular.IsEnabled = operador == "+" || operador == "-" || operador == "*" || operador == "/";
        }

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double num1 = double.Parse(txtNumero1.Text);
                double num2 = double.Parse(txtNumero2.Text);
                string operador = txtOperador.Text.Trim();
                double resultado = 0;

                switch (operador)
                {
                    case "+": resultado = num1 + num2; break;
                    case "-": resultado = num1 - num2; break;
                    case "*": resultado = num1 * num2; break;
                    case "/":
                        if (num2 == 0)
                        {
                            MessageBox.Show("No se puede dividir entre cero", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                            return;
                        }
                        resultado = num1 / num2;
                        break;
                    default:
                        MessageBox.Show("Operador no válido", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                }

                txtResultado.Text = resultado.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese números válidos", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtOperador.Clear();
            txtResultado.Clear();
            btnCalcular.IsEnabled = false;
        }
    }
}
