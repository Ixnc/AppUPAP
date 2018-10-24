using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.ViewsAdmin
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AccesosAdmin
	{
		public AccesosAdmin ()
		{
            InitializeComponent();
            Webview1.Source = "http://sip.upnl.edu.mx/alumnos.php/";
            Webview2.Source = "https://www.facebook.com/upapnl";
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();

            await progress.ProgressTo(0.9, 900, Easing.SpringIn);
        }

        protected void OnNavigating(object sender, WebNavigatingEventArgs e)
        {
            progress.IsVisible = true;
            progress1.IsVisible = true;
        }

        protected void OnNavigated(object sender, WebNavigatedEventArgs e)
        {
            progress.IsVisible = false;
            progress1.IsVisible = false;

        }
    }
}