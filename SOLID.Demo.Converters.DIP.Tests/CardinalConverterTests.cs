using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SOLID.Demo.Converters.DIP.Tests
{
    [TestClass]
    public class CardinalConverterTests
    {
        CardinalConverter arabicToCadinalConverter;

        [TestInitialize]
        public void DIP_Initialize()
        {
            arabicToCadinalConverter = new ArabicToCardinalConverter();
        }

        [TestMethod]
        public void DIP_ShouldNotBeNullWhenCreateInstance()
        {
            Assert.IsNotNull(arabicToCadinalConverter);
        }

        [TestMethod]
        public void DIP_ShouldReturnStringWhenReceiveInteger()
        {
            Assert.IsFalse(string.IsNullOrEmpty(arabicToCadinalConverter.Convert(4)));
        }

        [TestMethod]
        public void DIP_ShouldReturnZeroWhenReceive0()
        {
            Assert.AreEqual("Zero", arabicToCadinalConverter.Convert(0));
        }

        [TestMethod]
        public void DIP_ShouldReturnFourWhenReceive4()
        {
            Assert.AreEqual("Four", arabicToCadinalConverter.Convert(4));
        }

        [TestMethod]
        public void DIP_ShouldReturnTenWhenReceive10()
        {
            Assert.AreEqual("Ten", arabicToCadinalConverter.Convert(10));
        }

        [TestMethod]
        public void DIP_ShouldReturnFourteenWhenReceive14()
        {
            Assert.AreEqual("Fourteen", arabicToCadinalConverter.Convert(14));
        }

        [TestMethod]
        public void DIP_ShouldReturnThirtyFiveWhenReceive35()
        {
            Assert.AreEqual("Thirty Five", arabicToCadinalConverter.Convert(35));
        }

        [TestMethod]
        public void DIP_ShouldReturnFortyWhenReceive40()
        {
            Assert.AreEqual("Fourty", arabicToCadinalConverter.Convert(40));
        }

        [TestMethod]
        [ExpectedException(typeof(NotSupportedException), "Numbers should be Integers between 0 and 99.")]
        public void DIP_ShouldReturnExceptionWhenNumberIsLessThan0()
        {
            arabicToCadinalConverter.Convert(-2);
        }

        [TestMethod]
        [ExpectedException(typeof(NotSupportedException), "Numbers should be Integers between 0 and 99.")]
        public void DIP_ShouldReturnExceptionWhenNumberIs100()
        {
            arabicToCadinalConverter.Convert(100);
        }
    }
}
