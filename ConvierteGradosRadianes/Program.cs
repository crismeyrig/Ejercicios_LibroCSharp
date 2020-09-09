using System;

namespace ConvierteGradosRadianes
{
    class Program
    {
        static void Main(string[] args)
        {
           double grado, radianes, pi = 3.1416;
            string Valor = "";

            // pedir los grado
            Console.WriteLine("Ingrese la Cantidad de grado a convertir ");
            Valor = Console.ReadLine();
            grado = Convert.ToDouble(Valor);

            radianes = gradosRadianes(grado, pi);

            Console.WriteLine("{0} equivale a {1} radianes", grado, radianes);

            static double gradosRadianes(double n1, double n2)
            {
                double r = 0.0;
                r = (n1 * n2) / 180;

                return r;



            }
        }
       
        
    }
}
