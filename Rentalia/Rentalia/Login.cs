﻿using System;
using System.Collections.Generic;
using System.Text;
using Rentalia.Data;
using Xamarin.Forms;

namespace Rentalia
{
    public class Login : ContentPage
    {
        public Gebruiker loggedin;
        public bool CheckCredentials(string email, string pass)
        {
            if (email == /*HET OVEREENKOMENDE EMAIL ADRES UIT DATABASE, GEBASEERD OP PASS*/ && pass == /*HET OVEREENKOMENDE PASS ADRES UIT DATABASE, GEBASEERD OP EMAIL*/)
            {
                this.loggedin = new Gebruiker("Allon", "Allon", "Allon", "Allon", email, DateTime.Now, 0, 0, null, pass);
                return true;
            }
            else
            {
                DisplayAlert("Alert", "Het e-mail adres en wachtwoord komen niet overeen.", "Oke");
            }
        }
    }
}
