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

namespace Keyboard
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

        //private void Button_KeyUp(object sender, KeyEventArgs e)
        //{
        //    switch (e.Key)
        //    {
        //        case Key.Up:
        //            btn1.Content = "Arriba";
        //            break;
        //        case Key.Right:
        //            btn1.Content = "Derecha";
        //            break;
        //        case Key.Left:
        //            btn1.Content = "izquierda";
        //            break;
        //        case Key.Down:
        //            btn1.Content = "Abajo";
        //            break;
        //    }
            
        //}

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            btn1.Foreground = new SolidColorBrush(Colors.Red);
            btn1.Content = "Arriba";
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            btn1.Foreground = new SolidColorBrush(Colors.Blue);
            btn1.Content = "Abajo";

        }
    }
}
