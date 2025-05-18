using BussinessLogic.Interfaces;
using BussinessLogic.Models;

namespace BussinessLogic.Modeli.Artikli
{
    public class Cipela : Artikal
    {
        public short Broj { get; set; }
        public Cipela()
        {
            Vrsta = Enums.VrstaArtikla.Obuca;
        }
    
    }
}
