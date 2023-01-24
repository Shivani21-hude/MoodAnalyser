using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalyzer
    {
        string input;
        public string Analyze(string input)
        {
            if (input.ToLower().Contains("sad"))
            {
                Console.WriteLine("Sad");
                return "Sad";
            }
            else
            {
                Console.WriteLine("Happy");
                return "happy";
            }

        }
    }
}
