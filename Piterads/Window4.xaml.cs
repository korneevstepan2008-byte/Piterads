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

    public partial class Window4 : Window
    {
        public class Clients
        {
            public int user_id { get; set; }
            public string name { get; set; }
            public string email { get; set; }
            public string phone { get; set; }
            public string login { get; set; }
            public string password { get; set; }
            public int role_id { get; set; }

        }
        private void LoadClientsData()
        {
            List<Clients> clients = new List<Clients>
            {
                new Clients
                {
                    user_id = 1,
                    name = "Alexandra",
                    email ="sashalux@gmail.com",
                    phone = "89313656345",
                    login = "sashushik",
                    password = "luxwxwxw",
                    role_id = 1,
                }
            };

        }

        public Window4()
        {
            InitializeComponent();
        }

        public MainWindow MainWindow { get; private set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow = new MainWindow();
            MainWindow.Show();
            this.Close();
        }
    }
}
