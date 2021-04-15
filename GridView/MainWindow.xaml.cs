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

namespace GridView
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
            var users = new List<User>();
            for(int i=0; i < 5; i++)
            {
                users.Add(new User()
                {
                    ID = i,
                    FirstName = Guid.NewGuid().ToString(),
                    LastName= Guid.NewGuid().ToString(),
                    LastAccess=Guid.NewGuid().ToString()
                });
            }
            Lista.ItemsSource = users;
        }

    }
    public class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string LastAccess { get; set; }

    }

}
