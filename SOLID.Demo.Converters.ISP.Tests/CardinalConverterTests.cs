using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SOLID.Demo.Converters.ISP.Tests
{
    [TestClass]
    public class CardinalConverterTests
    {
        CardinalConverter arabicToCadinalConverter;

        [TestInitialize]
        public void ISP_Initialize()
        {
            arabicToCadinalConverter = new ArabicToCardinalConverter();
        }

        [TestMethod]
        public void ISP_ShouldNotBeNullWhenCreateInstance()
        {
            Assert.IsNotNull(arabicToCadinalConverter);
        }

        [TestMethod]
        public void ISP_ShouldReturnStringWhenReceiveInteger()
        {
            Assert.IsFalse(string.IsNullOrEmpty(arabicToCadinalConverter.Convert(4)));
        }

        [TestMethod]
        public void ISP_ShouldReturnZeroWhenReceive0()
        {
            Assert.AreEqual("Zero", arabicToCadinalConverter.Convert(0));
        }

        [TestMethod]
        public void ISP_ShouldReturnFourWhenReceive4()
        {
            Assert.AreEqual("Four", arabicToCadinalConverter.Convert(4));
        }

        [TestMethod]
        public void ISP_ShouldReturnTenWhenReceive10()
        {
            Assert.AreEqual("Ten", arabicToCadinalConverter.Convert(10));
        }

        [TestMethod]
        public void ISP_ShouldReturnFourteenWhenReceive14()
        {
            Assert.AreEqual("Fourteen", arabicToCadinalConverter.Convert(14));
        }

        [TestMethod]
        public void ISP_ShouldReturnThirtyFiveWhenReceive35()
        {
            Assert.AreEqual("Thirty Five", arabicToCadinalConverter.Convert(35));
        }

        [TestMethod]
        public void ISP_ShouldReturnFortyWhenReceive40()
        {
            Assert.AreEqual("Fourty", arabicToCadinalConverter.Convert(40));
        }

        [TestMethod]
        [ExpectedException(typeof(NotSupportedException), "Numbers should be Integers between 0 and 99.")]
        public void ISP_ShouldReturnExceptionWhenNumberIsLessThan0()
        {
            arabicToCadinalConverter.Convert(-2);
        }

        [TestMethod]
        [ExpectedException(typeof(NotSupportedException), "Numbers should be Integers between 0 and 99.")]
        public void ISP_ShouldReturnExceptionWhenNumberIs100()
        {
            arabicToCadinalConverter.Convert(100);
        }
    }
}
