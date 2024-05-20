using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    public class Gato : Animal
    {
        public Gato(string nombre) : base(nombre)
        {
        }

        public override void HacerSonido()
        {
            Console.WriteLine($"El {Nombre} hace: Miau Miau!");
        }

        public override void Moverse()
        {
            Console.WriteLine($"El {Nombre} camina en silencio");
        }
    }
}
