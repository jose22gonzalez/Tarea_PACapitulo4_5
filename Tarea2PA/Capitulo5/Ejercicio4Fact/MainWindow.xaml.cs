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

namespace Ejercicio4Fact
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

         private void Button_Click(object sender, RoutedEventArgs e)
        {
            int numero;
            int RES = 0;
            numero = Convert.ToInt32(num.Text);
            RES = factorial(numero);
            res.Text = RES.ToString();
        }

        static int factorial(int numero)
        {
            if(numero == 0)
            {
                numero = 1;
            }
            else
            {
                numero = numero * factorial(numero - 1);
            }
            return numero;
        }
    }
}
