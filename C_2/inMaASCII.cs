/*Viết chương trình nhập vào một ký tự. In ra mã Ascii của ký tự đó và in ra ký tự kế tiếp của nó.

Input: Nhập vào 1 ký tự
Output: Xuất ra mã Ascii và ký tự tiếp theo*/
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        char x = char.Parse(Console.ReadLine());
        Console.WriteLine((int)x);
        Console.WriteLine((char)(x + 1));
    }
}