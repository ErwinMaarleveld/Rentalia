using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Rentalia
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddOffer : ContentPage
	{
		public AddOffer ()
		{
			InitializeComponent ();
		}
        public void OnClickMailBox(object sender, EventArgs e)
        {
            App.Current.MainPage = new MainPage();
        }
        public void OnClickOfferPage(object sender, EventArgs e)
        {
            App.Current.MainPage = new OfferPage();
        }
        
        public void OnClickUserPage(object sender, EventArgs e)
        {
            App.Current.MainPage = new UserPage();
        }

        public void OnClickHubPage(object sender, EventArgs e)
        {
            App.Current.MainPage = new HubPage();
        }

        public void OnClickPlaceOffer(Object sender, EventArgs e)
        {
            App.Current.MainPage = new HubPage();
        }

    }
}