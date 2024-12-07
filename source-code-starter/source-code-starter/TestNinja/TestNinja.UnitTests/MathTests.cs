using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        private Math _math;
        [SetUp]
        public void Setup()
        {
            _math = new Math();
        }
        [Test]
        public void Add_WhenCalled_ReturnsSumOfArguments()
        { // act
            var result = _math.Add(1, 2);

            // Assert
            Assert.That(result, Is.EqualTo(3));
        }

            [Test]
            [Ignore("To learn")]
           public void Max_FirstArgumentIsGreater_ReturnFirstArgument()
           {
               // Arrange
               
               // Act
               var result = _math.Max(2, 1);
               // Assert
               Assert.That(result, Is.EqualTo(2));
           }
           
           [Test]
           [Ignore("To learn")]
           public void Max_SecondArgumentIsGreater_ReturnSecondArgument()
           {
               // Arrange
               
               // Act
               var result = _math.Max(1,2);
               
               // Assert
               Assert.That(result, Is.EqualTo(2));
               
           }
           
           [Test]
           [Ignore("To learn")]
           public void Max_ArgumentAreEqual_ReturnTheSameArgument()
           {
               // Arrange
               
               // Act
               var result = _math.Max(1, 1);
               // Assert
               Assert.That(result, Is.EqualTo(1));
           }
           
           [Ignore("To learn")]
            [Test]
            [TestCase(1, 2, 2)]
            [TestCase(2, 1, 2)]
            [TestCase(1, 1, 1)]
           public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expectedResult)
           {
               // Act
               var result = _math.Max(a, b);
               
               // Assert
               Assert.That(result, Is.EqualTo(expectedResult));
           }
        }
    }

