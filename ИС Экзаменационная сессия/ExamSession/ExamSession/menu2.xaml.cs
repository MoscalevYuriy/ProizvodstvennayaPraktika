﻿using System;
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
    /// Логика взаимодействия для menu2.xaml
    /// </summary>
    public partial class menu2 : Window
    {
        public menu2()
        {
            InitializeComponent();
        }

        private void buttonISP31_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new ISP31_2();
        }

        private void buttonMenuBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Close();
            main.Show();
        }
    }
}
