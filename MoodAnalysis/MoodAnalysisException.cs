using System;
using System.Runtime.Serialization;

namespace Mood_Analyzer_Problem
{
    [Serializable]
    internal class MoodAnalysisException : Exception
    {
        // enumaration for comstum exceptions
        public enum MoodException
        {
            Entered_Null,
            Entered_Empty,
            Entered_Full
        }//end: public enum MoodException

        MoodException exception_type;

        /// <summary>
        /// MoodAnalysisException Constructor for initiate base class message 
        /// </summary>
        /// <param name="exception_type"></param>
        /// <param name="ex_message"></param>
        public MoodAnalysisException(MoodException exception_type, string ex_message) : base(ex_message)
        {
            this.exception_type = exception_type;
        }
    }
}