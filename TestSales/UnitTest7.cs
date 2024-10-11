using System;
using Labrary1;

namespace TestProject1
{
    [TestClass] 
    public class UnitTest7
    {
        private PhoneNumber _phoneNumber;

        [TestInitialize]
        public void Setup()
        {
            // Khởi tạo đối tượng PhoneNumber 
            _phoneNumber = new PhoneNumber();
        }

        [TestMethod] 
        public void PhoneNumberLookup_ValidName_ReturnsCorrectPhoneNumber()
        {
            // Arrange
            string input = "Hoa"; // Tìm kiếm theo phần tên
            string expected = "Phone number of Hoa: 036-789-8933";

            // Act
            string actual = _phoneNumber.PhoneNumberLookup(input); // Sử dụng _phoneNumber để gọi phương thức

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] 
        public void PhoneNumberLookup_PartialName_ReturnsCorrectPhoneNumber()
        {
            // Arrange
            string input = "Duy"; 
            string expected = "Phone number of Duy: 678-901-2345";

            // Act
            string actual = _phoneNumber.PhoneNumberLookup(input); 

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PhoneNumberLookup_InvalidName_ReturnsNotFoundMessage()
        {
            // Arrange
            string input = "Kim";
            string expected = "Person not found. Please try again.";

            // Act
            string actual = _phoneNumber.PhoneNumberLookup(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

    }
}








