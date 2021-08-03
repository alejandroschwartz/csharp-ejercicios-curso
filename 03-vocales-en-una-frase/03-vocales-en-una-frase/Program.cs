using System;

namespace _03_vocales_en_una_frase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa texto");
            string frase = Console.ReadLine().ToLower();

            int cantidad = frase.Length;
            Console.WriteLine($"La cantidad de caracteres es: {cantidad}");
            Console.WriteLine("--------------------");
            
            if (cantidad <= 20)
            {
                //char[] miCaracter = { 'a', 'e', 'i', 'o', 'u' };
                //string fraseCortada = frase.TrimEnd(miCaracter);
                //Console.WriteLine(fraseCortada);

                //Console.WriteLine(frase.Trim(new Char[] { 'a', 'e', 'i', 'o', 'u' }));

                //frase = frase.Replace("a", "");
                //frase = frase.Replace("e", "");
                //frase = frase.Replace("i", "");
                //frase = frase.Replace("o", "");
                //frase = frase.Replace("u", "");

                frase = frase.Replace("a", "").Replace("e", "").Replace("i", "").Replace("o", "").Replace("u", "");

                Console.WriteLine($"La cantidad de vocales en {cantidad - frase.Length}");
                Console.WriteLine("--------------------");
            }
            else
            {
                Console.WriteLine("Debe contener menos de 20 caracteres");
                Console.WriteLine("--------------------");
            }
        }
    }
}
