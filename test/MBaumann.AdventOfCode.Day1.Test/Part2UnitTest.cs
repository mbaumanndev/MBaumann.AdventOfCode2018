using Xunit;

namespace MBaumann.AdventOfCode.Day1.Test
{
    public class Part2UnitTest
    {
        [Fact]
        public void Example1()
        {
            Assert.Equal(0, Part2.Compute(new string[] { "-1", "+1" }));
        }

        [Fact]
        public void Example2()
        {
            Assert.Equal(10, Part2.Compute(new string[] { "+3", "+3", "+4", "-2", "-4" }));
        }

        [Fact]
        public void Example3()
        {
            Assert.Equal(5, Part2.Compute(new string[] { "-6", "+3", "+8", "+5", "-6" }));
        }

        [Fact]
        public void Example4()
        {
            Assert.Equal(14, Part2.Compute(new string[] { "+7", "+7", "-2", "-7", "-4" }));
        }
    }
}
