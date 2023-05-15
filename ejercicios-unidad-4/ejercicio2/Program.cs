using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            float i, l, vf;

            Console.WriteLine("Ingrese el importe total: ");
            i = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de litros: ");
            l = float.Parse(Console.ReadLine());

            if (l < 100)
                vf = i; 
            else if (l >= 101 && l <= 300)
                vf = i * 0.9F;
            else if (l >= 301 && l <= 500)
                vf = i * 0.85F;
            else 
                vf = i * 0.75F;

            Console.WriteLine("El importe final es: $" + vf.ToString("0.00"));  

        }
    }
}
