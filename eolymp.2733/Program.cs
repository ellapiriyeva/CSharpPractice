string[] input = Console.ReadLine()!.Split();

int n = Convert.ToInt32(input[0]);
int m = Convert.ToInt32(input[1]);

int result = (1 << n) + (1 << m);

Console.WriteLine(result);