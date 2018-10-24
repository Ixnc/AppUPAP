using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.ViewsMaestros
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailMaestro : MasterDetailPage
    {
        public MasterDetailMaestro()
        {
            InitializeComponent();
            MasterPageMaestros.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterDetailMaestroMenuItem;
            if (item == null)
                return;

            var page = (Page)Activator.CreateInstance(item.TargetType);
            page.Title = item.Title;

            Detail = new NavigationPage(page);
            IsPresented = false;

            MasterPageMaestros.ListView.SelectedItem = null;
        }
    }
}