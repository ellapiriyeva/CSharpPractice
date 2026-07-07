int[] array = new int[0];
string input;

Console.WriteLine("Enter elements (* to quit):");

while (true)
{
    input = Console.ReadLine()!;

    if (input == "*")
        break;

    int value = int.Parse(input);

    int[] newArray = new int[array.Length + 1];

    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
    }

    newArray[array.Length] = value;
    array = newArray;
}

Console.WriteLine("Elements: ");

foreach (int item in array)
{
    Console.Write(item + " ");
}