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

namespace Ejercio5NumLetra
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
            string NL = Numero_Letra(Numero.Text);
            Num_Letra.Text = NL;
        }

        public string Numero_Letra(string num)
        {
            int numero;
            numero = Convert.ToInt32(num);
            if (numero == 1)
            {
                return "Uno";
            }
            else if (numero == 2)
            {
                return "Dos";
            }
            else if (numero == 3)
            {
                return "Tres";
            }
            else if (numero == 4)
            {
                return "Cuatro";
            }
            else if (numero == 5)
            {
                return "Cinco";
            }
            else if (numero == 6)
            {
                return "Seis";
            }
            else if (numero == 7)
            {
                return "Siete";
            }
            else if (numero == 8)
            {
                return "Ocho";
            }
            else if (numero == 9)
            {
                return "Nueve";
            }
            else if (numero == 10)
            {
                return "Diez";
            }

            return "";


        }
    }
}
