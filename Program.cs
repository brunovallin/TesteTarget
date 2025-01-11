// See https://aka.ms/new-console-template for more information

Questao1();
Questao2();

void Questao1()
{
    int soma = 0, k = 0, indice = 13;
    while (k < indice)
    {
        k++;
        soma += k;
        Console.WriteLine(soma);
    }
}

void Questao2()
{
    int fibonacci = 0,
    entrada = 0,
    primeiro = 0,
    segundo = 1;
    Console.Write("Digite o valor para identificar na sequência de fibonacci:");
    try
    {
        Console.Read(), entrada);
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