using System;

public class exercicio4
{
	public static void Main(string[] args)
	{
		double SP = 67836.43;
		double RJ = 36678.66;
		double MG = 29229.88;
		double ES = 27165.48;
		double Outros = 19849.53;

		double total = SP+RJ+MG+ES+Outros;

		double PercSP = (SP / total) * 100;
		double PercRJ = (RJ / total) * 100;
		double PercMG = (MG / total) * 100;
		double PercES = (ES / total) * 100;
		double PercOutros = (Outros / total) * 100;

        Console.WriteLine("Percentual de representação por estado:");
        Console.WriteLine($"SP: {PercSP:F2}%");
        Console.WriteLine($"RJ: {PercRJ:F2}%");
        Console.WriteLine($"MG: {PercMG:F2}%");
        Console.WriteLine($"ES: {PercES:F2}%");
        Console.WriteLine($"Outros: {PercOutros:F2}%");
        Console.ReadLine();

	}
}
