using System;
using Task1.Models;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------PERSON-------");
            Person person = new Person();
            Person person1 = new Person("Anar","Qandayev",21,false);
            person1.ShowInfo();
            Console.WriteLine("-------STUDENT-------");
            Student student1 = new Student("Anar", "Qandayev", 21, false, "Bakalavr", true);
            student1.ShowInfo();
        }
    }
}
