using System;
using System.Collections.Generic;
using System.Text;

namespace Task1.Models
{
    class Person
    {
        public string Name;
        public string Surname;
        public int Age;
        public bool IsMaried;
        public Person()
        {

        }
        public Person(string Name, string Surname)
        {
            this.Name = Name;
            this.Surname = Surname;

        }
        public Person(string Name, string Surname,int Age, bool IsMaried) : this(Name,Surname)
        {
            this.Age = Age;
            this.IsMaried = IsMaried;
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}\nSurnmae: {Surname}\nAge: {Age}\nIs Married: {IsMaried}");
            
        }
       

    }
}
