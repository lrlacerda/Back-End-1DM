

bool idadeCerta;

do
{
    Console.WriteLine($"Qual a idade do Péricles ?");
    int idade = int.Parse(Console.ReadLine());

    if (idade == 53)
    {
        idadeCerta = true;
    }
    else
    {
        idadeCerta = false;
    }

} while (!idadeCerta);
{
     Console.WriteLine($"Idade correta!!! ");
}
