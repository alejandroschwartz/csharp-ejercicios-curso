using System;

namespace _05_multiplos_3_y_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Contador de multiplos de dos y tres, entre 0 y 100.");
            Console.WriteLine("--------------------");

            int contador = 0;
            while (contador <= 100)
            {
                if (contador % 2 == 0 && contador % 3 == 0)
                {
                    Console.WriteLine($"{contador} multiplo de dos y tres");
                }
                else if(contador % 2 == 0)
                {
                    Console.WriteLine($"{contador} multiplo de dos");
                }
                else if(contador % 3 == 0)
                {
                    Console.WriteLine($"{contador} multiplo de tres");
                }
                contador++;
            }
        }
    }
}
