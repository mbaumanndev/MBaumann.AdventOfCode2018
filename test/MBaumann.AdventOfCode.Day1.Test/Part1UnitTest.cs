using Xunit;

namespace MBaumann.AdventOfCode.Day1.Test
{
    public class Part1UnitTest
    {
        [Fact]
        public void Example1()
        {
            Assert.Equal(3, Part1.Compute(new string[] { "+1", "+1", "+1" }));
        }

        [Fact]
        public void Example2()
        {
            Assert.Equal(0, Part1.Compute(new string[] { "+1", "+1", "-2" }));
        }

        [Fact]
        public void Example3()
        {
            Assert.Equal(-6, Part1.Compute(new string[] { "-1", "-2", "-3" }));
        }
    }
}
