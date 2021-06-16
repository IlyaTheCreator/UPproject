using System;
using System.Windows;
using System.Windows.Controls;
using WpfApp1.Pages;

namespace WpfApp1
{

    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Main.Content = new Page1().Content;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           Main.Content = new Page1().Content;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
           Main.Content = new Page2().Content;
        }
    }
}
