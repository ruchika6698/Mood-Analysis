using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
    public class MoodAnalyse
    {
        public string message;
        /// <summary>
        /// non_paramatrized_Constructer
        /// </summary>
        public MoodAnalyse()
        {

        }

        public MoodAnalyse(string message)
        {
            this.message = message;
            
        }

        /// <summary>
        /// Checking null reference Exception
        /// </summary>
        /// <returns></returns>
        public string Mood()
        { 
            try
            {
                if (this.message == null)
                {
                    throw new MoodAnalysisException("Exception present:-" + Exception_type.Empty_Exception);
                }
                if (message.Contains("Sad"))
                {
                    return "SAD";
                }
                else
                    return "HAPPY";
            }
            catch (MoodAnalysisException)
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
            MoodAnalyse moodobj = new MoodAnalyse("I am in Sad mood");
           Console.WriteLine(moodobj.Mood());
        }
    }
}