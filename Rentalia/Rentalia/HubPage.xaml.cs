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
	public partial class HubPage : ContentPage
	{
		public HubPage ()
		{
			InitializeComponent ();
		}

        public void OnClickMailBox(object sender, EventArgs e)
        {
            App.Current.MainPage = new MainPage();
        }

        public void OnCLickUserPage(object sender, EventArgs e)
        {
            App.Current.MainPage = new UserPage();
        }

        public void OnCLickLogOut(object sender, EventArgs e)
        {
            App.Current.MainPage = new MainPage();
        }

        public void OnClickOfferPage(object sender, EventArgs e)
        {
            App.Current.MainPage = new OfferPage();
        }

        private void OnClickAddOffer(object sender, EventArgs e)
        {
            App.Current.MainPage = new AddOffer();
        }
    }
}