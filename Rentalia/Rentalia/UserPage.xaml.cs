using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.FilePicker;
using Plugin.FilePicker.Abstractions;
using Rentalia.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Rentalia.FourMistakesAPIClient;

namespace Rentalia
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class UserPage : ContentPage
	{
		public UserPage (string gCode)
		{
			InitializeComponent ();
            var client = new GebruikerClient();
            Gebruiker ingelogdeGeruiker = (Gebruiker)Xamarin.Forms.Application.Current.Properties["loggedIn"];
            Gebruiker SelectedGebruiker = client.Get(ingelogdeGeruiker.GCode);
                //new Gebruiker("G0001", "Handige", "", "Harry", "handigehardeharry@gmail.com", DateTime.Now, 4.3423f, 27); //De gebruiker die overeen komt met de Gcode van de gebruiker waarop je hebt geklikt.
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
            Gebruiker gebruikert = (Gebruiker)Xamarin.Forms.Application.Current.Properties["LoggedIn"];
            App.Current.MainPage = new UserPage(gebruikert.GCode);
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

        async void OnUpload(object sender, EventArgs e)
        {
            try
            {

                FileData filedata = await CrossFilePicker.Current.PickFile();
                var a = new FieldCheckerMethod();
                a.AddFoto(filedata.FileName, "Entry field Titel", "Entry field Beschrijving", filedata.DataArray);

                // the dataarray of the file will be found in filedata.DataArray 
                // file name will be found in filedata.FileName;
                //etc etc.


            }
            catch (Exception ex)
            {
                await DisplayAlert("Alert", $"Error: {ex}", "Oke");
                //ExceptionHandler.ShowException(ex.Message);
            }
        }

    }
}