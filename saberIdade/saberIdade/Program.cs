// Exercício 1

/*
string nome;
int idade, maioridade;
bool maior;

nome = "Jady";
idade = 26;
maioridade = 18;

maior = idade >= maioridade;

Console.WriteLine("O {0} é maior de idade?: {1}", nome, maior);

Console.ReadKey();

*/

// Exercício 2

/*
string nome = "Jady";
int idade = 26;
float altura = 1.70F;
bool cartaConducao = false;
bool consegueConduzir;


consegueConduzir = (altura >= 1.50F) && ((idade >= 22)) || (cartaConducao == true);

Console.WriteLine("O {0} consegue conduzir?: {1}", nome, consegueConduzir.ToString());

Console.ReadKey();

*/

// Exercício 3

/*
string nome;
ushort idade;
float altura;

Console.WriteLine("insira o nome: ");
nome = Console.ReadLine();

Console.WriteLine("insira sua idade: ");
idade = ushort.Parse(Console.ReadLine());

Console.WriteLine("insira sua altura: ");
altura = float.Parse(Console.ReadLine());

Console.WriteLine("\tO {0} tem {1} anos e\n\tmede {2}m de altura.\n", nome, idade.ToString("0000#"), altura.ToString("##0.000"));

Console.ReadKey();

*/

int num1, num2, num3;
float media;

Console.Clear();

Console.WriteLine("========= Calcular a média ==================================");
Console.WriteLine(" By Jady MAciel");
Console.WriteLine("");
Console.WriteLine("");

Console.Write("   Insira o valor 1/3: ");
num1 = int.Parse(Console.ReadLine());

Console.WriteLine("");
Console.Write("   Insira o valor 2/3: ");
num2 = int.Parse(Console.ReadLine());

Console.WriteLine("");
Console.Write("  Insira o valor 3/3: ");
num3 = int.Parse(Console.ReadLine());

media = (num1 + num2 + num3) / 3.0F;

Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("   A média é {0}.", media);

Console.ReadKey();
