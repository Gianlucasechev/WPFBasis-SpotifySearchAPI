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

namespace Elementos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            llenarDatos();
        }
        public void llenarDatos()
        {
            var users = new List<Users>();
            for(int i = 0; i < 4; i++)
            {
                users.Add(new Users { 
                    ID=i,
                    FirstName=Guid.NewGuid().ToString(),
                    LastName=Guid.NewGuid().ToString(),
                    LastAccess=DateTime.Now.ToString()
                });
            }
            lstbox1.ItemsSource = users;

        }
        

    }
    public class Users
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string LastAccess { get; set; }

    }
}
