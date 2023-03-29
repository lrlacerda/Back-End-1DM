//Programa para calcular a idade de uma pessoa 
//meses
//dias
//horas
//minutos

Console.BackgroundColor = ConsoleColor.DarkBlue;

Console.WriteLine(@$"
_______________________________

    Calcular sua Idade em:
Meses - Dias - Horas - Minutos

_______________________________
");

Console.ResetColor();

Console.WriteLine($"Digite sua Idade: ");
int idade = int.Parse(Console.ReadLine());

int meses = idade * 12;
int dias = idade * 365;
int horas = idade * 24;
int minutos = idade * 60;

Console.WriteLine($"Sua idade corresponde a: (idade) anos, (meses) meses, (dias) dias, (horas) horas, (minutos) minutos.");












