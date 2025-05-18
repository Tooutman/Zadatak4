using BussinessLogic.Enums;
using BussinessLogic.Interfaces;
using BussinessLogic.Models;

namespace BussinessLogic.Modeli.Artikli
{
    public class Majica : Artikal
    {
        public string Velicina { get; set; }
        public Majica()
        {
            Vrsta = VrstaArtikla.Odjeca;
        }

    }
}
