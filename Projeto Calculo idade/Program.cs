//Faça um programa que receba o ano do nascimento de uma pessoa e calcule a idade dessa pessoa em anos e semanas e imprima o resultado no console.

//Observação: obter a data atual do sistema (Pesquisar na documentação)

// Recebe o ano de nascimento da pessoa
Console.Write("Digite o ano de nascimento: ");
int ano_nascimento = int.Parse(Console.ReadLine());

// Obtém o ano atual
int ano_atual = DateTime.Today.Year;

// Calcula a idade em anos e semanas
int idade_anos = ano_atual - ano_nascimento;
int idade_semanas = idade_anos * 52;

// Exibe a idade em anos e semanas
Console.WriteLine("A idade da pessoa é " + idade_anos + " anos (" + idade_semanas + " semanas)");