using System;

namespace _06_menu_ejercicios.Entidades
{
    class Ejercicio01
    {
        public static void Mostrar()
        {
            // -----ejemplo 3-----
            for (int i = 0; i <= 100; i++)
            {
                switch (i % 2)
                {
                    case 0:
                        Console.WriteLine("Valor de x es: " + i);
                        break;
                    default:
                        break;
                }
            }
            //-------------------------
        }
    }
}
