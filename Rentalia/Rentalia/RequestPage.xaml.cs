using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Rentalia.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Rentalia.FourMistakesAPIClient;

namespace Rentalia
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RequestPage : ContentPage
    {
		public RequestPage (string aCode)
		{
            BindingContext = this;
			InitializeComponent ();
            //Aanbieding[] currentAanbieding = new Aanbieding[] { new Aanbieding("testAanbieding", "Grasmaaier HUREN", "Goede grasmaair, JeWeetToch", 69, DateTime.Now, new Gebruiker("0001", "Bert", "van", "Torens", "bert@appel.nl", DateTime.Now, 0, 0)) };
            AanbiedingClient client = new AanbiedingClient();
            Aanbieding[] aanbiedingen = new Aanbieding[] { client.Get(aCode) };
            stackView.ItemsSource = aanbiedingen;
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
            App.Current.MainPage = new AnotherUserPage(gebruikert.GCode);
        }

        public void OnClickHubPage()
        {
            App.Current.MainPage = new HubPage();
        }

        public void OnClickAddOffer()
        {
            App.Current.MainPage = new AddOffer();
        }

        public void OnClickSentRequest()
        {
            DisplayAlert("Alert", "Het verzoek is ingediend.", "Oke");
            App.Current.MainPage = new OfferPage();
        }

    }
}