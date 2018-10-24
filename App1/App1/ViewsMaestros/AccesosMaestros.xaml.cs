using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.ViewsMaestros
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AccesosMaestros
	{
		public AccesosMaestros ()
		{
            InitializeComponent();
            Webview1.Source = "http://upnl.com.mx/moodle/login/index.php";
            Webview2.Source = "http://sip.upnl.edu.mx/docentes.php/";
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