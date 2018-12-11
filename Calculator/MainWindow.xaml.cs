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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private string inputText = "";  // this variable stores the equation that will be calculated

        private ExpressionParser ep;
        public MainWindow()
        {
            InitializeComponent();
            ep = new ExpressionParser();
        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            mainTextBox.Text += "0";
            inputText += "0";
        }

        private void comma_Click(object sender, RoutedEventArgs e)
        {
            mainTextBox.Text += ".";
            inputText += ".";
        }

        /**
         * Triggers the calcultation calling the expression parsing algorithm
         */
        private void equals_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                mainTextBox.Text = ep.ExecuteStringEquation(inputText).ToString();
            } catch (ArithmeticException ex)
            {
                MessageBox.Show("Cannot divide by 0 (zero)", "Division by zero",MessageBoxButton.OK, MessageBoxImage.Warning);
                ClrText();
            } catch (System.InvalidOperationException ex)
            {
                MessageBox.Show("Please input a valid operation", "Invalid expression", MessageBoxButton.OK, MessageBoxImage.Warning);
                ClrText();
            }
            catch (ParenthesesException ex)
            {
                MessageBox.Show("Parenthese do not match", "Invalid expression", MessageBoxButton.OK, MessageBoxImage.Warning);
                ClrText();
            }

        }

        private void subtract_Click(object sender, RoutedEventArgs e)
        {
            mainTextBox.Text += "-";
            inputText += "-";
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            mainTextBox.Text += "3";
            inputText += "3";
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            mainTextBox.Text += "2";
            inputText += "2";
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            mainTextBox.Text += "1";
            inputText += "1";
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            mainTextBox.Text += "+";
            inputText += "+";
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            mainTextBox.Text += "6";
            inputText += "6";
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            mainTextBox.Text += "5";
            inputText += "5";
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            mainTextBox.Text += "4";
            inputText += "4";
        }

        private void multiply_Click(object sender, RoutedEventArgs e)
        {
            mainTextBox.Text += "*";
            inputText += "*";
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            mainTextBox.Text += "9";
            inputText += "9";
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            mainTextBox.Text += "8";
            inputText += "8";
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            mainTextBox.Text += "7";
            inputText += "7";
        }

        private void divide_Click(object sender, RoutedEventArgs e)
        {
            mainTextBox.Text += "/";
            inputText += "/";
        }

        

        private void rightP_Click(object sender, RoutedEventArgs e)
        {
            mainTextBox.Text += ")";
            inputText += ")";
        }

        private void leftP_Click(object sender, RoutedEventArgs e)
        {
            mainTextBox.Text += "(";
            inputText += "(";
        }

        private void power_Click(object sender, RoutedEventArgs e)
        {
            mainTextBox.Text += "^";
            inputText += "^";
        }

        private void powerTwo_Click(object sender, RoutedEventArgs e)
        {
            mainTextBox.Text += "^2";
            inputText += "^2";
        }

        private void allClr_Click(object sender, RoutedEventArgs e)
        {
            ClrText();
        }

        private void sqroot_Click(object sender, RoutedEventArgs e)
        {
            mainTextBox.Text += "^(1/2)";
            inputText += "^(1/2)";

        }
        
        /**
         * Clears one symbol (backspace)
         */
        private void clr_Click(object sender, RoutedEventArgs e)
        {
            if (mainTextBox.Text.Length != 0)
            {
                int len = mainTextBox.Text.Length;
                StringBuilder sb = new StringBuilder(mainTextBox.Text);
                sb[len - 1] = ' ';
                mainTextBox.Text = sb.ToString().Trim();

                inputText = mainTextBox.Text;
            }
        }

        private void mainTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        /**
         * Plots the function given by y = f(x)
         * 
         * TODO FIX
         */
        private void pltBtn_Click(object sender, RoutedEventArgs e)
        {
            string[] rangeSplit = rangeInput.Text.Split(':');
            double[] range = new double[3];
            for (int i = 0; i < 3; i++)
                Double.TryParse(rangeSplit[i], out range[i]);

            List<double> domain = new List<double>();

            double deltaX = canvasGrid.ActualWidth / ((range[2] - range[0]) / range[1]);

            string expr = FunctionPlotter.ReturnExpression(mainTextBox.Text);

            Console.WriteLine(expr);
            Console.WriteLine(deltaX + " " + canvasGrid.ActualWidth);

            double y;
            for (double x = 0; x <= canvasGrid.ActualWidth; x += deltaX)
            {
                y = canvasGrid.ActualHeight - ep.ExecuteStringEquation(expr.Replace("x", (range[0] + x).ToString()));
                domain.Add(y);
            }

            double maxVal = domain.Max();
            for (double x = 0; x <= canvasGrid.ActualWidth; x += deltaX)
            {
                AddPoint(x, (canvasGrid.ActualHeight - ep.ExecuteStringEquation(expr.Replace("x", (range[0] + x).ToString()))) / maxVal);
            }
        }

        private void clrPlt_Click(object sender, RoutedEventArgs e)
        {
            pltCanvas.Children.Clear();
        }

        private void ClrText()
        {
            inputText = "";
            mainTextBox.Text = inputText;
        }

        /**
        * Function that encapsulates adding a single point on the canvas. Used for plotting
        */
        private void AddPoint(double x, double y)
        {
            Point p = new Point(x, y);

            var ellipse = new Ellipse()
            {
                Width = 6,
                Height = 6,
                Stroke = new SolidColorBrush(Colors.Black),
                StrokeThickness = 2,
                Fill = new SolidColorBrush(Colors.Black)
            };

            Canvas.SetLeft(ellipse, p.X - 3);
            Canvas.SetTop(ellipse, p.Y - 3);
            pltCanvas.Children.Add(ellipse);
        }

        private void DrawLine(double x1, double y1, double x2, double y2)
        {
            Line line = new Line();
            line.Stroke = Brushes.Black;
            line.StrokeThickness = 3;

            line.X1 = x1;
            line.X2 = x2;
            line.Y1 = y1;
            line.Y2 = y2;

            pltCanvas.Children.Add(line);
        }
    }
}
