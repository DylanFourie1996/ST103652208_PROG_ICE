using System;
using System.Windows;

namespace ST10362208_ICETask1
{
    public delegate double Functions(double x, double y);

    public partial class MainWindow : Window
    {
        private Publisher publisher;
        private Functions add;
        private Functions subtract;
        private Functions multiply;
        private Functions divide;

        public MainWindow()
        {
            InitializeComponent();
            publisher = new Publisher(); 

          
            add = new Functions(publisher.Addition);
            subtract = new Functions(publisher.Subtract);
            multiply = new Functions(publisher.Multiply);
            divide = new Functions(publisher.Divide);
        }

        private void sub_Click(object sender, RoutedEventArgs e)
        {
            PerformOperation(subtract);
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            PerformOperation(add);
        }

        private void Multi_Click(object sender, RoutedEventArgs e)
        {
            PerformOperation(multiply);
        }

        private void div_Click(object sender, RoutedEventArgs e)
        {
            PerformOperation(divide);
        }

        private void PerformOperation(Functions operation)
        {
            // Get input values
            if (double.TryParse(x.Text, out double xValue) && double.TryParse(y.Text, out double yValue))
            {
                try
                {
                    // Perform the operation and display the result
                    double result = operation(xValue, yValue);
                    MessageBox.Show("Result: " + result.ToString(), "Calculation Result");
                }
                catch (DivideByZeroException ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error");
                }
            }
            else
            {
                MessageBox.Show("Please enter valid numbers.", "Input Error");
            }
        }
    }
}
