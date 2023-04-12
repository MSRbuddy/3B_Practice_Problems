﻿namespace DefaultConstructor
{
    class Employee
    {
        public int Id, Age;
        public string Address, Name;
        public bool IsPermanent;
        //User Defined Default Constructor
        public Employee()
        {
            Id = 100;
            Age = 20;
            Address = "Hyderabad";
            Name = "Meghana";
            IsPermanent = true;
        }
        public void Display()
        {
            Console.WriteLine("Employee Id is:  " + Id);
            Console.WriteLine("Employee Age is:  " + Age);
            Console.WriteLine("Employee Address is:  " + Address);
            Console.WriteLine("Employee Name is:  " + Name);
            Console.WriteLine("Is Employee Permanent:  " + IsPermanent);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.Display();
        }
    }
}