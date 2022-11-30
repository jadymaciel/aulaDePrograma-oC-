string nome;
int idade;
string conducao;


Console.WriteLine("Escreva o nome do condutor: ");
nome = Console.ReadLine();

Console.WriteLine("Digite a idade do condutor: ");
idade = int.Parse(Console.ReadLine());


if (idade >= 18)
{
    Console.WriteLine("Pode tirar a carteira!!");
} else if (idade < 18)
{
    Console.WriteLine("O condutor não pode tirar carta!!" );
    Console.WriteLine();
    Console.WriteLine("Anos que falta para tirar a carta = " + (18 - idade) + " ano");
}

