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
            var result = _sut.GetValueFor(1);
        }
    }
}
