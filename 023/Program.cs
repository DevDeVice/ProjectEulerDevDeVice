bool[] boolTable = new bool[28123];
for (int i = 0; i < boolTable.Length; i++){ boolTable[i] = true; }

int lastNumber = 28123;
int[] arrayTwoAbundant = new int[7000];
int arrayInt = 0;

for (int i = 1; i < lastNumber; i++)
{
    var sumOfNumber = 0;
    for (int j = 1; j <= i/2; j++) if (i % j == 0) sumOfNumber += j;
    if (sumOfNumber > i)
    {
        arrayTwoAbundant[arrayInt] = i;
        arrayInt++;
    }
}

for(int i = 0; i < arrayTwoAbundant.Length; i++)
{
    if(arrayTwoAbundant[i] == 0) { break; }
    for (int j = 0; j < arrayTwoAbundant.Length; j++)
    {
        if(arrayTwoAbundant[j] == 0) { break; }
        if(arrayTwoAbundant[i] + arrayTwoAbundant[j] <= lastNumber)
        {
            boolTable[(arrayTwoAbundant[i] + arrayTwoAbundant[j])-1] = false;
        }
    }
}

int sum = 0;
for (int i = 0; i < lastNumber ; i++)
{
    if (boolTable[i]) 
    { 
        sum += (i + 1);
        Console.WriteLine(i+1);
    }
}
Console.WriteLine(sum);