using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10_GATM_1067022
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            string u;
            string c;
            int contador = 0;
            bool r;
          do
            {
                Console.WriteLine("Ingrese su Usuario");
                u=Console.ReadLine();
                Console.WriteLine("Ingrese su contraseña");
                c=Console.ReadLine();
                r=login(u, c);

                if (r==true)
                {
                    Console.WriteLine("Usuarios y contraseña correctos");
                    contador=3;
                }
                else
                {
                    Console.WriteLine("Usuario o contraseña Incorrectos");
                    contador++;
                    Console.WriteLine("Intentos: "+contador);
                }
            }
          while (contador<3);
            Console.ReadKey();

        }
        static bool login(string usuario, string contraseña)
        {
            if (usuario=="usuario1" && contraseña=="asdasd" )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       

    }
    
}

