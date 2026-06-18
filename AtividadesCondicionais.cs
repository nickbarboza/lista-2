public class AtividadesCondicionais
{
    public static void Atividade01()
    {
        Console.WriteLine("Informe a idade do visitante: ");
        int idade = int.Parse(Console.ReadLine()!);

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
    {
        Console.Write("Informe a nota final: ");
double nota = double.Parse(Console.ReadLine()!);

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
    {
        Console.WriteLine("Informe a temperatura atual: ");
double temperatura = double.Parse(Console.ReadLine()!);

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
    {
        Console.Write("Informe o valor total da compra: ");
double valor = double.Parse(Console.ReadLine()!);

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
    {
        Console.Write("Informe a quantidade de tarefas concluídas: ");
int tarefas = int.Parse(Console.ReadLine()!);

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
    {
        Console.Write("Informe a idade: ");
int idade = int.Parse(Console.ReadLine()!);

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
    {
       Console.Write("Informe o primeiro número: ");
int numero1 = int.Parse(Console.ReadLine()!);

Console.Write("Informe o segundo número: ");
int numero2 = int.Parse(Console.ReadLine()!);

if (numero1 > numero2)
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
    {
        Console.Write("Informe a primeira pontuação: ");
int p1 = int.Parse(Console.ReadLine()!);

Console.Write("Informe a segunda pontuação: ");
int p2 = int.Parse(Console.ReadLine()!);

Console.Write("Informe a terceira pontuação: ");
int p3 = int.Parse(Console.ReadLine()!);

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
    {
        Console.Write("Informe um número inteiro: ");
int numero = int.Parse(Console.ReadLine()!);

if (numero % 2 == 0)
{
    Console.WriteLine("O número informado é par.");
}
else
{
    Console.WriteLine("O número informado é ímpar.");
}
    }

    public static void Atividade10()
    {
Console.Write("Informe a idade do passageiro: ");
int idade = int.Parse(Console.ReadLine()!);

Console.Write("Informe o valor normal da passagem: ");
double valorNormal = double.Parse(Console.ReadLine()!);

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
}