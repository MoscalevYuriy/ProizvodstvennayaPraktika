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
    /// Логика взаимодействия для RazrabotkaIS.xaml
    /// </summary>
    public partial class RazrabotkaIS : Page
    {
        public RazrabotkaIS()
        {
            InitializeComponent();
            dataGrid1.ItemsSource = ExamSessionEntities.GetContext().РазработкаИС.ToList();
        }

        private void buttonAddRaz_Click(object sender, RoutedEventArgs e)
        {
            windowAdd add = new windowAdd(null);
            add.Show();
        }

        private void buttonBack_Click(object sender, RoutedEventArgs e)
        {
            /*MessageBoxResult result = MessageBox.Show("Все несохранённые изменения будут утеряны! Вы уверены, что хотите продолжить?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Warning);

            if (result == MessageBoxResult.No)
            {

            }
            else
            {
                MyFrame.Content = new ISP31();
            }*/
            MyFrame.Content = new ISP31();
        }

        private void MyFrame_Navigated(object sender, NavigationEventArgs e)
        {
            //WindowBack1 back = new WindowBack1();
            //back.Show();
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            dataGrid1.ItemsSource = ExamSessionEntities.GetContext().РазработкаИС.ToList();
        }

        private void buttonDel_Click(object sender, RoutedEventArgs e)
        {
            var РазработкаИСForRemoving = dataGrid1.SelectedItems.Cast<РазработкаИС>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {РазработкаИСForRemoving.Count()} элементов?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    ExamSessionEntities.GetContext().РазработкаИС.RemoveRange(РазработкаИСForRemoving);
                    ExamSessionEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");

                    dataGrid1.ItemsSource = ExamSessionEntities.GetContext().РазработкаИС.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void imageEdit_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            windowAdd add = new windowAdd((sender as Image).DataContext as РазработкаИС);
            add.Show();
        }
    }
}
