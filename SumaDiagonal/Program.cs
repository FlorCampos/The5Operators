using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n" + " Ingrese Valor 1 : ");
            int valor1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n" + " Ingrese Valor 2 : ");
            int valor2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n" + " Ingrese Valor 3 : ");
            int valor3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n" + " Ingrese Valor 4 : ");
            int valor4 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n" + " Ingrese Valor 5 : ");
            int valor5 = Convert.ToInt32(Console.ReadLine());

            int sumaDigitosPrimeraDiagonal = valor1 / 10000 + valor2 / 1000 % 10 + valor3 % 1000 /100 + valor4 % 100 / 10 + valor5 % 10;
            int sumaDigitosSegundaDiagonal = valor1 %10 + valor2 % 100 / 10 + valor3 % 1000 / 100 + valor4 % 10000 / 1000 + valor5 / 10000;
            int productoDeSumas = sumaDigitosPrimeraDiagonal * sumaDigitosSegundaDiagonal;
            
            Console.WriteLine("\n" + "  Suma de dígitos de primera diagonal : " + sumaDigitosPrimeraDiagonal);
            Console.WriteLine("\n" + "  Suma de dígitos de segunda diagonal : " + sumaDigitosSegundaDiagonal);
            Console.WriteLine("\n" + "  Cantidad de tanques disponibles : " + productoDeSumas);
            Console.ReadKey();
        }
    }
}
