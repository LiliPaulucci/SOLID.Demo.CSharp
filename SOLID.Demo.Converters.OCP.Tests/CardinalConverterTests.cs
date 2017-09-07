using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SOLID.Demo.Converters.OCP.Tests
{
    [TestClass]
    public class CardinalConverterTests
    {
        CardinalConverter arabicToCadinalConverter;

        [TestInitialize]
        public void OCP_Initialize()
        {
            arabicToCadinalConverter = new ArabicToCardinalConverter();
        }

        [TestMethod]
        public void OCP_ShouldNotBeNullWhenCreateInstance()
        {
            Assert.IsNotNull(arabicToCadinalConverter);
        }

        [TestMethod]
        public void OCP_ShouldReturnStringWhenReceiveInteger()
        {
            Assert.IsFalse(string.IsNullOrEmpty(arabicToCadinalConverter.Convert(4)));
        }

        [TestMethod]
        public void OCP_ShouldReturnZeroWhenReceive0()
        {
            Assert.AreEqual("Zero", arabicToCadinalConverter.Convert(0));
        }

        [TestMethod]
        public void OCP_ShouldReturnFourWhenReceive4()
        {
            Assert.AreEqual("Four", arabicToCadinalConverter.Convert(4));
        }

        [TestMethod]
        public void OCP_ShouldReturnTenWhenReceive10()
        {
            Assert.AreEqual("Ten", arabicToCadinalConverter.Convert(10));
        }

        [TestMethod]
        public void OCP_ShouldReturnFourteenWhenReceive14()
        {
            Assert.AreEqual("Fourteen", arabicToCadinalConverter.Convert(14));
        }

        [TestMethod]
        public void OCP_ShouldReturnThirtyFiveWhenReceive35()
        {
            Assert.AreEqual("Thirty Five", arabicToCadinalConverter.Convert(35));
        }

        [TestMethod]
        public void OCP_ShouldReturnFortyWhenReceive40()
        {
            Assert.AreEqual("Fourty", arabicToCadinalConverter.Convert(40));
        }

        [TestMethod]
        [ExpectedException(typeof(NotSupportedException), "Numbers should be Integers between 0 and 99.")]
        public void OCP_ShouldReturnExceptionWhenNumberIsLessThan0()
        {
            arabicToCadinalConverter.Convert(-2);
        }

        [TestMethod]
        [ExpectedException(typeof(NotSupportedException), "Numbers should be Integers between 0 and 99.")]
        public void OCP_ShouldReturnExceptionWhenNumberIs100()
        {
            arabicToCadinalConverter.Convert(100);
        }
    }
}
