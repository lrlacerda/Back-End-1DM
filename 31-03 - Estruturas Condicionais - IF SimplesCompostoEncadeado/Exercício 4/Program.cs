
// 5) Faça um programa que faça 5 perguntas para uma pessoa sobre um crime. As perguntas são:

// "Telefonou para a vítima?"

// "Esteve no local do crime?"

// "Mora perto da vítima?"

// "Devia para a vítima?"

// "Já trabalhou com a vítima?"

Console.Write($"Telefonou para a vítima? sim ou não");
string telefonou = Console.ReadLine().ToLower();

Console.Write($"Esteve no local do crime? sim ou não");
string esteve = Console.ReadLine().ToLower();

Console.Write($"Mora perto da vítima? sim ou não");
string mora = Console.ReadLine().ToLower();

Console.Write($"Devia para a vítima? sim ou não");
string devia = Console.ReadLine().ToLower();

Console.Write($"Já trabalhou com a vítima? sim ou não");
string trabalhou = Console.ReadLine().ToLower();


int respostaSim = 0;

if (telefonou == "sim")
{
    respostaSim ++;
    // respostaSim = respostaSim + 1;
    // respostaSim += 1;
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



