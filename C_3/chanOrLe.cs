/*Chương trình cho phép nhập vào một số nguyên. Kiểm tra và in ra màn hình kết quả “Là số chẵn” hoặc “Là số lẻ”.


Input: Nhập vào một số nguyên 
Output: In ra thông báo "So chan" hoặc "So le"*/
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());

        if(a % 2 == 0)
        {
            Console.WriteLine("So chan");
        } else { 
            Console.WriteLine("So le"); 
        }
    }
}
