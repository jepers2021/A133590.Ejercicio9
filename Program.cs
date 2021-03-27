using System;

namespace A133590.Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 9");
            Console.WriteLine("Dada una frase por el usuario, el programa presenta la misma frase en mayúscula.");
            Console.Write("Por favor, ingrese una frase: ");
            string frase = Console.ReadLine();
            Console.WriteLine(frase.ToUpperInvariant());
            Console.WriteLine("Presione cualquier tecla para salir..");
            Console.ReadKey();
        }
    }
}
