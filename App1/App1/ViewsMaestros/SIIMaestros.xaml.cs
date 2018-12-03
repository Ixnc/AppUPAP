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
	public partial class SIIMaestros : ContentPage
	{
		public SIIMaestros ()
        {
            InitializeComponent();
            var uri = new Uri("http://sip.upnl.edu.mx/docentes.php/");
            Device.OpenUri(uri);
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();

            await progress.ProgressTo(0.9, 900, Easing.SpringIn);
        }

        protected void OnNavigating(object sender, WebNavigatingEventArgs e)
        {
            progress.IsVisible = true;
        }

        protected void OnNavigated(object sender, WebNavigatedEventArgs e)
        {
            progress.IsVisible = false;
        }
    }
}