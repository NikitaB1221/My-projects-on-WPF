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

namespace _9_12_2022WPF
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

        private void PaintItRedCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var focusedControl = FocusManager.GetFocusedElement(this);
            if (focusedControl is Button)
            {
                var Buttemp = (Button)focusedControl;
                Buttemp.Background = Brushes.Red;
            }
        }

        private void PaintItBlueCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var focusedControl = FocusManager.GetFocusedElement(this);
            if (focusedControl is Button)
            {
                var Buttemp = (Button)focusedControl;
                Buttemp.Background = Brushes.Blue;
            }
        }

        private void PaintItGreenCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var focusedControl = FocusManager.GetFocusedElement(this);
            if (focusedControl is Button)
            {
                var Buttemp = (Button)focusedControl;
                Buttemp.Background = Brushes.Green;
            }
        }
    } 

    public class PaintItCommands
    {
        static PaintItCommands()
        {
            PaintItRedCommand = new RoutedCommand("PaintItRedCommand", typeof(PaintItCommands));
            PaintItBlueCommand = new RoutedCommand("PaintItBlueCommand", typeof(PaintItCommands));
            PaintItGreenCommand = new RoutedCommand("PaintItGreenCommand", typeof(PaintItCommands));
        }
        public static RoutedCommand PaintItRedCommand { get; set; }
        public static RoutedCommand PaintItBlueCommand { get; set; }
        public static RoutedCommand PaintItGreenCommand { get; set; }
    }
}
