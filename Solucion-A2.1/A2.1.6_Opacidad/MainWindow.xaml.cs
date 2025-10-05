using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Controls;

namespace A2._1._6_Opacidad
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Evento único para todas las imágenes
        private void Imagen_MouseEnter(object sender, MouseEventArgs e)
        {
            if (sender is Image img)
            {
                img.Opacity = 1.0; // Opacidad 100%
            }
        }

        private void Imagen_MouseLeave(object sender, MouseEventArgs e)
        {
            if (sender is Image img)
            {
                img.Opacity = 0.5; // Opacidad 50%
            }
        }
    }
}
