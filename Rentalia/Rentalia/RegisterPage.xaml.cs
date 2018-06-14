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
	public partial class RegisterPage : ContentPage
	{
		public RegisterPage ()
		{
			InitializeComponent ();
		}

        public void OnClickLogin(object sender, EventArgs e)
        {
            App.Current.MainPage = new MainPage();
        }

        public void OnClickHub(object sender, EventArgs e)
        {
            var a = new FieldCheckerMethod();
            a.AddGebruiker(voornaam.ToString(), tussen.ToString(), achternaam.ToString(), email.ToString(), pass1.ToString(), pass2.ToString());
            App.Current.MainPage = new HubPage();
        }

    }
}