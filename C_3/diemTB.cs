/*Viết chương trình nhập vào điểm ba môn Toán, Lý, Hóa của một học sinh. In ra điểm trung bình của học sinh đó với hai số lẻ thập phân.


Input: Nhập vào 3 số thực theo định dạng sau:
Dòng 1: số điểm môn Toán
Dòng 2: số điểm môn Lý
Dòng 3: số điểm môn Hóa
Output: 
Xuất ra 1 số duy nhất là kết quả trung bình của 3 môn.
(Dùng mã định dạng lấy chính xác 2 chữ số thập phân)*/
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        double toan = double.Parse(Console.ReadLine());
        double ly = double.Parse(Console.ReadLine());
        double hoa = double.Parse(Console.ReadLine());

        Console.WriteLine("{0:0.00}", ((toan + ly + hoa)/3));
    }
}
