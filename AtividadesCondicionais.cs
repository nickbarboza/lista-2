public class AtividadesCondicionais
{
    public static void Atividade01()
    {
        Console.WriteLine("Informe a idade do visitante: ");
        int idade = int.Parse(Console.ReadLine());

        if (idade >= 16)
        {
            Console.WriteLine("Entrada liberada.");
        }
        else
        {
            Console.WriteLine("Entrada permitida somente com responsável.");
        } 
    }
    public static void Atividade02()
    {Console.Write("Informe a nota final: ");
double nota = double.Parse(Console.ReadLine());

if (nota >= 7)
{
    Console.WriteLine("Estudante aprovado.");
}
else if (nota >= 5)
{
    Console.WriteLine("Estudante em recuperação.");
}
else
{
    Console.WriteLine("Estudante reprovado.");
}
    }
    public static void Atividade03()
    {Console.WriteLine("Informe a temperatura atual: ");
double temperatura = double.Parse(Console.ReadLine());

if (temperatura < 18)
{
    Console.WriteLine("Ambiente frio.");
}
else if (temperatura <= 26)
{
    Console.WriteLine("Ambiente confortável.");
}
else
{
    Console.WriteLine("Ambiente quente.");
}
    }
    public static void Atividade04()
    {Console.Write("Informe o valor total da compra: ");
double valor = double.Parse(Console.ReadLine());

double desconto = 0;

if (valor >= 200)
{
    desconto = valor * 0.10;
}

double valorFinal = valor - desconto;

Console.WriteLine($"Valor original: R$ {valor:F2}");
Console.WriteLine($"Desconto aplicado: R$ {desconto:F2}");
Console.WriteLine($"Valor final: R$ {valorFinal:F2}");
    }
    public static void Atividade05()
    {Console.Write("Informe a quantidade de tarefas concluídas: ");
int tarefas = int.Parse(Console.ReadLine());

if (tarefas >= 50)
{
    Console.WriteLine("Meta atingida.");
    Console.WriteLine($"Tarefas concluídas: {tarefas}");
}
else
{
    Console.WriteLine("Meta não atingida.");
    Console.WriteLine($"Faltaram {50 - tarefas} tarefas.");
}
    }

    public static void Atividade06()
    {Console.Write("Informe a idade: ");
int idade = int.Parse(Console.ReadLine());

if (idade <= 11)
{
    Console.WriteLine("Faixa etária: criança.");
}
else if (idade <= 17)
{
    Console.WriteLine("Faixa etária: adolescente.");
}
else if (idade <= 59)
{
    Console.WriteLine("Faixa etária: adulto.");
}
else
{
    Console.WriteLine("Faixa etária: idoso.");
}
    }
    public static void Atividade07()
    {if (numero1 > numero2)
{
    Console.WriteLine("O primeiro número é maior.");
}
else if (numero2 > numero1)
{
    Console.WriteLine("O segundo número é maior.");
}
else
{
    Console.WriteLine("Os números são iguais.");
}
    }
    public static void Atividade08()
    {Console.Write("Informe a terceira pontuação: ");
int p3 = int.Parse(Console.ReadLine());

if (p1 == p2 && p2 == p3)
{
    Console.WriteLine("As três pontuações são iguais.");
}
else
{
    int maior = p1;

    if (p2 > maior)
        maior = p2;

    if (p3 > maior)
        maior = p3;

    Console.WriteLine($"Maior pontuação: {maior}");
}
    }
    public static void Atividade09()
    {if (numero % 2 == 0)
{
    Console.WriteLine("O número informado é par.");
}
else
{
    Console.WriteLine("O número informado é ímpar.");
}
    }

    public static void Atividade10()
    {Console.Write("Informe o valor normal da passagem: ");
double valorNormal = double.Parse(Console.ReadLine());

double valorPagar;

if (idade <= 5)
{
    valorPagar = 0;
}
else if (idade >= 60)
{
    valorPagar = valorNormal / 2;
}
else
{
    valorPagar = valorNormal;
}

Console.WriteLine($"Valor normal da passagem: R$ {valorNormal:F2}");
Console.WriteLine($"Valor a pagar: R$ {valorPagar:F2}");

    }
    public static void Atividade11()
    {using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe o número final da contagem: ");
        int numero = int.Parse(Console.ReadLine());

        for (int i = 1; i <= numero; i++)
        {
            Console.WriteLine(i);
        }
    }
    }
    public static void Atividade12()
    { Console.Write("Informe o número inicial da contagem regressiva: ");
        int numero = int.Parse(Console.ReadLine());

        for (int i = numero; i >= 0; i--)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("Fim da contagem.");
    
    }
    public static void Atividade13()
    {int numero;

Console.Write("Informe o número da tabuada: ");
numero = int.Parse(Console.ReadLine());

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
    soma += double.Parse(Console.ReadLine());
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
    int numero = int.Parse(Console.ReadLine());

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
senha = int.Parse(Console.ReadLine());

while (senha != 1234)
{
    Console.WriteLine("Senha incorreta. Tente novamente.");
    Console.Write("Informe a senha: ");
    senha = int.Parse(Console.ReadLine());
}

Console.WriteLine("Acesso permitido.");
    }
    public static void Atividade17()
    {double nota;

Console.Write("Informe uma nota de 0 a 10: ");
nota = double.Parse(Console.ReadLine());

while (nota < 0 || nota > 10)
{
    Console.WriteLine("Nota inválida. Informe novamente.");
    nota = double.Parse(Console.ReadLine());
}

Console.WriteLine("Nota registrada: " + nota);
    }

    public static void Atividade18()
    {int quantidadeClientes;
double tempoAtendimento;
double tempoTotal = 0;

Console.Write("Informe a quantidade de clientes atendidos: ");
quantidadeClientes = int.Parse(Console.ReadLine());

for (int i = 1; i <= quantidadeClientes; i++)
{
    Console.Write("Informe o tempo do atendimento: ");
    tempoAtendimento = double.Parse(Console.ReadLine());

    tempoTotal += tempoAtendimento;
}

double tempoMedio = tempoTotal / quantidadeClientes;

Console.WriteLine("Tempo total de atendimento: " + tempoTotal + " minutos");
Console.WriteLine("Tempo médio por cliente: " + tempoMedio + " minutos");
    }
    public static void Atividade19()
    {double saldo;

Console.Write("Informe o saldo inicial: ");
saldo = double.Parse(Console.ReadLine());

int opcao = 0;

while (opcao != 3)
{
    Console.WriteLine("1 - Entrada");
    Console.WriteLine("2 - Saída");
    Console.WriteLine("3 - Encerrar");

    opcao = int.Parse(Console.ReadLine());

    if (opcao == 1)
    {
        Console.Write("Valor: ");
        double valor = double.Parse(Console.ReadLine());

        saldo += valor;
        Console.WriteLine("Saldo atual: R$ " + saldo);
    }

    else if (opcao == 2)
    {
        Console.Write("Valor: ");
        double valor = double.Parse(Console.ReadLine());

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
estoque = int.Parse(Console.ReadLine());

int opcao = 0;

while (opcao != 4)
{
    Console.WriteLine("1 - Entrada");
    Console.WriteLine("2 - Saída");
    Console.WriteLine("3 - Consultar");
    Console.WriteLine("4 - Encerrar");

    opcao = int.Parse(Console.ReadLine());

    if (opcao == 1)
    {
        Console.Write("Quantidade: ");
        int qtd = int.Parse(Console.ReadLine());

        estoque += qtd;
        Console.WriteLine("Estoque atual: " + estoque);
    }

    else if (opcao == 2)
    {
        Console.Write("Quantidade: ");
        int qtd = int.Parse(Console.ReadLine());

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
}