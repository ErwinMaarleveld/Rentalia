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
    public partial class RequestPage : ContentPage
    {
        public string code {get;}
		public RequestPage ()
		{
			InitializeComponent ();
            Aanbieding currentAanbieding = new Aanbieding("testAanbieding", "Grasmaaier HUREN", "Goede grasmaair, zgan", 69, DateTime.Now, new Gebruiker("veld", "veld", "veld", "veld", "veld", DateTime.Now, 0, 0));
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
            App.Current.MainPage = new UserPage();
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