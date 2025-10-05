using System.Windows;
using System.Windows.Controls;

namespace A2._1._4_CaracteresLimitados
{
    public partial class MainWindow : Window
    {
        private const int MaxCaracteres = 140;

        public MainWindow()
        {
            InitializeComponent();
            txtContador.Text = $"0 / {MaxCaracteres}";
        }

        private void txtContenido_TextChanged(object sender, TextChangedEventArgs e)
        {
            int longitud = txtContenido.Text.Length;

            // Actualizar contador
            txtContador.Text = $"{longitud} / {MaxCaracteres}";

            // Bloquear edición si se alcanzó el máximo
            if (longitud >= MaxCaracteres)
            {
                txtContenido.IsReadOnly = true;
            }
            else
            {
                txtContenido.IsReadOnly = false;
            }
        }
    }
}
