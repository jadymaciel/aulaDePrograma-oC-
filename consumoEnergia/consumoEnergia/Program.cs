string opcaoEscolha, nome;
int kwEstimativa;
double valorEstimado, /*valorIva,*/ valorFinal;

Console.WriteLine("===== Estimativa do custo mensal de energia =====");
Console.WriteLine(" Nome do cliente");
nome = Console.ReadLine();
Console.WriteLine("");

Console.WriteLine("      Escolha o seu tipo de cliente: ");
Console.WriteLine("          > 1 - Particulares (continente)");
Console.WriteLine("          > 2 - Particulares (ilhas)");
Console.WriteLine("          > A - Pequenas empresas");
Console.WriteLine("          > B - Medias e grandes empresas");
Console.WriteLine("          > C - Estados e organismos públicos");
Console.WriteLine("");
Console.WriteLine("                        Opcção: ");

// opção escolha
opcaoEscolha = Console.ReadLine();
Console.WriteLine("");

Console.WriteLine("   Insira os Km que estima consumir no mês: ");
kwEstimativa = int.Parse(Console.ReadLine());

switch (opcaoEscolha)
{
    case "1":
        valorEstimado = kwEstimativa * 0.1865;
        break;

    case "2":
        valorEstimado = kwEstimativa * 0.1875;
        break;

    case "A": case "a":
        valorEstimado = kwEstimativa * 0.1754;
        break;

    case "B": case "b":
        valorEstimado = kwEstimativa * 0.1592;
        break;

    case "C": case "c":
        valorEstimado = kwEstimativa * 0.1311;
        break;

    default:
        valorEstimado = -1;
        break;

}

valorFinal = (valorEstimado * (23.0 / 100));
/*valorIva = ( valorFinal - valorEstimado);*/


Console.WriteLine("");
Console.WriteLine("===== RESULTADO ============");

if (valorEstimado > 0)
    Console.WriteLine("Valor mensal estimado do cliente {0} é:  {1} Eur." /*\nValor do iva {2}*/, nome, valorFinal.ToString("###,##0.00") /*, valorIva.ToString("###,##0.00")*/);


else
    Console.WriteLine("((tipo de cliente iserido inválido! ))");

Console.ReadKey();