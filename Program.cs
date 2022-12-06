//ex 1

List<int> list = new List<int>(){2,3,5,1,593,23,4,563,2,4,454,7,74,2,1,231,4,2,42,5,46,7};
IEnumerable<int> result = list.Where(x => x > 2);
var count = list.Count();

var newList = list.Distinct();
Console.Write(newList);

//ex 2

var path = @"C:\Users\vladu\Downloads\test.txt";

var lines = File.ReadAllLines(path);

var resultLines = lines.Where(line => line.Contains("понимаешь"));
foreach (var line in resultLines)
{
    Console.WriteLine(line);
}


var resultWord = lines.FirstOrDefault(word => word.Contains("мир"));
Console.Write(resultWord);
Console.ReadLine();

