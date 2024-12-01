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

namespace Caclulator
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Calculator calculator = new Calculator();
        private float result;
        private string operation;
        private bool hasBeenPressed = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAddition_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            hasBeenPressed = true;
        }

        private void btnSubstraction_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            hasBeenPressed = true;
        }

        private void btnMultiplication_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            hasBeenPressed = true;
        }

        private void btnDivision_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            hasBeenPressed = true;
        }

        private void btnResult_Click(object sender, RoutedEventArgs e)
        {

            switch (operation)
            {
                case "+":
                    result = calculator.Add(calculator.NumberOne, calculator.NumberTwo);
                    break;
                case "-":
                    result = calculator.Substract(calculator.NumberOne, calculator.NumberTwo);
                    break;
                case "*":
                    result = calculator.Multiply(calculator.NumberOne, calculator.NumberTwo);
                    break;
                case "/":
                    result = calculator.Divide(calculator.NumberOne, calculator.NumberTwo);
                    break;
            }
            hasBeenPressed = false;
            MessageBox.Show(result.ToString());
            calculator.NumberOne = 0;
            calculator.NumberTwo = 0;
            operation = "";
            result = 0;
        }

        private void btnNumberOne_Click(object sender, RoutedEventArgs e)
        {

            if (!hasBeenPressed)
            {
                calculator.NumberOne = float.Parse(btnNumberOne.Content.ToString());
            } else
            {
                calculator.NumberTwo = float.Parse(btnNumberOne.Content.ToString());
            }
        }

        private void btnNumberTwo_Click(object sender, RoutedEventArgs e)
        {
            if (!hasBeenPressed)
            {
                calculator.NumberOne = float.Parse(btnNumberTwo.Content.ToString());
            }
            else
            {
                calculator.NumberTwo = float.Parse(btnNumberTwo.Content.ToString());
            }
        }

        private void btnNumberThree_Click(object sender, RoutedEventArgs e)
        {
            if (!hasBeenPressed)
            {
                calculator.NumberOne = float.Parse(btnNumberThree.Content.ToString());
            }
            else
            {
                calculator.NumberTwo = float.Parse(btnNumberThree.Content.ToString());
            }

        }

        private void btnNumberFour_Click(object sender, RoutedEventArgs e)
        {
            if (!hasBeenPressed)
            {
                calculator.NumberOne = float.Parse(btnNumberFour.Content.ToString());
            }
            else
            {
                calculator.NumberTwo = float.Parse(btnNumberFour.Content.ToString());
            }
        }

        private void btnNumberFive_Click(object sender, RoutedEventArgs e)
        {
            if (!hasBeenPressed)
            {
                calculator.NumberOne = float.Parse(btnNumberFive.Content.ToString());
            }
            else
            {
                calculator.NumberTwo = float.Parse(btnNumberFive.Content.ToString());
            }
        }

        private void btnNumberSix_Click(object sender, RoutedEventArgs e)
        {
            if (!hasBeenPressed)
            {
                calculator.NumberOne = float.Parse(btnNumberSix.Content.ToString());
            }
            else
            {
                calculator.NumberTwo = float.Parse(btnNumberSix.Content.ToString());
            }
        }

        private void btnNumberSeven_Click(object sender, RoutedEventArgs e)
        {
            if (!hasBeenPressed)
            {
                calculator.NumberOne = float.Parse(btnNumberSeven.Content.ToString());
            }
            else
            {
                calculator.NumberTwo = float.Parse(btnNumberSeven.Content.ToString());
            }
        }

        private void btnNumberEight_Click(object sender, RoutedEventArgs e)
        {
            if (!hasBeenPressed)
            {
                calculator.NumberOne = float.Parse(btnNumberEight.Content.ToString());
            }
            else
            {
                calculator.NumberTwo = float.Parse(btnNumberEight.Content.ToString());
            }
        }

        private void btnNumberNine_Click(object sender, RoutedEventArgs e)
        {
            if (!hasBeenPressed)
            {
                calculator.NumberOne = float.Parse(btnNumberNine.Content.ToString());
            }
            else
            {
                calculator.NumberTwo = float.Parse(btnNumberNine.Content.ToString());
            }
        }
    }
}
