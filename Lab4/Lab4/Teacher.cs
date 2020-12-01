using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    class Teacher<T>
    {
        public int age;
        public string name;
        public T numcl;

        public Teacher(int age, string name, T numcl)
        {
            this.age = age;
            this.name = name;
            this.numcl = numcl;
        }

        public override bool Equals(object obj)
        {
            return obj is Teacher<T> t1 &&
                   age == t1.age &&
                   name.Contains( t1.name);
        }

        public override string ToString()
        {
            return String.Format("Личное дело преподавателя: имя - {0}, возраст - {1}, успеваемость по предметам в процентах - {2} ", this.name, this.age, this.numcl); ;
        }
    }
}
