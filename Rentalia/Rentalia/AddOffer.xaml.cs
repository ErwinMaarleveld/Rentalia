using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Rentalia.Data;

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
            var c = new FieldCheckerMethod();
            if (c.IsFilled(price.Text) && c.IsFilled(title.Text) && c.IsFilled(desc.Text))
            {
                c.AddAanbieding(title.ToString(), desc.ToString(), float.Parse(price.Text), (Gebruiker)Application.Current.Properties["loggedIn"]);
                App.Current.MainPage = new HubPage();
            }
            else
            {
                DisplayAlert("Alert", "Je hebt niet alle velden ingevoerd.", "Oke");
            }
            
        }

    }
}