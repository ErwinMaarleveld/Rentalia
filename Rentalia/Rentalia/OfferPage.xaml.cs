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
    public partial class OfferPage : ContentPage
    {
        public OfferPage()
        {
            InitializeComponent();
            List<Page> pages = new List<Page>();
            pages.Add(new HubPage());
            pages.Add(new RegisterPage());
            ListOfPages.ItemsSource = pages;
        }

        private void ListOfPages_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                this.Navigation.PushAsync((Page)e.SelectedItem);
            }

        }
    }
}