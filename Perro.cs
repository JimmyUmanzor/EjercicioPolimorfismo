using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    public class Perro : Animal
    {
        public Perro(string nombre) : base(nombre)
        {
        }

        public override void HacerSonido()
        {
            Console.WriteLine($"El {Nombre} hace: Guau Guau");
        }

        public override void Moverse()
        {
            Console.WriteLine($"El {Nombre} corre por la calle.");
        }
    }
}
