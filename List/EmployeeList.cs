using System;
using System.Collections.Generic;
using System.Text;

namespace AccessSpecifier.List
{
    class EmployeeList
    {
        public int eid;
        public string ename;
        public int salary;

        public EmployeeList(int eid, string ename, int salary)
        {
            this.eid = eid;
            this.ename = ename;
            this.salary = salary;
        }
    }
    class EqualCheck: IEqualityComparer<EmployeeList>
    {
        bool IEqualityComparer<EmployeeList>.Equals(EmployeeList x, EmployeeList y)
        {
            return x.eid == y.eid && x.ename == y.ename;
        }
        int IEqualityComparer<EmployeeList>.GetHashCode(EmployeeList obj)
        {
            return obj.eid;
        }
    }
    class CustomDictionaryDemo
    {
        static void Main(string[] args)
        {
            Dictionary<EmployeeList, string> emp = new Dictionary<EmployeeList, string>(new EqualCheck());
            for(int i=1;i<=3;i++)
            {
                Console.WriteLine("Enter Employee id:");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Employee Name:");
                string name =Console.ReadLine();
                Console.WriteLine("Enter Employee Salary:");
                int salary = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Dept Name:");
                string deptname = Console.ReadLine();
                EmployeeList e = new EmployeeList(id, name, salary);
                if (emp.ContainsKey(e))
                {
                    Console.WriteLine("Already Present");
                }
                else
                {
                    emp.Add(e, deptname);
                }
            }

            foreach (KeyValuePair<EmployeeList, string> dm in emp)
            {
                EmployeeList em = dm.Key;
                Console.WriteLine(em.eid + "  " + em.ename + "  " + em.salary + "  " + dm.Value);
            }
        }
        }
    }

