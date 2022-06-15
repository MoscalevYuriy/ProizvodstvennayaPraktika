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

namespace ExamSession
{
    /// <summary>
    /// Логика взаимодействия для windowAdd2.xaml
    /// </summary>
    public partial class windowAdd2 : Window
    {
        private ТестированиеИС _currentIS = new ТестированиеИС();

        public windowAdd2(ТестированиеИС selectedтестированиеИС)
        {
            InitializeComponent();

            if (selectedтестированиеИС != null)
                _currentIS = selectedтестированиеИС;

            DataContext = _currentIS;
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (_currentIS.ФИО == null)
            {
                errors.AppendLine("Укажите ФИО");
            }
            if (_currentIS.Оценка == null)
            {

            }
            else
            {
                if (_currentIS.Оценка == 2 || _currentIS.Оценка == 3 || _currentIS.Оценка == 4 || _currentIS.Оценка == 5)
                {

                }
                else
                {
                    errors.AppendLine("Оценка ставится по 5-бальной системе");
                }
            }
            /* if (_currentIS.Оценка == null)
             {

             }
             else
             {
                 int ocenka = Convert.ToInt32(_currentIS.Оценка);
                 if (ocenka < 2 && ocenka > 5)
                 {
                     errors.AppendLine("Оценка ставится по 5-бальной системе");
                 }
             }*/

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (_currentIS.ID == 0)
                ExamSessionEntities.GetContext().ТестированиеИС.Add(_currentIS);
            try
            {
                ExamSessionEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация добавлена!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void textBoxTricket_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }

        private void textBoxOcenka_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }
    }
}
