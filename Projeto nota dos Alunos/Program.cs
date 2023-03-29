//Faça um programa que receba 5 notas de um aluno e calcule a média aritimética. Imprimir a resposta no console

Console.WriteLine($"Digite as notas do aluno: ");

float nota1 = float.Parse(Console.ReadLine());
float nota2 = float.Parse(Console.ReadLine());
float nota3 = float.Parse(Console.ReadLine());
float nota4 = float.Parse(Console.ReadLine());
float nota5 = float.Parse(Console.ReadLine());

float mediaDoAluno = ((nota1 + nota2 + nota3 + nota4 + nota5) / 5);

Console.WriteLine("Média do Aluno: " + (mediaDoAluno));





