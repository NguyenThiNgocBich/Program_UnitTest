using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Labrary1
{
    public class MonthDays

    {
        public string[] GetDaysInEachMonth()
        {
            // Mảng chứa tên các tháng
            string[] months = { "January", "February", "March", "April", "May", "June",
                                "July", "August", "September", "October", "November", "December" };

            // Mảng chứa số ngày của từng tháng
            int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            // Mảng để lưu các chuỗi kết quả
            string[] result = new string[12];

            // Vòng lặp để duyệt qua các phần tử của mảng
            for (int i = 0; i < months.Length; i++)
            {
                result[i] = $"{months[i]} has {daysInMonth[i]} days.";
            }

            // Trả về mảng chứa kết quả
            return result;
        }

    }

}

