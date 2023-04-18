// aplicar o seguinte projeto para gerenciamento de 10 produtos pelo console:

// Os produtos terão os seguintes atributos:
// string Nome
// float Preco
// bool Promocao (se está em promoção ou não)

// O sistema deverá ter as seguintes funcionalidades:
// cadastrarProduto
// ListarProdutos
// mostrarMenu
// Crie função(ões) para otimizar o código.
// Incremente o que achar necessário. Utilize sua lógica e sua criatividade.


using Projeto___Sistema_de_Produtos;


GerenciadorProdutos gerenciador = new GerenciadorProdutos();
int opcao = -1;

while (opcao != 0)
{
    gerenciador.mostrarMenu();
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            gerenciador.cadastrarProduto();
            break;
        case 2:
            gerenciador.ListarProdutos();
            break;
        case 0:
            Console.WriteLine("\nPrograma encerrado.");
            break;
        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nOpção inválida.\n");
            Console.ResetColor();
            break;
    }
}


