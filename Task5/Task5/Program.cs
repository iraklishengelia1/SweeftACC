
Console.WriteLine("enter number of stairs ");
int stairCount = int.Parse(Console.ReadLine());
int variants = CountVariants(stairCount);
Console.WriteLine($"Number of variants to climb {stairCount} floors: {variants}");


static int CountVariants(int stairCount)
{
    if (stairCount <= 1)
    {
        return 1;
    }

    int[] dp = new int[stairCount + 1];
    dp[0] = 1;
    dp[1] = 1;

    for (int i = 2; i <= stairCount; i++)
    {
        dp[i] = dp[i - 1] + dp[i - 2];
    }

    return dp[stairCount];
}
