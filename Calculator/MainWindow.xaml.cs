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
using System.Threading;

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

        #region ScaleValue Depdency Property
        public static readonly DependencyProperty ScaleValueProperty = DependencyProperty.Register("ScaleValue", typeof(double), typeof(MainWindow), new UIPropertyMetadata(1.0, new PropertyChangedCallback(OnScaleValueChanged), new CoerceValueCallback(OnCoerceScaleValue)));


        private static object OnCoerceScaleValue(DependencyObject o, object value)
        {
            MainWindow mainWindow = o as MainWindow;
            if (mainWindow != null)
                return mainWindow.OnCoerceScaleValue((double)value);
            else
                return value;
        }


        private static void OnScaleValueChanged(DependencyObject o, DependencyPropertyChangedEventArgs e)
        {
            MainWindow mainWindow = o as MainWindow;
            if (mainWindow != null)
                mainWindow.OnScaleValueChanged((double)e.OldValue, (double)e.NewValue);
        }

        protected virtual void OnScaleValueChanged(double oldValue, double newValue)
        {

        }

        protected virtual double OnCoerceScaleValue(double value)
        {
            if (double.IsNaN(value))
                return 1.0f;

            value = Math.Max(0.1, value);
            return value;

        }



        public double ScaleValue
        {
            get
            {
                return (double)GetValue(ScaleValueProperty);
            }
            set
            {
                SetValue(ScaleValueProperty, value);
            }
        }
        #endregion


        private void MainGrid_SizeChanged(object sender, EventArgs e)
        {
            CalculateScale();
        }



        private void CalculateScale()
        {
            double yScale = ActualHeight / 354f; // galvena loga izmers
            double xScale = ActualWidth / 525;
            double value = Math.Min(xScale, yScale);
            ScaleValue = (double)OnCoerceScaleValue(mainWindow, value);
        }


        ///</scaling>

        #region UIControls
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
        #endregion UIControls

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
         * Plots the function given by y = f(x) in a separate thread
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
                    return;
                }
            }

            if(range[0] > range[2] || Math.Abs(range[1]) > Math.Abs(range[2] - range[1]) / 2)
            {
                MessageBox.Show("Please specify the range correctly", "Invalid range", MessageBoxButton.OK, MessageBoxImage.Warning);
                ClrText();
                return;
            }

            Thread calcThread;      // used to plot the funciton as a separate thread, if no input errors so far
            List<Point> points = new List<Point>();
            // ClrPlotCanvas();    // clears canvas to plot another function

            double w = pltCanvas.ActualWidth - 10;
            double h = pltCanvas.ActualHeight - 10;

            const double epsilon = 0.00001;

            double deltaX = range[1];
            string expr = FunctionPlotter.ReturnExpression(mainTextBox.Text);
            double x, y, xMax, yMax, xMin, yMin;

            calcThread = new Thread(delegate()
            {
                for (x = range[0]; x <= range[2]; x += deltaX)
                {
                    if (Math.Abs(x) < epsilon) x = 0;
                    y = ep.ExecuteStringEquation(expr.Replace("x", x.ToString()));
                    points.Add(new Point(x, y));
                }

                xMax = points.Max(p => p.X);
                yMax = points.Max(p => p.Y);
                xMin = points.Min(p => p.X);
                yMin = points.Min(p => p.Y);

                //  invoke UI change - plot the function
                Dispatcher.Invoke(() =>
                {
                    ShowNumberAsText(xMin, 10, (h - 10) / 2);
                    ShowNumberAsText(xMax, w, (h - 10) / 2);
                    ShowNumberAsText(yMin, (w - 10) / 2, h);
                    ShowNumberAsText(yMax, (w - 10) / 2, 10);

                    // re-map numbers from one coordinate system to another
                    foreach (Point p in points)
                    {
                        x = p.X.Map(xMin, xMax, 10, w);
                        y = p.Y.Map(yMin, yMax, h, 10);
                        AddPoint(x, y);
                    }
                });
            });
            calcThread.SetApartmentState(ApartmentState.STA);
            calcThread.Start();
        }

        /**
         * Used to show range on the plot
         */
        private void ShowNumberAsText(double n, double x, double y)
        {
            TextBlock textBlock = new TextBlock();
            textBlock.Text = string.Format("{0:0.##}", n);
            textBlock.Foreground = new SolidColorBrush(Colors.Black);
            Canvas.SetLeft(textBlock, x);
            Canvas.SetTop(textBlock, y);
            pltCanvas.Children.Add(textBlock);
        }

        private void clrPlt_Click(object sender, RoutedEventArgs e)
        {
            ClrPlotCanvas();
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
         * Removes all children from canvas
         */
        private void ClrPlotCanvas()
        {
            pltCanvas.Children.Clear();
        }


        /**
        * Function that encapsulates adding a single point on the canvas. Used for plotting
        */
        private void AddPoint(double x, double y)
        {
            Point p = new Point(x, y);

            var ellipse = new Ellipse()
            {
                Width = 3,
                Height = 3,
                Stroke = new SolidColorBrush(Colors.Black),
                StrokeThickness = 2,
                Fill = new SolidColorBrush(Colors.Black)
            };

            Canvas.SetLeft(ellipse, p.X - 1.5);
            Canvas.SetTop(ellipse, p.Y - 1.5);
            pltCanvas.Children.Add(ellipse);
        }

        /**
         * Unused
         */
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
