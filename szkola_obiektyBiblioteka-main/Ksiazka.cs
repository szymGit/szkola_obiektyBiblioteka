using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka
{
    public class Ksiazka
    {
        public string Tytul { get; set; }
        public Autor autor { get; set; }
        public bool czyWzieta;
        public Ksiazka(string tytul, Autor autor)
        {
            this.Tytul = tytul;
            this.autor = autor;
            this.czyWzieta = false;
        }
    }
}