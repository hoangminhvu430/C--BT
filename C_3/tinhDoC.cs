/*Viết chương trình đọc vào độ F, tính và in ra độ C theo công thức như sau:

    C = ((F – 32) * 5) / 9.


Input: Nhập vào một số thực f
Output: Xuất ra một số duy nhất là kết quả của biểu thức  ((f – 32) * 5) / 9
(Lấy chính xác 2 chữ số thập phân)*/
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        double f = double.Parse(Console.ReadLine());
        double c = ((f - 32) * 5) / 9;
        Console.WriteLine("{0:0.00}", c);
    }
}