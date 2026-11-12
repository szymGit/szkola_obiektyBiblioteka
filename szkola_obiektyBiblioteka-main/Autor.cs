using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka
{
    public class Autor:Osoba
    {
        public Autor(string imie, string nazwisko) : base(imie, nazwisko)
        {
        
        }
        public override string ToString()
        {
            return imie+" "+nazwisko;
        }
    }
}