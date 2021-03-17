using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MoodAnalyserMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject();
        {
                string message = null;
                object expected = new MoodAnalyser1(message);
                object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyserAppWithCore.MoodAnalyser", "MoodAnalyser");
                expected.Equals(obj);

            }


        }


        private static void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject_UsingParameterizedConstructor()
        {
            object expected = new MoodAnalyser1("HAPPY");
            object obj = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyserAppWithCore.MoodAnalyser", "MoodAnalyser", "SAD");
            expected.Equals(obj);
        }

        private void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject()
        {
            throw new NotImplementedException();
        }
    }
}
