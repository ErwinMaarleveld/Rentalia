using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Rentalia.FieldCheckerMethod;
using Rentalia.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Rentalia
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HubPage : ContentPage
	{
		public HubPage ()
		{
            BindingContext = this;
			InitializeComponent ();
            Aanbieding[] hubAanbiedingen = new Aanbieding[] { new Aanbieding("veld", "Grasmaaier HUREN", "Goede grasmaair, zgan", 69, DateTime.Now, new Gebruiker("veld", "veld", "veld", "veld", "veld", DateTime.Now, 0, 0)), new Aanbieding("veld", "Opblaas zwembadje", "Goede grasmaair, zgan", 35, DateTime.Now, new Gebruiker("veld", "veld", "veld", "veld", "veld", DateTime.Now, 0, 0)), new Aanbieding("veld", "Tesla model X", "Goede grasmaair, zgan", 420, DateTime.Now, new Gebruiker("veld", "veld", "veld", "veld", "veld", DateTime.Now, 0, 0)) };
            stackView.ItemsSource = hubAanbiedingen;
        }

        public void OnClickMailBox(object sender, EventArgs e)
        {
            App.Current.MainPage = new MessagePage();
        }

        public void OnCLickUserPage(object sender, EventArgs e)
        {
            Gebruiker gebruikert = (Gebruiker)Xamarin.Forms.Application.Current.Properties["LoggedIn"];
            App.Current.MainPage = new UserPage(gebruikert.GCode);
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