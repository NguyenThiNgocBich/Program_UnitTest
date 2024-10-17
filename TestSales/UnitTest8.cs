using Labrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class UnitTest8
    {
        private Payroll _payroll;

        [TestInitialize]
        public void Setup()
        {
            // Arrange: Khởi tạo đối tượng Payroll
            _payroll = new Payroll();
        }

        // Test 1: Kiểm tra độ dài của mảng lương phải có 7 phần tử
        [TestMethod]
        public void TestWagesArrayLength()
        {
            // Arrange: Dữ liệu đầu vào
            int[] hoursWorked = { 8, 6, 5, 9, 7, 4, 3 };
            double[] hourlyRates = { 10.0, 15.0, 12.0, 11.0, 9.0, 8.0, 13.0 };

            // Act: Gọi phương thức CalculateWages để tính lương
            double[] wages = _payroll.CalculateWages(hoursWorked, hourlyRates);

            // Assert: Kiểm tra mảng lương có 7 phần tử
            Assert.AreEqual(7, wages.Length, "Mảng wages phải có 7 phần tử.");
        }

        // Test 2: Kiểm tra danh sách mã nhân viên có đủ 7 nhân viên không
        [TestMethod]
        public void TestEmployeeIdCount()
        {
            // Arrange: Không cần dữ liệu đầu vào vì hàm trả về danh sách mã nhân viên

            // Act: Gọi phương thức GetEmployeeIds để lấy danh sách mã nhân viên
            int[] empIds = _payroll.GetEmployeeIds();

            // Assert: Kiểm tra có đúng 7 mã nhân viên không
            Assert.AreEqual(7, empIds.Length, "Phải có 7 mã nhân viên.");
        }

        // Test 3: Kiểm tra tính lương cho nhân viên mã số 0
        [TestMethod]
        public void TestCalculateWagesForEmployee0()
        {
            // Arrange: Dữ liệu đầu vào cho nhân viên mã số 0
            int[] hoursWorked = { 8, 6, 5, 9, 7, 4, 3 };  // Giờ làm của từng nhân viên
            double[] hourlyRates = { 10.0, 15.0, 12.0, 11.0, 9.0, 8.0, 13.0 };  // Lương theo giờ

            // Act: Gọi phương thức CalculateWages để tính lương
            double[] wages = _payroll.CalculateWages(hoursWorked, hourlyRates);

            // Assert: Kiểm tra lương của nhân viên mã số 0
            double expectedWage = 80.0;  // Nhân viên 0 làm 8 giờ, lương 10 đô => 80 đô
            Assert.AreEqual(expectedWage, wages[0], "Lương của nhân viên mã 0 phải là 80 đô.");
        }
    }
}
