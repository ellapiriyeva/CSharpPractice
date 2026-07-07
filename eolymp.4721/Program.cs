int TicketNumber = Convert.ToInt32(Console.ReadLine());

int CountFives = 0;

while (TicketNumber > 0)
{
    if (TicketNumber % 10 == 5)
    {
        CountFives++;
    }
    TicketNumber /= 10;
}
Console.WriteLine(CountFives);