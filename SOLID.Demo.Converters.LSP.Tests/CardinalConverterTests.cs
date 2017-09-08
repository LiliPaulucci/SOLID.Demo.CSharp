using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SOLID.Demo.Converters.LSP.Tests
{
    [TestClass]
    public class CardinalConverterTests
    {
        CardinalConverter arabicToCadinalConverter;
        /*
         * The differente between this code and OCP test is that I`m declaring a generic type and using a especific implementation
         * */

        [TestInitialize]
        public void LSP_Initialize()
        {
            arabicToCadinalConverter = new ArabicToCardinalConverter();
        }

        [TestMethod]
        public void LSP_ShouldNotBeNullWhenCreateInstance()
        {
            Assert.IsNotNull(arabicToCadinalConverter);
        }

        [TestMethod]
        public void LSP_ShouldReturnStringWhenReceiveInteger()
        {
            Assert.IsFalse(string.IsNullOrEmpty(arabicToCadinalConverter.Convert(4)));
        }

        [TestMethod]
        public void LSP_ShouldReturnZeroWhenReceive0()
        {
            Assert.AreEqual("Zero", arabicToCadinalConverter.Convert(0));
        }

        [TestMethod]
        public void LSP_ShouldReturnFourWhenReceive4()
        {
            Assert.AreEqual("Four", arabicToCadinalConverter.Convert(4));
        }

        [TestMethod]
        public void LSP_ShouldReturnTenWhenReceive10()
        {
            Assert.AreEqual("Ten", arabicToCadinalConverter.Convert(10));
        }

        [TestMethod]
        public void LSP_ShouldReturnFourteenWhenReceive14()
        {
            Assert.AreEqual("Fourteen", arabicToCadinalConverter.Convert(14));
        }

        [TestMethod]
        public void LSP_ShouldReturnThirtyFiveWhenReceive35()
        {
            Assert.AreEqual("Thirty Five", arabicToCadinalConverter.Convert(35));
        }

        [TestMethod]
        public void LSP_ShouldReturnFortyWhenReceive40()
        {
            Assert.AreEqual("Fourty", arabicToCadinalConverter.Convert(40));
        }

        [TestMethod]
        [ExpectedException(typeof(NotSupportedException), "Numbers should be Integers between 0 and 99.")]
        public void LSP_ShouldReturnExceptionWhenNumberIsLessThan0()
        {
            arabicToCadinalConverter.Convert(-2);
        }

        [TestMethod]
        [ExpectedException(typeof(NotSupportedException), "Numbers should be Integers between 0 and 99.")]
        public void LSP_ShouldReturnExceptionWhenNumberIs100()
        {
            arabicToCadinalConverter.Convert(100);
        }
    }
}
