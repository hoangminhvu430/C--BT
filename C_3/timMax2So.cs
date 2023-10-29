/*Viết chương trình cho phép nhập hai số từ bàn phím, tìm và in ra màn hình số lớn nhất. 


Input: Nhập vào 2 số nguyên theo định dạng sau:
Dòng 1: số nguyên a
Dòng 2: số nguyên b
Output: 
Xuất ra 1 số duy nhất là số lớn nhất trong 2 số*/
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int max = a;

        if(b > max)
        {
            Console.WriteLine(b);
        } else
        {
            Console.WriteLine(max);
        }
    }
}
