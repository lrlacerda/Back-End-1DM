// 7 - Faça um algoritmo para ler 15 números e armazenar em um vetor. Após a leitura total dos
// 15 números, o algoritmo deve escrever esses 15 números lidos na ordem inversa da qual foi
// declarado.

Console.WriteLine(@$"

________________________________________
        Programa para imprimir 
         os numeros na ordem 
              INVERSA
________________________________________

");


int[] numeros = new int[15]; // vetor para armazenar os números

for (int i = 0; i < 15; i++) // loop para ler os 15 números
{
    Console.Write("Digite o número " + (i + 1) + ": ");
    numeros[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Números na ordem inversa:"); 
for (int i = 14; i >= 0; i--) // loop para imprimir os números na ordem inversa
{
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine(numeros[i]);
    Console.ResetColor();
}
