// See https://aka.ms/new-console-template for more information

static double GetMax(int[] numbers)
{
    double max = numbers[0];
    foreach (var number in numbers)
    {
        if (max < number)
        {
            max = number;
        }
    }

    return max;
}