// Exercício 1
/*Console.WriteLine("Vai mostra de 1 a 10");
for(int i = 1; i < 11; i++)
{
    Console.WriteLine(i);
}
*/

using System.Runtime.Serialization;
// Exercício 2
//static void Main(string[] args)


/* 
 int soma = 0;
 for (int i = 1; i < 51; i++)
 {
     soma = soma + i;
 }
 Console.WriteLine(soma);
*/

// Exercício 3

/*
int i;
for (i = 1; i <= 10; i++)
{
    Console.WriteLine("Tabuada 5 * {0} = {1}", i, 5 * i);
}
*/

// Exercício 4

/*
int num, i;
Console.WriteLine("Insira um número ");
num = Convert.ToInt32(Console.ReadLine());
for (i = 1; i <= 10; i++)
{
    Console.WriteLine("Tabuada: {0} * {1} = {2}", num, i, num*i);
}
*/

// Exercício 5
/*
int num, i;

Console.WriteLine("Insira um número: ");
num = Convert.ToInt32(Console.ReadLine());
bool eprimo = true;
for (i = 2; i < num; i++)
{
    if (num % i == 0)
    eprimo = false;
}
if (eprimo)
    Console.WriteLine("O número {0} é primo. ", num);
else
    Console.WriteLine("O número {0} não é primo. ", num);
*/

//

int num, i;

Console.WriteLine("Insira um número: ");
num = Convert.ToInt32(Console.ReadLine());
bool eprimo = true;
for (i = 2; i < Math.Sqrt(num); i++)
{
    if (num % i == 0)
        eprimo = false;
}
if (eprimo)
    Console.WriteLine("O número {0} é primo. ", num);
else
    Console.WriteLine("O número {0} não é primo. ", num);

