using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L12_GATM_1027022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("Ejercicio#1");
            int[,] T = new int[4, 5];
            int suma = 0;
            Random r= new Random();
            for (int i = 0;i<4; i++)
            {
                for (int j = 0; j<5; j++)
                {
                    T[i, j]=r.Next(100);
                    suma =suma+T[i,j];
                }
            }
            Console.WriteLine("La suma de los elementos de T es: "+suma);

            float promedio = suma/20;
            Console.WriteLine("El promedio de los elementos de T es: "+promedio);

            //2
            Console.WriteLine("Ejercicio#2");
            Console.WriteLine("Escriba los elementeos de las matrices A y B para ver el resultado en C");

            int[,]A = new int[2,2];
            for (int i=0;i<2;i++)
            {
                for (int j=0;j<2;j++)
                {
                    Console.WriteLine("Escriba un numero para A:");
                    int a = int.Parse(Console.ReadLine());
                    A[i,j] = a;
                }
            }

            int[,] B = new int[2, 2];
            for (int i = 0; i<2; i++)
            {
                for (int j = 0; j<2; j++)
                {
                    Console.WriteLine("Escriba un numero para B:");
                    int b = int.Parse(Console.ReadLine());
                    B[i,j] = b;
                }
            }

            int[,] C = new int[2, 2];
            Console.WriteLine("La suma de las matrices A y B es: ");
            for (int i = 0; i<2; i++)
            {
                for (int j = 0; j<2; j++)
                {
                    C[i, j] = A[i, j]+B[i, j];
                    
                    Console.Write(C[i, j]+" ");

                }
                Console.WriteLine();
            }
            
            Console.ReadKey();
            
        }
    }
}
