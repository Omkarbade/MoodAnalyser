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
            ///AAA Methodology
            ///Arrange
            string message = "I am in Happy mood";
            string expected = "happy";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);

            //Act
            string actual = moodAnalyser.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Sad Mood")]
        public void GivenSadMessageReturnSadMood()
        {
            ///AAA Methodology
            ///Arrange
            string message = "I am in Sad mood";
            string expected = "sad";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            string actual = moodAnalyser.AnalyseMood();
            Assert.AreEqual(expected, actual);
        }
    }
}
