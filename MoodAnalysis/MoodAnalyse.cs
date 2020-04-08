using System;

namespace Mood_Analyzer_Problem
{
    class MoodAnalyse
    {
        private String message;
        
        /// <summary>
        /// Constructor for mood Message
        /// </summary>
        public MoodAnalyse(String message)
        {
            this.message = message;
        }

        public MoodAnalyse()
        {
        }

        public string Mood(String message)
        {
            this.message = message;
            return Mood();
        }

        /// <summary>
        /// Method to Check Mood Sad or Happy and Exception for Invalid Mood
        /// </summary>
        public String Mood()
        {
            
                if (message.Contains("I am in sad mood"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
           
        }

        /// <summary>
        /// Main Method
        /// </summary>
        static void Main(string[] args)
        {
           Console.WriteLine("Welcome to Mood Analyzer Problem");
           MoodAnalyse moodanalyse = new MoodAnalyse();
           moodanalyse.Mood("HAPPY");
        }
    }
}
