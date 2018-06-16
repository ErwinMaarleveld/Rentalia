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
	public partial class UserPage : ContentPage
	{
		public UserPage ()
		{
			InitializeComponent ();
		}

        public void OnClickMailBox(object sender, EventArgs e)
        {
            App.Current.MainPage = new MessagePage();
        }

        public void OnCLickUserPage(object sender, EventArgs e)
        {
            App.Current.MainPage = new UserPage();
        }

        public void OnCLickHubPage(object sender, EventArgs e)
        {
            App.Current.MainPage = new HubPage();
        }

        public void OnCLickOfferPage(object sender, EventArgs e)
        {
            App.Current.MainPage = new OfferPage();
        }

        private void OnClickAddOffer(object sender, EventArgs e)
        {
            App.Current.MainPage = new AddOffer();
        }

    }
}