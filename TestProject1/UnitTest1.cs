using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;

namespace UnitTestProject1
{
    [TestClass]
    public class MoodAnalyser
    {
        [TestMethod]
        [TestCategory("Happy Mood")]
        public void GivenMessageShouldReturnHappy()
        {
            //Follow AAA strategy
            //Arrange , Act & last Assert
            MoodAnalyser mood = new MoodAnalyser("Happy Mood");
            string excepted = "happy";
            var actual = mood.AnalyseMood();
            Assert.AreEqual(excepted, actual);
        }
        [TestMethod]
        [TestCategory("SAD Mood")]
        public void GivenMessageShouldReturnSad()
        {
            //Arrange , Act & Assert
            MoodAnalyser mood = new MoodAnalyser("SAD Mood");
            string excepted = "sad";
            var actual = mood.AnalyseMood();
            Assert.AreEqual(excepted, actual);
        }
        [TestMethod]
        [TestCategory("Null Reference")]
        public void GivenNullShouldReturnHappy()
        {

            //Arrange , Act and in last Assert
            string? message = null;
            MoodAnalyser mood = new MoodAnalyser(message);
            string excepted = "happy";
            var actual = mood.AnalyseMood();
            Assert.AreEqual(excepted, actual);
        }
    }
}
