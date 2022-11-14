using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L6_GATM1067022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mes;
            Console.WriteLine("ejercicio 1");
            Console.WriteLine("Ingrese número de mes");
            mes = int.Parse(Console.ReadLine());

            switch (mes)
            {
                case 1:
                    Console.WriteLine("Mes: Enero");
                    break;
                case 2:
                    Console.WriteLine("Mes: Febrero");
                    break;
                case 3:
                    Console.WriteLine("Mes: Marzo");
                    break;
                case 4:
                    Console.WriteLine("Mes: Abril");
                    break;
                case 5:
                    Console.WriteLine("Mes: Mayo");
                    break;
                case 6:
                    Console.WriteLine("Mes: Junio");
                    break;
                case 7:
                    Console.WriteLine("Mes: Julio");
                    break;
                case 8:
                    Console.WriteLine("Mes: Agosto");
                    break;
                case 9:
                    Console.WriteLine("Mes: Sepriembre");
                    break;
                case 10:
                    Console.WriteLine("Mes: Octubre");
                    break;
                case 11:
                    Console.WriteLine("Mes: Noviembre");
                    break;
                case 12:
                    Console.WriteLine("Mes: Diciembre");
                    break;
                default:
                    Console.WriteLine("Error: El número debe de estar entre 1 y 12");
                    break;


            }
            Console.ReadKey();

            int num1;
            int num2;
            int num3;

            Console.WriteLine("ejercicio 2");

            Console.WriteLine("Ingrese el primer número");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer número");
            num3 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("resultado: El mayor es " + num1);
                }
                else
                {
                    if (num1 == num3)
                    {
                        Console.WriteLine("resultado: El mayor es " + num1);
                    }
                    else
                    {
                        Console.WriteLine("resultado: El mayor es" + num3);
                    }
                }
            }
            else
            {
                if (num1 == num2)
                {
                    if (num1 > num3)
                    {
                        Console.WriteLine("resultado: El mayor es " + num2);
                    }
                    else
                    {
                        if (num1 == num3)
                        {
                            Console.WriteLine("resultado: El mayor es " + num1);
                        }
                        else
                        {
                            Console.WriteLine("resultado: El mayor es " + num3);
                        }
                    }
                }
                else
                {
                    if (num2 > num3)
                    {
                        Console.WriteLine("resultado: El mayor es " + num2);
                    }
                    else
                    {
                        if (num2 == num3)
                        {
                            Console.WriteLine("resultado: El mayor es " + num2);
                        }
                        else
                        {
                            Console.WriteLine("resultado: El mayor es " + num3);
                        }
                    }
                }

            }
            Console.ReadKey();

            Console.WriteLine("T6_GATM1067022");
            Console.WriteLine("Tarea:");

            int M;
            int D;
            Console.WriteLine("Calculadora de Signo zodiacal");
            Console.WriteLine("ingrese su mes nacimiento, (1 al 12)");
            M = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el día del mes que nació, (1 al 31)");
            D = int.Parse(Console.ReadLine());

            switch (M)
            {
                case 1:

                    if (D < 20)
                    {
                        Console.WriteLine("Capricornio");
                    }
                    else if (D > 19)
                    {
                        Console.WriteLine("Acuario");
                    }
                    else
                        Console.WriteLine("Error");
                    break;

                case 2:

                    if (D< 19)
                    {
                        Console.WriteLine("Acuario");
                    }
                    else if (D > 18)
                    {
                        Console.WriteLine("Piscis");
                    }
                    else
                        Console.WriteLine("Erroer");
                    break;

                case 3:

                    if (D < 21)
                    {
                        Console.WriteLine("Piscis");
                    }
                    else if (D > 20)
                    {
                        Console.WriteLine("Aries");
                    }
                    else
                        Console.WriteLine("Error");
                    break;

                case 4:

                    if (D < 20)
                    {
                        Console.WriteLine("Aries");
                    }
                    else if (D>21)
                    {
                        Console.WriteLine("Tauro");
                    }
                    else
                        Console.WriteLine("Error");
                    break;

                case 5:
                    
                    if (D < 21)
                    {
                        Console.WriteLine("Tauro");
                    }
                    else if (D > 20)
                    {
                        Console.WriteLine("Géminis");
                    }
                    else
                        Console.WriteLine("Error");
                    break;

                case 6:
                    
                    if (D < 21)
                    {
                        Console.WriteLine("Géminis");
                    }
                    else if (D > 20)
                    {
                        Console.WriteLine("Cancer");
                    }
                    else
                        Console.WriteLine("Error");
                    break;

                case 7:
                    
                    if (D < 23)
                    {
                        Console.WriteLine("Cancer");
                    }
                    else if (D > 22)
                    {
                        Console.WriteLine("Leo");
                    }
                    else
                        Console.WriteLine("Error");
                    break;

                case 8:
                    
                    if (D < 23)
                    {
                        Console.WriteLine("Leo");
                    }
                    else if (D > 22)
                    {
                        Console.WriteLine("Virgo");
                    }
                    else
                        Console.WriteLine("Error");
                    break;

                case 9:
                    
                    if (D < 23)
                    {
                        Console.WriteLine("Virgo");
                    }
                    else if (D > 22)
                    {
                        Console.WriteLine("Libra");
                    }
                    else
                        Console.WriteLine("Error");
                    break;

                case 10:
                    
                    if (D < 23)
                    {
                        Console.WriteLine("libra");
                    }
                    else if (D > 22)
                    {
                        Console.WriteLine("Escorpio");
                    }
                    else
                        Console.WriteLine("Error");
                    break;

                case 11:
                    
                    if (D < 22)
                    {
                        Console.WriteLine("Escorpio");
                    }
                    else if (D > 21)
                    {
                        Console.WriteLine("Sagitario");
                    }
                    else
                        Console.WriteLine("Error");
                    break;

                case 12:
                    
                    if (D < 22)
                    {
                        Console.WriteLine("Sagitario");
                    }
                    else if (D > 21)
                    {
                        Console.WriteLine("Capricornio");
                    }
                    else
                        Console.WriteLine("Error");
                    break;

                default:
                    Console.WriteLine("Esta fecha no existe");
                    break;
            }
            Console.ReadKey();


        } 


    }


}

