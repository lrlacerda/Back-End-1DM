// 3) Escreva um programa que pergunte o raio de uma circunferência, e em seguida mostre o diâmetro, comprimento e área da circunferência.

Console.Write($"Qual o raio da circunferência: ");
float raio = float.Parse(Console.ReadLine());

float diametro = raio * 2;
Console.WriteLine($"O Diâmetro da circunferência é: " + diametro);

float comprimento = (float)(2 * Math.PI * raio);
Console.WriteLine($"O Diâmetro da circunferência é: " + comprimento);

float area = (float)(Math.PI * raio * raio);
Console.WriteLine($"O Diâmetro da circunferência é: " + area);

