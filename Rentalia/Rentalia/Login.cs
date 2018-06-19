using System;
using System.Collections.Generic;
using System.Text;
using Rentalia.Data;
using Xamarin.Forms;
using Rentalia.FourMistakesAPIClient;


namespace Rentalia
{
    public class Login
    {
        public bool CheckCredentials(string email, string pass)
        {
            var a = new FieldCheckerMethod();
            var client = new GebruikerClient();
            if (a.IsFilled(email) && a.IsFilled(pass))
            {
                Gebruiker gebruiker = client.Get(email);
                if (gebruiker.Wachtwoord == pass)
                {
                    Application.Current.Properties["loggedIn"] = gebruiker;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                
                return false;
            }
        }

        public bool IsLoggedIn()
        {
            if (Application.Current.Properties.ContainsKey("loggedIn"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
