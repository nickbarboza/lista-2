public class AtividadesRepeticao

{    
    public static void Atividade11()
    {
        Console.Write("Informe o número final da contagem: ");
        int numero = int.Parse(Console.ReadLine()!);

        for (int i = 1; i <= numero; i++)
        {
            Console.WriteLine(i);
        }
    }

    public static void Atividade12()
    { 
        Console.Write("Informe o número inicial da contagem regressiva: ");
        int numero = int.Parse(Console.ReadLine()!);

        for (int i = numero; i >= 0; i--)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("Fim da contagem.");
    
    }
    public static void Atividade13()
    {int numero;

Console.Write("Informe o número da tabuada: ");
numero = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(numero + " x " + i + " = " + (numero * i));
}
    }

    public static void Atividade14()
    {double soma = 0;

for (int i = 1; i <= 5; i++)
{
    Console.Write("Informe um valor: ");
    soma += double.Parse(Console.ReadLine()!);
}

double media = soma / 5;

Console.WriteLine("Soma dos valores: " + soma);
Console.WriteLine("Média dos valores: " + media);
    }
    public static void Atividade15()
    {int positivos = 0;
int negativos = 0;
int zeros = 0;

for (int i = 1; i <= 10; i++)
{
    Console.Write("Informe um número: ");
    int numero = int.Parse(Console.ReadLine()!);

    if (numero > 0)
        positivos++;
    else if (numero < 0)
        negativos++;
    else
        zeros++;
}

Console.WriteLine("Quantidade de positivos: " + positivos);
Console.WriteLine("Quantidade de negativos: " + negativos);
Console.WriteLine("Quantidade de zeros: " + zeros);
    }
    public static void Atividade16()
    {int senha;

Console.Write("Informe a senha: ");
senha = int.Parse(Console.ReadLine()!);

while (senha != 1234)
{
    Console.WriteLine("Senha incorreta. Tente novamente.");
    Console.Write("Informe a senha: ");
    senha = int.Parse(Console.ReadLine()!);
}

Console.WriteLine("Acesso permitido.");
    }
    public static void Atividade17()
    {double nota;

Console.Write("Informe uma nota de 0 a 10: ");
nota = double.Parse(Console.ReadLine()!);

while (nota < 0 || nota > 10)
{
    Console.WriteLine("Nota inválida. Informe novamente.");
    nota = double.Parse(Console.ReadLine()!);
}

Console.WriteLine("Nota registrada: " + nota);
    }

    public static void Atividade18()
    {int quantidadeClientes;
double tempoAtendimento;
double tempoTotal = 0;

Console.Write("Informe a quantidade de clientes atendidos: ");
quantidadeClientes = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= quantidadeClientes; i++)
{
    Console.Write("Informe o tempo do atendimento: ");
    tempoAtendimento = double.Parse(Console.ReadLine()!);

    tempoTotal += tempoAtendimento;
}

double tempoMedio = tempoTotal / quantidadeClientes;

Console.WriteLine("Tempo total de atendimento: " + tempoTotal + " minutos");
Console.WriteLine("Tempo médio por cliente: " + tempoMedio + " minutos");
    }
}