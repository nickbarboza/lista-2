    public class AtividadesSistemas
    {
    public static void Atividade19()
    {double saldo;

Console.Write("Informe o saldo inicial: ");
saldo = double.Parse(Console.ReadLine()!);

int opcao = 0;

while (opcao != 3)
{
    Console.WriteLine("1 - Entrada");
    Console.WriteLine("2 - Saída");
    Console.WriteLine("3 - Encerrar");

    opcao = int.Parse(Console.ReadLine()!);

    if (opcao == 1)
    {
        Console.Write("Valor: ");
        double valor = double.Parse(Console.ReadLine()!);

        saldo += valor;
        Console.WriteLine("Saldo atual: R$ " + saldo);
    }

    else if (opcao == 2)
    {
        Console.Write("Valor: ");
        double valor = double.Parse(Console.ReadLine()!);

        if (valor <= saldo)
        {
            saldo -= valor;
            Console.WriteLine("Saldo atual: R$ " + saldo);
        }
        else
        {
            Console.WriteLine("Saldo insuficiente.");
        }
    }
}

Console.WriteLine("Saldo final: R$ " + saldo);
    }
    public static void Atividade20()
    {int estoque;

Console.Write("Informe a quantidade inicial em estoque: ");
estoque = int.Parse(Console.ReadLine()!);

int opcao = 0;

while (opcao != 4)
{
    Console.WriteLine("1 - Entrada");
    Console.WriteLine("2 - Saída");
    Console.WriteLine("3 - Consultar");
    Console.WriteLine("4 - Encerrar");

    opcao = int.Parse(Console.ReadLine()!);

    if (opcao == 1)
    {
        Console.Write("Quantidade: ");
        int qtd = int.Parse(Console.ReadLine()!);

        estoque += qtd;
        Console.WriteLine("Estoque atual: " + estoque);
    }

    else if (opcao == 2)
    {
        Console.Write("Quantidade: ");
        int qtd = int.Parse(Console.ReadLine()!);

        if (qtd <= estoque)
        {
            estoque -= qtd;
            Console.WriteLine("Estoque atual: " + estoque);
        }
        else
        {
            Console.WriteLine("Quantidade insuficiente em estoque.");
        }
    }

    else if (opcao == 3)
    {
        Console.WriteLine("Estoque atual: " + estoque);
    }
}

Console.WriteLine("Estoque final: " + estoque);
    }
}