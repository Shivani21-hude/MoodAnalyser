using MoodAnalyser;

namespace MoodAnalyserTestCases
{
    [TestClass]
    public class UnitTest1
    {
        MoodAnalyzer analyse = new MoodAnalyzer("I am in any mood");
        [TestMethod]
        public void ReturnSadMood()
        {
            
            string expected = "SAD";
            string actualResult = analyse.Analyze();
            Assert.AreEqual(expected, actualResult);
        }
        [TestMethod]
        public void ReturnHappyMood()
        {
            string expected = "HAPPY";
            string actualResult = analyse.Analyze();
            Assert.AreEqual(expected, actualResult);
        }
    }
}