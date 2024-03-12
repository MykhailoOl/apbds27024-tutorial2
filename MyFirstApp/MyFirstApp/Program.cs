// See https://aka.ms/new-console-template for more information

static double GetMax(int[] num)
{
    double max = num[0];
    foreach (var n in num)
    {
        if (max < n)
        {
            max = n;
        }
    }

    return max;
}