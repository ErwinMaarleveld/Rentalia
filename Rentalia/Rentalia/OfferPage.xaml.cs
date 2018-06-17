using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Rentalia.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Rentalia
{


    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OfferPage : ContentPage
    {
        public OfferPage()
        {
            InitializeComponent();
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

        private void OnClickAddOffer(object sender, EventArgs e)
        {
            App.Current.MainPage = new AddOffer();
        }

    }

    public class ListOffers : OfferPage
        {
            public string title { get; set; }
            public float num { get; set; }
            public string imgsource { get; set; }
           

            public void GenerateList()
            {
                List<string[]> lijst = new List<string[]>();
                foreach (string[] l in lijst)
                {
                    Aanbieding[] AlleAanbiedingen = []; //Allon, work your magic!
                    foreach (Aanbieding offer in AlleAanbiedingen)
                    {
                        string[] item = { offer.Titel, offer.Huurprijs.ToString(), offer.Gebruiker.Voornaam, offer.Fotos[0].ToString() };
                        lijst.Add(item);
                    
                    }

                }
            }
        }
    };


    

