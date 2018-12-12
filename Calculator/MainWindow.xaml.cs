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
using ExtensionMethods;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        
        private ExpressionParser ep;
        public MainWindow()
        {
            InitializeComponent();

            ep = new ExpressionParser();
        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            mainTextBox.Text += "0";
        }

        private void comma_Click(object sender, RoutedEventArgs e)
        {
            mainTextBox.Text += ".";
        }

        /**
         * Triggers the calcultation calling the expression parsing algorithm
         */
        private void equals_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                mainTextBox.Text = ep.ExecuteStringEquation(mainTextBox.Text).ToString();
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
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            mainTextBox.Text += "3";
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            mainTextBox.Text += "2";
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            mainTextBox.Text += "1";
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            mainTextBox.Text += "+";
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            mainTextBox.Text += "6";
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            mainTextBox.Text += "5";
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            mainTextBox.Text += "4";
        }

        private void multiply_Click(object sender, RoutedEventArgs e)
        {
            mainTextBox.Text += "*";
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            mainTextBox.Text += "9";
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            mainTextBox.Text += "8";
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            mainTextBox.Text += "7";
        }

        private void divide_Click(object sender, RoutedEventArgs e)
        {
            mainTextBox.Text += "/";
        }

        

        private void rightP_Click(object sender, RoutedEventArgs e)
        {
            mainTextBox.Text += ")";
        }

        private void leftP_Click(object sender, RoutedEventArgs e)
        {
            mainTextBox.Text += "(";
        }

        private void power_Click(object sender, RoutedEventArgs e)
        {
            mainTextBox.Text += "^";
        }

        private void powerTwo_Click(object sender, RoutedEventArgs e)
        {
            mainTextBox.Text += "^2";
        }

        private void allClr_Click(object sender, RoutedEventArgs e)
        {
            ClrText();
        }

        private void sqroot_Click(object sender, RoutedEventArgs e)
        {
            mainTextBox.Text += "^(1/2)";
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
            }
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
            {
                try
                {
                    Double.TryParse(rangeSplit[i], out range[i]);
                } catch (System.IndexOutOfRangeException ex)
                {
                    MessageBox.Show("Please enter range in a valid format ([X_0]:[dX]:[X_n])", "Invalid range", MessageBoxButton.OK, MessageBoxImage.Warning);
                    ClrText();
                }
            }
                

            List<Point> points = new List<Point>();

            double w = pltCanvas.ActualWidth;
            double h = pltCanvas.ActualHeight;

            double deltaX = canvasGrid.ActualWidth / ((range[2] - range[0]) / range[1]);
            string expr = FunctionPlotter.ReturnExpression(mainTextBox.Text);

            double x, y, xMax, yMax, xMin, yMin;
            for(x = range[0]; x <= range[2]; x += range[1])
            {
                y = ep.ExecuteStringEquation(expr.Replace("x", x.ToString()));
                points.Add(new Point(x, y));
            }

            xMax = points.Max(p => p.X);
            yMax = points.Max(p => p.Y);
            xMin = points.Min(p => p.X);
            yMin = points.Min(p => p.X);

            Console.WriteLine("HOPHOP");

            // re-map numbers from one coordinate system to another
            foreach(Point p in points)
            {
                x = p.X.Map(xMin, xMax, 0, w);
                y = p.Y.Map(yMin, yMax, h, 0);
                AddPoint(x, y);
            }

        }

        private void clrPlt_Click(object sender, RoutedEventArgs e)
        {
            pltCanvas.Children.Clear();
        }

        /**
         * Clears all text input fields
         */
        private void ClrText()
        {
            mainTextBox.Text = "";
            rangeInput.Text = "";
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
