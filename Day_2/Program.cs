using System;
using System.Data.SqlTypes;

namespace Day_2_ENCAPSULATION
{
    class Program 
    {
        static void Main(string[] args)
        {

            SINHVIEN temp = new SINHVIEN();
            SINHVIEN sv = new SINHVIEN("2380601602", "Nguyen Dinh An Ninh", 3.31);
            sv.display();
            
        }

    }
}