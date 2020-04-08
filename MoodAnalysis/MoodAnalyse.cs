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
            try
            {
                // if legnth of message = 0 throw  Empty_Exception
                if (message.Length == 0)
                {
                    throw new MoodAnalysisException(MoodAnalysisException.MoodException.Entered_Empty, " please enter proper moood");
                }
                if (message.Contains("SAD", StringComparison.OrdinalIgnoreCase))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch (NullReferenceException excep)
            {
                throw new MoodAnalysisException(MoodAnalysisException.MoodException.Entered_Full, " please enter proper moood");
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
