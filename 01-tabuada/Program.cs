int num;
int result;

Console.WriteLine("\tTABUADA\n\n");

Console.WriteLine("digite um numero: ");
num = int.Parse(Console.ReadLine());
Console.WriteLine("\n");

for (int i = 1; i <= 10; i++)
{
    result = num * i;
    Console.WriteLine(num + " x " + i + " = " + result);
}