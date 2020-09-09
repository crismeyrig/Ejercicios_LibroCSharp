using System;

namespace ConvertirMoneda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            double cantdolares, tipocambio, canteuro;

            Console.WriteLine("Ingrese cantidad de dolares: ");
            cantdolares = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese tipo de cambio:");
            tipocambio = double.Parse(Console.ReadLine());

            canteuro = cantdolares * tipocambio;

            Console.WriteLine("Equivalente en Euros: {0}", canteuro);
            Console.WriteLine();

        


            

        }
    }
}
