using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;

            Console.WriteLine("Ingrese el 1er número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el 2do número: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el 3er número: ");
            n3 = int.Parse(Console.ReadLine());

            if ((n1 + n2) > n2 * n3) 
                Console.WriteLine("La suma de los dos primeros es mayor que el producto del segundo y el tercero");

        }
    }
}
