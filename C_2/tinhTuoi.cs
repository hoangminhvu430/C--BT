/*Chương trình cho phép người dùng nhập vào năm sinh một nam nhân viên. Tính:

-       Tính tuổi hiện tại.

-       Tính năm về hưu (biết tuổi về hưu của nam là 60).


Input: Nhập vào 1số nguyên namSinh
Output: 
Xuất ra 2 số là tuoiHienTai và namVeHuu*/
using System;

internal class Program
{
    private static void Main(string[] args)
    {
       int year = int.Parse(Console.ReadLine());
       int age, namVeHuu;
       age = 2022 - year;
       namVeHuu = year + 60;
        Console.WriteLine(age);
        Console.WriteLine(namVeHuu);
        
    }
}