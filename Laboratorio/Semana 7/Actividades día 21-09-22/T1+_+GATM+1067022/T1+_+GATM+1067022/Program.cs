using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1___GATM_1067022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Este es mi segundo programa");
            Console.WriteLine("Ingrese su nombre:");
            string Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su Edad:");
            string Edad = Console.ReadLine();
            Console.WriteLine("Ingrese su Carrera:");
            string Carrera = Console.ReadLine();
            Console.WriteLine("Ingrese su Carnet:");
            string Carnet = Console.ReadLine();           
            Console.ReadKey();

            Console.WriteLine("Soy"+Nombre +", tengo"+Edad + "años y estudio la carrera de"+Carrera + ". Mi número de carnet es"+ Carnet);

            Console.ReadKey();
            

        }
    }
}
