// Escreva um algoritmo que imprima a tabuada (de 1 a 10) para os números de 1 a 10.
// Exemplo: tabuada do 1, tabuada do 2, etc... Dica: utilize um laço dentro do outro.



for(int i=1; i<=10; i++) // loop externo para os números de 1 a 10
{
    Console.WriteLine("Tabuada do " + i + ":"); // imprime a mensagem da tabuada
    for(int j=1; j<=10; j++) // loop interno para a tabuada de 1 a 10
    {
        Console.WriteLine(i + " x " + j + " = " + i*j); // imprime a linha da tabuada
    }
    Console.WriteLine(); // imprime uma linha em branco para separar as tabuadas
}
