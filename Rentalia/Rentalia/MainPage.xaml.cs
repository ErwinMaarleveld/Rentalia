using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Rentalia
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
        }



        public void OnClickRegister(object sender, EventArgs e)
        {
            App.Current.MainPage = new RegisterPage();
        }

        public void OnClickHub(object sender, EventArgs e)
        {//Sign-in / login brings you here
            var b = new Login();
            if (b.CheckCredentials(email.ToString(), pass.ToString()))
            {
                App.Current.MainPage = new HubPage();
            }
            else
            {
                DisplayAlert("Alert", "Het e-mail adres en wachtwoord komen niet overeen.", "Ben ik lekker mee...");
            }
        }

    }
}
