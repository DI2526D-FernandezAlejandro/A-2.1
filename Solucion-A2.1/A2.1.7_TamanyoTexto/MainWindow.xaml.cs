using System;
using System.Windows;
using System.Windows.Controls;

namespace A2._1._7_TamanyoTexto
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Selección por defecto
            foreach (RadioButton rb in new RadioButton[] { (RadioButton)FindName("Pequeño"), (RadioButton)FindName("Mediano"), (RadioButton)FindName("Grande") })
            {
                    if (rb != null && rb.Tag != null && rb.Tag.ToString() == "48")
                {
                    rb.IsChecked = true;
                }
            }
        }

        private void Tamanyo_Checked(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton rb && rb.IsChecked == true)
            {
                if (double.TryParse(rb.Tag.ToString(), out double tamaño))
                {
                    txtEjemplo.FontSize = tamaño;
                }
            }
        }
    }
}
