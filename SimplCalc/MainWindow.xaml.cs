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

namespace SimplCalc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        public static string txt;
        public char operation;
        public double manipulation;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GetVal(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            txt += btn.Content.ToString();
            result.Text = txt;
        }

        private void Divide(object sender, RoutedEventArgs e)
        {
          
            operation = '/';
            result.Text += operation;
            txt += operation;
        }

        private void Multiply(object sender, RoutedEventArgs e)
        {  
            operation = '*';
            result.Text += operation;
            txt += operation;
        }

        private void Add(object sender, RoutedEventArgs e)
        {

            operation = '+';
            result.Text += operation;
            txt += operation;
        }

        private void Subtract(object sender, RoutedEventArgs e)
        {
            operation = '-';
            result.Text += operation;
            txt += operation;
        }

        private void showResult(object sender, RoutedEventArgs e)
        {
            string[] numbers = txt.Split(operation);

            switch(operation)
            {
                case '/':

                    manipulation = double.Parse(numbers[0]) / double.Parse(numbers[1]);
                    break;

                case '*':
                    manipulation = double.Parse(numbers[0]) * double.Parse(numbers[1]);
                    break;

                case '+':
                    manipulation = double.Parse(numbers[0]) + double.Parse(numbers[1]);
                    break;
                
                case '-':
                    manipulation = double.Parse(numbers[0]) - double.Parse(numbers[1]);
                    break;

                default:
                    break;
            }

            result.Text = txt;
            txt = manipulation.ToString();
            result.Text += " = " + txt;
        }

        private void Clear(object sender, RoutedEventArgs e)
        {
            txt = string.Empty;
            result.Text = txt;
            manipulation = 0;
        }
    }
}
