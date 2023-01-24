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
            if (input.ToLower().Contains("happy"))
            {
                Console.WriteLine("Happy");
                return "Happy";
            }
            else
            {
                Console.WriteLine("Sad");
                return "Sad";
            }

        }
    }
}
