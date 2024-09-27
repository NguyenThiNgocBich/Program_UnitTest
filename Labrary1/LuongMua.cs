using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ClassLibrary1
{
    public class LuongMua
    {
        // Hiển thị kết quả
        //        Console.WriteLine($"\nTổng lượng mưa trong năm: {total}");
        //        Console.WriteLine($"Trung bình lượng mưa hàng tháng: {average}");
        //        Console.WriteLine($"Tháng có lượng mưa cao nhất: Tháng {maxMonth + 1} với {max} mm");
        //        Console.WriteLine($"Tháng có lượng mưa thấp nhất: Tháng {minMonth + 1} với {min} mm");
        public static double tongluongmua(double[] luongmua)
        {
            double total = 0;
            for (int i = 0; i < luongmua.Length; i++)
            {
                total = total + luongmua[i];
            }
            return total;
        }
        public static double AverageRain(double[] rain)
        {
            double Average = 0; 
            for(int i = 0;i < rain.Length;i++)
            {
                Average = Average + rain[i];
            }
            Average = Average/rain.Length;
            return Average;
        }
        public static double Max (double[] rain)
        {
            double Max= 0;
            for (int i = 0; i < rain.Length; i++)
            {
                if (rain[i] > Max) 
                    Max = rain[i];
            }
          
            return Max;
        }
        public static double Min(double[] rain)
        {
            double Min = rain[0];
            //double Min = 0;
            for (int i = 0; i < rain.Length; i++)
            {
                if (rain[i] < Min)
                    Min = rain[i];
            }

            return Min;
        }






    }
}





