using System;

class Program
{
    static void Main(string[] args)
    {
        int pos = 0;
        int neg = 0;
        int numero;

        Console.WriteLine("Ingresa un numero (se detiene en cero):");
        Console.Write("Numero: ");
        numero = int.Parse(Console.ReadLine());

        while (numero != 0)
        {
            if (numero > 0)
                pos++;
            else
                neg++;

            Console.Write("Numero: ");
            numero = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nConteo de numeros:");
        Console.WriteLine("Numeros positivos: " + pos);
        Console.WriteLine("Numeros negativos: " + neg);
    }
}
