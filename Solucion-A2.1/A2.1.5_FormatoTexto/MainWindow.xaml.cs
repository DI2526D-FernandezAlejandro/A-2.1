using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace A2._1._5_FormatoTexto
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void chkFormato_Changed(object sender, RoutedEventArgs e)
        {
            // Aplicar negrita y cursiva
            txtContenido.FontWeight = (chkNegrita.IsChecked == true) ? FontWeights.Bold : FontWeights.Normal;
            txtContenido.FontStyle = (chkCursiva.IsChecked == true) ? FontStyles.Italic : FontStyles.Normal;
        }

        private void rbColor_Checked(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton rb)
            {
                string color = rb.Tag.ToString();
                switch (color)
                {
                    case "Blue":
                        txtContenido.Foreground = Brushes.Blue;
                        break;
                    case "Red":
                        txtContenido.Foreground = Brushes.Red;
                        break;
                    case "Green":
                        txtContenido.Foreground = Brushes.Green;
                        break;
                }
            }
        }
    }
}
