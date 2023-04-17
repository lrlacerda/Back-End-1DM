// Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: Nome do passageiro, Origem, Destino e Data do Voo de 5 passageiros.

// Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à 123456.
// O sistema deve exibir um menu com as seguintes opções:

// 1- Cadastrar passagem
// 2- Listar Passagens
// 0- Sair

// Ao cadastrar uma passagem ao final o sistema deverá perguntar se gostaria de cadastrar uma nova passagem caso contrário voltar ao menu anterior(S/N).


const string senha = "123456";


// Solicitando a senha ao usuário
Console.Write("Digite a senha de acesso: ");
string senhaDigitada = Console.ReadLine();

// Verificando se a senha está correta. Terminar de fazer o while para pedir a senha novamente 
if (senhaDigitada != senha)
{
    Console.WriteLine("Senha incorreta, digite novamente: ");
    return;
}

int opcao = -1;
while (opcao != 0)
{
    Console.WriteLine("\n==== AGÊNCIA DE TURISMO ====");
    Console.WriteLine("1- Cadastrar passagem");
    Console.WriteLine("2- Listar passagens");
    Console.WriteLine("0- Sair");
    Console.Write("\nDigite a opção desejada: ");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            CadastrarPassagem();
            break;
        case 2:
            ListarPassagens();
            break;
        case 0:
            Console.WriteLine("O programa será encerrado.");
            break;
        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
}

static void ListarPassagens()
{
    throw new NotImplementedException();
}

static void CadastrarPassagem()
{
    Console.WriteLine("\n==== CADASTRO DE PASSAGEM ====");

    // Definindo o tamanho máximo do array de passageiros
    

    // Criando os arrays para armazenar os dados dos passageiros
    string[] nomes = new string[5];
    string[] origens = new string[5];
    string[] destinos = new string[5];
    DateTime[] datas = new DateTime[5];

    // Solicitando os dados dos passageiros
    int indice = 0;
    while (indice < 5)
    {
        Console.Write($"\nDigite o nome do {indice + 1}º passageiro (ou digite SAIR para encerrar): ");
        string nome = Console.ReadLine();

        if (nome.ToUpper() == "SAIR")
        {
            break;
        }

        Console.Write("Digite a origem da passagem: ");
        string origem = Console.ReadLine();

        Console.Write("Digite o destino da passagem: ");
        string destino = Console.ReadLine();

        Console.Write("Digite a data do voo (formato DD/MM/AAAA): ");
        DateTime data = DateTime.Parse(Console.ReadLine());

        nomes[indice] = nome;
        origens[indice] = origem;
        destinos[indice] = destino;
        datas[indice] = data;

        indice++;
    }

    // Exibindo a lista de passageiros cadastrados
    Console.WriteLine("\n==== PASSAGEIROS CADASTRADOS ====");
    for (int i = 0; i < indice; i++)
    {
        Console.WriteLine($"Nome: {nomes[i]} | Origem: {origens[i]} | Destino: {destinos[i]} | Data do voo: {datas[i]:dd/MM/yyyy}");
    }

    // Perguntando se deseja cadastrar uma nova passagem
    Console.Write("\nDeseja cadastrar uma nova passagem? (S/N): ");
    string resposta = Console.ReadLine();

    if (resposta.ToUpper() == "S")
    {
        CadastrarPassagem();
    }

}
















