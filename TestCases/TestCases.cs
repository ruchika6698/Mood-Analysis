using NUnit.Framework;
using Mood_Analyzer_Problem;
using System;
using System.Reflection;

namespace TestCases
{
    [TestFixture]
    public class TestCases
    {
        public object MoodAnalyserReflactor { get; private set; }

        /// <summary>
        /// TestCase 1.1
        /// Analyses the sad mood when sad return sad.
        /// </summary>
        [Test]
        public void AnalyseMood_WhenSadReturnSad()
        {
            MoodAnalyse moodobj = new MoodAnalyse("I am in sad mood");
            string Expected = "SAD";
            Assert.AreEqual(Expected, moodobj.AnalyseMood());
        }
        /// <summary>
        /// TestCase_1.2
        /// Analyses the mood when happy mood return happy.
        /// </summary>
        [Test]
        public void AnalyseMood_WhenHappyMoodReturnHappy()
        {
            MoodAnalyse moodobj = new MoodAnalyse("I am in happy mood");
            string Expected = "HAPPY";
            Assert.AreEqual(Expected, moodobj.AnalyseMood());
        }
        /// <summary>
        /// TestCase-2.1
        /// Analyses the mood when null mood return happy.
        /// </summary>
        [Test]
        public void AnalyseMood_WhenNullMoodReturnHappy()
        {
            MoodAnalyse moodobj = new MoodAnalyse(null);
            string Expected = "HAPPY";
            Assert.AreEqual(Expected, moodobj.AnalyseMood());
        }
        /// <summary>
        /// TESTCASE_3.1
        /// Analyses the mood when null throw exception mood return happy.
        /// </summary>
        [Test]
        public void AnalyseMood_WhenNullThrowMoodAnalysisException()
        {
            MoodAnalyse moodobj = new MoodAnalyse(null);
            string Expected = "HAPPY";
            Assert.AreEqual(Expected, moodobj.AnalyseMood());
        }
        /// <summary>
        /// TestCase_3.2
        /// Analyses the mood when null throw exception mood return happy.
        /// </summary>
        [Test]
        public void AnalyseMood_WhenEmptyThrowMoodAnalysisException()
        {
            MoodAnalyse moodobj = new MoodAnalyse(" ");
            string Expected = "HAPPY";
            Assert.AreEqual(Expected, moodobj.AnalyseMood());
        }
        /// <summary>
        /// Testcase-4.1
        /// check two_object are equal
        /// </summary>
        [TestCase]
        public void CreatObjectUsingRef_AnalyserMoodObjectTest()
        {

            object obj = MoodAnalyserFactory.CreateObjectUsingReflection("AnalyseMood.MoodAnalyser");
            MoodAnalyse mood = new MoodAnalyse();
            bool actual = mood.Equals(obj);
            bool expected = true;
            Assert.AreEqual(actual, expected);
        }
        /// <summary>
        /// TestCase_4.2
        /// throw exception when null
        /// </summary>
        [TestCase]
        public void CreatObjectusingRef_AnalyserMoodExceptionTest()
        {
            object type = MoodAnalyserFactory.CreateObjectUsingReflection("HappyHour");
            MoodAnalyse mood = new MoodAnalyse();
            var actual = type.ToString();
            var expected = Exception_type.No_Such_class_Exception.ToString();
            Assert.AreEqual(actual, expected);
        }
        /// <summary>
        /// UseCase_5.1
        /// Creatobjectusings the reflection pass parametrized constructer.
        /// </summary>
        [Test]
        public void CreatobjectusingReflectionPassParametrizedConstructer()
        {
            object reflactionobj = MoodAnalyserFactory.CreateObjectUsingReflection("AnalyseMood.MoodAnalyser", "I am in Happy Mood");
            MoodAnalyse mood = new MoodAnalyse();
            bool actual = mood.Equals(reflactionobj);
            bool expected = true;
            Assert.AreEqual(actual, expected);
        }

        /// <summary>
        /// UseCase_5.2
        /// Whens the not proper classname through exception.
        /// </summary>
        [Test]
        public void WhenNotProperClassnameThroughException()
        {
            object Reflactionobject = MoodAnalyserFactory.CreateObjectUsingReflection("Wrong class name", "I am in Happy Mood");
            MoodAnalyse moodobj = new MoodAnalyse();

            var Expected = Exception_type.No_Such_class_Exception.ToString();
            Assert.AreEqual(Reflactionobject, Expected);

        }
        /// <summary>
        /// UseCase_5.3
        /// Whens the not proper constructer name through exception
        /// </summary>
        [Test]
        public void WhenNotProperConstructerNameThroughException()
        {
            object Reflactionobject = MoodAnalyserFactory.CreateObjectUsingReflection("AnalyseMood.MoodAnalyser", 123);
            MoodAnalyse moodobj = new MoodAnalyse();

            var Expected = Exception_type.No_Such_Method_Exception.ToString();
            Assert.AreEqual(Reflactionobject, Expected);
        }

        /// <summary>
        /// TestCse_6.1
        /// Invokes the method using reflection should return happy.
        /// </summary>
        [Test]
        public void InvokeMethodUsingReflection_shouldReturnHappy()
        {
            string actual = MoodAnalyserReflactor.InvokeMethodUsingReflection();
            string Expected = "HAPPY";
            Assert.AreEqual(actual, Expected);
        }

    }
}