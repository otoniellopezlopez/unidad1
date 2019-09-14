using System;

namespace Calculadora
{
    class operaciones
    {
        static void Main(string[] args)
        {
           suma();
        }

        static void suma(){
            int n1=10, n2=89;
            int suma=n1+n2;
            Console.WriteLine(suma);
        }

    }

        class operaciones2
    {
        static void Main(string[] args)
        {
           division();
        }

        static void division(){
            double n1=10, n2=89;
            double division=n1/n2;
            Console.WriteLine(division);
        }
    }
}

