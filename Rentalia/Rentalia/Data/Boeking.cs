using System;
using System.Collections.Generic;
using System.Text;

namespace Rentalia.Data
{
    public class Boeking
    {
        public Aanbieding Aanbieding { get; private set; }
        public Gebruiker Verhuurder { get; private set; }
        public Gebruiker Huurder { get; private set; }
        public Foto FotoIn { get; private set; }
        public Foto FotoUit { get; private set; }
        public DateTime GereserveerdIn { get; private set; }
        public DateTime GereserveerdUit { get; private set; }
        public DateTime DatumIn { get; private set; }
        public DateTime DatumUit { get; private set; }

        public Boeking(Aanbieding aanbieding, Gebruiker verhuurder, Gebruiker huurder, DateTime gereserveerdIn, DateTime gereserveerdUit)
        {
            Aanbieding = aanbieding;
            Verhuurder = verhuurder;
            Huurder = huurder;
            GereserveerdIn = gereserveerdIn;
            GereserveerdUit = gereserveerdUit;
        }
    }
}
