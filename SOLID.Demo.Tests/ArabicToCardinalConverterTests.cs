using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SOLID.Demo.Converters.Srp;

namespace SOLID.Demo.Tests
{
    [TestClass]
    public class ArabicToCardinalConverterTests
    {
        ArabicToCardinalConverter arabicToCadinalConverter;

        [TestInitialize]
        public void Initialize()
        {
            arabicToCadinalConverter = new ArabicToCardinalConverter();
        }

        [TestMethod]
        public void ShouldNotBeNullWhenCreateInstance()
        {
            Assert.IsNotNull(arabicToCadinalConverter);
        }

        [TestMethod]
        public void ShouldReturnStringWhenReceiveInteger()
        {
            Assert.IsFalse(string.IsNullOrEmpty(arabicToCadinalConverter.Convert(4)));
        }

        [TestMethod]
        public void ShouldReturnZeroWhenReceive0()
        {
            Assert.AreEqual("Zero", arabicToCadinalConverter.Convert(0));
        }

        [TestMethod]
        public void ShouldReturnFourWhenReceive4()
        {
            Assert.AreEqual("Four", arabicToCadinalConverter.Convert(4));
        }

        [TestMethod]
        public void ShouldReturnTenWhenReceive10()
        {
            Assert.AreEqual("Ten", arabicToCadinalConverter.Convert(10));
        }

        [TestMethod]
        public void ShouldReturnFourteenWhenReceive14()
        {
            Assert.AreEqual("Fourteen", arabicToCadinalConverter.Convert(14));
        }

        [TestMethod]
        public void ShouldReturnThirtyFiveWhenReceive35()
        {
            Assert.AreEqual("ThirtyFive", arabicToCadinalConverter.Convert(35));
        }

        [TestMethod]
        public void ShouldReturnFortyWhenReceive40()
        {
            Assert.AreEqual("ThirtyFive", arabicToCadinalConverter.Convert(35));
        }
        
        [TestMethod]
        [ExpectedException(typeof(NotSupportedException), "Numbers should be Integers between 0 and 99.")]
        public void ShouldReturnExceptionWhenNumberIsLessThan0()
        {
            arabicToCadinalConverter.Convert(-2);
        }

        [TestMethod]
        [ExpectedException(typeof(NotSupportedException), "Numbers should be Integers between 0 and 99.")]
        public void ShouldReturnExceptionWhenNumberIs100()
        {
            arabicToCadinalConverter.Convert(100);
        }
    }
}
