using BussinessLogic.Interfaces;
using BussinessLogic.Models;
using System.Web;

namespace BussinessLogic.Modeli.Artikli
{
    public class Hlace : Artikal, IShoping
    {
        public string Velicina { get; set; }

        public Hlace()
        {
            Vrsta = Enums.VrstaArtikla.Odjeca;
        }

    }
}
