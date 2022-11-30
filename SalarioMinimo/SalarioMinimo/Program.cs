

    double salarioMinimo = 705.0;
    double STx = 0.035;

    string nome;
    double salFunc, salFinal;

    Console.WriteLine("Insira o nome do funcionario: ");
    nome = Console.ReadLine();

    Console.WriteLine("");
    Console.WriteLine("Insira o salário do funcionario: ");
    salFunc = Convert.ToDouble(Console.ReadLine());

    if (salFunc > salarioMinimo)
    {
        salFinal = salFunc - ((salFunc - salarioMinimo) * STx);
        double vSTx = ((salFunc - salarioMinimo) * STx);
        
        Console.WriteLine("");
        Console.WriteLine("Salário final do funcionario {0} é de {1}euro e o valor da sobretaxa é {2}", nome, salFinal, vSTx );
    }
    else
    {
    Console.WriteLine("");
    Console.WriteLine("não será aplicado ao salario a sobretaxa!");

    }

    Console.ReadKey();

