using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace AccessSpecifier.stack
{
    class Employee
    {
        public int id;
        public string name;
        public int salary;

        public Employee(int id, string name, int salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }

        public void DisplayEmp()
        {
            Console.WriteLine(id+" "+name+" "+salary);


        }
    }
    class StackDemo
    {
        static void Main(string[] args)
        {
            Stack<Employee> empst = new Stack<Employee>();
           
            empst.Push(new Employee(1,"Riya",10000));
            empst.Push(new Employee(2,"Siya", 30000));
            empst.Push(new Employee(3,"Rahul", 35000));
            empst.Push(new Employee(4,"Kiara", 20000));
            empst.Push(new Employee(5,"Priya", 25000));
            Console.WriteLine("-----------PEEK---------------------");
            Employee e = empst.Peek();
            e.DisplayEmp();
            Console.WriteLine("---------------");
            foreach(Employee emp in empst)
            {
                emp.DisplayEmp();
            }

            


        }
    }
}
