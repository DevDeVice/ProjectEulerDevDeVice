int sumOfAllNumbersUnder10k = 0;

int[] divSumArray = new int[10000];
for (int i = 2; i < 10000; i++)
{
    int sum = 0;
    for (int j = 1; j <= i / 2; j++)
    {
        if (i % j == 0)
        {
            sum += j;
        }
    }
    divSumArray[i] = sum;
}
for (int i = 4; i < 10000; i++)
{
    if (divSumArray[i] <= 10000 && divSumArray[i] != i)
    {
        if (i == divSumArray[divSumArray[i]])
        {
            Console.WriteLine($"Dla liczby: {i} suma to: {divSumArray[i]} porównywana do {divSumArray[divSumArray[i]]}");
            Console.WriteLine();
            sumOfAllNumbersUnder10k += i;
        }
    }

}
Console.WriteLine(sumOfAllNumbersUnder10k);