// 1 - Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma mensagem que diga se
// ela poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu).

//tentar com dateTime
// Console.WriteLine($"Digite seu ano de nascimento: ");
// int anoDeNascimento = int.Parse(Console.ReadLine());

// var dataAtual =  DateTime.Now;

// int permitidoVotar = dataAtual - anoDeNascimento;


Console.Write("Digite o ano atual: ");
int anoAtual = int.Parse(Console.ReadLine());

Console.Write("Digite o ano de nascimento: ");
int anoNascimento = int.Parse(Console.ReadLine());

int idade = anoAtual - anoNascimento;

if (idade >= 16)
{
    Console.WriteLine("Você poderá votar este ano!");
}
else
{
    Console.WriteLine("Você não poderá votar este ano!");
}


