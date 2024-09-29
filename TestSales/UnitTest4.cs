using Labrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{

    public class NumberAnalysisProgramTests
    {
        private int[] numbers;

        public void Setup()
        {
            // Khởi tạo mảng trước mỗi lần kiểm thử
            numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        }
        public void Test_NumberAnalysis_()
        {
            // Thực thi phương thức
            int result = NumberAnalysisProgram.NumberAnalysis(numbers);

            // Kiểm tra kết quả
            Assert.AreEqual(210, result, "Tổng của các số trong mảng phải là 210.");
        }
        public void Test_AvarageNumber()
        {
            // Thực thi phương thức
            float result = NumberAnalysisProgram.AvarageNumber(numbers);

            // Kiểm tra kết quả
            Assert.AreEqual(10.5, result, 0.001, "Trung bình của các số trong mảng phải là 10.5.");
        }

        public void Test_Max()
        {
            // Thực thi phương thức
            int result = NumberAnalysisProgram.Max(numbers);

            // Kiểm tra kết quả
            Assert.AreEqual(20, result, "Giá trị lớn nhất phải là 20.");
        }


        public void Test_Min()
        {
            // Thực thi phương thức
            int result = NumberAnalysisProgram.Min(numbers);

            // Kiểm tra kết quả
            Assert.AreEqual(1, result, "Giá trị nhỏ nhất phải là 1.");
        }
    }
}
