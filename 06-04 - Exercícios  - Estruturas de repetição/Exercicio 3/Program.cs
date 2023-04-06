// Faça um programa que receba um número inteiro e mostre a sua tabuada.



Console.Write("Digite um número inteiro: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine("Tabuada de " + num + ":");
for (int i = 0; i <= 10; i++)
{
    Console.WriteLine(num + " x " + i + " = " + (num * i));
}
