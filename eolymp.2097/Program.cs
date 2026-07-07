string[] input = Console.ReadLine()!.Split();

int a = Convert.ToInt32(input[0]);
int b = Convert.ToInt32(input[1]);

for (int i = a; i <= b; i++)
{
    int digit1 = i % 10;
    int digit2 = (i / 10) % 10;
    int digit3 = i / 100;

    if (digit1 != digit2 && digit1 != digit3 && digit2 != digit3)
    {
        Console.WriteLine(i);
    }
}