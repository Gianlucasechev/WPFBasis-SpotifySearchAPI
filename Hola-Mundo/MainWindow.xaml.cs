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


namespace Hola_Mundo
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
            for(int i=0; i < 4; i++)
            {
                users.Add(new User()
                {
                    idUser = i,
                    firstName = Guid.NewGuid().ToString(),
                    lastName = Guid.NewGuid().ToString(),
                    lastAccess = DateTime.Now.AddDays(i).ToString()
                });
            }
            datagridusuario.ItemsSource = users;
        }
    }

    public class User
    {
        public int idUser { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string lastAccess { get; set; }

    }
}
