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

namespace _30_11_2022WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Num_Click(object sender, RoutedEventArgs e)
        {
            var NumButton = (Button)sender;
            if (tbnow.Text == "0" && (string)NumButton.Content != ".")
                tbnow.Text = $"{NumButton.Content}";
            else if(tbnow.Text == "0" && (string)NumButton.Content == ".")
                tbnow.Text += $"{NumButton.Content}";
            else
                tbnow.Text += $"{NumButton.Content}";

        }

        private void SymLeft_Click(object sender, RoutedEventArgs e)
        {
            if (tbnow.Text != "" || tbnow.Text != "0")
                tbnow.Text = tbnow.Text.Remove(tbnow.Text.Length - 1);
        }

        private void SymC_Click(object sender, RoutedEventArgs e)
        {
            tbnow.Text = "0";
            tbpast.Text = "0";
        }

        private void SymCE_Click(object sender, RoutedEventArgs e)
        {
            tbnow.Text = "0";
        }

        private void SymOperator_Click(object sender, RoutedEventArgs e)
        {
            var OperatorButton = (Button)sender;
            if (tbpast.Text == "" || tbpast.Text == "0")
                tbpast.Text = $"{tbnow.Text}" + $" {OperatorButton.Content} ";
            else
                tbpast.Text = $"{tbpast.Text}" + $"{tbnow.Text}" + $" {OperatorButton.Content} ";
            
            tbnow.Text = "0";
        }

        private void SymEquals_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                tbpast.Text = $"{tbpast.Text}" + $"{tbnow.Text}";
                tbnow.Text = "0";
                calculate();
            }
            catch (Exception exc)
            {
                tbpast.Text = "Error!";
            }
        }

        private void calculate()
        {
            String op;
            int iOp = 0;
            if (tbpast.Text.Contains("+"))
            {
                iOp = tbpast.Text.IndexOf("+");
            }
            else if (tbpast.Text.Contains("-"))
            {
                iOp = tbpast.Text.IndexOf("-");
            }
            else if (tbpast.Text.Contains("*"))
            {
                iOp = tbpast.Text.IndexOf("*");
            }
            else if (tbpast.Text.Contains("/"))
            {
                iOp = tbpast.Text.IndexOf("/");
            }
            else
            {
                //error    
            }

            op = tbpast.Text.Substring(iOp, 1);
            double op1 = Convert.ToDouble(tbpast.Text.Substring(0, iOp));
            double op2 = Convert.ToDouble(tbpast.Text.Substring(iOp + 1, tbpast.Text.Length - iOp - 1));

            tbpast.Text = "0";

            if (op == "+")
            {
                tbnow.Text = $"{op1 + op2}";
            }
            else if (op == "-")
            {
                tbnow.Text = $"{op1 - op2}";
            }
            else if (op == "*")
            {
                tbnow.Text = $"{op1 * op2}";
            }
            else
            {
                tbnow.Text = $"{op1 / op2}";
            }
        }

        /*Class work */

        //    private void RadioButton_Checked(object sender, RoutedEventArgs e)
        //    {
        //        var rb = sender as RadioButton;
        //        this.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString($"{rb.Content}"));
        //    }
    }

}