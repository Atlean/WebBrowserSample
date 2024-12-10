using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowserSample
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void cboLocation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                webBrowser1.Navigate(cboLocation.Text);
            }
        }

        private void cboLocation_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void Forward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void ButtonGo_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(cboLocation.Text);
        }
    }
}
