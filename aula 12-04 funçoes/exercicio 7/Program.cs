// 6 - Escreva um algoritmo que permita a leitura dos nomes de 10 pessoas e armazene os nomes
// lidos em um vetor. Após isto, o algoritmo deve permitir a leitura de mais 1 nome qualquer de
// pessoa (para efetuar uma busca) e depois escrever a mensagem ACHEI, se o nome estiver
// entre os 10 nomes lidos anteriormente (guardados no vetor), ou NÃO ACHEI caso contrário.


string[] nomes = new string[10]; // vetor para armazenar os nomes
for (int i = 0; i < 10; i++) // loop para ler os 10 nomes
{
    Console.Write("Digite o nome da pessoa " + (i + 1) + ": ");
    nomes[i] = Console.ReadLine();
}

Console.Write("Digite o nome que deseja buscar: ");
string nomeBusca = Console.ReadLine();

bool nomeEncontrado = false; // variável para indicar se o nome foi encontrado
for (int i = 0; i < 10; i++) // loop para buscar o nome no vetor
{
    if (nomes[i] == nomeBusca)
    {
        nomeEncontrado = true;
        break;
    }
}

if (nomeEncontrado)
{
    Console.WriteLine($"Nome Encontrado"); // imprime a mensagem de sucesso se o nome foi encontrado
}
else
{
    Console.WriteLine($"NÃO Encontrado"); // imprime a mensagem de erro se o nome não foi encontrado
}

