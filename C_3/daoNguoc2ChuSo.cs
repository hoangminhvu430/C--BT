/*Viết chương trình nhập vào số nguyên dương có hai chữ số. In ra số đảo ngược.  

Input: Nhập vào một số nguyên n có 2 chữ số (chữ số tận cùng khác 0)
Output: Xuất ra 1 số duy nhất là số đảo ngược của n*/
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int hangchuc = a / 10;
        int hangdonvi = a % 10;
        int daonguoc = hangdonvi * 10 + hangchuc; 
        Console.WriteLine(daonguoc);
    }
}
