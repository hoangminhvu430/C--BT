/*Chương trình nhập vào bán kính hình tròn. Tính, in ra chu vi và diện tích của hình tròn.

-       Biết PI =3.141;

-       Chu vi = 2 * bán kính * PI;

-       Diện tích = PI * bán kính * bán kính.




Input: Nhập vào 1 số thực r.
Output: Xuất ra 2 số duy nhất là kết quả của chu vi và diện tích
             (Dùng mã định dạng lấy chính xác 2 chữ số thập phân)*/
using System;

namespace baitap2
{
  class Program
  {
    static void Main(string[] args)
    {
      double r = double.Parse(Console.ReadLine());
        double pi = 3.141;
        double chuVi, dienTich;

        chuVi = 2 * pi * r;
        dienTich = pi * r * r;
        Console.WriteLine("{0:0.00}", chuVi);
        Console.WriteLine("{0:0.00}", dienTich);   
    }
  }
}   