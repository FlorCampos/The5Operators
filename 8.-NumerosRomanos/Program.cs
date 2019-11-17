using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._NumerosRomanos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n" + "  Ingrese valor de 10 dígitos : ");
            int valorIngresado = Convert.ToInt32(Console.ReadLine());

            //Ingreso: 1201010150
            int valor100 = valorIngresado / 100000000;
            int valor50 = valorIngresado % 100000000 / 1000000;
            int valor10 = valorIngresado % 10000 / 100;
            int valor5 = valorIngresado % 100 / 10;
            int valor1 = valorIngresado % 10;

            int sumaTotal = valor100 * 100 + valor50 * 50 + valor10 * 10 + valor5 * 5 + valor1 * 1;


            Console.WriteLine(" Cantidad de Billetes de 100 : " + valor100);
            Console.WriteLine(" Cantidad Billetes de 50 : " + valor50);
            Console.WriteLine(" Cantidad Billetes de 10 : " + valor10);
            Console.WriteLine(" Cantidad Monedas de 5 : " + valor5);
            Console.WriteLine(" Cantidad Monedas de 1 : " + valor1);
            Console.WriteLine(" Total en S/. " + sumaTotal);
            Console.ReadKey();
        }
    }
}
