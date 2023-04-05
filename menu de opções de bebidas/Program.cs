// Crie um menu de opções de bebidas e peça para o usuário escolher uma das opções.
// A depender da opção, exiba uma mensagem se gostaria de acrescentar gelo.
// Se sim, exiba uma mensagem que a bebida em questão será com adicional de gelo, caso contrário, a bebida é sem gelo adicional.


// Exibe o menu de bebidas e solicita a escolha do usuário

Console.ForegroundColor = ConsoleColor.DarkMagenta;

Console.WriteLine(@$"
             Bem vindo a Destilaria Barão!!
    ");
Console.WriteLine(@$"
   _____________________________________________________ 
   |                 MENU DE BEBIDAS                   |
   |                 1 - Água                          |
   |                 2 - Refrigerante                  |
   |                 3 - Suco                          |
   |                 4 - Batidas                       |
   |                 5 - Destilados                    |
   _____________________________________________________

    ");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Blue;

Console.Write("Escolha uma opção: ");
int escolha = int.Parse(Console.ReadLine());

Console.ResetColor();

// Verifica a escolha do usuário e solicita a adição de gelo se necessário
switch (escolha)
{
    case 1:
        Console.Write("Gostaria de adicionar gelo à água? (S/N): ");
        break;
    case 2:
        Console.Write("Gostaria de adicionar gelo ao refrigerante? (S/N): ");
        break;
    case 3:
        Console.Write("Gostaria de adicionar gelo ao suco? (S/N): ");
        break;
    case 4:
        Console.Write("Gostaria de adicionar gelo à Batida? (S/N): ");
        break;
    case 5:
        Console.Write("Gostaria de adicionar gelo ao Destilado? (S/N): ");
        break;
    default:
        Console.WriteLine("Opção inválida!");
        return;
}

// Verifica se o usuário deseja adicionar gelo ou não
Console.ForegroundColor = ConsoleColor.Blue;

string resposta = Console.ReadLine().ToUpper();
if (resposta == "S")
{
    Console.WriteLine("Bebida com adicional de gelo!");
}
else
{
    Console.WriteLine("Bebida sem gelo adicional.");
}

Console.ResetColor();




