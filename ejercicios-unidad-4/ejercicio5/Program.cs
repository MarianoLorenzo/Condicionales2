using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4;

            Console.WriteLine("Ingrese el 1er número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el 2do número: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el 3er número: ");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el 4to número: ");
            n4 = int.Parse(Console.ReadLine());

            if (n1 > n2 && n2 > n3 && n3 > n4)
               Console.WriteLine("Los números están ordenados en forma decreciente"); 
               
        }
    }
}
