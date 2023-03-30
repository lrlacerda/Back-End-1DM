// 3) Escreva     um     programa que leia     as     medidas     dos     lados     de     um     triângulo     e    escreva    se    ele    é    Equilátero,    Isósceles    ou  Escaleno. 
// Sendo    que:    
// − Triângulo    Equilátero:    possui    os    3    lados    iguais.
// − Triângulo    Isóscele:    possui    2    lados    iguais.
// − Triângulo    Escaleno:    possui    3    lados    diferentes.

//triangulos lados
System.Console.Write("Digite o valor do primeiro lado do triângulo: ");
int lado1 = int.Parse(Console.ReadLine());
System.Console.Write("Digite o valor do segundo lado do triângulo: ");
int lado2 = int.Parse(Console.ReadLine());
System.Console.Write("Digite o valor do terceiro lado do triângulo: ");
int lado3 = int.Parse(Console.ReadLine());

//condicional
if (lado1 == lado2 && lado2 == lado3)
{
    System.Console.WriteLine("Triângulo Equilátero");
}
else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
{
    System.Console.WriteLine("Triângulo Isósceles");
}
else
{
    System.Console.WriteLine("Triângulo Escaleno");
}