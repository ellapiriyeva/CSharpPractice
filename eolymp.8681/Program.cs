int number = Convert.ToInt32(Console.ReadLine());

int product = 1;

while (number > 0)
{
    int digit = number % 10;

    if (digit != 0)
    {
        product *= digit;
    }
    number /= 10;
}
Console.WriteLine(product);