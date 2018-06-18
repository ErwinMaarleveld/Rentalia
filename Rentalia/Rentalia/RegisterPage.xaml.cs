﻿using System;
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

            if (a.IsFilled(email.Text) && a.IsFilled(voornaam.Text) && a.IsFilled(achternaam.Text) && a.IsFilled(pass1.Text) && a.PassEqual(pass1.Text, pass2.Text) && a.IsValidEmail(email.Text))
            {
                App.Current.MainPage = new HubPage();
            }
            if(!a.IsValidEmail(email.Text))
            {
                DisplayAlert("Alert", "Vul een geldige e-mail in.", "Oke");
            }
            if(!(a.IsFilled(email.Text) && a.IsFilled(voornaam.Text) && a.IsFilled(achternaam.Text) && a.IsFilled(pass1.Text) && a.PassEqual(pass1.Text, pass2.Text)))
            {
                DisplayAlert("Alert", "Je hebt niet alle verplichte velden ingevuld!", "Oke");
            }
        }

    }
}