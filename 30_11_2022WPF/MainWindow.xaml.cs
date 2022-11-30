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
            if (tbnow.Text == "0")
                tbnow.Text = $"{NumButton.Content}";
            else
                tbnow.Text += $"{NumButton.Content}";

        }

        private void SymLeft_Click(object sender, RoutedEventArgs e)
        {
            if (tbnow.Text != "")
                tbnow.Text = tbnow.Text.Remove(tbnow.Text.Length - 1);
        }

        private void SymC_Click(object sender, RoutedEventArgs e)
        {
            tbnow.Text = "0";
            tbpast.Text = "0";
        }

        /*Class work */

        //    private void RadioButton_Checked(object sender, RoutedEventArgs e)
        //    {
        //        var rb = sender as RadioButton;
        //        this.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString($"{rb.Content}"));
        //    }
    }

}