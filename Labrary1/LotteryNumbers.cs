using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ConsoleApp1;

namespace Labrary1
{
    public static class LotteryNumbers
    {
        public static int[] GenerateRandomNumbers()
        {
            // Định nghĩa độ dài của mảng số lottery (7 số)
            int length = 7;

            // Tạo mảng để lưu các số lottery
            int[] lotteryNumbers = new int[length];

            // Tạo đối tượng Random để sinh số ngẫu nhiên
            Random random = new Random();

            // Duyệt qua từng phần tử trong mảng và sinh số ngẫu nhiên từ 0 đến 9
            for (int i = 0; i < length; i++)
            {
                lotteryNumbers[i] = random.Next(0, 10);
            }

            // Trả về mảng số lottery
            return lotteryNumbers;
        }
    }

}
