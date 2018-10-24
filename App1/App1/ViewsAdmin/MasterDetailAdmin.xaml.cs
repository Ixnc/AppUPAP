using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.ViewsAdmin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailAdmin : MasterDetailPage
    {
        public MasterDetailAdmin()
        {
            InitializeComponent();
            MasterPageAdmin.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterDetailAdminMenuItem;
            if (item == null)
                return;

            var page = (Page)Activator.CreateInstance(item.TargetType);
            page.Title = item.Title;

            Detail = new NavigationPage(page);
            IsPresented = false;

            MasterPageAdmin.ListView.SelectedItem = null;
        }
    }
}