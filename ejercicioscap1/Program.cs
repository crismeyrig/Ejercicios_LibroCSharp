using System;

namespace ejercicioscap1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int num;
            Console.WriteLine("Escribe tu nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Hola {0}, cuantos años tienes?", nombre);
            num = int.Parse(System.Console.ReadLine());
            Console.WriteLine("{0} tienes {1} años", nombre, num);
            Console.Read();
            Console.WriteLine(" Feliz Dia, Bendiciones  ");
        }
    }
}
