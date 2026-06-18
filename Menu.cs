public class Menu
{
    public static void Exibir()
    {
        int opcao;

        do
        {
            Console.Clear();

            Console.WriteLine("===== MENU PRINCIPAL =====");
            Console.WriteLine("1 - Verificação de idade para entrada em evento");
            Console.WriteLine("2 - Situação final do estudante");
            Console.WriteLine("3 - Classificação de temperatura ambiente");
            Console.WriteLine("4 - Cálculo de compra com desconto");
            Console.WriteLine("5 - Verificação de meta de produtividade");
            Console.WriteLine("6 - Classificação por faixa etária");
            Console.WriteLine("7 - Atividade 5Maior valor entre dois números");
            Console.WriteLine("8 - Maior valor entre três números");
            Console.WriteLine("9 - Identificação de número par ou ímpar");
            Console.WriteLine("10 - Cálculo de passagem por idade");
            Console.WriteLine("11 - Contagem progressiva");
            Console.WriteLine("12 - Contagem regressiva");
            Console.WriteLine("13 - Tabuada de um número");
            Console.WriteLine("14 - Soma e média de cinco valores");
            Console.WriteLine("15 - Relatório de números positivos, negativos e zero");
            Console.WriteLine("16 - Controle de acesso por senha numérica");
            Console.WriteLine("17 - Validação de nota");
            Console.WriteLine("18 - empo total de atendimento");
            Console.WriteLine("19 - Simulação de movimentação de caixa");
            Console.WriteLine("20 - Controle simples de estoque");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");

            opcao = int.Parse(Console.ReadLine()!);

            switch (opcao)
            {
                      case 1:
                    AtividadesCondicionais.Atividade01();
                    break;

                     case 2:
                    AtividadesCondicionais.Atividade02();
                    break;

                     case 3:
                    AtividadesCondicionais.Atividade03();
                    break;

                     case 4:
                    AtividadesCondicionais.Atividade04();;
                    break;

                     case 5:
                    AtividadesCondicionais.Atividade05();;
                    break;

                     case 6:
                    AtividadesCondicionais.Atividade06();;
                    break;

                     case 7:
                    AtividadesCondicionais.Atividade07();;
                    break;

                     case 8:
                    AtividadesCondicionais.Atividade08();;
                    break;

                     case 9:
                    AtividadesCondicionais.Atividade09();;
                    break;

                     case 10:
                    AtividadesCondicionais.Atividade10();
                    break;
                    
                     case 11:
                    AtividadesRepeticao.Atividade11();
                    break;
                    
                    case 12:
                    AtividadesRepeticao.Atividade12();
                    break;

                    case 13:
                    AtividadesRepeticao.Atividade13();
                    break;

                    case 14:
                    AtividadesRepeticao.Atividade14();
                    break;

                    case 15:
                    AtividadesRepeticao.Atividade15();
                    break;

                    case 16:
                    AtividadesRepeticao.Atividade16();
                    break;

                    case 17:
                    AtividadesRepeticao.Atividade17();
                    break;

                   case 18:
                    AtividadesRepeticao.Atividade18();
                    break;

                    case 19:
                    AtividadesSistemas.Atividade19();
                    break;

                    case 20:
                    AtividadesSistemas.Atividade20();
                    break;

                case 0:
                    Console.WriteLine("Encerrando...");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

            if (opcao != 0)
            {
                Console.WriteLine();
                Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
            }

        } while (opcao != 0);
    }
}
