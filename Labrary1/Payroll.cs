using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrary1
{
    public class Payroll
    {
        private int[] empId = { 56588, 45201, 78951, 87775, 84512, 13028, 75804 };
        private int[] hours = new int[7];
        private double[] payRate = new double[7];
        private double[] wages = new double[7];

        // Hàm này nhận vào số giờ làm và mức lương theo giờ từ ConsoleApp1 và trả về lương tổng
        public double[] CalculateWages(int[] hoursWorked, double[] hourlyRates)
        {
            for (int i = 0; i < empId.Length; i++)
            {
                hours[i] = hoursWorked[i];
                payRate[i] = hourlyRates[i];
                wages[i] = hours[i] * payRate[i];
            }
            return wages; // Trả về mảng lương tổng
        }
        //tính lương của người được chọn:
        public double CalculateWagesByPosition(int vt, int[] hoursWorked, double[] hourlyRates)
        {
            double totalWages = 0;
            for(int i = 0; i < empId.Length; i++)
            {
                if (i == vt) {
                    hours[i] = hoursWorked[i];
                    payRate[i] = hourlyRates[i];
                    totalWages = hours[i] * payRate[i];
                }
            }
            return totalWages;
        }
        public int[] GetEmployeeIds()
        {
            return empId; // Trả về danh sách mã nhân viên
        }
    }
}
