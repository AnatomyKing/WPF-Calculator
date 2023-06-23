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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double firstnumber;
        double secondnumber;
        int check = 0;
        int som = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void four(object sender, RoutedEventArgs e)
        {
            if (input.Text == "0")
            {
                input.Text = "";
                input.Text = input.Text + "4";
            }
            else
            {
                input.Text = input.Text + "4";
            }
        }

        private void eight(object sender, RoutedEventArgs e)
        {
            if (input.Text == "0")
            {
                input.Text = "";
                input.Text = input.Text + "8";
            }
            else
            {
                input.Text = input.Text + "8";
            }
        }

        private void nine(object sender, RoutedEventArgs e)
        {
            if (input.Text == "0")
            {
                input.Text = "";
                input.Text = input.Text + "9";
            }
            else
            {
                input.Text = input.Text + "9";
            }
        }

        private void seven(object sender, RoutedEventArgs e)
        {
            if (input.Text == "0")
            {
                input.Text = "";
                input.Text = input.Text + "7";
            }
            else
            {
                input.Text = input.Text + "7";
            }
        }

        private void five(object sender, RoutedEventArgs e)
        {
            if (input.Text == "0")
            {
                input.Text = "";
                input.Text = input.Text + "5";
            }
            else
            {
                input.Text = input.Text + "5";
            }
        }

        private void six(object sender, RoutedEventArgs e)
        {
            if (input.Text == "0")
            {
                input.Text = "";
                input.Text = input.Text + "6";
            }
            else
            {
                input.Text = input.Text + "6";
            }
        }

        private void one(object sender, RoutedEventArgs e)
        {
            if (input.Text == "0")
            {
                input.Text = "";
                input.Text = input.Text + "1";
            }
            else
            {
                input.Text = input.Text + "1";
            }
        }

        private void two(object sender, RoutedEventArgs e)
        {
            if (input.Text == "0")
            {
                input.Text = "";
                input.Text = input.Text + "2";
            }
            else
            {
                input.Text = input.Text + "2";
            }
        }

        private void three(object sender, RoutedEventArgs e)
        {
            if (input.Text == "0")
            {
                input.Text = "";
                input.Text = input.Text + "3";
            }
            else
            {
                input.Text = input.Text + "3";
            }
        }

        private void zero(object sender, RoutedEventArgs e)
        {
            if (input.Text == "0")
            {
                input.Text = "";
                input.Text = input.Text + "0";
            }
            else
            {
                input.Text = input.Text + "0";
            }
        }

        private void comma(object sender, RoutedEventArgs e)
        {
            if (input.Text == "-")
            { }
            else if (check == 0 && input.Text.Length >= 1)
            {
                check++;
                input.Text = input.Text + ",";
            }
        }

        private void plus(object sender, RoutedEventArgs e)
        {
            if (input.Text == "-")
            { }
            else
            {
                som = 1;
                check = 0;
                uhhh.Text = input.Text + " +";
                double.TryParse(input.Text, out firstnumber);
                input.Text = "0";
            }
        }

        private void multi(object sender, RoutedEventArgs e)
        {
            if (input.Text == "-")
            { }
            else
            {
                som = 3;
                check = 0;
                uhhh.Text = input.Text + " *";
                double.TryParse(input.Text, out firstnumber);
                input.Text = "0";
            }
        }

        private void divide(object sender, RoutedEventArgs e)
        {
            if (input.Text == "-")
            { }
            else
            {
                som = 4;
                check = 0;
                uhhh.Text = input.Text + " ÷";
                double.TryParse(input.Text, out firstnumber);
                input.Text = "0";
            }
        }

        private void minus(object sender, RoutedEventArgs e)
        {
            if (input.Text == "0")
            {
                input.Text = "";
                input.Text = input.Text + "-";
            }
            else if (input.Text == "-")
            {
            }
            else
            {
                som = 2;
                check = 0;
                uhhh.Text = input.Text + " -";
                double.TryParse(input.Text, out firstnumber);
                input.Text = "0";
            }
        }

        private void solve(object sender, RoutedEventArgs e)
        {
            if (input.Text.Length >= 1)
            {
                double.TryParse(input.Text, out secondnumber);
                double solved;

                switch (som)
                {
                    case 1:
                        uhhh.Text = "";
                        solved = firstnumber + secondnumber;
                        input.Text = solved.ToString();
                        break;
                    case 2:
                        uhhh.Text = "";
                        solved = firstnumber - secondnumber;
                        input.Text = solved.ToString();
                        break;
                    case 3:
                        uhhh.Text = "";
                        solved = firstnumber * secondnumber;
                        input.Text = solved.ToString();
                        break;
                    case 4:
                        uhhh.Text = "";
                        solved = firstnumber / secondnumber;
                        input.Text = solved.ToString();
                        break;
                    case 0:
                        break;
                }
                som = 0;
            }
        }

        private void clear(object sender, RoutedEventArgs e)
        {
            firstnumber = 0;
            secondnumber = 0;
            som = 0;
            check = 0;
            input.Text = "0";
            uhhh.Text = "";
        }

        private void back(object sender, RoutedEventArgs e)
        {
            if (input.Text.Length >= 1)
            {
                string bruh = input.Text;
                bruh = bruh.Remove(bruh.Length - 1);
                input.Text = bruh;
            }
            else { }
        }
    }
}
