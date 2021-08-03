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

            if (mayor != 0)
            {
                Console.WriteLine($"El mayor es {mayor}");

                Console.WriteLine("--------------------");
                tipoTriangulo(uno, dos, tres);

                Console.WriteLine("--------------------");
                perimetroArea(uno, dos, tres);
            }
            
            Console.WriteLine("--------------------");
        }

        public static void perimetroArea(int uno, int dos, int tres)
        {
            int seccion = uno + dos + tres;
            int area = (uno * dos) / 2;
            Console.WriteLine($"El perímetro del triángulo es {seccion} y el área es {area}");
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
            if (uno == dos && uno == tres && dos == tres)
            {
                Console.WriteLine($"Los tres lados son iguales a: {uno} y es un triangulo valido");
                mayor = uno;
            }
            else if (uno == dos || uno == tres || dos == tres)
            {
                Console.WriteLine($"Lados uno y dos son iguales");
                if (uno == dos && tres < uno + dos)
                {
                    if (tres < uno)
                    {
                        mayor = uno;
                    }
                    else
                    {
                        mayor = tres;
                    }
                }
                else if (uno == tres && dos < uno + tres)
                {
                    if (dos < uno)
                    {
                        mayor = uno;
                    }
                    else
                    {
                        mayor = dos;
                    }
                }
                else if (dos == tres && uno < dos + tres)
                {
                    if (uno < dos)
                    {
                        mayor = dos;
                    }
                    else
                    {
                        mayor = uno;
                    }
                }
                else
                {
                    Console.WriteLine($"INVALIDO, la base es mayor que la suma de los otros dos lados");
                }
            }
            else if (uno != dos && uno != dos && dos != tres)
            {
                if (uno > dos)
                {
                    if (uno > tres)
                    {
                        mayor = uno;
                        if (uno < (dos + tres) )
                        {
                            Console.WriteLine($"Lado 1 es mayor, vale: {uno} y es un triangulo valido");
                        }
                        else
                        {
                            Console.WriteLine("INVALIDO, el lado mas grande es mayor a la suma de los otros dos");
                        }
                    }
                    else
                    {
                        mayor = tres;
                        if (tres < (uno + dos))
                        {
                            Console.WriteLine($"Lado 3 es mayor, vale: {tres} y es un triangulo valido");
                        }
                        else
                        {
                            Console.WriteLine("INVALIDO, el lado mas grande es mayor a la suma de los otros dos");
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
                            Console.WriteLine($"Lado 2 es mayor, vale: {dos} y es un triangulo valido");
                        }
                        else
                        {
                            Console.WriteLine("INVALIDO, el lado mas grande es mayor a la suma de los otros dos");
                        }
                    }
                    else
                    {
                        mayor = tres;
                        if (tres < (uno + dos))
                        {
                            Console.WriteLine($"Lado 3 es mayor, vale: {tres} y es un triangulo valido");
                        }
                        else
                        {
                            Console.WriteLine("INVALIDO, el lado mas grande es mayor a la suma de los otros dos");
                        }
                    }
                }

            }
            return mayor;
        }
    }
}
