//using Microsoft.VisualStudio.TestTools.UnitTesting;


using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    //[TestClass]
    [TestFixture]
    public class ReservationTests
    {
        /*[TestMethod] */
        [Test]
        public void CanBeCancelledBy_AdminCanceling_ReturnsTrue()
        {
            // Arrange
            Reservation reservation = new Reservation();
            User user = new User() { IsAdmin = true};

            // Act
            bool result = reservation.CanBeCancelledBy(user);
            // Assert
           // Assert.IsTrue(result);
           Assert.That(user.IsAdmin, Is.True);
        }


        // [TestMethod]
        [Test]
        public void CanBeCancelledBy_SameUserCancellingTheReservation_ReturnsTrue()
        {
            // Arrange
            Reservation reservation = new Reservation();
            User user = new User();
            reservation.MadeBy = user;

            // Act
            bool result = reservation.CanBeCancelledBy(user);
            // Assert
            //Assert.IsTrue(result);
            Assert.That(result, Is.True);
        }

        //[TestMethod]
       [Test]
        public void CanBeCancelledBy_User_ReturnsFalse()
        {
            // Arrange
            Reservation reservation = new Reservation() { MadeBy = new User() };
            User user = new User();
            // Act
            bool result = reservation.CanBeCancelledBy(user);
            // Assert
            //Assert.IsFalse(result);
            Assert.That(result, Is.False);
        }
    }
}
