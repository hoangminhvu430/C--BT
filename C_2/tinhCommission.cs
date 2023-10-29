/*Chương trình cho phép người dùng nhập các giá trị sale1, sale2 và commissionRate.

-       Tính totalSale = sale1 + sale2 và commission=totalSale*commissionRate.

-       In ra màn hình giá trị commission.

Input: Nhập vào 3 số thực theo định dạng sau:
Dòng 1: số thực sale1
Dòng 2: số thực sale2
Dòng 3: số thực commissionRate 
Output: 
Xuất ra 1 số duy nhất là kết quả của commission*/
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        double sale1 = double.Parse(Console.ReadLine());
        double sale2 = double.Parse(Console.ReadLine());
        double commissionRate = double.Parse(Console.ReadLine());

        double totalSale, commission;
        totalSale = sale1 + sale2;
        commission = totalSale * commissionRate;
        Console.WriteLine(commission);
    }
}