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
            BindingContext = this;
            InitializeComponent();
            var items = Enumerable.Range(0, 10);
            listView.ItemsSource = items;
        }
        void OnImageTapped(object sender, EventArgs args)
        {
            var image = sender as Image;
            var viewCell = image.Parent.Parent as ViewCell;

            if (image.HeightRequest < 250)
            {
                image.HeightRequest = image.Height + 100;
                viewCell.ForceUpdateSize();
            }
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

    
    };


    

