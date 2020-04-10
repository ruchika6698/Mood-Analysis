using System;
using System.Collections.Generic;
using System.Text;

namespace Mood_Analyzer_Problem
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

        public MoodAnalyse(string v)
        {
        }

        public string Mood(String message)
        {
            this.message = message;
            return Mood();
        }

        /// <summary>
        /// Checking null reference Exception
        /// </summary>
        /// <returns></returns>
        public string Mood()
        {
            try
            {
                if (message == null)
                {
                    throw new MoodAnalysisException("Exception present is:-" + Exception_type.Null_Exception);
                }
                else if (this.message == "")
                {
                    throw new MoodAnalysisException("Exception present:-" + Exception_type.Empty_Exception);
                }
                else if (message.ToLower().Contains("sad"))
                {
                    return "SAD";
                }
                else
                    return "HAPPY";
            }
            catch (MoodAnalysisException ex)
            {
                return "HAPPY";
            }
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (this.GetType().Equals(((MoodAnalyse)obj).GetType()))
                return true;
            return false;


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
        internal double AnalyseMood()
        {
            throw new NotImplementedException();
        }
    }
}