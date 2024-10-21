using Labrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    [TestClass]
    public class LicenseExamTests
    {
        private License_Exam _licenseExam;

        [TestInitialize]
        public void Setup()
        {
            _licenseExam = new License_Exam();
        }


        [TestMethod]
        public void TestAnswersArrayLength()
        {
            // Arrange: 
            string[] userAnswers = new string[20]; // Mảng câu trả lời của thí sinh với độ dài 20

            // Assert: Kiểm tra độ dài của mảng câu trả lời phải là 20
            Assert.AreEqual(20, userAnswers.Length, "Mảng câu trả lời của thí sinh phải có độ dài là 20.");
        }

        // Test số lượng câu trả lời đúng
        [TestMethod]
        public void TestTotalCorrectAnswer()
        {
            // Arrange: 
            string[] userAnswers = { "B", "D", "A", "A", "C", "A", "B", "A", "C", "D", "B", "C", "D", "A", "D", "C", "C", "B", "D", "A" }; // Thí sinh trả lời đúng hết

            int expectedCorrectAnswers = 20;

            // Act: 
            int actualCorrectAnswers = _licenseExam.totalCorrectAnswer(userAnswers);

            // Assert:
            Assert.AreEqual(expectedCorrectAnswers, actualCorrectAnswers, "Tổng số câu trả lời đúng phải là 20.");
        }
    }
}
