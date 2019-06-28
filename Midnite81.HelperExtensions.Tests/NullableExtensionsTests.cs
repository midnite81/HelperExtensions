using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Midnite81.HelperExtensions.Tests
{
    [TestClass]
    public class NullableExtensionsTests
    {
        private string _string;
        private string _stringNull;
        private int _int;
        private int? _intNull;
        private object _obj;
        private object _objNull;
        private User _class;
        private User _classNull;
        

        [TestInitialize]
        public void Initialise()
        {
            _string = "string";
            _stringNull = null;
            _int = 6;
            _intNull = null;
            _obj = new { Id = 1 };
            _objNull = (object)null;
            _class = new User { Id = 1, Name = "Clive" };
            _classNull = null;
        }
        
        [TestMethod]
        public void ItAssertsNullValuesReturnTrueWhenIsNullExtensionIsUsed()
        {
            _stringNull.IsNull().Should().BeTrue();
            _intNull.IsNull().Should().BeTrue();
            _objNull.IsNull().Should().BeTrue();
            _classNull.IsNull().Should().BeTrue();
        }

        [TestMethod]
        public void ItAssertsNullValuesReturnFalseWhenIsNotNullExtensionIsUsed()
        {
            _stringNull.IsNotNull().Should().BeFalse();
            _intNull.IsNotNull().Should().BeFalse();
            _objNull.IsNotNull().Should().BeFalse();
            _classNull.IsNotNull().Should().BeFalse();
        }

        [TestMethod]
        public void ItAssertsNotNullValuesReturnTrueWhenIsNotNullExtensionIsUsed()
        {
            _string.IsNotNull().Should().BeTrue();
            _int.IsNotNull().Should().BeTrue();
            _obj.IsNotNull().Should().BeTrue();
            _class.IsNotNull().Should().BeTrue();
        }

        [TestMethod]
        public void ItAssertsNotNullValuesReturnFalseWhenIsNullExtensionIsUsed()
        {
            _string.IsNull().Should().BeFalse();
            _int.IsNull().Should().BeFalse();
            _obj.IsNull().Should().BeFalse();
            _class.IsNull().Should().BeFalse();
        }

        [TestMethod]
        public void ItAssertsHasValueAndEqualTo()
        {
            int? myInt = 2;

            var sut = myInt.HasValueEqualTo(2);

            sut.Should().BeTrue();
        }

        [TestMethod]
        public void ItAssertsNoValue()
        {
            int? myInt = null;

            var sut = myInt.HasValueEqualTo(2);

            sut.Should().BeFalse();
        }

        [TestMethod]
        public void ItAssertsNoEqualTo()
        {
            int? myInt = 4;

            var sut = myInt.HasValueEqualTo(2);

            sut.Should().BeFalse();
        }
    }
}