﻿// See https://aka.ms/new-console-template for more information
using System.Globalization;
using Labrary1;


Console.WriteLine("Hello, World!");

//Console.WriteLine(Sales.CalculateTotalSales());
Sales.CalculateTotalSales();
//Console.WriteLine(LotteryNumbers.GenerateRandomNumbers());
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
    //Console.WriteLine("Nhap vao luong mua thang " +i+": ");
    //double luongmua = double.Parse(Console.ReadLine());
    //thang[i-1] = luongmua;
    thang[i - 1] = rand.Next(1, 10);
}
for (int i = 1; i <= thang.Length; i++)
{
    //Console.WriteLine("Nhap vao luong mua thang " +i+": ");
    //double luongmua = double.Parse(Console.ReadLine());
    //thang[i-1] = luongmua;
    Console.WriteLine("Luong mua thang " + i + " la: " + thang[i - 1]);
}
double tongluongmua = LuongMua.tongluongmua(thang);
Console.WriteLine("Tong luong mua trong nam la: " + tongluongmua);

double AverageRain = LuongMua.AverageRain(thang);
Console.WriteLine("Trung binh mua trong nam: " + AverageRain);

double Max = LuongMua.Max(thang);
Console.WriteLine("Max mua trong nam: " + Max);

double Min = LuongMua.Min(thang);
Console.WriteLine("Min mua trong nam: " + Min);

int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
int totalNumber = NumberAnalysisProgram.NumberAnalysis(Numbers);
Console.WriteLine("Tong cac so trong mang: " + totalNumber);

float average = NumberAnalysisProgram.AvarageNumber(Numbers);
Console.WriteLine("Trung binh day so: " + average);

int max = NumberAnalysisProgram.Max(Numbers);
Console.WriteLine(" so lon nhat : " + max);

int min = NumberAnalysisProgram.Min(Numbers);
Console.WriteLine(" so nho nhat : " + min);



// Yêu cầu người dùng nhập số tài khoản
Console.Write("Vui lòng nhập số tài khoản: ");
int accountNumber;

// Đọc input và kiểm tra xem có phải là số không
if (int.TryParse(Console.ReadLine(), out accountNumber))
{
    // Kiểm tra tính hợp lệ của tài khoản sử dụng lớp từ Labrary1
    bool isValid = ChargeAccountValidation.AccountValidation(accountNumber);

    // In ra kết quả kiểm tra
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



//// Tạo đối tượng của lớp MonthDays
//MonthDays monthdays = new MonthDays();

//// Gọi phương thức GetDaysInEachMonth từ đối tượng monthdays
//string[] result = monthdays.GetDaysInEachMonth();

//// Hiển thị kết quả
//Console.WriteLine("so ngay cua tung thang trong nam : "+ result[0]);



// Tạo đối tượng của lớp MonthDays
MonthDays monthdays = new MonthDays();

// Gọi phương thức GetDaysInEachMonth từ đối tượng monthdays
string[] result = monthdays.GetDaysInEachMonth();

// Yêu cầu người dùng nhập vị trí tháng (1-12)
Console.Write("Vui lòng nhập vị trí của tháng (1-12): ");
string input = Console.ReadLine();

// Chuyển đổi đầu vào từ chuỗi sang số nguyên
int monthIndex;
if (int.TryParse(input, out monthIndex))
{
    // Trừ 1 vì mảng bắt đầu từ 0
    monthIndex--;

    // Kiểm tra nếu người dùng nhập đúng vị trí hợp lệ
    if (monthIndex >= 0 && monthIndex < result.Length)
    {
        // Hiển thị số ngày của tháng tương ứng
        Console.WriteLine(result[monthIndex]);
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













