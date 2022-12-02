
using AdventOfCode2022.Solutions;
using System.Reflection;

string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Inputs\input02.txt");
string[] lines = File.ReadAllLines(path);

//Day1 day1 = new Day1();
//day1.calculateCalories(lines);

Day2 day2 = new Day2();
day2.determineWinnerScore(lines);
