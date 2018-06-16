﻿using System;
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
                Gebruiker nieuweGebruiker = new Gebruiker("defaultGCode", voornaam, tussen, achternaam, email, now, 0, 0, null, pass1);
                
                return nieuweGebruiker;
            }
            else if (!(IsFilled(email) && IsFilled(voornaam) && IsFilled(achternaam) && IsFilled(pass1) && IsFilled(pass2)))
            {
                DisplayAlert("Alert", "Je hebt niet alle verplichte velden ingevuld!", "Oke");
                return null;
            }
            else if(!(PassEqual(pass1, pass2)))
            {
                DisplayAlert("Alert", "De wachtwoorden die je hebt ingevuld komen niet overeen.", "Oke");
                return null;
            }
            else
            {
                DisplayAlert("Alert", "Error", "Ben ik lekker mee...");
                return null;
            }
        }

        public Aanbieding AddAanbieding(string title, string desc, float prijs, DateTime geplaatst, Gebruiker ingelogd)
        {
            var z = new Login();
            if (IsFilled(title) && IsFilled(desc) && IsFilled(prijs.ToString()) && IsFilled(ingelogd.Voornaam))
            {
                Aanbieding nieuweAanbieding = new Aanbieding("defaultACode", title, desc, prijs, geplaatst, z.loggedin);
            }
            else
            {
                DisplayAlert("Alert", "Je hebt niet alle velden ingevoerd.", "Oke");
                return null;
            }
        }
    }
}
