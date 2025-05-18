using BussinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic.Models
{
    public class Outfit : List<Artikal>
    {
        public DateTime DatumKupnje { get; set; }


        public decimal UkupnaProdajnaCijena
        {
            get
            {
                decimal ukupno = 0;
                foreach (IShoping item in this)
                {
                    ukupno += item.Prodaj();
                }

                return ukupno;
            }

        }


        public Outfit(DateTime datumKupnje)
        {
            DatumKupnje = datumKupnje;
        }
    }
}
