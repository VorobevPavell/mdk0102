using Microsoft.VisualStudio.TestTools.UnitTesting;
using PasswordChecker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordChecker.Tests
{
    [TestClass()]
    public class PasswordChecker666Tests
    {
        [TestMethod()]
        public void Check_8Symbols_ReturnsTrue()
        {
            // Arrange
            string password = "ASqw12$$";
            bool expected = true;

            // Act
            bool actual = PasswordChecker666.ValidatePassword(password);


            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Check_PasswordWithoutLowerSymbols_ReturnsFalse()
        {
            // Arrange
            string password = "ASDQWE123$";
            bool expected = false;


            // Act
            bool actual = PasswordChecker666.ValidatePassword(password);


            // Assert
            Assert.AreEqual(expected,actual);
        }
        [TestMethod()]
        public void Check_4Symbols_ReturnsFalse()
        {
            // Arrange
            string password = "Aq1$";


            // Act
            bool actual = PasswordChecker666.ValidatePassword(password);


            // Assert
            Assert.IsFalse(actual);

        }
        [TestMethod()]
        public void Check_PasswordWithoutLowerSymbols_ReturnsTrue()
        {
            // Arrange
            string password = "ASDq123$";
            bool expected = true;


            // Act
            bool actual = PasswordChecker666.ValidatePassword(password);


            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}