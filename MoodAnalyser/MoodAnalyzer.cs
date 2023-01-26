using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalyzer
    {
        string message;
        public  MoodAnalyzer(string message)
        {
            this.message = message;
        }
        public string Analyze()
        {
            if (message.ToLower().Contains("happy"))
            {
               
                return "HAPPY";
            }
            else
            {
               
                return "SAD";
            }

        }
    }
}
