int[] arr = { -1, -7, -10, 9 };
int max = arr[0];
int max2 = arr[0];

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > max)
    {
        max2 = max;
        max = arr[i];
        Console.WriteLine(max2);
    }
}