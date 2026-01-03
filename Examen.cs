using System;

class Program
{
    static void Main(string[] args)
    {
        int opcion;
        int num;
        int formula;

        do
        {
            Console.WriteLine("1. Calcular el doble de un numero");
            Console.WriteLine("2. Calcular el triple de un numero");
            Console.WriteLine("3. Calcular el cuadrado de un numero");
            Console.WriteLine("4. Salir");
            Console.WriteLine("Indica la operacion que deseas realizar:");

            opcion = int.Parse(Console.ReadLine());

            if (opcion >= 1 && opcion <= 3)
            {
                Console.WriteLine("Ingresa el numero:");
                num = int.Parse(Console.ReadLine());
            }
            else
            {
                num = 0;
            }

            switch (opcion)
            {
                case 1:
                    formula = num * 2;
                    Console.WriteLine("Resultado: " + formula);
                    break;

                case 2:
                    formula = num * 3;
                    Console.WriteLine("Resultado: " + formula);
                    break;

                case 3:
                    formula = num * num;
                    Console.WriteLine("Resultado: " + formula);
                    break;

                case 4:
                    Console.WriteLine("Salir.");
                    break;

                default:
                    Console.WriteLine("Opcion no valida.");
                    break;
            }

            Console.WriteLine();

        } while (opcion != 4);
    }
}
