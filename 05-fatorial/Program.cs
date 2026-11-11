int num;
int fatorial=1;
bool valido = true;

Console.WriteLine("digite um numero: ");
num = int.Parse(Console.ReadLine());

if(num >= 0)
{
    for (int i = num; i > 1; i--)
    {
        fatorial *= i;
    }
}
else
{
    Console.WriteLine("numero invalido");
    valido = false;
}

if(valido)
    Console.WriteLine("o fatorial de  " + num + " é " + fatorial);  

