int contador = 10;

while (contador > 0)
{
    Console.WriteLine(contador);
    contador--;
    Thread.Sleep(100);
}
Console.WriteLine("Happy New Year!");

contador = 10;

do
{
    Console.WriteLine(contador);
    contador--;
    Thread.Sleep(100);
} while (contador > 0);
Console.WriteLine("Happy New Year!");

for(contador = 10; contador > 0; contador--)
{
    Console.WriteLine(contador);
    Thread.Sleep(100);
}
Console.WriteLine("Happy New Year!");