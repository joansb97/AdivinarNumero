using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prueba2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rnd = new Random();
        int numero;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void AdivinarButton_Click(object sender, RoutedEventArgs e)
        {
            numero = rnd.Next(0, 2);
            int numeroUsuario;
            do
            {
                numeroUsuario = int.Parse(numeroTextBox.Text);
                if (numero == numeroUsuario)
                    adivinaTextBlock.Text = "Has adivinado el numero!";
            } while (numeroUsuario != numero);
        }
    }
}
