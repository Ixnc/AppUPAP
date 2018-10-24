using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PreguntasFre : ContentPage
	{
		public PreguntasFre ()
		{
			InitializeComponent ();
		}
        private void ListViewItem_Tabbed(object sender, ItemTappedEventArgs e)
        {
            var product = e.Item as Pregunta;
            var vm = BindingContext as MainListView;
            vm?.ShoworHiddenProducts(product);
        }
    }
}