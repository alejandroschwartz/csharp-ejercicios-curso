using System;

namespace _03_vocales_en_una_frase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa texto");
            String frase = Console.ReadLine();

            int largo = frase.Length;
            if(largo < 20)
            {
                Console.WriteLine($"La cantidad de caracteres es: {largo}");

                //char[] miCaracter = { 'a', 'e', 'i', 'o', 'u' };
                //string fraseCortada = frase.TrimEnd(miCaracter);
                //Console.WriteLine(fraseCortada);

                Console.WriteLine(frase.Trim(new Char[] { 'a', 'e', 'i', 'o', 'u' }));
            } 
            else
            {
                Console.WriteLine("Debe contener menos de 20 caracteres");
            }
        }
    }
}
