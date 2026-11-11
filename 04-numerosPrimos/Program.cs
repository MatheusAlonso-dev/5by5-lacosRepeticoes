int num;
int contador = 0;

Console.WriteLine("\tPRIMOS\n\n");

Console.WriteLine("digite um numero: ");
num = int.Parse(Console.ReadLine());
Console.WriteLine("\n");

for (int i = 1; i <= num; i++)
{
    contador = 0;
    for (int j = 1; j <= num; j++)
    {
        if (i % j == 0)
            contador++;
    }

    if(contador == 2)
    {
        Console.WriteLine(i + " é primo");
    }
    else
    {
        Console.WriteLine(i);
    }
}
