using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailPage1Master : ContentPage
    {
        public ListView ListView { get { return MenuItemsListView; } }

        public MasterDetailPage1Master()
        {
            InitializeComponent();

            var itemmaster = new List<MasterDetailPage1MenuItem>();

            itemmaster.Add(new MasterDetailPage1MenuItem
            {
                Title = "Noticias",
                IconSource = "ic_noticias",
                TargetType = typeof(MasterDetailPage1Detail)
            });
            itemmaster.Add(new MasterDetailPage1MenuItem
            {
                Title = "Proximos Eventos",
                IconSource = "ic_event",
                //TargetType = typeof()
            });
            itemmaster.Add(new MasterDetailPage1MenuItem
            {
                Title = "Moodle",
                IconSource = "ic_link",
                TargetType = typeof(Accesos)
            });
            itemmaster.Add(new MasterDetailPage1MenuItem
            {
                Title = "SII",
                IconSource = "ic_link",
                TargetType = typeof(SII)
            });
            itemmaster.Add(new MasterDetailPage1MenuItem
            {
                Title = "Contacto",
                IconSource = "ic_chat",
                //TargetType = typeof(MasterDetailPage1)
            });
            itemmaster.Add(new MasterDetailPage1MenuItem
            {
                Title = "Preguntas Frecuentes",
                IconSource = "ic_question",
                TargetType = typeof(PreguntasFre)
            });
            itemmaster.Add(new MasterDetailPage1MenuItem
            {
                Title = "Encuestas",
                IconSource = "ic_encusta",
                //TargetType = typeof(MasterDetailPage1)
            });
            MenuItemsListView.ItemsSource = itemmaster;
        }
    }
}