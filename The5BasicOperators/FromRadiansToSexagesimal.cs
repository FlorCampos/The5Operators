using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The5BasicOperators
{
    class FromRadiansToSexagesimal
    {
        static void Main(string[] args)
        {
            /*1. Que lea el valor de un ángulo en radianes, luego que calcule y muestre su valor 
             * en grados, minutos y segundos.*/

            Console.Write( "\n" + "  Ingrese el ángulo en radianes : ");
            double anguloEnRadianes = Convert.ToDouble(Console.ReadLine());
            double anguloEnSexagesimal = anguloEnRadianes * 180 / 3.1416;
            double gg, mm, ss;
            gg = (int)anguloEnSexagesimal; //get only the integer part
            mm =(anguloEnSexagesimal - gg) * 60;
            ss = (mm - (int)mm) * 60;

            Console.WriteLine("\n" + "  El ángulo en radianes es: " + anguloEnRadianes + " radianes");
            Console.WriteLine("\n" + "  El ángulo en sexagesimal es: " + anguloEnSexagesimal + "°");
            Console.Write("\n" + "  El ángulo equivale a : " + gg + " grados, " + (int)mm + " minutos, " + (int)ss + " segundos");
            Console.ReadKey();
            //The result is variable. It depends on the pi value
        }
    }
}
