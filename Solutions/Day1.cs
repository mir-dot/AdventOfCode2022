
using System.Reflection;

int counter = 0;
List<int> weights = new List<int>();

string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Inputs\input01.txt");
string[] lines = File.ReadAllLines(path);


foreach (string line in lines)
{
    if (string.IsNullOrEmpty(line))
    {
        weights.Add(counter);
        counter = 0;
    }
    else
    {
        counter += int.Parse(line);
    }

}
weights.Sort();

int mostCalories = weights.Last();

Console.WriteLine("The elf carrying most calories: {0}", mostCalories);
Console.WriteLine("The three with most calories: {0}", mostCalories + weights[weights.Count - 2] + weights[weights.Count - 3]);
