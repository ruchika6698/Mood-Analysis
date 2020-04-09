using Mood_Analyzer_Problem;
using NUnit.Framework;

namespace TestCases
{
    [TestFixture]
    public class TestCases
    {
        private string message;

        public string String { get; private set; }

        /// <summary>
        /// Test Case for Sad Mood
        /// </summary>
        [Test]
        public void MoodTestSad()
        {
            var moodanalyse = new MoodAnalyse(message);
            string result = moodanalyse.Mood("I am in sad mood");
            Assert.AreEqual(result, "SAD");
        }

        /// <summary>
        /// Test Case for Happy Mood
        /// </summary>
        [Test]
        public void MoodTestHappy()
        {
            var moodanalyse = new MoodAnalyse(message);
            string result = moodanalyse.Mood("I am in Happy mood");
            Assert.AreEqual(result, "HAPPY");
        }

        /// <summary>
        /// Test Case for Message in Constructor should be sad
        /// </summary>
        [Test]
        public void No_Parameter_Sad()
        {
            String = "I am in sad mood";
            var moodanalyse = new MoodAnalyse(message);
            string result = moodanalyse.Mood("I am in sad mood");
            Assert.AreEqual(result, "SAD");
        }

        /// <summary>
        /// Test Case for Message in Constructor should be Happy
        /// </summary>
        [Test]
        public void No_Parameter_Happy()
        {
            String = "I am in Happy mood";
            var moodanalyse = new MoodAnalyse(message);
            string result = moodanalyse.Mood("I am in happy mood");
            Assert.AreEqual(result, "HAPPY");
        }

        /// <summary>
        /// Test Case for Null Mood
        /// </summary>
        [Test]
        public void Exception_Invalid()
        {
            var moodanalyse = new MoodAnalyse(null);
            string result = moodanalyse.Mood("I am in Happy mood");
            Assert.AreEqual(result, "HAPPY");
        }
    }
}