using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapicesFaberCastell
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n" + "  Ingrese la cantidad de lápices : ");
            long cantidadLapices = Convert.ToInt64(Console.ReadLine());

            long cajasDeCien = cantidadLapices / 100;
            long cajasDe50 = cantidadLapices % 100 / 50;
            long cajasDeDiez = cantidadLapices % 100 % 50 / 10;
            long bolsitas = cantidadLapices % 100 % 50 % 10;

            Console.WriteLine("\n" + "Cajas de ciento : " + cajasDeCien);
            Console.WriteLine("\n" + "Cajas de medio ciento : " + cajasDe50);
            Console.WriteLine("\n" + "Cajas de una decena : " + cajasDeDiez);
            Console.WriteLine("\n" + "Lápiz en bolsita : " + bolsitas);
            Console.ReadKey();
        }
    }
}
