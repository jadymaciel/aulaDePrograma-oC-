
Console.WriteLine("Vamos lá");

double num1;
double num2;
double adicao, subtracao, multiplicacao, divisao, resto;

Console.WriteLine("Insira o primeiro número: ");
num1 = double.Parse(Console.ReadLine());

Console.WriteLine("Insira o segundo número: ");
num2 = double.Parse(Console.ReadLine());

Console.WriteLine();

adicao = num1 + num2;
Console.WriteLine("Soma dos números é: " + adicao);

Console.WriteLine();

subtracao = num1 - num2;
Console.WriteLine("Subtração dos números é: " + subtracao);

Console.WriteLine();

multiplicacao = num1 * num2;
Console.WriteLine("Multiplicação dos números é: " + multiplicacao);

Console.WriteLine();

divisao = num1 / num2;
Console.WriteLine("Divisão dos números é: " + divisao);

Console.WriteLine();

resto = num1 % num2;
Console.WriteLine("O resto dos números é: " + resto);

