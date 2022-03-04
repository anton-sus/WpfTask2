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

namespace WpfApp2

{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        double number1 = 0;
        public string Ariph;
        bool flagN2Active;

        public MainWindow()
        {
            flagN2Active = false;
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (flagN2Active == true)
            {
                flagN2Active = false;
                textBlock.Text = "0";
            }
            Button B = (Button)sender;
            if (textBlock.Text == "0")
                textBlock.Text = (string)B.Content;
            else
            textBlock.Text =textBlock.Text + B.Content;
        }


        private void ButtonС_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text = "0";
        }

        private void ButtonAriph_Click(object sender, RoutedEventArgs e)
        {
            Button B = (Button)sender;
            Ariph = (string)B.Content;
            number1 =Convert.ToDouble(textBlock.Text);
            flagN2Active = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double N1, N2;
            double result = 0;
            N1 = number1;
            N2 = Convert.ToDouble(textBlock.Text);
            if(Ariph == "+")
            {
                result = N1 + N2;
            }
            if (Ariph == "-")
            {
                result = N1 - N2;
            }
            if (Ariph == "*")
            {
                result = N1 * N2;
            }
            if (Ariph == "/")
            {
                result = N1 / N2;
            }
            if (Ariph == "%")
            {
                result = N1 * N2/100;
            }
            Ariph = "=";
            flagN2Active = true;
            textBlock.Text = result.ToString();
        }

        private void ButtonSqr_Click(object sender, RoutedEventArgs e)
        {
            double result;
            number1 = Convert.ToDouble(textBlock.Text);
            result = Math.Sqrt(number1);
            textBlock.Text = result.ToString();
        }

        private void ButtonPow_Click(object sender, RoutedEventArgs e)
        {
            double result;
            number1 = Convert.ToDouble(textBlock.Text);
            result = Math.Pow(number1,2);
            textBlock.Text = result.ToString();
        }


        private void ButtonPoint_Click(object sender, RoutedEventArgs e)
        {
            if(!textBlock.Text.Contains("."))
            textBlock.Text = textBlock.Text + ".";
        }
    }
}
