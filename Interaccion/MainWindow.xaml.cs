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

namespace Interaccion
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            btn.Click += Btn_Click;
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            lblHola.Text = "Adios mundo!";
            lblHola.FontSize = 29;
            lblHola.Foreground = Brushes.Red;
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            lblHola.Text = "Segundo Botón!";
            lblHola.FontSize = 29;
            lblHola.Foreground = Brushes.Red;
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            lblHola.Text = "Tercer Botón!";
            lblHola.FontSize = 29;
            lblHola.Foreground = Brushes.Red;
        }
    }
}
