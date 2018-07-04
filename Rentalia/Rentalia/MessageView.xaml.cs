using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Rentalia.Data;
using Rentalia.FourMistakesAPIClient;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Rentalia
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MessageView : ContentPage
	{
		public MessageView ()
		{
            BindingContext = this;
			InitializeComponent ();
            BerichtClient client = new BerichtClient();
            var a = (Gebruiker)Xamarin.Forms.Application.Current.Properties["loggedIn"];
            Bericht[] bericht = new Bericht[] { client.Get(a.GCode)[0] };
            stackView.ItemsSource = bericht;
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

        public void OnClickReply()
        {
            App.Current.MainPage = new ReplyPage();
        }
    }
}