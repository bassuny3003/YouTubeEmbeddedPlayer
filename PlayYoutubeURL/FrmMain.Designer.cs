
namespace PlayYoutubeURL
{
    partial class FrmLoadPlayer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.btnLoadPlayer = new System.Windows.Forms.Button();
            this.txtBxYoutubeURL = new System.Windows.Forms.TextBox();
            this.lstBxYoutubeURLs = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // webBrowser
            // 
            this.webBrowser.AllowWebBrowserDrop = false;
            this.webBrowser.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser.Location = new System.Drawing.Point(12, 38);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScrollBarsEnabled = false;
            this.webBrowser.Size = new System.Drawing.Size(520, 418);
            this.webBrowser.TabIndex = 0;
            this.webBrowser.WebBrowserShortcutsEnabled = false;
            // 
            // btnLoadPlayer
            // 
            this.btnLoadPlayer.Location = new System.Drawing.Point(538, 387);
            this.btnLoadPlayer.Name = "btnLoadPlayer";
            this.btnLoadPlayer.Size = new System.Drawing.Size(222, 69);
            this.btnLoadPlayer.TabIndex = 1;
            this.btnLoadPlayer.Text = "Show Me Magic";
            this.btnLoadPlayer.UseVisualStyleBackColor = true;
            this.btnLoadPlayer.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBxYoutubeURL
            // 
            this.txtBxYoutubeURL.Location = new System.Drawing.Point(12, 12);
            this.txtBxYoutubeURL.Name = "txtBxYoutubeURL";
            this.txtBxYoutubeURL.Size = new System.Drawing.Size(748, 20);
            this.txtBxYoutubeURL.TabIndex = 2;
            // 
            // lstBxYoutubeURLs
            // 
            this.lstBxYoutubeURLs.FormattingEnabled = true;
            this.lstBxYoutubeURLs.Location = new System.Drawing.Point(538, 38);
            this.lstBxYoutubeURLs.Name = "lstBxYoutubeURLs";
            this.lstBxYoutubeURLs.Size = new System.Drawing.Size(222, 342);
            this.lstBxYoutubeURLs.TabIndex = 3;
            // 
            // FrmLoadPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 467);
            this.Controls.Add(this.lstBxYoutubeURLs);
            this.Controls.Add(this.txtBxYoutubeURL);
            this.Controls.Add(this.btnLoadPlayer);
            this.Controls.Add(this.webBrowser);
            this.Name = "FrmLoadPlayer";
            this.Text = "Load Player";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button btnLoadPlayer;
        private System.Windows.Forms.TextBox txtBxYoutubeURL;
        private System.Windows.Forms.ListBox lstBxYoutubeURLs;
    }
}

