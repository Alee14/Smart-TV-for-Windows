using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cef;
using CefSharp;
using CefSharp.WinForms;
using CefSharp.WinForms.Internals;

namespace Smart_TV_for_Windows
{
    public partial class youtube : Form
    {
        public youtube()
        {
            InitializeComponent();
        }

        public CefSharp.WinForms.ChromiumWebBrowser browser;

        private void youtube_Load(object sender, EventArgs e)
        {
            browser = new CefSharp.WinForms.ChromiumWebBrowser("https://www.youtube.com/tv")
            {
                Dock = DockStyle.Fill,
                Size = new Size(600, 600),
                Location = new Point(200, 200),
            };
            this.panel1.Controls.Add(browser);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
