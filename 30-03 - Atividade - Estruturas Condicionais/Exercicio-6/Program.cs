//  6) Sabemos que um aluno é aprovado caso apresente média maior ou igual a 7.0 e frequência maior ou igual a 75%. Na verdade, em uma situação real, se o aluno obtiver a frequência mínima exigida e uma média entre 3 e 7, ainda teria direito a uma última avaliação de recuperação. Como faríamos para resolver o problema em questão utilizando apenas estruturas de condição se-então-senão? Poderíamos começar avaliando a frequência do aluno, e se a mesma for menor que 75% o aluno já estaria reprovado, porém caso a frequência respeite o mínimo exigido, começaríamos a avaliar a média para saber se está aprovado, em recuperação ou reprovado.
        
        
        float nota1, nota2, media, frequencia;

        Console.Write("Digite a primeira nota: ");
        nota1 = float.Parse(Console.ReadLine());

        Console.Write("Digite a segunda nota: ");
        nota2 = float.Parse(Console.ReadLine());

        Console.Write("Digite a frequência do aluno em %: ");
        frequencia = float.Parse(Console.ReadLine());

        if (frequencia < 75) 
        {
            Console.WriteLine("Aluno reprovado por frequência.");
        }
        else 
        {
            media = (nota1 + nota2) / 2;

            if (media >= 7.0) 
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media >= 3.0) 
            {
                Console.WriteLine("Aluno em recuperação.");
            }
            else 
            {
                Console.WriteLine("Aluno reprovado por média.");
            }
        }
    

