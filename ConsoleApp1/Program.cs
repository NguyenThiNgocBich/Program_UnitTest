// See https://aka.ms/new-console-template for more information
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
    Console.Write(" "+a[i]+" ");
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
    Console.WriteLine("Luong mua thang " +i+" la: "+thang[i-1]);
}
double tongluongmua = LuongMua.tongluongmua(thang);
Console.WriteLine("Tong luong mua trong nam la: "+ tongluongmua);

double AverageRain = LuongMua.AverageRain(thang);
Console.WriteLine("Trung binh mua trong nam: "+ AverageRain);

double Max = LuongMua.Max(thang);
Console.WriteLine("Max mua trong nam: " + Max);

double Min = LuongMua.Min(thang);
Console.WriteLine("Min mua trong nam: " + Min);

int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
int totalNumber = NumberAnalysisProgram.NumberAnalysis(Numbers);
Console.WriteLine("Tong cac so trong mang: " + totalNumber);

float average = NumberAnalysisProgram.AvarageNumber(Numbers);
Console.WriteLine("Trung binh day so: "+ average);

int max = NumberAnalysisProgram.Max(Numbers);
Console.WriteLine(" so lon nhat : " + max);

int min = NumberAnalysisProgram.Min(Numbers);
Console.WriteLine(" so nho nhat : " + min);





