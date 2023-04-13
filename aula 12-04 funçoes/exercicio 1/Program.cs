//faça um método para calcular imposto sobre a renda

//regras de negócio
//tabela de imposto vs renda
//até $1500 - isento
//de $1501 até $3500 - 20% de imposto
//de $3501 até $6000 - 25% de imposto
//acima de $6000 - 35% de imposto


//receber o renda via console
//chamar o método passando a renda como parâmetro
//exibir o valor do imposto referente á renda 


using System.Globalization;

Console.Write("Digite o valor da sua renda: ");
        double renda = double.Parse(Console.ReadLine());

        double imposto = CalcularImposto(renda);

        Console.WriteLine("O valor do imposto a ser pago é: " + imposto.ToString("C", new CultureInfo("pt-br")));
    

    static double CalcularImposto(double renda) 
    {
        double imposto;

        if (renda <= 1500) {
            imposto = 0;
        }
        else if (renda <= 3500) {
            imposto = renda * 0.2;
        }
        else if (renda <= 6000) {
            imposto = renda * 0.25;
        }
        else {
            imposto = renda * 0.35;
        }

        return imposto;
    }


