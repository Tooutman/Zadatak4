using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic.Interfaces
{
    internal interface IShoping
    {
        int Stanje { get;  }
        decimal Cijena { get; set; }
        int Kolicina { get; set; }

        decimal Prodaj();
        decimal Naruci();
    }
}
