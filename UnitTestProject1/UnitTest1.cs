using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Obligatirisk_Opgave_1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //test

        [TestMethod]
        public void TestMethodName()
        {
            try
            {
                FanOut testFanOut = null;
                testFanOut = new FanOut() { Name = "q" };
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.AreEqual("Not Valid", e.Message);
            }
        }

        [TestMethod]
        public void TestMethodTempLav()
        {
            try
            {
                FanOut testFanOut = null;
                testFanOut = new FanOut() { Temp = 14 };
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.AreEqual("Temp er for lav", e.Message);
            }
        }
        [TestMethod]
        public void TestMethodTempOK()
        {
            try
            {
                FanOut testFanOut = null;
                testFanOut = new FanOut() { Temp = 22 };

            }
            catch (Exception e)
            {
                Assert.Fail();
            }
        }


        [TestMethod]
        public void TestMethodTempH�j()
        {
            try
            {
                FanOut testFanOut = null;
                testFanOut = new FanOut() { Temp = 26 };
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.AreEqual("Temp er for h�j", e.Message);
            }
        }

        [TestMethod]
        public void TestMethodFugtLav()
        {
            try
            {
                FanOut testFanOut = null;
                testFanOut = new FanOut() { Fugt = 26 };
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.AreEqual("For lidt fugt", e.Message);
            }
        }

        [TestMethod]
        public void TestMethodFugtOK()
        {
            try
            {
                FanOut testFanOut = null;
                testFanOut = new FanOut() { Fugt = 50 };

            }
            catch (Exception e)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestMethodFugtH�j()
        {
            try
            {
                FanOut testFanOut = null;
                testFanOut = new FanOut() { Fugt = 85 };
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.AreEqual("For meget fugt", e.Message);
            }
        }


    }
}

