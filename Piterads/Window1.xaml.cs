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
using System.Windows.Shapes;

namespace Piterads
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {

        public Window1()
        {
            InitializeComponent();
        }

        public Window3 Window3 { get; private set; }
        public Window2 Window2 { get; private set; }
        public MainWindow MainWindow { get; private set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window3 = new Window3();
            Window3.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window2 = new Window2();
            Window2.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindow = new MainWindow();
            MainWindow.Show();
            this.Close();
        }

    }
}
