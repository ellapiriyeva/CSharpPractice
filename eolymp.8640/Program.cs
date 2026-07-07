string[] input = Console.ReadLine()!.Split();

int a = Convert.ToInt32(input[0]);
int b = Convert.ToInt32(input[1]);

while (a <= b)
{
    if (a / 1000 % 2 != 0 && a / 100 % 10 % 2 != 0 && a / 10 % 10 % 2 != 0 && a % 10 % 2 != 0)
    {
        Console.Write(a + " ");
    }
    a++;
}