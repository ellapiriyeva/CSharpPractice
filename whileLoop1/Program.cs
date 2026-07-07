int number;
int sum = 0;

Console.WriteLine("Enter numbers (0 to stop): ");

while (true)
{
    number = Convert.ToInt32(Console.ReadLine());

    if (number == 0)
    {
        break;
    }

    sum += number;
}
Console.WriteLine($"Sum: {sum}");