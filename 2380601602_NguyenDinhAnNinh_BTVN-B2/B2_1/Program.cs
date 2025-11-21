using System;
using System.Text;

namespace B2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<SinhVien> ls = new List<SinhVien> {
                    new SinhVien (1, "Ninh", 11),
                    new SinhVien (2, "Loan", 21),
                    new SinhVien (3, "An", 100),
                    new SinhVien (4, "Hân", 90),
                    new SinhVien (5, "Khoa", 51)
            };
            ;
            // a
            Console.WriteLine("a. Danh sách toàn bộ sanh diên: ");
            ls.ForEach (s => Console.WriteLine (s));

            // b
            Console.WriteLine("\nb. Sanh diên từ 15 đến 18 tuổi");
            var temp2 = ls.Where(s => s.Age >= 15 && s.Age <= 18).ToList();
            temp2.ForEach (s => Console.WriteLine (s));

            // c
            Console.WriteLine("\nc. Sanh diên tên bắt đầu bằng chữ 'A'");
            List<SinhVien> temp3 = ls.Where(s => s.Name.StartsWith("A")).ToList();
            temp3.ForEach (s => Console.WriteLine (s));

            //d
            int temp4 = ls.Sum(s => s.Age);
            Console.WriteLine($"\nd. Tổng tuổi tất cả sanh diên: {temp4}");

            //e
            Console.WriteLine("\ne. Sanh diên lớn tuổi nhất");
            SinhVien temp5 = ls.OrderByDescending(s => s.Age).FirstOrDefault();
            if (temp5 != null) Console.WriteLine(temp5);

            //f
            Console.WriteLine("\nf. Danh sách sắp xếp theo tuổi tăng dần: ");
            var temp6 = ls.OrderBy(s => s.Age).ToList();
            temp6.ForEach(s => Console.WriteLine(s));

        }
    }
}
