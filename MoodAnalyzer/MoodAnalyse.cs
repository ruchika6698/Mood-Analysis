using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
    public class MoodAnalyse
    {
        public string message;
        /// <summary>
        /// non paramatrized Constructer
        /// </summary>
        public MoodAnalyse()
        {

        }

        /// <summary>
        /// paramatrized_Constructer
        /// </summary>
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
                    //if message i null then throw empty exception
                    throw new MoodAnalysisException("Exception present:-" + Exception_type.Empty_Exception);
                }
                if (message.Contains("Sad"))
                {
                    //if message sad then return sad
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