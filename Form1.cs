using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bluelime
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void cboLocation_KeyDown(object sender, KeyEventArgs e) // funkcja do wyszukiwania strony
        {
            if (e.KeyCode == Keys.Enter)
            {

                webBrowser1.Navigate(cboLocation.Text);
            }
        }

        private void btnBack_Click(object sender, EventArgs e) // button do powracania na poprzednią strone
        {
            webBrowser1.GoBack();
        }

        private void btnForward_Click(object sender, EventArgs e) // button do przenoszenia do następnej strony
        {
            webBrowser1.GoForward();
        }

        private void btnGo_Click(object sender, EventArgs e) // button do zatwierdzenia wyszukiwania
        {
            webBrowser1.Navigate(cboLocation.Text);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e) // funckcja dodająca "Damian WebBrowser - " w tytule przeglądarki przed tytulem otwartej strony
        {
            Text = "Damian WebBrowser - " + webBrowser1.Document.Title;
        }
    }
}
