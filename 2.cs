using System;

public class exercicio2
{
    public static void Main(string[] args)
    {
        Console.Write("Informe um número: ");
        int numero = int.Parse(Console.ReadLine());

        int a = 0, b = 1, c = 0;
        bool pertence = false;

        if (numero == a || numero == b)
        {
            pertence = true;
        }

        while (c < numero)
        {
            c = a + b;
            a = b;
            b = c;

            if (c == numero)
            {
                pertence = true;
                break;
            }
        }

        if (pertence)
        {
            Console.WriteLine(numero + " pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine(numero + " não pertence à sequência de Fibonacci.");
        }
        Console.ReadKey();
    }
}
