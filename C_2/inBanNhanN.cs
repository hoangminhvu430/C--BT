/*Chương trình cho phép nhập một số nguyên dương n và in bảng nhân của số đó.

Ví dụ: n=3 thì ta in ra:

 3x1=3

 3x2=6

 …

3x10=30

Input: Nhập vào 1 số nguyên n
Output: 
Xuất ra bảng nhân n.*/
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());

        for(int i = 1; i <= 10;  i++)
        {
            Console.WriteLine(i * num);
        }
    }
}