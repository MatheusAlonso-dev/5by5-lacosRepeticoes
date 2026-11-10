int num;
int result;

Console.WriteLine("digite um numero: ");
num = int.Parse(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    result = num * i;
    Console.WriteLine(num + " x " + i + " = " + result);
}

