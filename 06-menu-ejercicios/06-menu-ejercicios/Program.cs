using System;

namespace _06_menu_ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("-----       Inicio       -----");
            Console.WriteLine("------------------------------");

            Console.WriteLine("Seleccióna el número de proyecto");
            Console.WriteLine(" 0 - Salir del programa");
            Console.WriteLine(" 1 - Impares del 1 al 100");
            Console.WriteLine(" 2 - Números naturales");
            Console.WriteLine(" 3 - Vocales en una frase");
            Console.WriteLine(" 4 - Calcular triangulo");
            Console.WriteLine(" 5 - Multiplos de 2 y 3");

            Console.WriteLine("------------------------------");
            Console.WriteLine("----- Ingresa el número  -----");
            Console.WriteLine("------------------------------");

            switch (Console.ReadLine().ToString())
            {
                case "0":
                    Console.WriteLine("0 - Salir del programa");
                    break;
                case "1":
                    Console.WriteLine("1 - Impares del 1 al 100");
                    MostrarImpares();
                    break;
                case "2":
                    Console.WriteLine("2 - Números naturales");
                    MostarNaturales();
                    break;
                case "3":
                    Console.WriteLine("3 - Vocales en una frase");
                    MostrarVocales();
                    break;
                case "4":
                    Console.WriteLine("4 - Calcular triangulo");
                    MostrarTriangulo();
                    break;
                case "5":
                    Console.WriteLine("5 - Multiplos de 2 y 3");
                    MostrarMultiplos2y3();
                    break;
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine("-----      Finalizo      -----");
            Console.WriteLine("------------------------------");
        }

        static void MostrarImpares()
            {
                for (int i = 0; i <= 100; i++)
                {
                    switch (i % 2)
                    {
                        case 0:
                            break;
                        default:
                            Console.WriteLine("Valor de x es: " + i);
                            break;
                    }
                }
            }

        static void MostarNaturales()
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
                    while (dos <= uno)
                    {
                        Console.WriteLine(dos);
                        dos++;
                        contador++;
                        if (contador % 2 == 0)
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

        static void MostrarVocales()
            {
                Console.WriteLine("Ingresa texto");
                string frase = Console.ReadLine().ToLower();

                int cantidad = frase.Length;
                Console.WriteLine($"La cantidad de caracteres es: {cantidad}");

                if (cantidad <= 20)
                {
                    frase = frase.Replace("a", "").Replace("e", "").Replace("i", "").Replace("o", "").Replace("u", "");
                    Console.WriteLine($"La cantidad de vocales en {cantidad - frase.Length}");
                }
                else
                {
                    Console.WriteLine("Debe contener menos de 20 caracteres");
                }
            }

        static void MostrarTriangulo()
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
                tipoTriangulo(uno, dos, tres);
                perimetroArea(uno, dos, tres);
            }
        }

        static void perimetroArea(int uno, int dos, int tres)
        {
            int seccion = uno + dos + tres;
            int area = (uno * dos) / 2;
            Console.WriteLine($"El perímetro del triángulo es {seccion} y el área es {area}");
        }

        static void tipoTriangulo(int uno, int dos, int tres)
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

        static int ladoMayor(int uno, int dos, int tres)
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
                        if (uno < (dos + tres))
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

        static void MostrarMultiplos2y3()
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
                else if (contador % 2 == 0)
                {
                    Console.WriteLine($"{contador} multiplo de dos");
                }
                else if (contador % 3 == 0)
                {
                    Console.WriteLine($"{contador} multiplo de tres");
                }
                contador++;
            }
        }
    }
}