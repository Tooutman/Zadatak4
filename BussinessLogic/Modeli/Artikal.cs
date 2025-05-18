using BussinessLogic.Enums;
using BussinessLogic.Interfaces;
using System;

namespace BussinessLogic.Models
{
    public abstract class Artikal : IShoping
    {
        public string Sifra { get; set; }
        public string Naziv { get; set; }
        public VrstaArtikla Vrsta { get; set; }
        public int Stanje { get; set; } = 20;
        public decimal Cijena { get; set; }
        public int Kolicina { get; set; }

        public decimal Prodaj()
        {
            Stanje -= Kolicina;

            return Kolicina * Cijena;
        }

        public decimal Naruci()
        {
            Stanje += Kolicina;

            return Kolicina * Cijena;
        }
    }
}
