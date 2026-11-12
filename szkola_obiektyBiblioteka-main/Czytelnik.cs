using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Biblioteka
{
    public class Czytelnik:Osoba
    {
        private int nrEwidencyjny;
        private List<Ksiazka> wypozyczone;
        public Czytelnik(string imie, string nazwisko) : base(imie, nazwisko)
        {
            nrEwidencyjny = licznikOsob;
            wypozyczone = new List<Ksiazka>();
        }
        public override string ToString()
        {
            return "Imię: "+imie+" | nazwisko: "+nazwisko+" | nr Ewidencyjny: "+nrEwidencyjny;
        }
        public void wezKsiazke(Ksiazka ks)
        {
            if (ks.czyWzieta == false)
            {
                ks.czyWzieta = true;
                wypozyczone.Add(ks);
            }
        }
        public void oddajKsiazke(Ksiazka ks)
        {
            if (wypozyczone.Contains(ks))
            {
                ks.czyWzieta = false;
                wypozyczone.Remove(ks);
            }
        }
        public void maszCos()
        {
            foreach (Ksiazka k in wypozyczone)
            {
                Console.WriteLine("Tytuł: "+k.Tytul+" | Autor: "+k.autor.ToString());
            }
        }
    }
}