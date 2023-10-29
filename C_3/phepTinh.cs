/*Viết chương trình đọc vào 2 số nguyên và in ra kết quả của phép (+), phép trừ (-), phép nhân (*), phép chia (/). Nhận xét kết quả chia 2 số nguyên.
Input: Nhập vào 2 số nguyên theo định dạng sau:
Dòng 1: số nguyên a
Dòng 2: số nguyên b (b khác 0)
Output: Xuất ra 4 số là kết quả của phép (+), (-), (*), (/).*/
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        if (b != 0)
        {
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine("{0:0.0}", (double)a / b);
        }
    }
}