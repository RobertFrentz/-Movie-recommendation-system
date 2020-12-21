
using SearchingMovieMicroservice;
using Xunit;

namespace SeachingMovieMicroserviceTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("Gigi a fost", "gigiafost")]
        [InlineData("Laurentiu se duce", "laurentiuseduce")]
        [InlineData("    Lala     se    ", "lalase")]
        [InlineData(" l l l e e e", "llleee")]
        public void TestFilteredKeyword(string input, string expected)
        {
            string actual = FilteringOperations.FilterKeyword(input);
            Assert.Equal(actual, expected);
        }
    }
}
