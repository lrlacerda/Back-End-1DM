//Faça um programa que peça um nome de usuário e a sua senha e não aceite a senha igual ao nome de usuário, mostrando uma mensagem de erro e voltando pedir as informações.


string nome, senha;

do
{
    Console.Write("Digite o nome de usuário: ");
    nome = Console.ReadLine();
    Console.Write("Digite a senha: ");
    senha = Console.ReadLine();
    if (nome == senha)
    {
        Console.WriteLine("A senha não pode ser igual ao nome de usuário! Tente novamente.");
    }
} while (nome == senha);
{
    Console.WriteLine("Usuário e senha cadastrados com sucesso!");
}

