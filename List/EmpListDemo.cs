using System;
using System.Collections.Generic;
using System.Text;

namespace AccessSpecifier.List
{
    class EmpListDemo
    {
        public int id;
        public string name;
        public double salary;

        public EmpListDemo(int id,string name,double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
    }
    class CustomList
    {
        static void Main(string[] args)
        {
            List<EmpListDemo> li = new List<EmpListDemo>();
            li.Add(new EmpListDemo(101, "Rohan", 30000));
            li.Add(new EmpListDemo(102, "Rohit", 20000));
            li.Add(new EmpListDemo(103, "Shreya", 350000));
            li.Add(new EmpListDemo(101, "Riya", 15000));

            foreach (EmpListDemo e in li)
            {
            
                if (e.salary > 25000)
                {
                    Console.WriteLine(e.id + " " + e.name + " " + e.salary);

                }
            }

        }
    }
}
