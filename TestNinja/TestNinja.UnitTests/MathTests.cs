using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Math = TestNinja.Fundamentals.Math;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        private Math _math;
        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }
        [Test]
        //[Ignore("Because I wanted to")]
        public void Add_WhenCalled_ReturnsSumOfArguments()
        {
            // Act
            int result = _math.Add(1, 2);

            // Assert
            Assert.That(result, Is.EqualTo(3));
        }
        
        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        public void Max_WhenCalled_ReturnsGreaterValue(int a, int b, int expectedResult)
        {
            // Act
            int result = _math.Max(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }
        //[Test]
        //public void Max_FirstArgumentIsGreater_ReturnsFirstArgument()
        //{
        //    int result = _math.Max(5, 3);
        //    Assert.That(result, Is.EqualTo(5));
        //}

        //[Test]
        //public void Max_SecondArgumentIsGreater_ReturnsSecondArgument()
        //{
        //    int result = _math.Max(3, 5);
        //    Assert.That(result, Is.EqualTo(5));
        //}

        //[Test]
        //public void Max_ArgumentsAreEqual_ReturnsSameArgument()
        //{
        //    int result = _math.Max(5, 5);
        //    Assert.That(result, Is.EqualTo(5));
        //}
    }
}
