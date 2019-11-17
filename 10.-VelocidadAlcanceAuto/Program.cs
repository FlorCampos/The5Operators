using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._VelocidadAlcanceAuto
{
    class Program
    {
        static void Main(string[] args)
        {
            double velocidadAutoA = 70;
            double velocidadAutoB = 90;
            double distanciaRecorridaAutoA = velocidadAutoA * 3; // e = v *  t 

            double tiempoDeAlcance = distanciaRecorridaAutoA / (velocidadAutoB - velocidadAutoA);

            Console.WriteLine("\n" + "  Tiempo de alcance : " + tiempoDeAlcance);
            Console.ReadKey();
        }
    }
}
