﻿//Criando uma calculadora usando o Switch Case.

// 1 definir operação
// 2 informar o primeiro número
// 3 informar o segundo número
// 4 processar os dados inseridos
// 5 exibir o resultado


//Entrada
 Console.WriteLine(@$"
 
 
 
 
 
 
 
 
 ");

 //Recebe a operação escolhida

 char operacao = char.Parse(Console.ReadLine());

 //Entrada do primeiro número

 Console.WriteLine($"Digite o primeiro número: ");
 float numero1 = float.Parse(Console.ReadLine());

 //Entrada segundo número

 Console.WriteLine($"Digite o segundo número: ");
 float numero2 = float.Parse(Console.ReadLine());
 
//Variavel que vai receber o resultado

float resultado = 0;

//processamento

switch (operacao)
{
    case '+':
    resultado = (numero1 + numero2);
    Console.WriteLine($"O resultado da soma é:  {resultado}");
    break;
    case '-':
    resultado = (numero1 - numero2);
    Console.WriteLine($"O resultado da subtração é:  {resultado}");
    break;
    case '*':
    resultado = (numero1 * numero2);
    Console.WriteLine($"O resultado da multiplicação é:  {resultado}");
    break;
    case '/':
    resultado = (numero1 / numero2);
    Console.WriteLine($"O resultado da divisão é:  {resultado}");
    break;

    default:
    Console.WriteLine($"A operação informada não é suportada pela nossa calculadora");
        break;
}

 