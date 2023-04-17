﻿// 6 - Escreva um algoritmo que permita a leitura dos nomes de 10 pessoas e armazene os nomes
// lidos em um vetor. Após isto, o algoritmo deve permitir a leitura de mais 1 nome qualquer de
// pessoa (para efetuar uma busca) e depois escrever a mensagem ACHEI, se o nome estiver
// entre os 10 nomes lidos anteriormente (guardados no vetor), ou NÃO ACHEI caso contrário.


Console.WriteLine(@$"

_________________________________________
        Programa para procura 
              de Nomes
_________________________________________

");

// vetor para armazenar os nomes
string[] nomes = new string[10];
// loop para ler os 10 nomes 
for (int i = 0; i < 10; i++)
{
    Console.Write("Digite o nome da pessoa " + (i + 1) + ": ");
    nomes[i] = Console.ReadLine().ToLower();
}

Console.Write("\nDigite o nome que deseja buscar: ");
string nomeBusca = Console.ReadLine().ToLower();

// variável para indicar se o nome foi encontrado
bool nomeEncontrado = false;

// loop para buscar o nome no vetor
for (int i = 0; i < 10; i++)
{
    if (nomes[i] == nomeBusca)
    {
        nomeEncontrado = true;
        break;
    }
}
 
if (nomeEncontrado)
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine($"\nNome Encontrado"); // imprime a mensagem de sucesso se o nome foi encontrado
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine($"\nNome NÃO Encontrado"); // imprime a mensagem de erro se o nome não foi encontrado
    Console.ResetColor();
}


//Outra forma de fazer

// bool encontrado = false;

// for (var i = 0; i < nomes.Length; i++)
// {
//     Console.WriteLine($"Informe o {i + 1}º nome: ");
//     nomes[i] = Console.ReadLine();    
// }

// Console.WriteLine($"Informe um nome a ser buscado: ");
// string nomeBuscado = Console.ReadLine();

// //processamento
// foreach (string nome in nomes)
// {
//    if (nome == nomeBuscado)
//    {
//         encontrado = true;
//         break;
//    } 
// }

// //saída
// if (encontrado == true)
// {
//     Console.WriteLine($"ACHEIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII!!!!!!!!!!!!!");    
// }
// else
// {
//     Console.WriteLine($"NÃO  ACHEIIIIIIIIIIIIIIIIIIIIIIIII!");    
// }

// string resultadoPesquisa = encontrado == true ? "ACHEI" : "NÃO ACHEI";
// Console.WriteLine(resultadoPesquisa);

// Console.WriteLine(encontrado == true ? "ACHEI" : "NÃO ACHEI");