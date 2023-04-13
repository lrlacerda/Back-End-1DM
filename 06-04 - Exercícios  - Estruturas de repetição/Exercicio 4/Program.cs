//Uma certa empresa fez uma pesquisa de mercado com 10 pessoas para saber se elas gostaram de um determinado produto lançado. Para isso forneceu o sexo do entrevistado e sua resposta (sim ou não). Faça um programa que calcule e imprima:

// A.    
// O número de pessoas que responderam SIM.

// B.    
// O número de pessoas que responderam NÃO;

// C.   
// O número de mulheres que responderam SIM;

// D.   
// A porcentagem de homens que responderam NÃO entre todos

// E.    
// os homens analisados.

// string sexo;
// char resposta;

// Console.Write($"Qual seu genero: ");
// sexo = Console.ReadLine();
// Console.Write($"Gostaram do produto sim(s) não(n)");
// resposta = char.Parse(Console.ReadLine());



int totalSim = 0, totalNao = 0, totalMulheresSim = 0, totalHomens = 0, totalHomensNao = 0;
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("Pessoa " + i + ":");
    char sexo = char.Parse(Console.ReadLine().ToUpper());
    Console.Write("Sexo (M/F): ");
    char resposta = char.Parse(Console.ReadLine().ToUpper());
    Console.Write("Resposta (S/N): ");
    if (resposta == 'S')
    {
        totalSim++;
        if (sexo == 'F')
        {
            totalMulheresSim++;
        }
    }
    else
    {
        totalNao++;
        if (sexo == 'M')
        {
            totalHomensNao++;
        }
    }
    if (sexo == 'M')
    {
        totalHomens++;
    }

}
Console.WriteLine("Total de pessoas que responderam SIM: " + totalSim);
Console.WriteLine("Total de pessoas que responderam NÃO: " + totalNao);
Console.WriteLine("Total de mulheres que responderam SIM: " + totalMulheresSim);
Console.WriteLine("Porcentagem de homens que responderam NÃO: " + (totalHomensNao * 100.0 / totalHomens).ToString("F2") + "%");







