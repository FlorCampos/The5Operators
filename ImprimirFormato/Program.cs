using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImprimirFormato
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n" + "  Ingrese valor de 6 dígitos : ");
            int numero6Digitos = Convert.ToInt32(Console.ReadLine());
            // Ingreso: 463527
            int valor1 = numero6Digitos / 100000;
            int valor2 = numero6Digitos % 100000 / 10000;
            int valor3 = numero6Digitos % 10000 / 1000;
            int valor4 = numero6Digitos % 1000 / 100;
            int valor5 = numero6Digitos % 100 / 10;
            int valor6 = numero6Digitos % 10;

            Console.WriteLine("\n" + "  Salida : " + valor1 + valor6 + valor2 + valor5 + valor3 + valor4);
            Console.ReadKey();
        }
    }
}
