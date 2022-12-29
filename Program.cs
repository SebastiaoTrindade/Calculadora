
Menu();

static void Menu()
{
    Console.Clear();

    Console.WriteLine("O que deseja fazer?");
    Console.WriteLine("");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Divisão");
    Console.WriteLine("4 - Multiplicação");
    Console.WriteLine("5 - Sair");

    Console.WriteLine("");
    Console.WriteLine("---------------------------");

    Console.WriteLine("");
    Console.WriteLine("Selecione uma opção");

    short res = short.Parse(Console.ReadLine());

    switch (res)
    {
        case 1:
            Soma();
            break;

        case 2:
            Subtracao();
            break;

        case 3:
            Divisao();
            break;

        case 4:
            Multiplicacao();
            break;

        case 5:
            Sair();             
            break;            

        default:
            Menu();
            break;
    }

}

static void Sair()
{
    Console.WriteLine("Obrigado por utilizar a calculadora!!!");
    Environment.Exit(0);    
}

// Método Soma
static void Soma()
{
    Console.Clear();

    Console.WriteLine("Primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float resultado = v1 + v2;

    Console.WriteLine($"O resultado da soma é : {resultado}");
    Console.ReadKey();
    Menu();

}

// Metodo Subtracao
static void Subtracao()
{
    Console.Clear();

    Console.WriteLine("Primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float resultado = v1 - v2;

    Console.WriteLine($"O resultado da subtração é : {resultado}");
    Console.ReadKey();
    Menu();
}

// Metodo Divisão
static void Divisao()
{
    Console.Clear();

    Console.WriteLine("Primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float resultado = v1 / v2;

    Console.WriteLine($"O resultado da divisão é : {resultado}");
    Console.ReadKey();
    Menu();
}

// Metodo Multiplicacao
static void Multiplicacao()
{
    Console.Clear();

    Console.WriteLine("Primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float resultado = v1 * v2;

    Console.WriteLine($"O resultado da multiplação é : {resultado}");
    Console.ReadKey();
    Menu();    
}
