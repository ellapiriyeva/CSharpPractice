int n = Convert.ToInt32(Console.ReadLine());

int product = 1;
bool hasOdd = false;

while (n > 0)
{
    int digit = n % 10;

    if (digit % 2 != 0)
    {
        product *= digit;
        hasOdd = true;
    }

    n /= 10;
}

if (hasOdd)
{
    Console.WriteLine(product);
}
else
{
    Console.WriteLine(-1);
}