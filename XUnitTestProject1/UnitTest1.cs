using System;
using MoodAnalyzer;
using Xunit;

namespace MoodAnalyzer
{
    public class UnitTest1
    {
        /// <summary>
        /// TestCase 1.1:Analyses the sad mood when sad return sad 
        /// </summary>
        [Fact]
        public void AnalyseMood_WhenSadReturnSad()
        {
            MoodAnalyse moodobj = new MoodAnalyse("I am in Sad mood");
            string actual = moodobj.Mood();
            string Expected = "SAD";
            Assert.Equal(Expected, actual);
        }
        /// <summary>
        /// TestCase_1.2:Analyses the mood when happy mood return happy.
        /// </summary>
        [Fact]
        public void AnalyseMood_WhenHappyMoodReturnHappy()
        {
            MoodAnalyse moodobj = new MoodAnalyse("I am in happy mood");
            string Expected = "HAPPY";
            Assert.Equal(Expected, moodobj.Mood());
        }
        /// <summary>
        /// TestCase-2.1:Analyses the mood when null mood return happy
        /// </summary>
        [Fact]
        public void AnalyseMood_WhenNullMoodReturnHappy()
        {
            MoodAnalyse moodobj = new MoodAnalyse(null);
            string Expected = "HAPPY";
            Assert.Equal(Expected, moodobj.Mood());
        }
        /// <summary>
        /// TESTCASE_3.1:Analyses the mood when null throw exception mood return happy.
        /// </summary>
        [Fact]
        public void AnalyseMood_WhenNullThrowMoodAnalysisException()
        {
            MoodAnalyse moodobj = new MoodAnalyse(null);
            string Expected = "HAPPY";
            Assert.Equal(Expected, moodobj.Mood());
        }
        /// <summary>
        /// TestCase_3.2
        /// Analyses the mood when null throw exception mood return happy.
        /// </summary>
        [Fact]
        public void AnalyseMood_WhenEmptyThrowMoodAnalysisException()
        {
            MoodAnalyse moodobj = new MoodAnalyse(" ");
            string Expected = "HAPPY";
            Assert.Equal(Expected, moodobj.Mood());
        }
        /// <summary>
        /// Testcase-4.1
        /// check two_object are equal
        /// </summary>
        [Fact]
        public void CreatObjectUsingRef_AnalyserMoodObjectTest()
        {

            object obj = MoodAnalyzerReflactor.CreateObjectUsingReflection("MoodAnalyzer.MoodAnalyse");
            MoodAnalyse moodobj = new MoodAnalyse();
            bool actual = moodobj.Equals(obj);
            bool expected = false;
            Assert.Equal(actual, expected);
        }
        /// <summary>
        /// TestCase_4.2:throw exception when null
        /// </summary>
        [Fact]
        public void CreatObjectusingRef_AnalyserMoodExceptionTest()
        {
            var ex = Assert.Throws<MoodAnalysisException>(() => MoodAnalyzerReflactor.CreateObjectUsingReflection("HappyHour"));
            Assert.Equal(ex.msg, Exception_type.No_Such_class_Exception.ToString());
        }
        /// <summary>
        /// UseCase_5.1:Creatobjectusings the reflection pass parametrized constructer.
        /// </summary>
        [Fact]
        public void CreatobjectusingReflectionPassParametrizedConstructer()
        {
            object reflactionobj = MoodAnalyzerReflactor.CreateObjectUsingReflection("MoodAnalyzer.MoodAnalyse", "I am in Happy Mood");
            MoodAnalyse moodobj = new MoodAnalyse();
            bool actual = moodobj.Equals(reflactionobj);
            bool expected = false;
            Assert.Equal(actual, expected);
        }
        /// <summary>
        /// UseCase_5.2:Whens the not proper classname through exception.
        /// </summary>
        [Fact]
        public void WhenNotProperClassnameThroughException()
        {
            var ex = Assert.Throws<MoodAnalysisException>(() => MoodAnalyzerReflactor.CreateObjectUsingReflection("Wrong class name", "I am in Happy Mood"));
            Assert.Equal(ex.msg, Exception_type.No_Such_class_Exception.ToString());
        }
        /// <summary>
        /// UseCase_5.3:Whens the not proper constructer name throw exception
        /// </summary>
        [Fact]
        public void WhenNotProperConstructerNameThrowException()
        {
            object Reflactionobject = MoodAnalyzerReflactor.CreateObjectUsingReflection("MoodAnalyzer.MoodAnalyse", 123);
            MoodAnalyse moodobj = new MoodAnalyse();
            var Expected = Exception_type.No_Such_Method_Exception.ToString();
            Assert.Equal(Reflactionobject, Expected);

        }
        /// <summary>
        /// TestCse_6
        /// Invokes the method using reflection should return happy.
        /// </summary>
        [Fact]
        public void InvokeMethodUsingReflection_shouldReturnHappy()
        {
            string actual = MoodAnalyzerReflactor.InvokeMethodUsingReflection("MoodAnalyzer.MoodAnalyse", "message");
            string Expected = "HAPPY";
            Assert.Equal(actual, Expected);
        }

        /// <summary>
        /// Sets the field value should return happy.
        /// Testcase_7
        /// </summary>
        [Fact]
        public void SetFieldValue_shouldReturnHappy()
        {
            string actual = MoodAnalyzerReflactor.InvokeMethodUsingReflection("AnalyseMood", "message");
            string Expected = "HAPPY";
            Assert.Equal(actual, Expected);
        }
        [Fact]
        public void SetImproperField_throwException()
        {
            string actual = MoodAnalyzerReflactor.InvokeMethodUsingReflection("AnalyseMood", "Improper Field Name");
            string Expected = "No_Such_Field_Exception";
            Assert.Equal(actual, Expected);
        }
        [Fact]
        public void SetNullField_throwException()
        {
            string actual = MoodAnalyzerReflactor.InvokeMethodUsingReflection("AnalyseMood", null);
            string Expected = "Null_Exception";
            Assert.Equal(actual, Expected);
        }
    }
}