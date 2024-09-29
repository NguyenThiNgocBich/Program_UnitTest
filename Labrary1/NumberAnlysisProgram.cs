using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ConsoleApp1;

namespace Labrary1;

public class NumberAnalysisProgram
{
    public static int NumberAnalysis(int[] number)
    {
        // Khởi tạo mảng 20 số 
        //int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        int totalNumber = 0;

        // Tính tổng các số trong mảng 
        for (int i = 0; i < number.Length; i++)
        {
            totalNumber = totalNumber + number[i];
        }

        // Trả về tổng
        return totalNumber;
    }
    public static float AvarageNumber(int[] number)
    {
        float avarage = 0;
        float total = 0;
        for (int i = 0; i < number.Length; i++)
        {
            total = total + number[i];
        }
        avarage = total / number.Length;
        return avarage;
    }
    public static int Max(int[] number)
    {
        int max = 0;
        for (int i = 0; i < number.Length; i++)
        {
            if (number[i] > max)
                max = number[i];
        }

        return max;
    }
    public static int Min(int[] number)
    {
        int min = number[0];
        for (int i = 0;i < number.Length; i++)
        {
            if(number[i] < min) 
                min = number[i];
        }
        return min;
    }
    

}





















