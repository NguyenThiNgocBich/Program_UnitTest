using Labrary1;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCalculateTotalSales()
        {
            // Act: Gọi phương thức CalculateTotalSales để tính tổng doanh số
            int result = Sales.CalculateTotalSales();

            // Assert: Kiểm tra xem kết quả trả về (result) có bằng 35 hay không
            Assert.AreEqual(35, result);
        }
    }
}