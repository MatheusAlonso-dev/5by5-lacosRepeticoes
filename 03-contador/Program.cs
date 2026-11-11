int cont;

Console.WriteLine("\tCONTADOR\n\n");

Console.WriteLine("digite um numero: ");
cont = int.Parse(Console.ReadLine());
Console.WriteLine("\n");

for (int i = 1; i <= cont; i++)
{
    if(i%2 == 0)
    {
    Console.WriteLine(i);
    }
}

for (int i = cont; i >= 1; i--)
{
    if (i % 2 != 0)
    {
        Console.WriteLine(i);
    }
}
