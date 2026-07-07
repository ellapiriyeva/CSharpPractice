int n = Convert.ToInt32(Console.ReadLine());

int remainder = n % 5;

if (remainder == 0)
{
    Console.WriteLine(n - 5);
}
else if (remainder > 0)
{
    Console.WriteLine(n - remainder);
}
else
{
    Console.WriteLine(n - (remainder + 5));
}