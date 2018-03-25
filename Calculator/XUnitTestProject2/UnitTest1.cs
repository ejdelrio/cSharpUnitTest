using System;
using Xunit;
using Calculator;

namespace XUnitTestProject2
{
    public class CalcTest
    {
        Calc calc = new Calc();
        [Fact]
        public void TesAddTwo()
        {
            int output = calc.AddTwo(2, 5);
            Assert.True(output == 7, "Expects 2 + 5 to equal 7");
            Assert.False(output == 6, "Expects 2 + 5 to not equal 6");
        }
        [Fact]
        public void TestSubtractTwo()
        {
            int output = calc.SubtractTwo(5, 2);
            Assert.True(output == 3, "Expects 5 - 2 to equal 3");
            Assert.False(output == 1, "Expects 5 - 2 to not equal 1");

            //Failing Test :D  
        }

        public void TestFailingTest()
        {
            Assert.True(false, "This will fail. Just checking to make sure it fails :D");
        }
    }
}
