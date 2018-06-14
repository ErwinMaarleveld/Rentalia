using System;
using System.Collections.Generic;
using System.Text;

namespace Rentalia.Data
{
    public class Aanbieding
    {
        public string ACode { get; private set; }
        public string Titel { get; protected set; }
        public string Beschrijving { get; protected set; }
        public float Huurprijs { get; protected set; }
        public DateTime Geplaatsd { get; protected set; }
        public Gebruiker Gebruiker { get; protected set; }
        public Foto[] Fotos { get; protected set; }
        public DateTime BeschikbaarVan { get; set; }
        public DateTime BeschikbaarTot { get; set; }

        public Aanbieding(string aCode, string titel, string beschrijving, float huurprijs, DateTime geplaatsd, Gebruiker gebruiker, Foto[] fotos = null)
        {
            ACode = aCode;
            Titel = titel;
            Beschrijving = beschrijving;
            Huurprijs = huurprijs;
            Geplaatsd = geplaatsd;
            Gebruiker = gebruiker;
            if (fotos == null)
            {
                Fotos = new Foto[] { new OptionalFoto() };
            }
            else
            {
                Fotos = fotos;
            }
            BeschikbaarVan = DateTime.MaxValue;
            BeschikbaarTot = DateTime.MaxValue;
        }
    }
}
