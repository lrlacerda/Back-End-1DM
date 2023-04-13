// Faça um algoritmo para ler: a descrição do produto (nome), a quantidade adquirida e o
// preço unitário. Calcular e escrever o total (total = quantidade adquirida * preço unitário), o
// desconto e o total a pagar (total a pagar = total - desconto), sabendo-se que:
// - Se quantidade <= 5 o desconto será de 2%
// - Se quantidade > 5 e quantidade <=10 o desconto será de 3%
// - Se quantidade > 10 o desconto será de 5%
// Dica: utilize if / else if / else


Console.Write("Digite a descrição do produto: ");
string nome = Console.ReadLine();

Console.Write("Digite a quantidade adquirida: ");
int quantidade = int.Parse(Console.ReadLine());

Console.Write("Digite o preço unitário: R$ ");
double precoUnitario = double.Parse(Console.ReadLine());

double total = quantidade * precoUnitario;
double desconto = 0;

if (quantidade <= 5)
{
    desconto = total * 0.02;
}
else if (quantidade > 5 && quantidade <= 10)
{
    desconto = total * 0.03;
}
else
{
    desconto = total * 0.05;
}

double totalAPagar = total - desconto;

Console.WriteLine("Produto: " + nome);
Console.WriteLine("Quantidade adquirida: " + quantidade);
Console.WriteLine("Preço unitário: R$ " + precoUnitario.ToString("F2"));
Console.WriteLine("Total: R$ " + total.ToString("F2"));
Console.WriteLine("Desconto: R$ " + desconto.ToString("F2"));
Console.WriteLine("Total a pagar: R$ " + totalAPagar.ToString("F2"));


