// 2) Faça um programa que leia três números e mostre o maior e o menor deles.

Console.Write("Digite o primeiro número: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Digite o segundo número: ");
int num2 = int.Parse(Console.ReadLine());

Console.Write("Digite o terceiro número: ");
int num3 = int.Parse(Console.ReadLine());


if (num1 > num2 && num1 > num3)
{
    Console.Write("Maior número: " + num1);
}
else if (num2 > num1 && num2 > num3)
{
    Console.Write("Maior número: " + num2);
}
else
{
    Console.Write("Maior número: " + num3);
}