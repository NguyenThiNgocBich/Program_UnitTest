
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
            Console.WriteLine("Khong tim thay ket qua."); // Thông báo nếu không có kết quả
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
        Console.Write("Vui long nhap mot so tai khoan: ");
        int accountNumber;
        if (int.TryParse(Console.ReadLine(), out accountNumber))
        {
            bool isValid = ChargeAccountValidation.AccountValidation(accountNumber);
            if (isValid)
            {
                Console.WriteLine($"So tai khoan {accountNumber} la hop le.");
            }
            else
            {
                Console.WriteLine($"Số tài khoản {accountNumber} không hợp lệ.");
            }
        }
        else
        {
            Console.WriteLine("Vui long nhap mot so hop le.");
        }

        // Phần xử lý MonthDays
        MonthDays monthdays = new MonthDays();
        string[] monthResult = monthdays.GetDaysInEachMonth();

        Console.Write("Vui long nhap vi tri cua thang (1-12): ");
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
                Console.WriteLine("Vui long nhap mot so trong khoang từ 1 den 12.");
            }
        }
        else
        {
            Console.WriteLine("Dau vao khong hop le. Vui lòng nhap mot so.");
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
            Console.WriteLine($"Nhap so gio lam cho nhan vien có ma so {empIds[i]}: ");
            hoursWorked[i] = int.Parse(Console.ReadLine());

            Console.WriteLine($"Nhap muc lương theo gio cho nhan vien có ma so {empIds[i]}: ");
            hourlyRates[i] = double.Parse(Console.ReadLine());
        }

        // Gọi hàm tính lương
        double[] wages = payroll.CalculateWages(hoursWorked, hourlyRates);

        // Hiển thị kết quả
        Console.WriteLine("\nKet qua tinh lương:");
        for (int i = 0; i < empIds.Length; i++)
        {
            Console.WriteLine($"Ma nhan vien: {empIds[i]}, Luong tong: {wages[i]:C}");
        }
        for (int i = 0; i < empIds.Length; i++)
        {
            Console.WriteLine(i);
            Console.WriteLine($"Ma nhan vien:{empIds[i]}");
        }
        int vt = 0;
        Console.WriteLine("Nhap vao nhan vien ban muon tinh luong: ");
        vt = int.Parse(Console.ReadLine());
        double totalwages = payroll.CalculateWagesByPosition(vt, hoursWorked, hourlyRates);
        Console.WriteLine($"Luong cua nhan vien o vi tri {vt} la : {totalwages}");

        //Tổng số câu đúng của học sinh
        License_Exam exam = new License_Exam();
        string[] userAnswer = new string[20];
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine($"Cau {i+1} co dap an la: ");
            userAnswer[i] = Console.ReadLine();
        }
        int toltalAnswerCorrect = exam.totalCorrectAnswer(userAnswer);
        if (toltalAnswerCorrect >= 15) {
            Console.WriteLine("You are pass");
            Console.WriteLine(toltalAnswerCorrect);
        }
        else
        {
            Console.WriteLine("you not pass");
            Console.WriteLine(toltalAnswerCorrect);
        }
    }
}









