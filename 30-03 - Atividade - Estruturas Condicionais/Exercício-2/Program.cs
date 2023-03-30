// 2) Desenvolva um programa que recebe do usuário, o placar de um jogo de futebol (os gols de cada time) e informa se o resultado foi um empate, se a vitória foi do primeiro time ou do segundo time.

//placar de cada time
System.Console.Write("Informe os gols do time A: ");
int golsTimeA = int.Parse(Console.ReadLine());

System.Console.Write("Informe os gols do time B: ");
int golsTimeB = int.Parse(Console.ReadLine());

//resultado
if (golsTimeA == golsTimeB)
{
    System.Console.WriteLine("Empate!");
}
else if (golsTimeA > golsTimeB)
{
    System.Console.WriteLine("Vitória do Time A");
}
else
{
    System.Console.WriteLine("Vitória do Time B");
}
