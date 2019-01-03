using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Igroland
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            WebView webView = new WebView() { Source="http://igroland.com.ua"};
            this.Content = webView;
        }
    }
}
