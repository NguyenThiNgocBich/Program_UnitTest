using Labrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class UnitTest5
    {
        [TestMethod] 
        public void AccountValidation_ValidAccount_ReturnsTrue()
        {
            // Arrange
            int validAccountNumber = 5658850; // Một số tài khoản hợp lệ
            bool expected = true;

            // Act
            bool actual = ChargeAccountValidation.AccountValidation(validAccountNumber);

            // Assert
            Assert.AreEqual(expected, actual); // Kiểm tra xem kết quả có như mong đợi không
        }

        [TestMethod] // Định nghĩa một test case khác
        public void AccountValidation_InvalidAccount_ReturnsFalse()
        {
            // Arrange
            int invalidAccountNumber = 9999999; // Một số tài khoản không hợp lệ
            bool expected = false;

            // Act
            bool actual = ChargeAccountValidation.AccountValidation(invalidAccountNumber);

            // Assert
            Assert.AreEqual(expected, actual); // Kiểm tra kết quả
        }
    }
}
