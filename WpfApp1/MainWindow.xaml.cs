using System;
using System.Collections.Generic;
using static System.Linq.Enumerable;
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
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {



        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_3(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double xa1 = Convert.ToDouble(a1.Text);
            double xa2 = Convert.ToDouble(a2.Text);
            double xa3 = Convert.ToDouble(a3.Text);
            double xa4 = Convert.ToDouble(a4.Text);
            double xb1 = Convert.ToDouble(b1.Text);
            double xb2 = Convert.ToDouble(b2.Text);
            double xb3 = Convert.ToDouble(b3.Text);
            double xb4 = Convert.ToDouble(b4.Text);
            double xc1 = Convert.ToDouble(c1.Text);
            double xc2 = Convert.ToDouble(c2.Text);
            double xc3 = Convert.ToDouble(c3.Text);
            double xc4 = Convert.ToDouble(c4.Text);
            double xd1 = Convert.ToDouble(d1.Text);
            double xd2 = Convert.ToDouble(d2.Text);
            double xd3 = Convert.ToDouble(d3.Text);
            double xd4 = Convert.ToDouble(d4.Text);
            double xa0 = Convert.ToDouble(a0.Text);
            double xb0 = Convert.ToDouble(b0.Text);
            double xc0 = Convert.ToDouble(c0.Text);
            double xd0 = Convert.ToDouble(d0.Text);

            double A11 = (xb2 * xc3 * xd4 + xc2 * xd3 * xb4 + xd2 * xb3 * xc4) - (xd2 * xc3 * xb4 + xc2 * xb3 * xd4 + xb2 * xd3 * xc4);
            double A21 = -1 * ((xa2 * xc3 * xd4 + xd2 * xa3 * xc4 + xc2 * xa4 * xd3) - (xd2 * xc3 * xa4 + xc2 * xa3 * xd4 + xd3 * xc4 * xa2));
            double A31 = (xa2 * xb3 * xd4 + xb2 * xd3 * xa4 + xd2 * xa3 * xb4) - (xd2 * xb3 * xa4 + xd3 * xb4 * xa2 + xb2 * xa3 * xd4);
            double A41 = -1 * ((xa2 * xb3 * xc4 + xb2 * xc3 * xa4 + xc2 * xa3 * xb4) - (xc2 * xb3 * xa4 + xa2 * xc3 * xb4 + xb2 * xa3 * xc4));

            double A11x = (xb0 * xc3 * xd4 + xc0 * xd3 * xb4 + xd0 * xb3 * xc4) - (xd0 * xc3 * xb4 + xc0 * xb3 * xd4 + xb0 * xd3 * xc4);
            double A21x = -1 * ((xa0 * xc3 * xd4 + xd0 * xa3 * xc4 + xc0 * xa4 * xd3) - (xd0 * xc3 * xa4 + xc0 * xa3 * xd4 + xd3 * xc4 * xa0));
            double A31x = (xa0 * xb3 * xd4 + xb0 * xd3 * xa4 + xd0 * xa3 * xb4) - (xd0 * xb3 * xa4 + xd3 * xb4 * xa0 + xb0 * xa3 * xd4);
            double A41x = -1 * ((xa0 * xb3 * xc4 + xb0 * xc3 * xa4 + xc0 * xa3 * xb4) - (xc0 * xb3 * xa4 + xa0 * xc3 * xb4 + xb0 * xa3 * xc4));

            double A11y = (xb2 * xc0 * xd4 + xc2 * xd0 * xb4 + xd2 * xb0 * xc4) - (xd2 * xc0 * xb4 + xc2 * xb0 * xd4 + xb2 * xd0 * xc4);
            double A21y = -1 * ((xa2 * xc0 * xd4 + xd2 * xa0 * xc4 + xc2 * xa4 * xd0) - (xd2 * xc0 * xa4 + xc2 * xa0 * xd4 + xd0 * xc4 * xa2));
            double A31y = (xa2 * xb0 * xd4 + xb2 * xd0 * xa4 + xd2 * xa0 * xb4) - (xd2 * xb0 * xa4 + xd0 * xb4 * xa2 + xb2 * xa0 * xd4);
            double A41y = -1 * ((xa2 * xb0 * xc4 + xb2 * xc0 * xa4 + xc2 * xa0 * xb4) - (xc2 * xb0 * xa4 + xa2 * xc0 * xb4 + xb2 * xa0 * xc4));

            double A11z = (xb2 * xc3 * xd0 + xc2 * xd3 * xb0 + xd2 * xb3 * xc0) - (xd2 * xc3 * xb0 + xc2 * xb3 * xd0 + xb2 * xd3 * xc0);
            double A21z = -1 * ((xa2 * xc3 * xd0 + xd2 * xa3 * xc0 + xc2 * xa0 * xd3) - (xd2 * xc3 * xa0 + xc2 * xa3 * xd0 + xd3 * xc0 * xa2));
            double A31z = (xa2 * xb3 * xd0 + xb2 * xd3 * xa0 + xd2 * xa3 * xb0) - (xd2 * xb3 * xa0 + xd3 * xb0 * xa2 + xb2 * xa3 * xd0);
            double A41z = -1 * ((xa2 * xb3 * xc0 + xb2 * xc3 * xa0 + xc2 * xa3 * xb0) - (xc2 * xb3 * xa0 + xa2 * xc3 * xb0 + xb2 * xa3 * xc0));

            double opred1 = xa1 * A11 + xb1 * A21 + xc1 * A31 + xd1 * A41;

            double opred2 = xa0 * A11 + xb0 * A21 + xc0 * A31 + xd0 * A41;

            double opred3 = xa1 * A11x + xb1 * A21x + xc1 * A31x + xd1 * A41x;

            double opred4 = xa1 * A11y + xb1 * A21y + xc1 * A31y + xd1 * A41y;

            double opred5 = xa1 * A11z + xb1 * A21z + xc1 * A31z + xd1 * A41z;

            op1.Text = Convert.ToString(opred1);
            op2.Text = Convert.ToString(opred2);
            op3.Text = Convert.ToString(opred3);
            op4.Text = Convert.ToString(opred4);
            op5.Text = Convert.ToString(opred5);

            x1.Text = Convert.ToString(opred2 / opred1);
            x2.Text = Convert.ToString(opred3 / opred1);
            x3.Text = Convert.ToString(opred4 / opred1);
            x4.Text = Convert.ToString(opred5 / opred1);

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            a1.Text = "";
            a2.Text = "";
            a3.Text = "";
            a4.Text = "";
            a0.Text = "";

            b1.Text = "";
            b2.Text = "";
            b3.Text = "";
            b4.Text = "";
            b0.Text = "";

            c1.Text = "";
            c2.Text = "";
            c3.Text = "";
            c4.Text = "";
            c0.Text = "";

            d1.Text = "";
            d2.Text = "";
            d3.Text = "";
            d4.Text = "";
            d0.Text = "";

            op1.Text = "";
            op2.Text = "";
            op3.Text = "";
            op4.Text = "";
            op5.Text = "";

            x1.Text = "";
            x2.Text = "";
            x3.Text = "";
            x4.Text = "";
        }
    }
}
