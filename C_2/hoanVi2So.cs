/*Chương trình cho phép nhập vào hai giá trị num1, num2. Thực hiện hoán vị hai giá trị num1 và num2 cho nhau. In giá trị mới ra màn hình.




Input: Nhập vào 2 số nguyên theo định dạng sau:
Dòng 1: số nguyên num1
Dòng 2: số nguyên num2
Output: 
Xuất ra giá trị mới cho số num1 và num2*/
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3;

        num3 = num1;
        num1 = num2;
        num2 = num3;

        Console.WriteLine(num1);
        Console.WriteLine(num2);

    }
}