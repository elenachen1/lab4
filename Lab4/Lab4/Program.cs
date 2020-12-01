using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student(20, "Коля", 60);
            Student st2 = new Student(20, "Коля", 60);
            Student st3 = new Student(25, "Вика", 100);
            Student st4 = st1;

            Teacher<int> t1 = new Teacher<int>(80, "Евгений Викторович", 15);
            Teacher<string> t2 = new Teacher<string>(45, "Мария Сергеевна", "45");

            Console.WriteLine(st1.ToString());
            Console.WriteLine(st1.Equals(st2));
            Console.WriteLine(st1.Equals(st3));
            Console.WriteLine(st1.Equals(st4));

            Console.WriteLine(t1.ToString());
            Console.WriteLine(t2.ToString());
            Console.WriteLine(t1.Equals(t2));
        }
    }
}
