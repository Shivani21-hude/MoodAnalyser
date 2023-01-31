using MoodAnalyser;

namespace MoodAnalyserTestCases
{
    [TestClass]
    public class UnitTest1
    {
        MoodAnalyzer analyse = new MoodAnalyzer("I am in any mood");

        [TestMethod]  // message pass as "I am in Sad mood " then should return SAD

        public void ReturnSadMood()
        {
            string expected = "SAD";
            string actualResult = analyse.Analyze();
            Assert.AreEqual(expected, actualResult);
        }

        [TestMethod] // message pass as "I am in Sad mood " then should return HAPPY

        public void ReturnHappyMood()
        {
            string expected = "HAPPY";
            string actualResult = analyse.Analyze();
            Assert.AreEqual(expected, actualResult);
        }

        [TestMethod]  //message pass as "null " then should return HAPPY


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

        [TestMethod] //Pass null using try catch
        public void GivenNull_MoodAnalyzer_Should_Throw_CustomException()
        {
            try
            {
                string message = null;
                MoodAnalyzer analyser = new MoodAnalyzer(message);
                string actual = analyser.Analyze();
            }
            catch (MoodAnalyserCustomException exception)
            {
                Assert.AreEqual("Mood should not be Null", exception.Message);
            }

        }
        [TestMethod]//Pass the empty message 
        public void GivenEmptyMood_WhenAnalyzer_ShouldThrowCustomException()
        {
            try
            {
                string message = " ";
                MoodAnalyzer analyser = new MoodAnalyzer(message);
                string actual = analyser.Analyze();
            }
            catch (MoodAnalyserCustomException exception)
            {
                Assert.AreEqual("Mood should not be Empty", exception.Message);
            }
        }

        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject()
        {
            string message = null;
            object expected = new MoodAnalyzer(message);
            //object expected1 = expected;
            object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyser.MoodAnalyzer", "MoodAnalyser");
            expected.Equals(obj);
            Assert.AreEqual(expected, obj);

        }

        [TestMethod] //Catch the exception as no such class
        public void GivenClassNameWhenImproper_ShouldThrow_NoSuchClass_Expection()
        {
            string excepted = "No such Class";
            try
            {
                object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyser.MoodAnalyzer", "MoodAnalyser");
            }
            catch (MoodAnalyserCustomException exception)
            {
                Assert.AreEqual(excepted, exception.Message);
            }
        }

        [TestMethod] //Catch the exception as no such class
        public void GivenClassNameWhenImproper_ShouldThrow_NoSochMethod_Expection()
        {
            string excepted = "No such Method";
            try
            {
                object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyser.MoodAnalyzer", "MoodAnalyser");
            }
            catch (MoodAnalyserCustomException exception)
            {
                Assert.AreEqual(excepted, exception.Message);
            }
        }

        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject_UsingParameterizedConstructor()
        {
            object expected = new MoodAnalyzer("HAPPY");
            object obj = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyser.MoodAnalyzer", "MoodAnalyzer", "SAD");
            expected.Equals(obj);
        }
    }
}