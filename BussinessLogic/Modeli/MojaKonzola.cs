using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic.Modeli
{
    public static class MojaKonzola
    {

        public static ConsoleColor Boja { get; set; }
        public static void WriteLine(string value)
        {
            Console.ForegroundColor = Boja;
            Console.WriteLine(value);
            Console.ResetColor();
        }
       
    }
}
