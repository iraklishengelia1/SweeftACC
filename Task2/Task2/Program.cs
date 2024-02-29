
Console.WriteLine("Enter the amount in tetris:");
int amount = int.Parse(Console.ReadLine());
int minCoins = MinSplit(amount);
Console.WriteLine($"Minimum number of coins needed: {minCoins}");


static int MinSplit(int amount)
{
    int[] coins = new int[] { 50, 20, 10, 5, 1 };
    int minCoins = 0;

    foreach (int coin in coins)
    {
        minCoins += amount / coin;
        amount %= coin;
    }

    return minCoins;
}
