using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaEmpaquetadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n" + "  Ingrese la cantidad de sobres : ");
            int cantidadDeSobres = Convert.ToInt32( Console.ReadLine());
            //148
            int empaquesDe50 = cantidadDeSobres / 50; //2
            int empaquesDe30 = cantidadDeSobres % 50 / 30; //48/30=1
            decimal empaquesDe12 = ((decimal)cantidadDeSobres % 50 - empaquesDe30*30) / 12;
            

            Console.Write("\n" + "  Cantidad de empaques de 50 : " + empaquesDe50);
            Console.Write("\n" + "  Cantidad de empaques de 30 : " + empaquesDe30);
            Console.Write("\n" + "  Cantidad de empaques de 12 : " + Math.Ceiling(empaquesDe12));
            Console.ReadKey();

            //references
            //https://parzibyte.me/blog/2019/06/20/redondear-numeros-c-sharp/
        }
    }
}
