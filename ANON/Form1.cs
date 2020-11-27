using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ANON
{
    public partial class ANON : Form
    {
        public ANON()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We are ANON, an application Developement company that is fully community ran, if you want to share code goto Discord and add the server https://discord.gg/Hv8pxEFhq7");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We are the first Application devs, that are un organized.");

            MessageBox.Show("We have closed source and open source code for are members to use to make improvements");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Changes V.0.0.1.1A, We have added a download to get our new version. we have also added a BASIC web feature that we will be updating.");
        }
    }
}
