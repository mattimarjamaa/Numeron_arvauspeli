using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeron_arvauspeli
{
    class Program
    {
        static void Main(string[] args)
        {
        Alku:
            Random rand = new Random();
            int arvaus = 0;
            int numero = rand.Next(1, 100);
            Console.WriteLine("Arvaa numero väliltä 1 ja 100");


            int i = 0;

            while (arvaus != numero)
            {
                try
                {
                    arvaus = Convert.ToInt32(Console.ReadLine());


                    if (arvaus > numero)
                    {
                        if (arvaus <= numero + 5)
                        {
                            Console.WriteLine("Polttaa");
                        }

                        else
                        {

                            Console.WriteLine("Se on pienempi kuin arvaus");
                        }

                    }

                    if (arvaus < numero)
                    {
                        if (arvaus >= numero - 5)
                        {
                            Console.WriteLine("Polttaa");
                        }

                        else
                        {

                            Console.WriteLine("Se on isompi kuin arvaus");
                        }
                    }
                }

                catch
                {
                    Console.WriteLine("Arvauksen pitää olla numero");
                    i--;
                }


                i++;
            }
            Console.WriteLine("Onnistui! Peli vei sinulta " + i + " vuoroa!");
            Console.ReadLine();
            Console.WriteLine("Uusi peli K/E?");
            string vastaus = Console.ReadLine();
            if (vastaus == "K" | vastaus == "k")
            {
                goto Alku;
            }




        }
    }
}
