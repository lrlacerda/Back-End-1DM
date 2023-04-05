
//Faça um programa que leia e valide as seguintes informações:

// 1. Nome: diferente de vazio;

// 2. Idade: entre 0 e 100 anos;

// 3. Salário: maior que zero;

// 4. Estado Civil: 's'(solteiro(a)), 'c'(casado(a)), 'v'(viuvo(a)), 'd'(divorciado(a));

Console.Write("Informe seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine("Bem vindo " + nome );

while (nome == "")
{
    Console.WriteLine("O nome não pode ser vazio.");
    nome = Console.ReadLine();
}


Console.Write("Informe sua idade: ");
int idade = int.Parse(Console.ReadLine());

while (idade < 0 || idade > 100)
{
    Console.WriteLine("A idade deve estar entre 0 e 100 anos.");
    idade = int.Parse(Console.ReadLine());
}


Console.Write("Informe seu salário: ");
float salario = float.Parse(Console.ReadLine());

while (salario <= 0)
{
    Console.WriteLine("O salário deve ser maior que zero.");
      salario = float.Parse(Console.ReadLine());
}


Console.Write($"Informe seu estado Civil 's'(solteiro(a)), 'c'(casado(a)), 'v'(viuvo(a)), 'd'(divorciado(a)): ");
char estadoCivil = char.Parse(Console.ReadLine().ToLower()) ;

while (estadoCivil != 's' && estadoCivil != 'c' && estadoCivil != 'v' && estadoCivil != 'd')
{
    Console.WriteLine("O estado civil deve ser 's', 'c', 'v' ou 'd'.");
    estadoCivil = char.Parse(Console.ReadLine().ToLower()) ; 
}


 Console.WriteLine("Informações válidas.");





