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
    /// Логика взаимодействия для TestIS.xaml
    /// </summary>
    public partial class TestIS : Page
    {
        public TestIS()
        {
            InitializeComponent();
            dataGrid1.ItemsSource = ExamSessionEntities.GetContext().ТестированиеИС.ToList();
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            dataGrid1.ItemsSource = ExamSessionEntities.GetContext().ТестированиеИС.ToList();
        }

        private void buttonDel_Click(object sender, RoutedEventArgs e)
        {
            var ТестированиеИСForRemoving = dataGrid1.SelectedItems.Cast<ТестированиеИС>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {ТестированиеИСForRemoving.Count()} элементов?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    ExamSessionEntities.GetContext().ТестированиеИС.RemoveRange(ТестированиеИСForRemoving);
                    ExamSessionEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");

                    dataGrid1.ItemsSource = ExamSessionEntities.GetContext().ТестированиеИС.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void buttonBack_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new ISP31();
        }

        private void buttonAddRaz_Click(object sender, RoutedEventArgs e)
        {
            windowAdd2 add = new windowAdd2(null);
            add.Show();
        }

        private void imageEdit_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            windowAdd2 add = new windowAdd2((sender as Image).DataContext as ТестированиеИС);
            add.Show();
        }
    }
}
