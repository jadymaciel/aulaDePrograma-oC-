double nota1, nota2, notaFinal;
string nome;

Console.WriteLine("Insira o nome do aluno");
nome = Console.ReadLine();

Console.WriteLine("");
Console.WriteLine("Insira a nota do primeiro teste: ");
nota1 = double.Parse(Console.ReadLine());

Console.WriteLine("");
Console.WriteLine("Insira a nota do segundo teste: ");
nota2 = double.Parse(Console.ReadLine());

if (nota1 >= 8.5 && nota2 >= 9) 
{
    notaFinal = (nota1 + nota2) / 2;

    if (notaFinal >= 10 && notaFinal < 17)
    {
        Console.WriteLine("");
        Console.WriteLine("O aluno {0} está aprovado com a nota {1}.", nome, notaFinal);
    }
    else if (notaFinal >= 17)
    {
        Console.WriteLine("");
        Console.WriteLine("Introduza a nota do aluno (defesa oral) {0}: ", nome);
        notaFinal = double.Parse(Console.ReadLine());
        Console.WriteLine("");
        Console.WriteLine("A classificação final do aluno {0}, é {1}. ", nome, notaFinal);
    }

    else
    {
        Console.WriteLine("");
        // Esse {0} ele é como o "+" para concatena a variavel, ex:"nome", pode se utilizar o Ex: "O aluno" + nome + "está reprovado!"; ou pode ser assim
        // "O aluno {0} está reprovado!", nome;
        Console.WriteLine("O aluno {0} está reprovado!", nome);
    }
}
Console.ReadKey();