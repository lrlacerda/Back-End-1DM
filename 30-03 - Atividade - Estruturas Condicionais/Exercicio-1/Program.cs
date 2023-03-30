// 1) Faça um programa que o usuário informe o salário recebido e o total gasto. Deverá ser exibido na tela “Gastos dentro do orçamento” caso o valor gasto não ultrapasse o valor do salário e “Orçamento estourado” se o valor gasto ultrapassar o valor do salário.


//salário recebido
Console.Write($"Informe o Salário: ");
float salarioRecebido = float.Parse(Console.ReadLine());

//total gasto
Console.Write($"Informe o Total de gastos: ");
float totalDeGastos = float.Parse(Console.ReadLine());

//condicional
if (totalDeGastos <= salarioRecebido)
{
    System.Console.WriteLine("Gastos dentro do orçamento");
}
else
{
    System.Console.WriteLine("Orçamento estourado");
}