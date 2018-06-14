using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Rentalia.Data;
using Xamarin.Forms;

namespace Rentalia
{
    public class FieldCheckerMethod : ContentPage
    {
        public bool IsFilled(string field)
        {
            if ((field.Length > 1) && field != ("Xamarin.Forms.Entry"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool PassEqual(string pass1, string pass2)
        {
            if (pass1 == pass2)
            {
                return true;
            }
            else
            {
                DisplayAlert("Alert", "Je ingevulde wachtwoorden komen niet overeen!", "Oke");
                return false;
            }
        }

        public Gebruiker AddGebruiker(string voornaam, string tussen, string achternaam, string email, string pass1, string pass2)
        {
            if (IsFilled(email) && IsFilled(voornaam) && IsFilled(achternaam) && IsFilled(pass1) && PassEqual(pass1, pass2))
            {
                DateTime now = DateTime.Now;
                Gebruiker nieuweGebruiker = new Gebruiker("420691337yoMum", voornaam, tussen, achternaam, email, now, 0, 0);
                
                return nieuweGebruiker;
            }
            else
            {
                DisplayAlert("Alert", "Je hebt niet alle verplichte velden ingevuld!", "Oke");
                return null;
            }
        }
    }
}
