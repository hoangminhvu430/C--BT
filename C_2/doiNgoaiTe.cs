/*Chương trình chuyển đổi tiền tệ từ đô la Mỹ($) sang bảng Anh (£), yên Nhật (¥), Việt Nam đồng(đ) và hiển thị kết quả ra màn hình. Biết tỷ giá 1 đô la Mỹ bằng 0.8144£, 105.407¥, 23160đ.

Input: Nhập vào 1 nguyên (Số đô la Mỹ).
Output: Xuất ra số bảng Anh, yên Nhật và Việt Nam đồng.*/
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int USD = int.Parse(Console.ReadLine());
        double anh = 0.8144, yen = 105.407, VND = 23160;

        Console.WriteLine(anh * USD);
        Console.WriteLine(yen * USD);
        Console.WriteLine(VND * USD);
    }
}