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
            new Persona("Pippo", 800, new DateTime(2000, 2, 23));
            new Persona("Astolfo", 1500, new DateTime(1996, 12, 18));

            foreach (var Persona in listaPersone)
            {
                Console.WriteLine(Persona.ToString() + "\n");
                Console.ReadKey();
            }
        }
    }
}
