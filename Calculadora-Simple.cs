using System;

class Program
{
    static void Main(string[] args)
    {
        char opcion = ' ';
        int num1 = 0;
        int num2 = 0;
        int formula = 0;

        Console.WriteLine("Ingresa el primer numero:");
        num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingresa el segundo numero:");
        num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingresa la operacion (+, -, *, /):");
        opcion = char.Parse(Console.ReadLine());

        switch (opcion)
        {
            case '+':
                formula = num1 + num2;
                break;

            case '-':
                formula = num1 - num2;
                break;

            case '*':
                formula = num1 * num2;
                break;

            case '/':
                if (num2 != 0)
                {
                    formula = num1 / num2;
                }
                else
                {
                    Console.WriteLine("No se puede dividir entre cero.");
                    return;
                }
                break;

            default:
                Console.WriteLine("Operacion invalida.");
                return;
        }

        Console.WriteLine("El resultado es = " + formula);
    }
}
