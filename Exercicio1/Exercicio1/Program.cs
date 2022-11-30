/*Um professor pretende encontrar uma forma simplificada de calcular a nota final à disciplina de
inglês de um aluno. A fórmula que usa na sua metodologia de avaliação considera uma ponderação
diferente do primeiro teste (t1) para o segundo (t2).*/
Console.WriteLine(" ================== Nota do Aluno ==================");

double nota1; 
double nota2;
double notaFinal;
string nome;

Console.WriteLine("Escreva o nome do aluno: ");
nome = Console.ReadLine();

Console.WriteLine();

Console.WriteLine("Insira a primeira nota do aluno");
nota1 = double.Parse(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("Insira a segunda nota do aluno");
nota2 = double.Parse(Console.ReadLine());

Console.WriteLine();

double p1 = 0.4;
double p2 = 0.6;
notaFinal = ((p1 * nota1) + (p2 * nota2));

Console.WriteLine("Nota final " + nome + "(a) é: " + notaFinal );








