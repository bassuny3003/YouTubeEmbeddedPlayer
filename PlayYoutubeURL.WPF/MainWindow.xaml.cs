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
using WPF.YouTubeEmbeddedPlayer;

namespace PlayYoutubeURL.WPF
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

        private void btnLoadPlayer_Click(object sender, RoutedEventArgs e)
        {
            YoutubePlayer youtubeWebBrowserPlayer = new YoutubePlayer()
            {
                YotubeVideoURL = "https://www.youtube.com/watch?v=e53c1nRtH7w&list=PLqPejUavRNTVu6AWaG8HREYJDw6cL1oZA&index=27",

                //StartSeconds = 30,
                //EndSeconds = 70,

                Force1080HD = true,

                Autoplay = true,

                LoopVideoOrPlaylist = true,

                ModestBranding = true,

                ShowUnrelatedVideos = true,

                PlayerLanguage = "ar-eg",

                EnablePlayerControls = true,

                UsingWhiteProgressBar = true,

                DisablePlayerKeyboardShortcuts = true,

                PlayerPlaylistIDs = new string[] { "u0_fEeQG9Q4", "u0_fEeQG9Q4", "AuZR06xtgXQ", "e53c1nRtH7w" },

                WebBrowserControl = webBrowser
            };


            this.webBrowser.NavigateToString(youtubeWebBrowserPlayer.HtmlPlayer());

            txtBxYoutubeURL.Text = youtubeWebBrowserPlayer.CreateYoutubeEmbedURL();
        }
    }
}
