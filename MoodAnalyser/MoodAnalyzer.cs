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
            try
            {
                if (message.ToUpper().Contains("Sad"))
                    return "SAD";
                else
                    return "HAPPY";
            }
            catch
            {
                return "HAPPY";
            }
        }
    }
}
