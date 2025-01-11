// See https://aka.ms/new-console-template for more information

Questao1();
Questao2();
Questao3();
Questao4();
Questao5();

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
    string entradaConsole;
    Console.Write("Digite o valor para identificar na sequência de fibonacci:");
    try
    {
        entradaConsole = Console.ReadLine();
        entrada = Convert.ToInt32(entradaConsole);
        if(entrada == null)
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

void Questao3()
{
    List<Faturamento> faturamentos = new List<Faturamento>();
    
}

void Questao4()
{
    double sp = 67836.43, 
    rj = 36678.66,
    mg = 29229.88,
    es = 27165.48,
    outros = 19849.53;


}

void Questao5()
{
    Console.Write("Digite a sentença a ser invertida: ");
    string entrada = Console.ReadLine();
    for (int i = entrada.Length; i<0 ;i--)
    {
        Console.Write(entrada[i]);
    }
}

public class Faturamento
{
    public int Dia { get; set; }
    public float Valor { get; set; }
}