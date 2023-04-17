int bulletPrice = int.Parse(Console.ReadLine());
int gunBarrelSize = int.Parse(Console.ReadLine());
Stack<int> bullets = new(
    Console.ReadLine()
    .Split().Select(int.Parse)
    );
Queue<int> locks = new(
        Console.ReadLine()
        .Split().Select(int.Parse)
    );
int intelligenceValue = int.Parse(Console.ReadLine());
int bulletCounter = 0;

while (bullets.Count > 0)
{
    for (int i = 1; i <= gunBarrelSize; i++)
    {
        if (bullets.Count <= 0)
        {
            break;
        }
        if (locks.Count <= 0)
        {
            int bulletMoney = bulletCounter * bulletPrice;
            int moneyEarned = intelligenceValue - bulletMoney;
            Console.WriteLine($"{bullets.Count} bullets left. Earned ${moneyEarned}");
            return;
        }
        else
        {
            int currentBulletPower = bullets.Peek();
            int currentLockPower = locks.Peek();
            if (currentBulletPower <= currentLockPower)
            {
                Console.WriteLine("Bang!");
                bullets.Pop();
                locks.Dequeue();
                bulletCounter++;
                continue;
            }
            else
            {
                Console.WriteLine("Ping!");
                bullets.Pop();
                bulletCounter++;
            }
        }
    }
    if (bullets.Count > 0)
    {
        Console.WriteLine("Reloading!");
    }
}
if (locks.Count > 0)
{
    Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
}
else if (locks.Count <= 0 && bullets.Count >= 0)
{
    int bulletMoney = bulletCounter * bulletPrice;
    int moneyEarned = intelligenceValue - bulletMoney;
    Console.WriteLine($"{bullets.Count} bullets left. Earned ${moneyEarned}");
}