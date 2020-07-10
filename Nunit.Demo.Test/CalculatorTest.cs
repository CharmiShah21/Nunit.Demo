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

        [Ignore("Ignore test")]
        public void Test_To_Ignore()
        {

        }

    }
}
