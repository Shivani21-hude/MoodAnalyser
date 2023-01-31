using MoodAnalyser;

namespace MoodAnalyserTestCases
{
    [TestClass]
    public class UnitTest1
    {
        MoodAnalyzer analyse = new MoodAnalyzer("I am in any mood");
        [TestMethod]

      // message pass as "I am in Sad mood " then should return SAD
            public void ReturnSadMood()
        {
            string expected = "SAD";
            string actualResult = analyse.Analyze();
            Assert.AreEqual(expected, actualResult);
        }

        [TestMethod]

       // message pass as "I am in Sad mood " then should return HAPPY
        public void ReturnHappyMood()
        {
            string expected = "HAPPY";
            string actualResult = analyse.Analyze();
            Assert.AreEqual(expected, actualResult);
        }

        [TestMethod]

        //message pass as "null " then should return HAPPY
        public void GivenNullMood_ShouldReturnHappyMood()
        {
            //Arrange
            string expected = "HAPPY";
            string message = null;
            MoodAnalyzer analyser = new MoodAnalyzer(message);
            //Act
            string actual = analyser.Analyze();
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}