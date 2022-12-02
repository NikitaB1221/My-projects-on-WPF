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

namespace _2_12_2022WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            #region ClassWork Practice1
            //    int rows = 10;
            //    int columns = 10;
            //    for (int i = 0; i < rows; i++)
            //    {
            //        g1.RowDefinitions.Add(new RowDefinition());
            //    }
            //    for (int i = 0; i < columns; i++)
            //    {
            //        g1.ColumnDefinitions.Add(new ColumnDefinition());
            //    }
            //    int cntr = 1;
            //    for (int y = 0; y < rows; y++)
            //    {
            //        for (int x = 0; x < columns; x++)
            //        {
            //            var b = new Button();
            //            b.Content = $"{cntr++}";
            //            b.Margin = new Thickness(3, 3, 3, 3);
            //            Random _r = new Random();
            //            b.Background = new SolidColorBrush(System.Windows.Media.Color.FromArgb((byte)_r.Next(1, 255), (byte)_r.Next(1, 255), (byte)_r.Next(1, 255), (byte)_r.Next(1, 255)));
            //            b.Click += Button_Click;
            //            Grid.SetColumn(b, x);
            //            Grid.SetRow(b, y);
            //            g1.Children.Add(b);
            //        }
            //    }
            //}
            //
            //private void Button_Click(object sender, RoutedEventArgs e)
            //{
            //    var sb = (Button)sender;
            //    sb.Visibility = Visibility.Hidden;
            #endregion

        }
    }
}
