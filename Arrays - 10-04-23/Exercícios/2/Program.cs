// Escreva um programa que receba e imprima o nome e idade de 5 pessoas com foreach c#


string[] nomes = new string[5];
int[] idades = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.Write($"Digite o nome da {i + 1}ª pessoa: ");
    nomes[i] = Console.ReadLine();

    Console.Write($"Digite a idade da {i + 1}ª pessoa: ");
    idades[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Nomes e idades das pessoas são:");

foreach (string nome in nomes)
{
    int indice = Array.IndexOf(nomes, nome);
    Console.WriteLine("{0}, {1} anos", nome, idades[indice]);
}





