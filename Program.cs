using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;

namespace HelloWorld;

public static class Program
{

    public static void Questao1()
    {
        int soma = 0, k = 0, indice = 13;
        while (k < indice)
        {
            k++;
            soma += k;

        }
        Console.WriteLine(soma);
    }

    public static void Questao2()
    {
        int fibonacci = 0,
        entrada = 0,
        primeiro = 0,
        segundo = 1;
        string entradaConsole;
        Console.Write("Digite o valor para identificar na sequência de fibonacci:");
        try
        {
            entradaConsole = Console.ReadLine();

            if (!int.TryParse(entradaConsole, out entrada))
                throw new Exception("Valor digitado é inválido");
            while (fibonacci <= entrada)
            {
                fibonacci = primeiro + segundo;

                if (fibonacci == entrada)
                {
                    Console.WriteLine($"O valor {entrada} pertence a sequência de Fibonacci");
                    return;
                }

                primeiro = segundo;
                segundo = fibonacci;
            }

            Console.WriteLine($"O valor {entrada} não pertence a sequência de Fibonacci");
        }
        catch (Exception ex)
        {
            throw new Exception($"Erro na execução da atividade 2:{ex.Message}");
        }
    }

    public static void Questao3()
    {
        int diasComFaturamento = 0, diaMaiorFaturamento = 0, diaMenorFaturamento = 0, diasAcimaDaMedia = 0;
        double mediaFaturamento = 0, maiorFaturamento = 0, menorFaturamento = 0;


        List<Faturamento> faturamentos = new List<Faturamento>();
        using (StreamReader reader = new StreamReader("./files/dados.json"))
        {
            string json = reader.ReadToEnd();
            faturamentos = JsonSerializer.Deserialize<List<Faturamento>>(json);
        }

        foreach (Faturamento item in faturamentos)
        {
            if (item.valor.Equals(0)) continue;

            diasComFaturamento++;
            mediaFaturamento += item.valor;

            if (item.valor > maiorFaturamento)
            {
                maiorFaturamento = item.valor;
                diaMaiorFaturamento = item.dia;
                if (menorFaturamento.Equals(0)) menorFaturamento = item.valor;
            }

            if (item.valor < menorFaturamento && !item.valor.Equals(0))
            {
                menorFaturamento = item.valor;
                diaMenorFaturamento = item.dia;
            }
        }
        mediaFaturamento /= diasComFaturamento;

        foreach (Faturamento item in faturamentos)
        {
            if (item.valor > mediaFaturamento) diasAcimaDaMedia++;
        }

        Console.WriteLine($"Maior faturamento: {maiorFaturamento:c} no dia {diaMaiorFaturamento}");
        Console.WriteLine($"Menor faturamento: {menorFaturamento:c} no dia {diaMenorFaturamento}");
        Console.WriteLine($"Número de dias com faturamento acima da média: {diasAcimaDaMedia}");
    }

    public static void Questao4()
    {
        double sp = 67836.43,
        rj = 36678.66,
        mg = 29229.88,
        es = 27165.48,
        outros = 19849.53,
        valorTotal = sp + rj + mg + es + outros;


        Console.WriteLine($"Valor total de faturamento mensal da distribuidora: {valorTotal:c2}");
        Console.WriteLine($"Porcentagem equivalente a SP: {sp / valorTotal * 100:N2}%");
        Console.WriteLine($"Porcentagem equivalente a RJ: {rj / valorTotal * 100:N2}%");
        Console.WriteLine($"Porcentagem equivalente a MG: {mg / valorTotal * 100:N2}%");
        Console.WriteLine($"Porcentagem equivalente a ES: {es / valorTotal * 100:N2}%");
        Console.WriteLine($"Porcentagem equivalente aos demais estados: {outros / valorTotal * 100:N2}%");
    }

    public static void Questao5()
    {
        Console.Write("Digite a sentença a ser invertida: ");
        string entrada = Console.ReadLine();
        for (int i = entrada.Length - 1; i >= 0; i--)
        {
            Console.Write(entrada[i]);
        }
    }

    public static void Main()
    {
        Questao1();
        Questao2();
        Questao3();
        Questao4();
        Questao5();
    }
}

public class Faturamento
{
    public int dia { get; set; }
    public float valor { get; set; }
}