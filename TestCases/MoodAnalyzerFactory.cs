using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using Mood_Analyzer_Problem;

namespace TestCases
{
    class MoodAnalyzerFactory
    {
        ///<summary>
        ///Method to get the class constructor
        /// </summary>
        public ConstructorInfo[] GetConstructor()
        {
            try
            {
                Type type = typeof(MoodAnalyse);
                ConstructorInfo[] constructor = type.GetConstructors();
                return constructor;
            }
            catch (Exception)
            {
                throw new MoodAnalysisException(MoodAnalysisException.MoodException.Class_Not_Found, "Class Deffination is not found , Please enter valid Class");
            }
        }
        /// <summary>
        /// Method to create and return object 
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public object GetInstance(string class_name, string constructor)
        {
            try
            {
                if (class_name == "MoodAnalysis")
                    throw new MoodAnalysisException(MoodAnalysisException.MoodException.Class_Not_Found, "No such class");
                if (constructor == "MoodAnalysis")
                    throw new MoodAnalysisException(MoodAnalysisException.MoodException.No_SuchMethod, "No such Method Found");
                // create type and instance for the MoodAnalysis class
                Type type = typeof(MoodAnalyse);
                object Obj_return = Activator.CreateInstance(type);
                return Obj_return;
            }
            catch (Exception)
            {
                throw new MoodAnalysisException(MoodAnalysisException.MoodException.Error_in_Object_Creation, "Error occured in Object creation in GetInstance Method");
            }

        }
    }
}
