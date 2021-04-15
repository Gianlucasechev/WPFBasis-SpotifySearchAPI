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

namespace ToggleButton
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

        private void ToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            tglbtn1.Content = "Encender";
            tglbtn1.Foreground = Brushes.Green;
            tglbtn1.Background = Brushes.Gray;
        }

        private void ToggleButton_Unchecked(object sender, RoutedEventArgs e)
        {
            tglbtn1.Content = "Apagar";
            tglbtn1.Foreground = Brushes.Red;
            tglbtn1.Background = Brushes.Gray;
        }
    }
}
