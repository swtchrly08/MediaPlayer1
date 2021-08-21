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
using System.Diagnostics;
using System.ComponentModel;
using System.Net;

namespace MediaPlayer1
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
        private void NetflixButtonClick(object sender, RoutedEventArgs e)
        {
            ProcessStartInfo Netflix = new ProcessStartInfo("netflix:");
            Process.Start(Netflix);
        }
        private void SpotifyButtonClick(object sender, RoutedEventArgs e)
        {
            ProcessStartInfo Spotify = new ProcessStartInfo("spotify:");
            Process.Start(Spotify);
        }
        private void SteamButtonClick(object sender, RoutedEventArgs e)
        {
            ProcessStartInfo Steam = new ProcessStartInfo("steam:");
            Process.Start(Steam);
        }
    }
}
