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

namespace Tarea2PA
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

        public void Click_GenerarTabla(object sender, RoutedEventArgs e)
        {
            int n = Convert.ToInt32(tabla.Text);
            int rest = 0;
            if (n < 10)
            {
                for (int i = 0; i <= 10; i++)
                {
                    rest = i * n;
                    tablas.Items.Add(i + " X " + n + " = " + rest);
                }
            }
            else
            {
                MessageBox.Show("La tabla es de solo de 1 al 10");
            }

        }


    }
}
