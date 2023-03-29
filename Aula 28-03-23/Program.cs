// string name = "Lucas";
// Console.WriteLine(name);

// int idade = 37;

// const int idade = 36;

// Console.WriteLine("A idade do " + name + " é " + idade + " anos");

// double preco = 10.95d;
// Console.WriteLine(preco);



// atribuição

// int x = 15;

// //operadores aritiméticos
// //soma
// Console.WriteLine(5 + 4);
// Console.WriteLine(5 + "4");
// Console.WriteLine(5 + x);

// //subtração
// Console.WriteLine(15 - 3);

// //multiplicação
// Console.WriteLine(3 * 5);

// //divisão
// Console.WriteLine(10 / 2);

//modular para saber se é par ou impar
// Console.WriteLine(5 % 2);


// //operadores de comparação
// //igual a
// Console.WriteLine(5 == 5);

// //maior ou igual a 
// Console.WriteLine(5 >= 4);

// //menor ou igual a
// Console.WriteLine(4 <= 2 );

// //maior que
// Console.WriteLine(150 > 95);

// //menor que 
// Console.WriteLine(54 < 25);

// //diferente de 
// Console.WriteLine(5 != 6);


//operadores logicos
// && : e
// Console.WriteLine(5 == 5 && 8 == 8); // True && True = True
// Console.WriteLine(5 == 5 && 8 == 5); // True && False = False
// Console.WriteLine(5 == 6 && 8 == 8); // False && True = False
// Console.WriteLine(5 == 6 && 8 == 5); // False && False = False

// //|| : ou
// Console.WriteLine(2 == 2 || 3 == 3); //True || True = True
// Console.WriteLine(2 == 2 || 3 == 4); //True || False = True
// Console.WriteLine(2 == 4 || 3 == 3); //False || True = True
// Console.WriteLine(2 == 4 || 3 == 5); //False || false = False

// //! : não
// Console.WriteLine(!(2 == 2 || 3 == 3));



//Crie um programa para calcular o IMC de uma pessoa 

//algoritimo
//entrada: nome, peso, altura, idade
//processamento: peso / por altura ao quadrado

//entrada
string nome = "Lucas Lacerda";

int idade = 37;

float peso = 74.5f;

float altura = 1.72f;

//processamento
float imc = peso / (altura * altura);

//saída
Console.WriteLine($"O IMC do " + nome + " é de : " + Math.Round(imc,2));














