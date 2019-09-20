using System;

namespace Calculadora
{
    class operaciones
    {
        static void Main(string[] args)
        {
           suma();
           multiplicacion();
        }

         static void suma(){
            int n1=10, n2=89;
            int suma=n1+n2;
            Console.WriteLine(suma);
        }
         static void multiplicacion(){
            int n1=10, n2=89;
            int multiplicacion=n1*n2;
            Console.WriteLine(multiplicacion);
        }    
    }
}