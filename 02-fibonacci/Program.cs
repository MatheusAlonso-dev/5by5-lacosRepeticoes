int cont;
int result = 0;

int num1 = 1;
int num2 = 1;

Console.WriteLine("digite um numero: ");
cont = int.Parse(Console.ReadLine());
Console.WriteLine("\n");


for (int i = 1; i <= cont-3; i++)
{
    if(result == 0) {
        Console.WriteLine(result);
        Console.WriteLine(num1);
        Console.WriteLine(num2);
    }

    result = num1 + num2;
    Console.WriteLine(result);
    num1 = num2;
    num2 = result;
}

