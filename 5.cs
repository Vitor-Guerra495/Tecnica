using System;

public class exercicio5
{
    public static void Main(string[] args)
    {

        Console.Write("Digite uma palavra: ");
        string palavra = Console.ReadLine();

        string inverter = "";
        for (int i = palavra.Length - 1; i >= 0; i--)
        {
            inverter += palavra[i];
        }

        Console.WriteLine(inverter);
        Console.ReadLine();
    }
}