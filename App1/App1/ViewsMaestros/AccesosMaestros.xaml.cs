﻿using Xamarin.Forms;
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