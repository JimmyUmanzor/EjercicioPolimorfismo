using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Animal miPerro = new Perro("Sultán");
            Animal miGato = new Gato("Michi");

            MostrarInformacion(miPerro);
            MostrarInformacion(miGato);
        }

        static void MostrarInformacion(Animal animal)
        {
            animal.HacerSonido();
            animal.Moverse();
            Console.WriteLine();
            Console.ReadLine();
            }
    }
}
