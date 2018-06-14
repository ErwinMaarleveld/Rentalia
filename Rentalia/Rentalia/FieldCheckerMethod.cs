using System;
using System.Collections.Generic;
using System.Text;
using Rentalia.Data;

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

        public Gebruiker AddGebruiker(string voornaam, string tussen, string achternaam, string email)
        {
            if IsFilled() && IsFlled() && IsFlled()
            {
                DateTime now = DateTime.Now;
                Gebruiker nieuweGebruiker = new Gebruiker(gcodeMETHode, voornaam, tussen, achternaam, email, now, 0, 0);
                return nieuweGebruiker;
            }
        }
    }
}
