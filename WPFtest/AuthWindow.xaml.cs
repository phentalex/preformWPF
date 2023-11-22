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
using System.Data.SqlClient;
using Npgsql;
using System.Threading;
using System.Diagnostics.Eventing.Reader;

namespace WPFtest
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;

            if (ConnectionCheck() == true)
            {
                MessageBox.Show("Соединение с базой: Установлено!", "Успех!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Соединение с базой: Не установлено!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        public static string myport = "User ID=postgres;Password=admin;Host=localhost;Port=5432;Database=preform;Connection Lifetime=0;";

        public static NpgsqlConnection con = new NpgsqlConnection(myport);

        public static bool ConnectionCheck()
        {
            try
            {
                con.Open();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void enterButton_Click(object sender, RoutedEventArgs e)
        {
            NpgsqlConnection con = new NpgsqlConnection();
            MainWindow winMain = new MainWindow();
            winMain.Show();
            this.Close();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            
        }
    }
}
