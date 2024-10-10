using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;

public class Faturamento
{
    public static void Main(string[] args)
    {

        string json = System.IO.File.ReadAllText("faturamento.json");

        JObject jsonObject = JObject.Parse(json);
        List<double> valoresFaturamento = jsonObject["faturamento_diario"].ToObject<List<double>>();

        double menorValor = valoresFaturamento.Min();
        double maiorValor = valoresFaturamento.Max();

        double somaFaturamento = 0;
        int diasComFaturamento = 0;
        foreach (var valor in valoresFaturamento)
        {
            if (valor > 0)
            {
                somaFaturamento += valor;
                diasComFaturamento++;
            }
        }
        double mediaMensal = somaFaturamento / diasComFaturamento;

        int diasAcimaDaMedia = 0;
        foreach (var valor in valoresFaturamento)
        {
            if (valor > mediaMensal)
            {
                diasAcimaDaMedia++;
            }
        }

        Console.WriteLine($"Menor valor de faturamento: {menorValor:C}");
        Console.WriteLine($"Maior valor de faturamento: {maiorValor:C}");
        Console.WriteLine($"Dias com faturamento acima da média: {diasAcimaDaMedia}");
        Console.ReadLine();
    }
}