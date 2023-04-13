// Um posto está vendendo combustíveis com a seguinte tabela de descontos:
// Álcool:
// . até 20 litros, desconto de 3% por litro Álcool
// . acima de 20 litros, desconto de 5% por litro
// Gasolina:
// . até 20 litros, desconto de 4% por litro Gasolina
// . acima de 20 litros, desconto de 6% por litro

// Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado
// da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente
// sabendo-se que o preço do litro da gasolina é R$ 5,30 e o preço do litro do álcool é R$ 4,90.
// Dica: utilize switch case e funções/métodos para otimizar o algorítimo.


double precoGasolina = 5.30;
double precoAlcool = 4.90;

Console.Write("Digite o tipo de combustível (A-álcool, G-gasolina): ");
char tipoCombustivel = char.Parse(Console.ReadLine().ToUpper());

Console.Write("Digite a quantidade de litros: ");
double quantidadeLitros = double.Parse(Console.ReadLine());

double precoLitro = 0;
double descontoLitro = 0;

switch (tipoCombustivel)
{
    case 'A':
        precoLitro = precoAlcool;
        if (quantidadeLitros <= 20)
        {
            descontoLitro = 0.03;
        }
        else
        {
            descontoLitro = 0.05;
        }
        break;
    case 'G':
        precoLitro = precoGasolina;
        if (quantidadeLitros <= 20)
        {
            descontoLitro = 0.04;
        }
        else
        {
            descontoLitro = 0.06;
        }
        break;
    default:
        Console.WriteLine("Tipo de combustível inválido!");
        return;
}

double valorTotal = quantidadeLitros * precoLitro * (1 - descontoLitro);
Console.WriteLine("Valor a ser pago: R$ " + valorTotal.ToString("F2"));





