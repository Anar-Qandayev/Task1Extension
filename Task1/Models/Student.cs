using System;
using System.Collections.Generic;
using System.Text;

namespace Task1.Models
{
    class Student:Person
    {
        public string Degree;
        public bool IsHigh;
        public Student(string Name, string Surname, int Age, bool IsMaried,string Degree, bool IsHigh):base( Name, Surname,Age, IsMaried)
        {
            this.Degree = Degree;
            this.IsHigh = IsHigh;
            
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            if (Age < 6 || Age > 18)
            {
                Console.WriteLine("You can't be Student");
            }
            else Console.WriteLine($"Name: {Name}\nSurnmae: {Surname}\nAge: {Age}\nIs Married: {IsMaried}\nDegree: {Degree}\nIsHigh: {IsHigh}");
        }
        
    }
}
