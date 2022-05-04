string file = @"C:\Users\sejko\Desktop\ProjectEuler\22\22\22\bin\Debug\net6.0\p022_names.txt";
/*string fullString = File.ReadAllText(file);
var names = fullString.Split(',').ToList();*/
var allNames = File.ReadAllLines(file)
    .SelectMany(l => l.Split(','))
    .Select(l => l.Trim('\"'))
    .ToList();
allNames.Sort();
long totalScore = 0;
for (int i = 0; i < allNames.Count; i++)
{
    var sumOfLetter = 0;
    var name = allNames[i];
    for (int j = 0; j < name.Length; j++)
    {
        sumOfLetter += (int)name[j] - 64;
    }
    totalScore += sumOfLetter * (i + 1);
    Console.WriteLine($"Imie: {name} Score: {sumOfLetter*(i+1)}");
}
Console.WriteLine(totalScore);