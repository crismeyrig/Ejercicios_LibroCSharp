using System;

namespace PerimetroPoligono
{
    class Program
    {
        static void Main(string[] args)
        {
              float  longlado  =  0 ;
            float  cantlado  =  0 ;
            float  perimetro  =  0 ;

            Console.WriteLine ( " Ingrese la longitud de cada lado: " );
            longlado  =  float.Parse ( Console . ReadLine ());

            Console.WriteLine ( " Ingrese la cantidad de lado del poligono: " );
            cantlado  =  float.Parse ( Console . ReadLine ());

            perimetro  =  longlado  *  cantlado ;
            Console.WriteLine ( " El perimetro del Poligono es: {0} " , perimetro );
        }
    }
}
