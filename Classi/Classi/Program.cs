using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaPersone = new List<Persona>();
            var p1 = new Persona("Logitech", 900, new DateTime(2000, 2, 23));
            listaPersone.Add(p1);
            var p2 = new Persona("Epson", 1200, new DateTime(1998, 4, 15));
            listaPersone.Add(p2);
            var p3 = new Persona("Jeck", 1500, new DateTime(1996, 12, 18));
            listaPersone.Add(p3);
            new Persona("Astolfo", 1500, new DateTime(1996, 12, 18)); //questo non lo restiuisce, mentre quello sopra si.

            foreach (var Persona in listaPersone)
            {
                Console.WriteLine(Persona.ToString() + "\n");  
            }
            Console.ReadKey();
        }
    }
}
