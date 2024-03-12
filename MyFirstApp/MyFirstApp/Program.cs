// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Modification 1");
Console.WriteLine("Modification 2");
Console.WriteLine("Modification 3");

static double GetMax(int[] num)
{
    double maximum = num[0];
    foreach (var n in num)
    {
        if (maximum < n)
        {
            maximum = n;
        }
    }

    return maximum;
}

static double GetAverage(int[] arr)
{
    double res = 0;
    foreach (var nu in arr)
    {
        res += nu;
    }

    return res / arr.Length;
}
