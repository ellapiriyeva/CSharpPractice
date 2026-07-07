string[] input = Console.ReadLine()!.Split();

int a = Convert.ToInt32(input[0]);
int b = Convert.ToInt32(input[1]);

for (int i = a; i <= b; i++)
{
    Console.Write(i + " ");
}