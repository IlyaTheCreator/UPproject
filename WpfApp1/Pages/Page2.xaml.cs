using MathNet.Numerics.LinearAlgebra;
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

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        private List<List<TextBox>> matrix = new List<List<TextBox>>();

        public Page2()
        {
            InitializeComponent();

            // remove later
            list.Items.Clear();
            resultsPanel.Children.Clear();
            resultsCard.Width = 0;
            resultsCard.Height = 0;


            double amount = Convert.ToDouble(Navigator.DataToPass);
            RenderEquations(amount);
        }

        private void RenderEquations(double amount)
        {
            for (var i = 0; i < amount; i++)
            {
                int xNumber = 1;
                List<TextBox> textBoxList = new List<TextBox>();

                StackPanel panel = new StackPanel()
                {
                    Margin = new Thickness(0, 0, 20, 0),
                    Orientation = Orientation.Horizontal,
                    HorizontalAlignment = HorizontalAlignment.Center
                };

                for (var k = 0; k < amount; k++)
                {
                    TextBox textBox = new TextBox()
                    {
                        Foreground = new SolidColorBrush(Colors.White),
                        VerticalAlignment = VerticalAlignment.Bottom,
                        Margin = new Thickness(5, 0, 5, 0),
                        FontSize = 12,
                        Width = 15,
                    };

                    TextBlock xValue = new TextBlock()
                    {
                        VerticalAlignment = VerticalAlignment.Bottom,
                        Foreground = new SolidColorBrush(Colors.White),
                        FontSize = 12,
                        Text = $"X{xNumber}"
                    };

                    TextBlock plusSign = new TextBlock()
                    {
                        Margin = new Thickness(20, 0, 20, 0),
                        Foreground = new SolidColorBrush(Colors.White),
                        VerticalAlignment = VerticalAlignment.Bottom,
                        FontSize = 12,
                        Text = "+"
                    };

                    textBoxList.Add(textBox);

                    panel.Children.Add(textBox);
                    panel.Children.Add(xValue);

                    if (k == amount - 2)
                    {
                        plusSign.Margin = new Thickness(20, 0, 10, 0);
                    }

                    if (k != amount - 1)
                    {
                        panel.Children.Add(plusSign);
                    } 

                    xNumber += 1;
                }

                TextBlock equalsSign = new TextBlock()
                {
                    Foreground = new SolidColorBrush(Colors.White),
                    VerticalAlignment = VerticalAlignment.Bottom,
                    Margin = new Thickness(20, 0, 5, 0),
                    FontSize = 12,
                    Text = "="
                };

                TextBox textBox2 = new TextBox()
                {
                    Foreground = new SolidColorBrush(Colors.White),
                    VerticalAlignment = VerticalAlignment.Bottom,
                    Margin = new Thickness(10, 0, 0, 0),
                    FontSize = 12,
                    Width = 15
                };

                textBoxList.Add(textBox2);

                panel.Children.Add(equalsSign);
                panel.Children.Add(textBox2);

                list.Items.Add(panel);
                matrix.Add(textBoxList);
            }
        }

        private void Calculate_Equation(object sender, RoutedEventArgs e)
        {
            List<double> listOfDets = new List<double>();


            // 3 vars => 4 dets
            for (var i = 0; i <= matrix.Count; i++) {

                var newMatrix = matrix.Select(list =>
                {
                    return list.Select(textBox => Convert.ToDouble(textBox.Text)).ToArray();
                }).ToArray();


                Console.WriteLine($"HEEEEEEEEEEERE: {matrix[0].Count}");

                // if not main det
                if (i != 0)
                {
                    // any other case: 

                    // do stuff.. correct.
                    var indexOfVarToBePutInsteadOfB = i - 1;

                    for (var k = 0; k < newMatrix[0].Length; k++)
                    {
                        newMatrix[k][indexOfVarToBePutInsteadOfB] = newMatrix[k][newMatrix[k].Length - 1];
                        var numberList = newMatrix[k].ToList();
                        numberList.RemoveAt(numberList.Count - 1);

                        newMatrix[k] = numberList.ToArray();

                    }
                }


                if (i == 0)
                {

                    for (var k = 0; k < newMatrix.Length; k++)
                    {

                        var numberList = newMatrix[k].ToList();
                        numberList.RemoveAt(numberList.Count - 1);

                        newMatrix[k] = numberList.ToArray();
                    }
                }


                foreach (var list in newMatrix)
                {
                    foreach (var num in list) {
                        Console.Write($"   {num}   ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();


                var matrixOfDeterminant = Matrix<double>.Build.DenseOfColumnArrays(newMatrix);
                listOfDets.Add(matrixOfDeterminant.Determinant());
            }

            foreach (var det in listOfDets)
            {
                Console.WriteLine(det);
            }

            PrintResults(listOfDets);
        }

        private void PrintResults(List<double> listOfDets)
        {
            resultsCard.Width = 300;
            resultsCard.Height = 170;

            TextBlock mainDet = new TextBlock()
            {
                Margin = new Thickness(20, 0, 5, 0),
                FontSize = 15,
                Text = $"∆ = {listOfDets[0]}"
            };

            resultsPanel.Children.Add(mainDet);

            for (var i = 1; i < listOfDets.Count; i++)
            {
                TextBlock det = new TextBlock()
                {
                    Margin = new Thickness(20, 0, 5, 0),
                    FontSize = 15,
                    Text = $"∆{i + 1} = {listOfDets[i]}"
                };

                resultsPanel.Children.Add(det);
            }

            for (var i = 0; i < listOfDets.Count; i++)
            {
                TextBlock result = new TextBlock()
                {
                    FontSize = 15,
                    Text = $"X{i + 1} = {listOfDets[i] / listOfDets[0]}"
                };

                resultsPanel.Children.Add(result);
            }
        }
    }
}
