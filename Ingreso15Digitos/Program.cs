using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingreso15Digitos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write( "\n" + "  Ingrese un número de 15 dígitos : ");
            long numero = Convert.ToInt64(Console.ReadLine()); //I use "long" because is a number with 15 digits
            //123456789123456
            long primerNumero = numero % 100000; //23456
            long segundoNumero = ((numero - primerNumero) / 100000) % 100000;
            long tercerNumero = numero / 10000000000;

            long suma = primerNumero + segundoNumero + tercerNumero;

            Console.Write("\n" + "  El primer número es : " + primerNumero);
            Console.Write("\n" + "\n" + "  El segundo número es : " + segundoNumero);
            Console.Write("\n" + "\n" + "  El tercer número es : " + tercerNumero);
            Console.Write("\n" + "\n" + "  La suma de los números es : " + suma);
            Console.ReadKey();
        }
    }
}
