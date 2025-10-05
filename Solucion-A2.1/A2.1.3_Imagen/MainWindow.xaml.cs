using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace A2._1._3_Imagen
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            foreach (RadioButton rb in spOpacidad.Children.OfType<RadioButton>())
            {
                if (rb.Tag.ToString() == "1.0")
                {
                    rb.IsChecked = true;
                    Opacidad_Checked(rb, null); // Llama al evento manualmente
                }
            }

            foreach (RadioButton rb in spStretch.Children.OfType<RadioButton>())
            {
                if (rb.Tag.ToString() == "Uniform")
                {
                    rb.IsChecked = true;
                    Stretch_Checked(rb, null); // Llama al evento manualmente
                }
            }
        }

        private void Opacidad_Checked(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton rb && rb.IsChecked == true)
            {
                if (double.TryParse(rb.Tag.ToString(), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double opacidad))
                {
                    imgFoto.Opacity = opacidad;
                }
            }
        }

        private void Stretch_Checked(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton rb && rb.IsChecked == true)
            {
                switch (rb.Tag.ToString())
                {
                    case "None": imgFoto.Stretch = Stretch.None; break;
                    case "Fill": imgFoto.Stretch = Stretch.Fill; break;
                    case "Uniform": imgFoto.Stretch = Stretch.Uniform; break;
                    case "UniformToFill": imgFoto.Stretch = Stretch.UniformToFill; break;
                }
            }
        }
    }
}
