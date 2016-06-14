using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AudioFileTests;
using WordPlayer.Controller;

namespace AudioFileTests
{
    [TestClass]
    public class UnitTestAudioFileController
    {
        [TestMethod]
        public void TestMethodOpen()
        {
            Boolean result = false;
            try
            {
                IAudioFileController audioFile = new UnitTestAudioFileController();
                result = true;
            }
            catch (Exception e)
            {
                result = false;
            }
            
            Assert.AreEqual(true, result);
        }
    }
}
