//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    #region MSTests
    //    [TestClass]
    //    public class ReservationTests
    //    {
    //        [TestMethod]
    //        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
    //        {
    //            // Arrange

    //            var reservation = new Reservation();
    //            // Act
    //            var result = reservation.CanBeCancelledBy(new User() { IsAdmin = true});
    //            // Assert
    //            Assert.IsTrue(result);

    //        }

    //        [TestMethod]
    //        public void CanBeCancelledBy_SameUserCancellingTheReservation_ReturnsTrue()
    //        {
    //            // Arrange
    //            var user = new User();
    //            var reservation = new Reservation() { MadeBy = user};
    //            // Act
    //            var result = reservation.CanBeCancelledBy(user);
    //            // Assert
    //            Assert.IsTrue(result);

    //        }

    //        [TestMethod]
    //        public void CanBeCancelledBy_AnotherUserCancellingTheReservation_ReturnsFalse()
    //        {
    //            var user = new User();
    //            var reservation = new Reservation() { MadeBy = new User()};

    //            var result = reservation.CanBeCancelledBy(user);
    //            Assert.IsFalse(result);
    //        }
    //    }

    #endregion

    [TestFixture]

    public class ReservationTests
    {
        [Test]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            // Arrange

            var reservation = new Reservation();
            // Act
            var result = reservation.CanBeCancelledBy(new User() { IsAdmin = true });
            // Assert
            Assert.That(result, Is.True);

        }

        [Test]
        public void CanBeCancelledBy_SameUserCancellingTheReservation_ReturnsTrue()
        {
            // Arrange
            var user = new User();
            var reservation = new Reservation() { MadeBy = user };
            // Act
            var result = reservation.CanBeCancelledBy(user);
            // Assert
            Assert.IsTrue(result);

        }

        [Test]
        public void CanBeCancelledBy_AnotherUserCancellingTheReservation_ReturnsFalse()
        {
            var user = new User();
            var reservation = new Reservation() { MadeBy = new User() };

            var result = reservation.CanBeCancelledBy(user);
            Assert.IsFalse(result);
        }
    }
}
