

int[] array = { 1, 92, 93, 56, 32, 66, 20, 32, 35, 99, 100, 202 };
int result = NotContains(array);
Console.WriteLine($"The smallest integer greater than 0 not in the array is: {result}");


static int NotContains(int[] array)
{
    int min = 1;

    while (array.Contains(min))
    {
        min++;
    }

    return min;
}

