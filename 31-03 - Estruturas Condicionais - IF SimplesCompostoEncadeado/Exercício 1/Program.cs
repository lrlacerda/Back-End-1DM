// 1) Escreva um programa que pergunte o dia, mês e ano do aniversário de uma pessoa e diga se a data é válida ou não. Caso não seja, diga o motivo. Suponha que todos os meses tem 31 dias e que estejamos no ano de 2013.

//Perguntas dia / mês / ano de aniversário

Console.Write($"Qual o dia do seu aniversário: ");
int dia = int.Parse(Console.ReadLine());

Console.Write($"Qual o mês do seu aniversário: ");
int mes = int.Parse(Console.ReadLine());

Console.Write($"Qual o ano do seu aniversário: ");
int ano = int.Parse(Console.ReadLine());



        if (dia < 1 && dia > 31) 
        {
            
            Console.WriteLine("Dia inválido.");
        }

        else if (mes < 1 && mes > 12) 
        {
            
            Console.WriteLine("Mês inválido.");
        }

        else if (ano > 2013)  
        {
            
            Console.WriteLine("Ano inválido.");
        }

        else 
        {
            Console.WriteLine("Data válida.");
        }

        



        