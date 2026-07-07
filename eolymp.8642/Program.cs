string[] input = Console.ReadLine()!.Split();

int a = Convert.ToInt32(input[0]);
int b = Convert.ToInt32(input[1]);

for (int i = a; i <= b; i++)
{
  int num = i;

  int digit1 = num / 1000;
  int digit2 = (num / 100) % 10;
  int digit3 = (num / 10) % 10;
  int digit4 = num % 10;

  int sum = digit1 * digit1 * digit1 * digit1 +
            digit2 * digit2 * digit2 * digit2 +
            digit3 * digit3 * digit3 * digit3 +
            digit4 * digit4 * digit4 * digit4;

  if (sum == i)
  {
    Console.Write(i + " ");
  }
}

