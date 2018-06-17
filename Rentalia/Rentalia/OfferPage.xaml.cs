using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

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

        
        public ObservableCollection<string> Items { get; set; }
        public void OfferList()
        {
            public string name { get; set; }
            public string title { get; set; }
            public string desc { get; set; }
            public float price { get; set; }
        

            lst.ItemsSource = new List<Contacts>() {  
                new Contacts()
                    {
                        Name = "Umair", Num = "0456445450945", imgsource = "http://bit.ly/2oDQpPT",  
                    },  
                    new Contacts()
                    {
                        Name = "Cat", Num = "034456445905", imgsource = "http://gtty.im/2psFEos",  
                    },  
                    new Contacts()
                    {
                        Name = "Nature", Num = "56445905", imgsource = "http://gtty.im/2psFEos",  
                    },  
            };

    ObservableCollection<string> Items = new ObservableCollection<string>
            {
                "Item 1",
                "Item 2",
                "Item 3",
                "Item 4",
                "Item 5"
            };

            MyListView.ItemsSource = (ObservableCollection<string>)Items;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
    

    
}
