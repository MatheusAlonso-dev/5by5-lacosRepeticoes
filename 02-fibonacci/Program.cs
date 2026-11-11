int cont;
int result = 0;

int num1 = 0;
int num2 = 1;

Console.WriteLine("digite um numero: ");
cont = int.Parse(Console.ReadLine());
Console.WriteLine("\n");


for (int i = 1; i <= cont; i++)
{
    Console.WriteLine(result);
    num1 = num2;
    num2 = result;
    result = num1 + num2;
}

