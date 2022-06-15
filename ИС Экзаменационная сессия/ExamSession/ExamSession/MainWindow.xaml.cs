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

namespace ExamSession
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonInput_Click(object sender, RoutedEventArgs e)
        {
            menu menu = new menu();

            if(textBoxLogin.Text == "admin" && passwordBox.Password == "admin")
            {
                menu.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Такого пользователя не существует");
            }
        }

        private void buttonStud_Click(object sender, RoutedEventArgs e)
        {
            menu2 menu2 = new menu2();
            menu2.Show();
            this.Close();
        }
    }
}
