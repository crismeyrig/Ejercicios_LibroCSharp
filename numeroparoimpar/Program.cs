using System;

namespace numeroparoimpar
{
    class Program
    {
        static void Main(string[] args)
        {
             {
            int  num  =  0 ;
            Console.WriteLine ( " Ingrese un número: " );
            num = int.Parse ( Console.ReadLine ());

            if ( num %20== 0 )
            {
                Console.WriteLine ( " El número es par " );
            }
            else
            {
                Console.WriteLine ( " El número es impar " );
                Console.ReadKey ();
            }
        }
    }
}
}
