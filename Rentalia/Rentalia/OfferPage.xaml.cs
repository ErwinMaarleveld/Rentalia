using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Rentalia.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Rentalia.FourMistakesAPIClient;

namespace Rentalia
{


    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OfferPage : ContentPage
    {
        public string Name { get; set; }
        public string Huurprijs { get; set; }
        public string FileName {get; set;}
        public OfferPage()
        {
            BindingContext = this;
            InitializeComponent();
            //var items = Enumerable.Range(0, 10);
            //Aanbieding[] alleAanbiedingen = new Aanbieding[] {new Aanbieding("veld", "Grasmaaier HUREN", "Goede grasmaair, zgan", 69, DateTime.Now, new Gebruiker("veld", "veld", "veld", "veld", "veld", DateTime.Now, 0, 0) ), new Aanbieding("veld", "Opblaas zwembadje", "Goede grasmaair, zgan", 35, DateTime.Now, new Gebruiker("veld", "veld", "veld", "veld", "veld", DateTime.Now, 0, 0)), new Aanbieding("veld", "Tesla model X", "Goede grasmaair, zgan", 420, DateTime.Now, new Gebruiker("veld", "veld", "veld", "veld", "veld", DateTime.Now, 0, 0)), new Aanbieding("veld", "Injectie naalden", "Goede grasmaair, zgan", 23, DateTime.Now, new Gebruiker("veld", "veld", "veld", "veld", "veld", DateTime.Now, 0, 0)), new Aanbieding("veld", "Springkussen te huur", "Goede grasmaair, zgan", 35, DateTime.Now, new Gebruiker("veld", "veld", "veld", "veld", "veld", DateTime.Now, 0, 0)), new Aanbieding("veld", "Opblaaspop", "Goede grasmaair, zgan", 3, DateTime.Now, new Gebruiker("veld", "veld", "veld", "veld", "veld", DateTime.Now, 0, 0)), new Aanbieding("veld", "Labrador hond", "Goede grasmaair, zgan", 75, DateTime.Now, new Gebruiker("veld", "veld", "veld", "veld", "veld", DateTime.Now, 0, 0)), new Aanbieding("veld", "Vogel kooi", "Goede grasmaair, zgan", 9, DateTime.Now, new Gebruiker("veld", "veld", "veld", "veld", "veld", DateTime.Now, 0, 0)), new Aanbieding("veld", "Projectie beamer", "Goede grasmaair, zgan", 74, DateTime.Now, new Gebruiker("veld", "veld", "veld", "veld", "veld", DateTime.Now, 0, 0)), new Aanbieding("veld", "Trampoline", "Goede grasmaair, zgan", 124, DateTime.Now, new Gebruiker("veld", "veld", "veld", "veld", "veld", DateTime.Now, 0, 0)), new Aanbieding("veld", "HDMI kabel", "Goede grasmaair, zgan", 2, DateTime.Now, new Gebruiker("veld", "veld", "veld", "veld", "veld", DateTime.Now, 0, 0)), new Aanbieding("veld", "De Nachtwacht", "Goede grasmaair, zgan", 7865491, DateTime.Now, new Gebruiker("veld", "veld", "veld", "veld", "veld", DateTime.Now, 0, 0)), new Aanbieding("veld", "Bos Gerberas", "Goede grasmaair, zgan", 8, DateTime.Now, new Gebruiker("veld", "veld", "veld", "veld", "veld", DateTime.Now, 0, 0)), new Aanbieding("veld", "Tractor", "Goede grasmaair, zgan", 123, DateTime.Now, new Gebruiker("veld", "veld", "veld", "veld", "veld", DateTime.Now, 0, 0)), new Aanbieding("veld", "De Titanic", "Goede grasmaair, zgan", 4328691, DateTime.Now, new Gebruiker("veld", "veld", "veld", "veld", "veld", DateTime.Now, 0, 0)), new Aanbieding("veld", "BUK raket installatie", "Goede grasmaair, zgan", 1, DateTime.Now, new Gebruiker("veld", "veld", "veld", "veld", "veld", DateTime.Now, 0, 0)), new Aanbieding("veld", "MAGA cap", "Goede grasmaair, zgan", 69, DateTime.Now, new Gebruiker("veld", "veld", "veld", "veld", "veld", DateTime.Now, 0, 0)), new Aanbieding("veld", "Toetsenboord", "Goede grasmaair, zgan", 9, DateTime.Now, new Gebruiker("veld", "veld", "veld", "veld", "veld", DateTime.Now, 0, 0)), new Aanbieding("veld", "Computer muis Te Huur", "Goede grasmaair, zgan", 87, DateTime.Now, new Gebruiker("veld", "veld", "veld", "veld", "veld", DateTime.Now, 0, 0)) };
            AanbiedingClient client = new AanbiedingClient();
            listView.ItemsSource = client.Get();
        }

        void OnImageTapped(object sender, EventArgs args)
        {
            var image = sender as Image;
            var viewCell = image.Parent.Parent as ViewCell;

            if (image.HeightRequest < 250)
            {
                image.HeightRequest = image.Height + 100;
                viewCell.ForceUpdateSize();
            }
        }

        public void OnClickMailBox()
        {
            App.Current.MainPage = new MessagePage();
        }
        public void OnClickOfferPage()
        {
            App.Current.MainPage = new OfferPage();
        }
        public void OnClickUserPage()
        {
            Gebruiker gebruikert = (Gebruiker)Xamarin.Forms.Application.Current.Properties["loggedIn"];
            App.Current.MainPage = new UserPage(gebruikert.GCode);
        }
        public void OnClickHubPage()
        {
            App.Current.MainPage = new HubPage();
        }

        private void OnClickAddOffer(object sender, EventArgs e)
        {
            App.Current.MainPage = new AddOffer();
        }

        private void OnClickRequestPage(object sender, ItemTappedEventArgs e)
        {
            App.Current.MainPage = new RequestPage();
        }
    }

    
    };


    

