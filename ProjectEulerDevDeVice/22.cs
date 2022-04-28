string file = @"C:\Users\sejko\Desktop\ProjectEuler\22\22\22\bin\Debug\net6.0\p022_names.txt";
/*string fullString = File.ReadAllText(file);
var names = fullString.Split(',').ToList();*/
var allNames = File.ReadAllLines(file)
    .SelectMany(l => l.Split(','))
    .Select(l => l.Trim('\"'))
    .ToList();
foreach (var name in allNames)
{
    Console.WriteLine($"Name: {name}");
}