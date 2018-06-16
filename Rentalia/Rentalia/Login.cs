using System;
using System.Collections.Generic;
using System.Text;
using Rentalia.Data;
using Xamarin.Forms;


namespace Rentalia
{
    public class Login
    {
        public bool CheckCredentials(string email, string pass)
        {
            var a = new FieldCheckerMethod();
            if (/*HET OVEREENKOMENDE EMAIL ADRES UIT DATABASE, GEBASEERD OP PASS*//*HET OVEREENKOMENDE PASS ADRES UIT DATABASE, GEBASEERD OP EMAIL*/a.IsFilled(email) && a.IsFilled(pass)) 
            {
                Application.Current.Properties ["loggedIn"] = new Gebruiker("Allon", "Allon", "Allon", "Allon", email, DateTime.Now, 0, 0, null, pass);
                return true;
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
