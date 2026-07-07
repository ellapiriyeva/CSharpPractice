int[] array1 = { 1, 5, -3, 0, 7, -99, 21, 20, 10, 15, 11, 9, -1 };
int[] array2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 11, 12, 14 };

int sum = 0;

for (int i = 0; i < array1.Length; i++)
{
    for (int j = 0; j < array2.Length; j++)
    {
        if (i == j)
        {
            sum = array1[i] + array2[j];
        }
    }
    Console.Write(sum + " ");
}