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
    /// Логика взаимодействия для TestIS_2.xaml
    /// </summary>
    public partial class TestIS_2 : Page
    {
        public TestIS_2()
        {
            InitializeComponent();
            dataGrid1.ItemsSource = ExamSessionEntities.GetContext().ТестированиеИС.ToList();
        }

        private void buttonBack_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new ISP31_2();
        }
    }
}
