using System;

namespace Calculadora
{
    class operaciones
    {
        static void Main(string[] args)
        {
           suma();
           resta();
        }

         static void suma(){
            int n1=10, n2=89;
            int suma=n1+n2;
            Console.WriteLine(suma);
        }
         static void resta(){
            int n1=10, n2=89;
            int resta=n1-n2;
            Console.WriteLine(resta);
        }    
    }
}