using System;
using System.Collections.Generic;
using System.Text;

namespace AccessSpecifier.List
{
    class Employee : IComparable
    {
        public int id;
        public string name;
        public int salary;

        public Employee(int id,string name,int salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        public int CompareTo(object obj)
        {
            Employee e = (Employee)obj;
            return e.salary - this.salary;
        }

    }
    class CustomListDemo
    {
        static void Main(string[] args)
        {
            List<Employee> li = new List<Employee>();
            li.Add(new Employee(101, "Peter", 50000));
            li.Add(new Employee(111, "Michael", 75000));
            li.Add(new Employee(121, "Kylie", 85000));
            li.Add(new Employee(151, "Khloe", 35000));

            foreach(Employee e in li)
            {
                Console.WriteLine(e.id+" "+e.name+" "+e.salary);
            }
            Console.WriteLine("---------------------------------------------------");
            li.Sort();
            foreach(Employee e in li)
            {
                Console.WriteLine(e.id + " " + e.name + " " + e.salary);

            }
        }
    }
}
