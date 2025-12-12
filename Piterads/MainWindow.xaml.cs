using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Piterads
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Window1 Window1 { get; private set; }
        public Window3 Window3 { get; private set; }
        public Window4 Window4 { get; private set; }

        //public Window1 Window1 { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {

            // Получаем логин из текстового поля и удаляем лишние пробелы
            string login = LoginTextBox.Text.Trim();
            // Получаем пароль из поля для пароля (PasswordBox скрывает ввод)
            string password = PasswordTextBox.Text.Trim();

            // Валидация ввода: проверяем, что оба поля заполнены
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите логин и пароль");
                return;
            }

            // Вызываем метод аутентификации из сервиса базы данных
            // DbService.AuthenticateUser проверяет логин/пароль в базе данных
            var user = DbService.AuthenticateUser(login, password);

            // Проверяем результат аутентификации
            if (user != null)
            {
                // Если пользователь найден (аутентификация успешна):

                // Открываем окно, соответствующее роли пользователя
                Window1 = new Window1();
                Window1.Show();
                // скрываем, но не уничтожаем
                // Окно невидимо, но продолжает существовать в памяти
                // Можно вернуться к нему позже (например, при разлогине)
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window3 = new Window3();
            Window3.Show();
            this.Close();
        }

        private void AdminButton_Click(object sender, RoutedEventArgs e)
        {
            Window4 = new Window4();
            Window4.Show();
            this.Close();
        }


        private void LoginTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = (TextBox)sender;
            // Управление placeholder через Tag или отдельный TextBlock
        }
    }
}