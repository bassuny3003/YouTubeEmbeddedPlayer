using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//
using WinForm.YouTubeEmbeddedPlayer;

namespace PlayYoutubeURL
{
    public partial class FrmLoadPlayer : Form
    {
        public FrmLoadPlayer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            YoutubePlayer youtubeWebBrowserPlayer = new YoutubePlayer()
            {
                YotubeVideoURL = "https://www.youtube.com/watch?v=RHNS3Sn21bA",

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

                PlayerPlaylistIDs = new string[] { "u0_fEeQG9Q4", "u0_fEeQG9Q4", "AuZR06xtgXQ" , "e53c1nRtH7w" },

                WebBrowserControl = webBrowser
            };


            this.webBrowser.DocumentText = string.Format(youtubeWebBrowserPlayer.HtmlPlayer());

            txtBxYoutubeURL.Text = youtubeWebBrowserPlayer.CreateYoutubeEmbedURL();
        }
    }
}
