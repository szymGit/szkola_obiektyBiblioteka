using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka
{
    public abstract class Osoba
    {
        protected string imie;
        protected string nazwisko;
        protected static int licznikOsob = 0;

        public Osoba(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            licznikOsob++;
        }
    }
}