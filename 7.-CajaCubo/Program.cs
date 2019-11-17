using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._CajaCubo
{
    class Program
    {
        static void Main(string[] args)
        {
            long volumenCaja = 3;
            double volumenCajon = 1.5 * 1000000;

            double numeroCajas = volumenCajon / volumenCaja;

            Console.WriteLine("\n" + "  Número de cajas : " + numeroCajas);
            Console.ReadKey();
        }
    }
}
