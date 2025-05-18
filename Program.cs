using BussinessLogic.Enumeratori;
using BussinessLogic.Modeli;
using BussinessLogic.Modeli.Artikli;
using BussinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak4
{
    internal class Program
    {
        static void Main(string[] args)

        {
            //Zadatak 4.
            //Izraditi program koji sastavlja outfit(odjecu) u web trgovini, koristeći klase koje mogu naslijeđivati osobine artikala te nuditi popis
            //korištenih (izabranih) komada odjeće. Program bi mogao iskoristiti značjake koje smo obrađivali, poput: naslijeđivanja, enumeracije, listi i slično po smislu.
            //Pretpostavlja se unos artikala putem kontole i ispis odabrane/unesene odjeće putem konzole u boji!

            var narudzba = new Outfit(DateTime.Now);

           
            bool prvi = true;
            while (true)
            {
                MojaKonzola.Boja = ConsoleColor.Green;
                if (!prvi)
                {
                    MojaKonzola.WriteLine("Želite li još unjeti koji artikal? Y) N)");
                    var odgovor = Console.ReadLine();

                    if (odgovor.ToUpper() == "N")
                    {
                        break;
                    }
                }

                prvi = false;

                MojaKonzola.WriteLine("Unesite osnovne podatke artikla:");
                MojaKonzola.WriteLine("Sifra artikla:");
                var sifra = Console.ReadLine();
                MojaKonzola.WriteLine("Naziv artikla:");
                var naziv = Console.ReadLine();
                MojaKonzola.WriteLine("Cijena artikla:");
                decimal cijena = decimal.Parse(Console.ReadLine());
                MojaKonzola.WriteLine("Količina:");
                int kolicina = int.Parse(Console.ReadLine());
                //MojaKonzola.WriteLine("Stanje:");
                //int stanje = int.Parse(Console.ReadLine());



                MojaKonzola.Boja = ConsoleColor.Magenta;

                MojaKonzola.WriteLine("Odaberi vrstu artkla:");
                MojaKonzola.WriteLine("1) Cipela");
                MojaKonzola.WriteLine("2) Hlace");
                MojaKonzola.WriteLine("3) Majica");
                MojaKonzola.WriteLine("4) Kapa");

                var unos = Console.ReadLine();


                if (Enum.TryParse<VrstaOdabranogArtikla>(unos, true, out VrstaOdabranogArtikla odabrano))
                {
                    Artikal artikal = null;
                    switch (odabrano)
                    {
                        case VrstaOdabranogArtikla.Cipela:
                            artikal = new Cipela() { Sifra = sifra, Naziv = naziv, Cijena = cijena, Kolicina = kolicina };
                            MojaKonzola.WriteLine("Broj cipele:");
                            ((Cipela)artikal).Broj = short.Parse(Console.ReadLine());
                            break;
                        case VrstaOdabranogArtikla.Hlace:
                            artikal = new Hlace() { Sifra = sifra, Naziv = naziv, Cijena = cijena, Kolicina = kolicina };
                            MojaKonzola.WriteLine("Veličina:");
                            ((Hlace)artikal).Velicina = Console.ReadLine();
                            break;
                        case VrstaOdabranogArtikla.Majica:
                            artikal = new Majica() { Sifra = sifra, Naziv = naziv, Cijena = cijena, Kolicina = kolicina };
                            MojaKonzola.WriteLine("Veličina:");
                            ((Majica)artikal).Velicina = Console.ReadLine();
                            break;
                        case VrstaOdabranogArtikla.Kapa:
                            artikal = new Kapa() { Sifra = sifra, Naziv = naziv, Cijena = cijena, Kolicina = kolicina };
                            break;
                    }

                    if (artikal != null)
                    {
                        narudzba.Add(artikal);
                    }
                }
                else
                {
                    MojaKonzola.Boja = ConsoleColor.Red;
                    MojaKonzola.WriteLine("Neispravan unos");
                    break;
                }


            }

            //Izlaz
            MojaKonzola.Boja = ConsoleColor.Yellow;
            MojaKonzola.WriteLine($"Ukupni račun za navedenu kupnju {narudzba.DatumKupnje:d} je: {narudzba.UkupnaProdajnaCijena:F2} EUR");





        }
    }
}
