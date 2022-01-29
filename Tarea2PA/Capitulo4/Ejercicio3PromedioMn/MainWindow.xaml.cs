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

namespace Ejercicio3PromedioMn
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

        public void ClickButton_Calcular(object sender, RoutedEventArgs e)
        {
            int age1 = Convert.ToInt32(edad1.Text);
            int age2 = Convert.ToInt32(edad2.Text);
            int age3 = Convert.ToInt32(edad3.Text);
            int age4 = Convert.ToInt32(edad4.Text);
            int age5 = Convert.ToInt32(edad5.Text);
            int age6 = Convert.ToInt32(edad6.Text);

            double Promedio = 0, suma = 0;
            suma = age1 + age2 + age3 + age4 + age5 + age6;
            Promedio = suma / 6;
            promedio.Text = Promedio.ToString();

            //Edad mayor

            if (age1 > age2 && age1 > age3 && age1 > age4 && age1 > age5 && age1 > age6)
            {
                mayor.Text = age1.ToString();
            }
            else if (age2 > age1 && age2 > age3 && age2 > age4 && age2 > age5 && age2 > age6)
            {
                mayor.Text = age2.ToString();
            }
            else if (age3 > age1 && age3 > age2 && age3 > age4 && age3 > age5 && age3 > age6)
            {
                mayor.Text = age3.ToString();
            }
            else if (age4 > age1 && age4 > age2 && age4 > age3 && age4 > age5 && age4 > age6)
            {
                mayor.Text = age4.ToString();
            }
            else if (age5 > age1 && age5 > age2 && age5 > age3 && age5 > age4 && age5 > age6)
            {
                mayor.Text = age5.ToString();
            }
            else if (age6 > age1 && age6 > age2 && age6 > age3 && age6 > age4 && age6 > age5)
            {
                mayor.Text = age6.ToString();
            }

            //Edad Menor

            if (age1 < age2 && age1 < age3 && age1 < age4 && age1 < age5 && age1 < age6)
            {
                menor.Text = age1.ToString();
            }
            else if (age2 < age1 && age2 < age3 && age2 < age4 && age2 < age5 && age2 < age6)
            {
                menor.Text = age2.ToString();
            }
            else if (age3 < age1 && age3 < age2 && age3 < age4 && age3 < age5 && age3 < age6)
            {
                menor.Text = age3.ToString();
            }
            else if (age4 < age1 && age4 < age2 && age4 < age3 && age4 < age5 && age4 < age6)
            {
                menor.Text = age4.ToString();
            }
            else if (age5 < age1 && age5 < age2 && age5 < age3 && age5 < age4 && age5 < age6)
            {
                menor.Text = age5.ToString();
            }
            else if (age6 < age1 && age6 < age2 && age6 < age3 && age6 < age4 && age6 < age5)
            {
                menor.Text = age6.ToString();
            }

        }
    }
}
