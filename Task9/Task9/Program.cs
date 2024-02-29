
var semaphore = new SemaphoreSlim(1, 1);

var continuousOutputTask = Task.Run(async () =>
{
    while (true)
    {
        await semaphore.WaitAsync();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("1");
        await Task.Delay(1);
        Console.Write("0");
        semaphore.Release();
    }
});

await Task.Delay(4000);
var periodicMessageTask = Task.Run(async () =>
{
    while (true)
    {
        await semaphore.WaitAsync();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nNeo, you are the chosen one");
        semaphore.Release();
        await Task.Delay(5000);
    }
});


await Task.WhenAll(continuousOutputTask, periodicMessageTask);
