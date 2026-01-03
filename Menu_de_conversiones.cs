using System;

class Program
{
    static void Main(string[] args)
    {
        int opcion;
        double f;
        double n;

        Console.WriteLine("1. Convertir de Celsius a Fahrenheit");
        Console.WriteLine("2. Convertir de km/h a m/s");
        Console.WriteLine("3. Convertir de Pesos a Dolares");
        Console.WriteLine("Indica la operacion que deseas realizar:");

        opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine("Ingresa los grados Celsius:");
                n = double.Parse(Console.ReadLine());
                f = (n * 9 / 5) + 32;
                Console.WriteLine("Fahrenheit: " + f);
                break;

            case 2:
                Console.WriteLine("Ingresa km/h:");
                n = double.Parse(Console.ReadLine());
                f = n / 3.6;
                Console.WriteLine("m/s: " + f);
                break;

            case 3:
                Console.WriteLine("Ingresa Pesos:");
                n = double.Parse(Console.ReadLine());
                f = n / 17.0;
                Console.WriteLine("Dolares: " + f);
                break;

            default:
                Console.WriteLine("Opcion no valida");
                break;
        }
    }
}
