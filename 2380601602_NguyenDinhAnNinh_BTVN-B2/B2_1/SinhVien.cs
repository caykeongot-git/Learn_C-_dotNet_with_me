using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2_1
{
    internal class SinhVien
    {

        public int Id { get; set; }

        public string Name { get; set; }

        private int _age;

        public int Age
        {
            get {  return _age; }
            set {

                if (value < 0) throw new ArgumentException("Nhập tuổi lớn hơn 0");
                _age = value;
            
            }
        }

        public SinhVien(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public override string ToString() {
            return $"ID: {Id}, Name: {Name}, Age: {Age}";
        }
    
    }
}
