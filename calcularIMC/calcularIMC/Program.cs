double peso, altura, imc;
string nome, msg;

Console.WriteLine("Olá, informe o seu nome: ");
nome = Console.ReadLine();

Console.WriteLine("\nInsira seu peso: ");
peso = double.Parse(Console.ReadLine());

Console.WriteLine("\nInsira sua altura: ");
altura = double.Parse(Console.ReadLine());

imc = peso / (altura * altura);

if (imc <= 18.5)
{
    msg = "Peso abaixo do Recomendado!!";
    Console.WriteLine(msg);
}
else if (imc <= 25)
{
    msg = "Peso Normal!!!";
    Console.WriteLine(msg);
}
else if (imc <= 30)
{
    msg = "Peso acima do recomendado!!";
    Console.WriteLine(msg);
}
else
{
    msg = "Peso muito acima do recocomandado!!";
    Console.WriteLine(msg);
}

Console.WriteLine("O Senhor(a) {0} tem de IMC: {1} que equivale a {2}", nome, imc.ToString("0.00"), msg);