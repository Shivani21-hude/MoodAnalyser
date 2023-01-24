using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    internal class MoodAnalyzer
    {
        string input;
        public MoodAnalyzer(string input)
        {
            this.input = input;
        }
        public string Analyze()
        {
            if (this.input.Contains("Sad"))
            {
                return "Sad Mood";
            }
            else
            {
                return "happy Mood";
            }
        }
    }
}
