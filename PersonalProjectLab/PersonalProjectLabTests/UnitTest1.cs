using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonalProjectLab;

namespace PersonalProjectLabTests
{
    [TestClass]
    public class UnitTest1
    {
        private object readinput;

        [TestMethod]
        public void AHAtest()
        {
            // arrange 

            sensorreader name = new sensorreader("heart rate sensor",100);


            // act

            
            string sensorname = name.SensorName();

            // assert

            Assert.AreEqual("heart rate sensor", sensorname);


        }
    }
}
