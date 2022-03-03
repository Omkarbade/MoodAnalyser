using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalyser
    {
        string message;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }

        //analyse mood if sad or happy
        public string AnalyseMood()
        {
            if (message.ToLower().Contains("happy"))
            {
                return "happy";
            }

            else
            {
                return "sad";
            }

        }
    }
}
