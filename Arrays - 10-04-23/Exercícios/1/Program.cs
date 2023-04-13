// Criar um programa em c# que receba 5 números inteiros e ao final exiba o seu dobro

//Vc deve utilizar a estrutura array com tamnho 5 para o armazenameto dos números, a estrutura for para a leitura dos números e a estrutura foreach para exibílos


int[] numeros = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.Write($"Digite o {i + 1}º número inteiro: ");
    numeros[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Números digitados (dobro):");
foreach (int numero in numeros)
{
    Console.WriteLine(numero + " =>" + numero * 2);
}

Console.ReadKey();



