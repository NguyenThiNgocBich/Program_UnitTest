using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labrary1;

namespace TestProject1
{

    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void GenerateRandomNumbers_ShouldReturnArrayOfLength7()
        {
            // Act: Gọi phương thức sinh số ngẫu nhiên
            int[] lotteryNumbers = LotteryNumbers.GenerateRandomNumbers();

            // Assert: Kiểm tra xem mảng có đúng 7 phần tử
            Assert.AreEqual(7, lotteryNumbers.Length, "Mảng số lottery không có độ dài 7.");
        }
        [TestMethod]
        public void GenerateRandomNumbers_ShouldContainValuesBetween0And9()
        {
            // Act: Gọi phương thức sinh số ngẫu nhiên
            int[] lotteryNumbers = LotteryNumbers.GenerateRandomNumbers();

            // Assert: Kiểm tra xem từng số trong mảng đều nằm trong khoảng từ 0 đến 9
            foreach (var number in lotteryNumbers)
            {
                Assert.IsTrue(number >= 0 && number < 10, $"Số {number} nằm ngoài khoảng 0-9.");
            }
        }

    }

}


