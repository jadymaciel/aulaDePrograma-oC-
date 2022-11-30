
Console.WriteLine("Calcular consumo");

double litrosConsumidos;
double kPercorrido;
double totalViagem;
double valorGasolina;
double gasOleo;
double totalGastoGasolina;
double totalGastoGasOleo;

Console.WriteLine("Quantos você consumio: ");
litrosConsumidos = double.Parse(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("Quantos Km pecorridos");
kPercorrido = double.Parse(Console.ReadLine());

Console.WriteLine();

totalViagem = (litrosConsumidos / kPercorrido) * 100;
Console.WriteLine("A cada 100Km é " + totalViagem + "L ");

Console.WriteLine();

Console.WriteLine("Quantidade de litros consumidos: ");
litrosConsumidos = double.Parse(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("Valor do litro da gasolina");
valorGasolina = double.Parse(Console.ReadLine());

Console.WriteLine();

totalGastoGasolina = (litrosConsumidos * valorGasolina);
Console.WriteLine("Total gasto de gasolina " + totalGastoGasolina + " Euros");

Console.WriteLine();
// calcular gasoleo
Console.WriteLine("Valor do litro da gasoleo ");
gasOleo = double.Parse(Console.ReadLine());


Console.WriteLine();

totalGastoGasOleo = (litrosConsumidos * gasOleo);
Console.WriteLine("Total gasto de gasoleo " + totalGastoGasOleo + " Euros");




