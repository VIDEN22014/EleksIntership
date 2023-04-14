using System.Text;
using System.Text.RegularExpressions;

string filename = "..\\..\\..\\in.txt";

StreamReader? reader = null;

Console.OutputEncoding = Encoding.UTF8;

try
{
    reader = new StreamReader(filename);
    string text = reader.ReadToEnd();
    text = text.ToLower();

    var wordPattern = new Regex(@"\w+");

    Dictionary<string, int> words = new Dictionary<string, int>();

    foreach (Match match in wordPattern.Matches(text))
    {
        int currentCount = 0;
        words.TryGetValue(match.Value, out currentCount);

        currentCount++;
        words[match.Value] = currentCount;
    }

    words = words.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

    foreach (var word in words)
    {
        Console.WriteLine($"{word.Key} - {word.Value}");
    }
}
catch
{
    Console.WriteLine("Файл не існує");
}
finally
{
    reader?.Close();
}
