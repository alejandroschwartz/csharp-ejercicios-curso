using System;

namespace _04_calcular_triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa el lado 1");
            string lado1 = Console.ReadLine();
            int uno = Int16.Parse(lado1);

            Console.WriteLine("Ingresa el lado 2");
            string lado2 = Console.ReadLine();
            int dos = Int16.Parse(lado2);

            Console.WriteLine("Ingresa el lado 3");
            string lado3 = Console.ReadLine();
            int tres = Int16.Parse(lado3);

            Console.WriteLine("--------------------");

            int mayor = ladoMayor(uno, dos, tres);
            Console.WriteLine($"El mayor es {mayor}");

            Console.WriteLine("--------------------");
            tipoTriangulo(uno, dos, tres);

        }

        public static void tipoTriangulo(int uno, int dos, int tres)
        {
            if (uno == dos && uno == tres)
            {
                Console.WriteLine("Es Equilatero");
            }
            else if (uno == dos || uno == tres || dos == tres)
            {
                Console.WriteLine("Es Isosceles");
            }
            else
            {
                Console.WriteLine("No es Equilatero ni Isosceles");
            }
        }

        public static int ladoMayor(int uno, int dos, int tres)
        {
            int mayor = 0;

            if (uno > dos)
            {
                if (uno > tres)
                {
                    mayor = uno;
                    if (uno < (dos + tres) )
                    {
                        Console.WriteLine($"Lado 1 es mayor, vale: {uno} y es valido");
                    }
                    else
                    {
                        Console.WriteLine("Invalido");
                    }
                }
                else
                {
                    mayor = tres;
                    if (tres < (uno + dos))
                    {
                        Console.WriteLine($"Lado 3 es mayor, vale: {tres} y es valido");
                    }
                    else
                    {
                        Console.WriteLine("Invalido");
                    }
                }
            }
            else if (dos > uno)
            {
                if (dos > tres)
                {
                    mayor = dos;
                    if (dos < (uno + tres))
                    {
                        Console.WriteLine($"Lado 2 es mayor, vale: {dos} y es valido");
                    }
                    else
                    {
                        Console.WriteLine("Invalido");
                    }
                }
                else
                {
                    mayor = tres;
                    if (tres < (uno + dos))
                    {
                        Console.WriteLine($"Lado 3 es mayor, vale: {tres} y es valido");
                    }
                    else
                    {
                        Console.WriteLine("Invalido");
                    }
                }
            }
            return mayor;

        }
    }
}
