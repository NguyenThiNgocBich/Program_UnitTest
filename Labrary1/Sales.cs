using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ConsoleApp1;
namespace Labrary1;

public static class Sales
{
    public static int CalculateTotalSales()
    {
        // Khởi tạo mảng doanh số cho 7 ngày
        int[] sales = new int[] { 1, 7, 5, 8, 2, 9, 3 };
        int totalSales = 0;

        // Cộng từng giá trị doanh số vào tổng một cách rõ ràng
        for (int i = 0; i < sales.Length; i++)
        {
            totalSales = totalSales + sales[i];
        }
        Console.WriteLine("Tổng doanh số trong tuần là: " + totalSales);
        return totalSales;
    }
}