using System;

namespace _01_mostrar_impares
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;

            // -----ejemplo 1-----
            //while (x <= 10)
            //{
            //    Console.WriteLine("Valor de x es: " + x);
            //    x = x + 2;
            //}
            //-------------------------



            // -----ejemplo 2-----
            //while (x <= 100)
            //{
            //    if(x % 2 == 0)
            //    {
            //        Console.WriteLine("Valor de x es: " + x);
            //        x++;
            //    } 
            //    else
            //    {
            //        x++;
            //    }
            //}
            //-------------------------



            // -----ejemplo 3-----
            //for (int i = 0; i <= 100; i++ )
            //{
            //    if(i % 2 == 0)
            //        Console.WriteLine("Valor de x es: " + i);
            //}
            //-------------------------



            // -----ejemplo 3-----
            for (int i = 0; i <= 100; i++)
            {
                switch(i % 2)
                {
                    case 0 :
                        Console.WriteLine("Valor de x es: " + i);
                        break;
                    default :
                        break;
                }
            }
            //-------------------------
        }
    }
}