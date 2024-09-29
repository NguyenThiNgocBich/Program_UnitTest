using Labrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class LuongMuaTests
    {
        public void Test_TongLuongMua()
        {
            // Arrange
            double[] luongmua = { 10, 20, 30, 40 };

            // Act
            double result = LuongMua.tongluongmua(luongmua);

            // Assert
            Assert.AreEqual(100, result);
        }
        public void Test_AverageRain()
        {
            // Arrange
            double[] rain = { 10, 20, 30, 40 };

            // Act
            double result = LuongMua.AverageRain(rain);

            // Assert
            Assert.AreEqual(25, result);
        }
        public void Test_MaxRain()
        {
            // Arrange
            double[] rain = { 10, 20, 30, 40 };

            // Act
            double result = LuongMua.Max(rain);

            // Assert
            Assert.AreEqual(40, result);
        }
        public void Test_MinRain()
        {
            // Arrange
            double[] rain = { 10, 20, 30, 40 };

            // Act
            double result = LuongMua.Min(rain);

            // Assert
            Assert.AreEqual(10, result);
        }
    }

}
