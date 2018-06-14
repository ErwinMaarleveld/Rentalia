using System;
using System.Collections.Generic;
using System.Text;

namespace Rentalia.Data
{
    public class Rapportage
    {
        public Gebruiker Rapporteerder { get; private set; }
        public Gebruiker Gerapporteerde { get; private set; }
        public DateTime Datumtijd { get; private set; }
        public string Klacht { get; private set; }

        public Rapportage(Gebruiker rapporteerder, Gebruiker gerapporteerde, DateTime datumtijd, string klacht)
        {
            Rapporteerder = rapporteerder;
            Gerapporteerde = gerapporteerde;
            Datumtijd = datumtijd;
            Klacht = klacht;
        }
    }
}
