using System;
using Xunit;

namespace FizzBuzz.Library
{
    public class FizzBuzzTests
    {
        private readonly FizzBuzzService _sut;

        public FizzBuzzTests()
        {
            _sut = new FizzBuzzService();
        }

        [Fact]
        public void FizzBuzzValueForOneShouldBeOne()
        {
            Assert.Equal("1", FizzBuzzService.GetValueFor(1));
        }

        [Fact]
        public void FizzBuzzValueForTwoShouldBeTwo()
        {
            Assert.Equal("2", FizzBuzzService.GetValueFor(2));
        }

        [Fact]
        public void FizzBuzzValueForFourShouldBeFour()
        {
            Assert.Equal("4", FizzBuzzService.GetValueFor(4));
        }

        [Theory]
        [InlineData(3)]
        [InlineData(9)]
        [InlineData(96)]
        [InlineData(99)]
        public void FizzBuzzValueForMultipleOfThreeShouldBeFizz(int value)
        {
            Assert.Equal("Fizz", FizzBuzzService.GetValueFor(value));
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(95)]
        [InlineData(100)]
        public void FizzBuzzValueForMultipleOfFiveShouldBeBuzz(int value)
        {
            Assert.Equal("Buzz", FizzBuzzService.GetValueFor(value));
        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(60)]
        [InlineData(90)]
        public void FizzBuzzValueForMultipleOfThreeAndFiveShouldBeFizzBuzz(int value)
        {
            Assert.Equal("FizzBuzz", FizzBuzzService.GetValueFor(value));
        }

        [Fact]
        public void FizzBuzzOutputBeginsWithOne()
        {
            Assert.Equal("1", _sut.ToString()[..1]);
        }

        [Fact]
        public void FizzBuzzOutputBeginsWithOneCommaTwoCommaFizz()
        {
            Assert.Equal("1,2,Fizz", _sut.ToString()[..8]);
        }

        [Fact]
        public void FizzBuzzOutputEndsWithNintyEightCommaFizzCommaBuzz()
        {
            var result = _sut.ToString();
            Assert.Equal("98,Fizz,Buzz", result[Range.StartAt(result.Length-12)]);
        }
    }
}
