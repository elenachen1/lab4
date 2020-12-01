using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    class Student
    {
        public int age;
        public string name;
        public double procent;

        public Student(int age, string name, double procent)
        {
            this.age = age;
            this.name = name;
            this.procent = procent;
        }

        public override bool Equals(object obj)
        {
            return obj is Student st1 &&
                   age == st1.age &&
                   name == st1.name &&
                   procent == st1.procent;
        }

        public override string ToString()
        {
            return String.Format("Личное дело студента: имя - {0}, возраст - {1}, успеваемость по предметам в процентах - {2} ", this.name, this.age,this.procent);
        }

        
    }
}
