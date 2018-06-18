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
	public partial class UserPage : ContentPage
	{
		public UserPage ()
		{
			InitializeComponent ();
            Gebruiker SelectedGebruiker = new Gebruiker("G0001", "Handige", "", "Harry", "handigehardeharry@gmail.com", DateTime.Now, 4.3423f, 27); //De gebruiker die overeen komt met de Gcode van de gebruiker waarop je hebt geklikt.
            string profielnaam = $"{SelectedGebruiker.Voornaam} {SelectedGebruiker.Tussenvoegsel} {SelectedGebruiker.Achternaam}";
            string profielsinds = SelectedGebruiker.LidGeworden.Year.ToString();
            //string profielfoto = Path naar profiel foto in database

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