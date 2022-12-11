using System;
using System.Collections.Generic;
using System.Text;

namespace AccessSpecifier
{
    class Employee
    {
        private int id;
        private string name;
        private double salary;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            // property initializer syntax
            e1.Id = 1;
            e1.Name = "Peter";
            e1.Salary = 50000;

            Console.WriteLine($"{e1.Id}  {e1.Name}  {e1.Salary}");
            // object initializer syntax
            Employee e2 = new Employee { Id = 2, Name = "Shraddha", Salary = 70000 };

            Console.WriteLine($"{e1.Id}  {e1.Name}  {e1.Salary}");


        }

    }
}
