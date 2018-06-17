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

        public List<List<string>> GenerateList()
        {
            //FrontList.ItemsSource = new List<List<string>>();
            List<List<string>> lijst = new List<List<string>>(); //Generate list

            Aanbieding[] alleAanbiedingen = new Aanbieding[1];
            foreach (Aanbieding offer in alleAanbiedingen) //Fill in list
            {
                List<string> sublijst = new List<string>();
                sublijst.Add(offer.Titel);
                sublijst.Add(offer.Huurprijs.ToString());
                sublijst.Add(offer.Fotos[0].ToString());
                lijst.Add(sublijst);
            }

            return lijst;
        }

    }

    
    };


    

