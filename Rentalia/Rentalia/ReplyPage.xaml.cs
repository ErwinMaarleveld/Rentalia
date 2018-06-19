using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Rentalia.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Rentalia.Data;

namespace Rentalia
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ReplyPage : ContentPage
	{
		public ReplyPage ()
		{
            BindingContext = this;
			InitializeComponent ();
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
            Gebruiker ingelodgeGebruiker = (Gebruiker)Xamarin.Forms.Application.Current.Properties["LoggedIn"];
            App.Current.MainPage = new UserPage(ingelodgeGebruiker.GCode);
        }
        public void OnClickHubPage()
        {
            App.Current.MainPage = new HubPage();
        }

        public void OnClickAddOffer()
        {
            App.Current.MainPage = new AddOffer();
        }
    }
}