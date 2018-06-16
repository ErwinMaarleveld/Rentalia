using System;
using System.Collections.Generic;
using System.Text;

namespace Rentalia.Data
{
    public class Foto
    {
        public string Bestandsnaam { get; private set; }
        public string Titel { get; private set; }
        public string Beschrijving { get; private set; }

        public Foto(string bestandsnaam, string titel, string beschrijving)
        {
            if (beschrijving == null)
            {
                Beschrijving = "";
            }
            else
            {
                Beschrijving = beschrijving;
            }

            Bestandsnaam = bestandsnaam;
            Titel = titel;
        }
    }

    public class OptionalFoto : Foto
    {
        public OptionalFoto() : base("", "", "") { }
    }
}
