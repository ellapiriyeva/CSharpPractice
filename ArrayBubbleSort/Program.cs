int[] numbers = { 1, 5, -3, 0, 7, -99, 21, 20, 10, 15, 11, 9, -1 };

for (int i = 0; i < numbers.Length; i++)
{
    for (int j = 0; j < numbers.Length - i - 1; j++)
    {
        if (numbers[j] > numbers[j + 1])
        {
            int num = numbers[j];
            numbers[j] = numbers[j + 1];
            numbers[j + 1] = num;
        }
    }
}
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i] + " ");
}