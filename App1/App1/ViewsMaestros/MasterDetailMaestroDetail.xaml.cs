using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.ViewsMaestros
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailMaestroDetail : ContentPage
    {
        public MasterDetailMaestroDetail()
        {
            InitializeComponent();
            Webview2.Source = "https://m.facebook.com/pg/upapnl/posts/";
        }
    }
}