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

namespace Dialog
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

        private void eventclick(object sender, RoutedEventArgs e)
        {
            string msgtext = "Click any button";
            string tittle = "First caption";
            MessageBoxButton button = MessageBoxButton.YesNoCancel;
            MessageBoxResult result = MessageBox.Show(msgtext, tittle, button);

            switch (result)
            {
                case MessageBoxResult.Yes:
                    txtbox1.Text="SI";
                    break;
                case MessageBoxResult.No:
                    txtbox1.Text = "NO";
                    break;
                case MessageBoxResult.Cancel:
                    txtbox1.Text = "CANCELAR";
                    break;

            }
        }
    }
}
