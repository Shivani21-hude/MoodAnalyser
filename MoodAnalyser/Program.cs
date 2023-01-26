

using MoodAnalyser;
Console.WriteLine("  ****  Mood Analyzer  ****");

Console.WriteLine("Sad or Happy mood");
string input = "I am in SAD Mood";
MoodAnalyzer analyse = new MoodAnalyzer(input);

Console.WriteLine("I am in {0} mood",analyse.Analyze());