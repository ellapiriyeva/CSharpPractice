int[] arr = { -1, -7, -10, 9, 14, 7 };
int negative = 0;
int positive = 0;
int sum = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] < 0)
    {
        negative++;
    }
    else if (arr[i] > 0)
    {
        positive++;
    }
    sum += arr[i];
}
Console.WriteLine(negative);
Console.WriteLine(positive);
Console.WriteLine(sum);