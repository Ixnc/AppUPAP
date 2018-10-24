using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.ViewsAdmin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailAdminMaster : ContentPage
    {
        public ListView ListView { get { return MenuItemsListViewA; } }

        public MasterDetailAdminMaster()
        {
            InitializeComponent();

            var itemmaster = new List<MasterDetailAdminMenuItem>();

            itemmaster.Add(new MasterDetailAdminMenuItem
            {
                Title = "Noticias",
                IconSource = "ic_noticias",
                TargetType = typeof(MasterDetailAdminDetail)
            });
            itemmaster.Add(new MasterDetailAdminMenuItem
            {
                Title = "Proximos Eventos",
                IconSource = "ic_event",
                //TargetType = typeof()
            });
            itemmaster.Add(new MasterDetailAdminMenuItem
            {
                Title = "Accesos",
                IconSource = "ic_link",
                TargetType = typeof(AccesosAdmin)
            });
            itemmaster.Add(new MasterDetailAdminMenuItem
            {
                Title = "Contacto",
                IconSource = "ic_chat",
                //TargetType = typeof(MasterDetailPage1)
            });
            MenuItemsListViewA.ItemsSource = itemmaster;
        }
    }
}