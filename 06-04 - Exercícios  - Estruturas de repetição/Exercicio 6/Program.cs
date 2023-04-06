// Faça um programa que receba a
// idade, o peso e o sexo de 10 pessoas. Calcule e imprima:

// Total de Homens;

// Total de Mulheres;

// Média de idade dos Homens;

// Média de idade das mulheres.


int totalHomens = 0;
int totalMulheres = 0;
int somaIdadeHomens = 0;
int somaIdadeMulheres = 0;

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Pessoa {i}:");
    Console.Write("Idade: ");
    int idade = int.Parse(Console.ReadLine());

    Console.Write("Peso: ");
    double peso = double.Parse(Console.ReadLine());

    Console.Write("Sexo (M ou F): ");
    char sexo = char.Parse(Console.ReadLine());

    if (sexo == 'M')
    {
        totalHomens++;
        somaIdadeHomens += idade;
    }
    else if (sexo == 'F')
    {
        totalMulheres++;
        somaIdadeMulheres += idade;
    }
    else
    {
        Console.WriteLine("Sexo inválido. Digite M ou F.");
        i--;
    }
}

Console.WriteLine($"Total de homens: {totalHomens}");
Console.WriteLine($"Total de mulheres: {totalMulheres}");

if (totalHomens > 0)
{
    double mediaIdadeHomens = (double)somaIdadeHomens / totalHomens;
    Console.WriteLine($"Média de idade dos homens: {mediaIdadeHomens}");
}
else
{
    Console.WriteLine("Não há homens na lista.");
}

if (totalMulheres > 0)
{
    double mediaIdadeMulheres = (double)somaIdadeMulheres / totalMulheres;
    Console.WriteLine($"Média de idade das mulheres: {mediaIdadeMulheres}");
}
else
{
    Console.WriteLine("Não há mulheres na lista.");
}











