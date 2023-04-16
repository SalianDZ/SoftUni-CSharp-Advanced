Dictionary<int, Pump> pumps = new();
int pumpsCount = int.Parse(Console.ReadLine());
int truck = 0;

for (int i = 0; i < pumpsCount; i++)
{
    int[] pumpsInfo = Console.ReadLine()
        .Split().Select(int.Parse).ToArray();

    pumps[i] = new(pumpsInfo[0], pumpsInfo[1]);
}

int counter = 0;
for (int i = 0; i < pumpsCount; i++)
{
    bool notEnough = false;
    int iCopy = i;
    counter = 0;
    while (true)
    {
        if (truck < 0)
        {
            break;
        }
        truck += pumps[iCopy].PetrolAmount;
        truck -= pumps[iCopy].Distance;
        if (truck < 0)
        {
            truck = 0;
            notEnough = true;
            break;
        }
        iCopy++;
        counter++;
        if (counter > pumpsCount)
        {
            Console.WriteLine(i);
            return;
        }
        if (iCopy > pumpsCount - 1)
        {
            iCopy = 0;
        }

    }
    if (notEnough)
    {
        continue;
    }
}

class Pump
{
    public Pump(int petrolAmount, int distance)
    {
        PetrolAmount = petrolAmount;
        Distance = distance;
    }

    public int PetrolAmount { get; set; }

    public int Distance { get; set; }
}