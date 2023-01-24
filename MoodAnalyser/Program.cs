

using MoodAnalyser;
Console.WriteLine("  ****  Mood Analyzer  ****");

Console.WriteLine("Sad or Happy");
string input = Console.ReadLine();
MoodAnalyzer analyse = new MoodAnalyzer();

analyse.Analyze(input);