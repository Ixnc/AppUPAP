using App1.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.ViewsMaestros
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailMaestroMaster : ContentPage
    {
        public ListView ListView { get { return MenuItemsListViewM; } }

        public MasterDetailMaestroMaster()
        {
            InitializeComponent();

            var itemmaster = new List<MasterDetailMaestroMenuItem>();

            itemmaster.Add(new MasterDetailMaestroMenuItem
            {
                Title = "Noticias",
                IconSource = "ic_noticias",
                TargetType = typeof(MasterDetailMaestroDetail)
            });
            itemmaster.Add(new MasterDetailMaestroMenuItem
            {
                Title = "Proximos Eventos",
                IconSource = "ic_event",
                //TargetType = typeof()
            });
            itemmaster.Add(new MasterDetailMaestroMenuItem
            {
                Title = "Accesos",
                IconSource = "ic_link",
                TargetType = typeof(AccesosMaestros)
            });
            itemmaster.Add(new MasterDetailMaestroMenuItem
            {
                Title = "Contacto",
                IconSource = "ic_chat",
                //TargetType = typeof(MasterDetailPage1)
            });
            itemmaster.Add(new MasterDetailMaestroMenuItem
            {
                Title = "Preguntas Frecuentes",
                IconSource = "ic_question",
                TargetType = typeof(PreguntasFre)
            });
            MenuItemsListViewM.ItemsSource = itemmaster;
        }
    }
}