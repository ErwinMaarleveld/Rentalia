﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.OS;
using Java.IO;
using Rentalia.Data;
using Xamarin.Forms;

namespace Rentalia
{
    public class FieldCheckerMethod : ContentPage
    {
        public bool IsFilled(string field)
        {
            try
            {
                if ((field.Length > 0) && field != ("Xamarin.Forms.Entry"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(System.NullReferenceException)
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

        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
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
            else if (!(PassEqual(pass1, pass2)))
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

        public Aanbieding AddAanbieding(string title, string desc, float prijs, Gebruiker ingelogd)
        {
            string prijsje = prijs.ToString();
            try
            {
                if (IsFilled(prijsje) && IsFilled(title) && IsFilled(desc))
                {
                    Aanbieding nieuweAanbieding = new Aanbieding("defaultACode", title, desc, prijs, DateTime.Now, (Gebruiker)Xamarin.Forms.Application.Current.Properties["loggedIn"]);
                    return nieuweAanbieding;
                }
                else
                { 
                    return null;
                }
            }
            catch(System.NullReferenceException)
            {
                DisplayAlert("Alert", "Je hebt niet alle velden ingevoerd.", "Oke");
                return null;
            }
        }

        public Bericht AddBericht(string tekst, Aanbieding onderwerp, Gebruiker ontvanger)
        {
            if (IsFilled(tekst))
            {
                Bericht nieuwBericht = new Bericht(ontvanger, (Gebruiker)Xamarin.Forms.Application.Current.Properties["loggedIn"], onderwerp, onderwerp.Gebruiker, DateTime.Now, tekst);
                return nieuwBericht;
            }
            else
            {
                DisplayAlert("Alert", "Je probeert een bericht zonder tekst te versturen.", "Oke");
                return null;
            }
            
        }

        public Bericht FirstMessage(Aanbieding onderwerp)
        {
            var ingelogdeGebruiker = (Gebruiker)Xamarin.Forms.Application.Current.Properties["loggedIn"];
            var firstMessage = AddBericht($"{ingelogdeGebruiker.Voornaam} heeft interesse in uw {onderwerp.Titel}!", onderwerp, onderwerp.Gebruiker);
            return firstMessage;
        }
        public Foto AddFoto(string bestandsnaam, string titel, string beschrijving, Byte[] dataArray)
        {
            if(IsFilled(bestandsnaam.ToString()) && IsFilled(Title.ToString()))
            {
                Foto nieuweFoto = new Foto(bestandsnaam.ToString(), titel.ToString(), beschrijving.ToString());
                return nieuweFoto; //dataArray moet nog in assests gedouwt worden
            }
            else
            {
                return null;
            }
        }
    }
}
