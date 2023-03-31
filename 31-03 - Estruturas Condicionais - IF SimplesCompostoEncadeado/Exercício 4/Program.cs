
Console.Write($"Telefonou para a vítima?");
string telefonou = Console.ReadLine();

Console.Write($"Esteve no local do crime?");
string esteve = Console.ReadLine();

Console.Write($"Mora perto da vítima?");
string mora = Console.ReadLine();

Console.Write($"Devia para a vítima?");
string devia = Console.ReadLine();

Console.Write($"Já trabalhou com a vítima?");
string trabalhou = Console.ReadLine();


int respostaSim = 0;

if (telefonou == "sim")
{
    respostaSim ++;
}
if (esteve == "sim")
{
    respostaSim ++;
}
if (mora == "sim")
{
    respostaSim ++;
}
if (devia == "sim")
{
    respostaSim ++;
}
if (trabalhou == "sim")
{
    respostaSim ++;
}


if (respostaSim == 2)
{
    Console.WriteLine($"Classificada como Suspeito");
}

else if (respostaSim >= 3 && respostaSim == 4)
{
    Console.WriteLine($"Classificada como Cúmplice");
}

else if (respostaSim == 5)
{
    Console.WriteLine($"Classificada como Culpado");
}
else
{
    Console.WriteLine($"Classificada como Inocente");
}


