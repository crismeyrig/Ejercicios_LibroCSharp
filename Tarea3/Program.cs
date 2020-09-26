using System;
using Ejercicios_Cap6y7;

//main
namespace Ejercicios_Cap6y7
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc=1;
            switch(opc){
             case 1:
             Ejercicios1_3Cap6 ejer123 = new Ejercicios1_3Cap6();
             ejer123.Ejercicios1_3Cap6();

            break;

            case 2:
             Ejercicio4_6 ejer2 =new Ejercicio4_6();
             ejer2.EscuelaFunciones();

            break;
                
            case 3:
             Ejercicio1_7 ejer3 = new Ejercicio1_7();
             ejer3.arraylist();

             break;


             default: 
             Console.WriteLine("Error, no existe:");
            break;

            }
        }
    }
}
