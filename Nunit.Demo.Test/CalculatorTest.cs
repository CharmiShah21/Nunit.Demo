using System;
using NUnit.Framework;

namespace Nunit.Demo.Test
{
    [TestFixture]
    public class CalculatorTest
    {
        [Test]
        public void Test_Addition_With_Valid_Integers()
        {
            var calc = new Calculator();
            var result = calc.Addition(3, 5);
            //Verify the result by using the assert class and changing the expected result
            Assert.AreEqual(8, result);//success
                                 
        }
        [Test]
        public void Test_Subtraction_Argument_Exception()
        {
            var calc = new Calculator();
            Assert.Catch<ArgumentException>(() => calc.Subtraction(4, 5));//success
           // Assert.Catch<ArgumentException>(() => calc.Subtraction(4, 3));//failure

        }



        [Ignore("Ignore test")]
        public void Test_To_Ignore()
        {

        }

    }
}
