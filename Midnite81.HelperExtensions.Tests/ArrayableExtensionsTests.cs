using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Midnite81.HelperExtensions.Tests
{
    [TestClass]
    public class ArrayableExtensionsTests
    {
        [TestMethod]
        public void ItFindsAStringMatch()
        {
            var sut = "Dave".IsOneOf(new[] { "Dave" });

            sut.Should().BeTrue();
        }
        
        [TestMethod]
        public void ItDoesntFindsAStringMatch()
        {
            var sut = "Dave".IsOneOf(new[] { "Bernard", "Jeremy" });

            sut.Should().BeFalse();
        }

        [TestMethod]
        public void ItFindsAnIntMatch()
        {
            var sut = 6.IsOneOf(new[] { 1, 2, 3, 4, 5, 6 });

            sut.Should().BeTrue();
        }

        [TestMethod]
        public void ItDoesntFindAnIntMatch()
        {
            var sut = 6.IsOneOf(new[] { 1, 2, 3, 4, 5 });

            sut.Should().BeFalse();
        }
        
        [TestMethod]
        public void ItFindsAFloatMatch()
        {
            var aFloat = 4.53;
            var sut = aFloat.IsOneOf(new[] { 3.45, 4.53, 6.34 });

            sut.Should().BeTrue();
        }

        [TestMethod]
        public void ItDoesntFindAFloatMatch()
        {
            var aFloat = 4.53;
            var sut = aFloat.IsOneOf(new[] { 3.45, 6.34 });

            sut.Should().BeFalse();
        }
        
        [TestMethod]
        public void ItFindsACaseInsensitiveStringMatch()
        {
            var sut = "Dave".IsOneOfCaseInsensitive(new[] { "dave" });

            sut.Should().BeTrue();
        }
        
        [TestMethod]
        public void ItDoesntFindsACaseInsensitiveStringMatch()
        {
            var sut = "Dave".IsOneOfCaseInsensitive(new[] { "Bernard", "Jeremy" });

            sut.Should().BeFalse();
        }

        [TestMethod]
        public void ItAssertsTrueOnClassProperties()
        {
            var user = new User { Id = 1, Name = "Dave", Level = UserType.Admin };

            var sut = user.Level.IsOneOf(new[] { UserType.Admin });

            sut.Should().BeTrue();
        }
    }
}