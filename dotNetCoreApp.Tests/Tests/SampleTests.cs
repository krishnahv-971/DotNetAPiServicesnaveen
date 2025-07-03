using Xunit;

namespace dotNetCoreApp.Tests
{
    public class SampleTests
    {
        [Fact]
        public void Test_OnePlusOne_EqualsTwo()
        {
            int result = 1 + 1;
            Assert.Equal(2, result);
        }
    }
}
