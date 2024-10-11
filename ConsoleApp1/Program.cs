
// See https://aka.ms/new-console-template for more information
using System.Globalization;
using Labrary1;

class Program // Tạo lớp cho chương trình
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!"); // Hiển thị thông điệp chào mừng

        // Tạo đối tượng PhoneNumber
        PhoneNumber phoneNumber = new PhoneNumber();

        // Yêu cầu người dùng nhập tên hoặc số điện thoại
        Console.Write(" Enter the name or part of the name:");
        string input = Console.ReadLine(); // Đọc đầu vào từ người dùng

        // Gọi phương thức để tìm kiếm số điện thoại
        string result = phoneNumber.PhoneNumberLookup(input);

        // Hiển thị kết quả
        if (!string.IsNullOrEmpty(result)) // Kiểm tra xem kết quả có hợp lệ không
        {
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Không tìm thấy kết quả."); // Thông báo nếu không có kết quả
        }



        // Phần logic khác của chương trình
        // Tính toán và in ra số điện thoại, lượng mưa, số tài khoản, v.v...

        // Ví dụ, phần gọi các phương thức khác
        Sales.CalculateTotalSales();
        int[] a = LotteryNumbers.GenerateRandomNumbers();
        Console.WriteLine("Day xo so la: ");
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write(" " + a[i] + " ");
        }
        Console.WriteLine();

        Random rand = new Random();
        double[] thang = new double[12];
        for (int i = 1; i <= thang.Length; i++)
        {
            thang[i - 1] = rand.Next(1, 10);
        }
        for (int i = 1; i <= thang.Length; i++)
        {
            Console.WriteLine("Luong mua thang " + i + " la: " + thang[i - 1]);
        }
        double tongluongmua = LuongMua.tongluongmua(thang);
        Console.WriteLine("Tong luong mua trong nam la: " + tongluongmua);

        // Phần xử lý số tài khoản
        Console.Write("Vui lòng nhập số tài khoản: ");
        int accountNumber;
        if (int.TryParse(Console.ReadLine(), out accountNumber))
        {
            bool isValid = ChargeAccountValidation.AccountValidation(accountNumber);
            if (isValid)
            {
                Console.WriteLine($"Số tài khoản {accountNumber} là hợp lệ.");
            }
            else
            {
                Console.WriteLine($"Số tài khoản {accountNumber} không hợp lệ.");
            }
        }
        else
        {
            Console.WriteLine("Vui lòng nhập một số hợp lệ.");
        }

        // Phần xử lý MonthDays
        MonthDays monthdays = new MonthDays();
        string[] monthResult = monthdays.GetDaysInEachMonth();

        Console.Write("Vui lòng nhập vị trí của tháng (1-12): ");
        string monthInput = Console.ReadLine();
        if (int.TryParse(monthInput, out int monthIndex))
        {
            monthIndex--; // Trừ 1 vì mảng bắt đầu từ 0
            if (monthIndex >= 0 && monthIndex < monthResult.Length)
            {
                Console.WriteLine(monthResult[monthIndex]);
            }
            else
            {
                Console.WriteLine("Vui lòng nhập một số trong khoảng từ 1 đến 12.");
            }
        }
        else
        {
            Console.WriteLine("Đầu vào không hợp lệ. Vui lòng nhập một số.");
        }


        // Program Payroll

        Payroll payroll = new Payroll(); // Tạo đối tượng từ class Payroll

        // Lấy danh sách mã nhân viên
        int[] empIds = payroll.GetEmployeeIds();

        // Khởi tạo mảng chứa số giờ làm và mức lương theo giờ
        int[] hoursWorked = new int[7];
        double[] hourlyRates = new double[7];

        // Nhập liệu từ người dùng
        for (int i = 0; i < empIds.Length; i++)
        {
            Console.WriteLine($"Nhập số giờ làm cho nhân viên có mã số {empIds[i]}: ");
            hoursWorked[i] = int.Parse(Console.ReadLine());

            Console.WriteLine($"Nhập mức lương theo giờ cho nhân viên có mã số {empIds[i]}: ");
            hourlyRates[i] = double.Parse(Console.ReadLine());
        }

        // Gọi hàm tính lương
        double[] wages = payroll.CalculateWages(hoursWorked, hourlyRates);

        // Hiển thị kết quả
        Console.WriteLine("\nKết quả tính lương:");
        for (int i = 0; i < empIds.Length; i++)
        {
            Console.WriteLine($"Mã nhân viên: {empIds[i]}, Lương tổng: {wages[i]:C}");
        }

    }
}









