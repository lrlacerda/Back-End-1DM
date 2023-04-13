// Escreva um programa que receba e imprima o nome e idade de 5 pessoas com foreach c#


string[] nomes = new string[5];
int[] idades = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.Write($"Digite o nome da {i + 1}ª pessoa: ");
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    nomes[i] = Console.ReadLine();
    Console.ResetColor();

    Console.Write($"Digite a idade da {i + 1}ª pessoa: ");
    Console.ForegroundColor = ConsoleColor.Green;
    idades[i] = int.Parse(Console.ReadLine());
    Console.ResetColor();
}

Console.WriteLine("Nomes e idades das pessoas são:");

foreach (string nome in nomes)
{
    int indice = Array.IndexOf(nomes, nome);
    Console.WriteLine("{0}, {1} anos", nome, idades[indice]);
}


//Exercício de fixação
 
 //escreva um programa que receba e imprima o nome e idade de 5 pessoas

 //personalizar cores: a resposta do nome em azul e a resposta da idade em verde (cor da fonte)

//declarando as variáveis
// string[] nomes = new string[5];//collection
// int[] idades = new int[5];//collection

// //recebe e armazena os nomes e idades nos arrays
// for (var i = 0; i < 5; i++)
// {
//     Console.WriteLine($"Informe o {i + 1}º nome: ");
//     nomes[i] = Console.ReadLine();

//     Console.WriteLine($"Informe a {i + 1}º idade: ");
//     idades[i] = int.Parse(Console.ReadLine());         
// }

// //exibe o nome e a idade correspondente
// for (var posicao = 0; posicao < 5; posicao++)
// {
//     Console.ForegroundColor = ConsoleColor.Blue;
//     Console.WriteLine($"{posicao + 1}) nome: {nomes[posicao]}  ");
//     Console.ResetColor();

//     Console.ForegroundColor = ConsoleColor.Green;
//     Console.WriteLine($"  idade: {idades[posicao]} anos");
//     Console.ResetColor();

//     Console.WriteLine($"");    
// }
	

    