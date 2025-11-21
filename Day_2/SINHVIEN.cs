using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Day_2_ENCAPSULATION
{
    internal class SINHVIEN
    {
        private string _maSinhVien;
        private string _hoTen;
        private double _gpa;
        private static int countStudent { get; set; } = 0;
        public string HoTen { get; set; }
        public string MaSinhVien { 
            get { return _maSinhVien; }
            set { _maSinhVien = value; }
        }
        public double GPA
        {
            get { return _gpa; }
            set
            {
                if (_gpa >= 0 && _gpa <= 4.0) _gpa = value;
                else _gpa = 0;
            }
        }

        public SINHVIEN ()
        {
            Console.WriteLine("Ham tao khong co tham so");
            _maSinhVien = "NULL";
            _hoTen = "NULL";
            _gpa = 0;   
        }

        public SINHVIEN (string maSinhVien, string hoTen , double gpa)
        {
            this._maSinhVien = maSinhVien;
            this._gpa = gpa;
            this._hoTen = hoTen;
            ++countStudent;
        }

        public void display ()
        {
            Console.WriteLine($"{_maSinhVien} - {_hoTen} - {_gpa}");
        }

        public static void ThongTinTruong ()
        {
            Console.WriteLine("Lam gi co bien thong tin truong");
        }


    }
}
