using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using suma;
using resta;
using multiplicaion;

namespace Nacho_inegrado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long variable;

            //Suma
            variable = suma.suma.Suma(2, 9);
            Console.WriteLine(variable);
            //resta
            variable = resta.resta.Resta(2, 9);
            Console.WriteLine(variable);
            //multiplicacion
            variable = multiplicacion.Multi(2, 9);
            Console.WriteLine(variable);

        }
    }
}
