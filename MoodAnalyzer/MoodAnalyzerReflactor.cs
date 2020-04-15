using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using MoodAnalyzer;

namespace MoodAnalyzer
{
    /// <summary>
    /// Method for Mood AnalyzerReflector
    /// </summary>
    public class MoodAnalyzerReflactor
    {
        public static object CreateObjectUsingReflection(string ClassName, params object[] construct)
        {
            Type type = Type.GetType(ClassName);

            if (type == null)
            {
                throw new MoodAnalysisException("" + Exception_type.No_Such_class_Exception);
            }
            try
            {
                var objInstance = Activator.CreateInstance(type, construct);
                if (objInstance == null)
                {
                    throw new MissingMethodException("" + Exception_type.No_Such_Method_Exception);
                }
                return objInstance;
            }
            catch (MissingMethodException)
            {
                return Exception_type.No_Such_Method_Exception.ToString();
            }
        }

        public static string InvokeMethodUsingReflection(string methodName, string fieldName)
        {

            Assembly assembly = Assembly.GetExecutingAssembly();
            Type moodAnalysertype = Type.GetType("MoodAnalyzer.MoodAnalyse");
            MethodInfo methodInfo = moodAnalysertype.GetMethod(methodName);

           
                string[] stringArray = { "I am in Happy mood" };
                object objectInstance = Activator.CreateInstance(moodAnalysertype, stringArray);
            try
            {
                if (fieldName != null)
                {
                    FieldInfo fieldInfo = moodAnalysertype.GetField(fieldName);
                    if (fieldInfo == null)
                        throw new MoodAnalysisException("" + Exception_type.No_Such_Field_Exception);
                    fieldInfo.SetValue(objectInstance, fieldName);
                }
            }
            catch (MoodAnalysisException)
            {
                return "No_Such_Field_Exception";

            }
            try
            {
                if (fieldName == null)
                {
                    throw new MoodAnalysisException(Exception_type.Null_Exception.ToString());
                }
            }
            catch (MoodAnalysisException)
            {
                return "Null_Exception";
            }
            try
            {
                if (methodInfo == null)
                {
                    throw new MoodAnalysisException("" + Exception_type.No_Such_Method_Exception);
                }

                string method = (string)methodInfo.Invoke(objectInstance, null);
                return method;
            }
            catch (MoodAnalysisException)
            {
                return "HAPPY";
                
            }
        }
    }
}