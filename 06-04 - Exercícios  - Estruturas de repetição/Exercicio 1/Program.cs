﻿//Faça um programa que peça uma nota entre 0 e 10. Mostre uma mensagem caso o valor seja inválido e continue pedindo até que o usuário informe um valor válido.


int nota;
do
{
    Console.Write("Digite a nota (entre 0 e 10): ");
    nota = int.Parse(Console.ReadLine());
    if (nota < 0 || nota > 10)
    {
        Console.WriteLine("Valor inválido! Digite uma nota entre 0 e 10.");
    }
} while (nota < 0 || nota > 10);
Console.WriteLine("Nota informada: " + nota);
