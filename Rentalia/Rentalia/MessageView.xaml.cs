using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Rentalia.Data;
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
            Bericht[] alleBerichten = new Bericht[] { new Bericht(new Gebruiker("0005", "Bart", "van", "Velden", "BartvVelden@gmail.com", DateTime.Now, 0, 0), new Gebruiker("0009", "Harry", "", "Hertog", "Harry@Hertog.nl", DateTime.Now, 0, 0), new Aanbieding("veld", "Grasmaaier HUREN", "Goede grasmaair, zgan", 69, DateTime.Now, new Gebruiker("veld", "veld", "veld", "veld", "veld", DateTime.Now, 0, 0)), new Gebruiker("0005", "Bart", "van", "Velden", "BartvVelden@gmail.com", DateTime.Now, 0, 0), DateTime.Now, "Intresse in grasmaaier") };
            stackView.ItemsSource = alleBerichten;
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
            Gebruiker gebruikert = (Gebruiker)Xamarin.Forms.Application.Current.Properties["LoggedIn"];
            App.Current.MainPage = new UserPage(gebruikert.GCode);
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