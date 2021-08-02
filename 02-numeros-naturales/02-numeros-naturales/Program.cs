using System;

namespace _02_numeros_naturales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa el primer número");
            string primero = Console.ReadLine();
            int uno = Int16.Parse(primero);

            Console.WriteLine("Ingresa el segundo número");
            string segundo = Console.ReadLine();
            int dos = Int16.Parse(segundo);

            Console.WriteLine($"Valores ingresados: {primero} y {segundo}");

            int contador = 0;
            int contadorPares = 0;
            if (uno > dos)
            {
                Console.WriteLine($"El mayor es {uno}");
                while(dos <= uno)
                {
                    Console.WriteLine(dos);
                    dos++;
                    contador++;
                    if(contador % 2 == 0)
                    {
                        contadorPares++;
                    }
                }
            }
            else if (uno < dos)
            {
                Console.WriteLine($"El mayor es {dos}");
                while (dos >= uno)
                {
                    Console.WriteLine(uno);
                    uno++;
                    contador++;
                    if (contador % 2 == 0)
                    {
                        contadorPares++;
                    }
                }
            }
            else
            {
                Console.WriteLine($"Ambos son iguales a {uno}");
            }

            Console.WriteLine($"La cantidad de numeros es {contador}");
            Console.WriteLine($"La cantidad de numeros pares es {contadorPares}");
        }
    }
}