Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.WriteLine(@$"

 ___________________________
|       Programa para       |
|        Calcular IMC       |
|___________________________|

");

Console.ResetColor();

//entrada

Console.Write($"Digite o nome do paciente: ");
string? nome = Console.ReadLine();

Console.WriteLine($"Bem vindo ao nosso sistema! (nome)");

Console.Write($"Informe o peso do paciente: ");
float peso = float.Parse(Console.ReadLine());

Console.Write($"Informe a altura do paciente: ");
float altura = float.Parse(Console.ReadLine());


float imc = (peso / ((float) Math.Pow(altura,2)));

Console.WriteLine($"O Paciente", (nome) "tem imc igual à: ", (imc));

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine($"Obrigado por usar nosso sistema!");
Console.ResetColor();







