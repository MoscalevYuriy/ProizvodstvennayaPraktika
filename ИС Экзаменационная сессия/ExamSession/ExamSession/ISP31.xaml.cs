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
    /// Логика взаимодействия для ISP31.xaml
    /// </summary>
    public partial class ISP31 : Page
    {
        public ISP31()
        {
            InitializeComponent();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void buttonRazIS_Click(object sender, RoutedEventArgs e)
        {
            MyFrame2.Content = new RazrabotkaIS();
        }

        private void buttonTestIS_Click(object sender, RoutedEventArgs e)
        {
            MyFrame2.Content = new TestIS();
        }
    }
}
