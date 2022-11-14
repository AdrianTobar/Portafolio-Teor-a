using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;


namespace Proyecto_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola mundo soy Adrián");//B) salida
            Console.WriteLine("Hola Mundo");//B) salida
            Console.WriteLine("Soy Adrián");//B) salida
            /* WriteLine se escribe en una linea propia, en cambio, write solo escribe uno seguido de otro*/
            Console.Write("Hola Mundo");//B) salida
            Console.Write("Soy Adrián");//B) salida

            Console.WriteLine("Ingrese su nombre:");//B) salida
            string Nombre = Console.ReadLine();//B) entrada
            Console.WriteLine("Hola Mundo");//B) salida
            Console.WriteLine("Soy" + Nombre);//B) salida

            Console.Write("Hola Mundo");//B) salida
            Console.Write("Soy" + Nombre);//B) salida
            Console.ReadKey();//B) proceso

        }
    }
}
//A) C# utiliza un compilador, ya que analiza todo el programa y realiza todas las intrucciónes a mismo tiempo.
