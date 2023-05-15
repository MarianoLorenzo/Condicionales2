using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int procesador, memoria, disco, precio;

            Console.WriteLine("Seleccione procesador: ");
            procesador = int.Parse(Console.ReadLine());
            Console.WriteLine("Seleccione memoria RAM: ");
            memoria = int.Parse(Console.ReadLine());
            Console.WriteLine("Seleccione si extiende disco: ");
            disco = int.Parse(Console.ReadLine());

            if (procesador == 1 && memoria == 1)
                precio = 800;
            else if ((procesador == 2 && memoria == 1) || (procesador == 1 && memoria == 2)) 
                precio = 900;
            else if (procesador == 3 && memoria == 1) 
                precio = 1200; 
            else if ((procesador == 1 && memoria == 3) || (procesador == 2 && memoria == 2)) 
                precio = 1000;
            else if ((procesador == 2 && memoria == 3) || (procesador == 3 && memoria == 2)) 
                precio = 1400; 
            else 
                precio = 2000;
            if (disco == 1)
                precio = precio + 300;

             Console.WriteLine("El monto de la máquina seleccionada es: USD " + precio);    
        }
    }
}
