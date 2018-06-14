using System;
using System.Collections.Generic;
using System.Text;
using static Rentalia.Data.Gebruiker;
using static Rentalia.Data.Aanbieding;
using static Rentalia.Data.Bericht;
using static Rentalia.Data.Boeking;
using static Rentalia.Data.Foto;

namespace Rentalia
{
    public class FieldCheckerMethod
    {
        public bool IsFilled(string field)
        {
            if (field.Length > 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Gebruiker addGebruiker(string voornaam, string tussen, string achternaam, string email)
        {
            return new Gebruiker();
        }
    }
}
