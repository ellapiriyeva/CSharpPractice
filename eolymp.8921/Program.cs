int n = Convert.ToInt32(Console.ReadLine());

while (n > 0)
{
    Console.WriteLine(n % 10);
    n /= 10;
}