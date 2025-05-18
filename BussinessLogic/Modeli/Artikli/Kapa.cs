using BussinessLogic.Enumeratori;
using BussinessLogic.Interfaces;
using BussinessLogic.Models;

namespace BussinessLogic.Modeli.Artikli
{
    public class Kapa : Artikal
    {

        public VrstaKape VrstaKape { get; set; }
        public Kapa()
        {
            Vrsta = Enums.VrstaArtikla.ModniDodaci;
        }

    }
}
