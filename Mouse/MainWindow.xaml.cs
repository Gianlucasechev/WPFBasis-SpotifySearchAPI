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

namespace Mouse
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hiciste Click en el boton perro");
        }

        private void btnenviar_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Hiciste Doble Click prro");
        }

        private void btnenviar_MouseEnter(object sender, MouseEventArgs e)
        {
             MessageBox.Show("Entraste");
            
            
        }

        private void btnenviar_MouseLeave(object sender, MouseEventArgs e)
        {
             MessageBox.Show("Saliste");
            
           
        }
    }
}
