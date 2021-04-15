using ProyectoFinalSpotify.Helpers;
using ProyectoFinalSpotify.Models;
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

namespace ProyectoFinalSpotify
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //boton del mouse al hacerle click
            tittleBar.MouseLeftButtonDown += (o, e) => DragMove(); 
            //Primero ejecutará el getToken para poder ejecutar nuestra implementación del api en el evento keyup
            Task.Run(async () => await SearchHelper.GetTokenAsync());
        }

        private void txt1_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtSearch.Text == string.Empty)
            {
                ListArtist.ItemsSource = null;
                return;
            }

            var result = SearchHelper.SearchArtist(txtSearch.Text);

            if (result == null)
            {
                return;
            }

            var listArtist = new List<SpotifyArtist>();

            foreach (var item in result.artists.items)
            {
                listArtist.Add(new SpotifyArtist()
                {
                    ID = item.id,
                    Image = item.images.Any() ? item.images[0].url : "https://user-images.githubusercontent.com/24848110/33519396-7e56363c-d79d-11e7-969b-09782f5ccbab.png",
                    Name = item.name,
                    Popularity = $"{item.popularity}% popularidad",
                    Followers = $"{item.followers.total.ToString("N")} seguidores"
                });
            }

            ListArtist.ItemsSource = listArtist;
        }

        private void btnminimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        
        private void btnminimize_MouseEnter(object sender, MouseEventArgs e)
        {
            btnminimize.Background = new SolidColorBrush(Colors.Yellow);
        }
        //estado de apagar una aplicacion
        private void btnclose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnclose_MouseEnter(object sender, MouseEventArgs e)
        {
            btnminimize.Background = new SolidColorBrush(Colors.Red);
        }
    }
}
