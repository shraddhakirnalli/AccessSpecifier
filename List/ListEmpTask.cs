using System;
using System.Collections.Generic;
using System.Text;

namespace AccessSpecifier.List
{
    class Department_
    {
        public int deptId;
        public string deptName;
        public Department_(int dId, string dName)
        {
            this.deptId = dId;
            this.deptName = dName;
        }
    }
    class Employee_
    {
        public int eId;
        public string eName;
        public Department_ edept;

        public Employee_(int eId, string eName, Department_ eDept)
        {
            this.eId = eId;
            this.eName = eName;
            this.edept = eDept;
        }
    }
    class ListEmpTask
    {
        static void Main(string[] args)
        {
            List<Employee_> li = new List<Employee_>();
            li.Add(new Employee_(101, "Nikhil", new Department_(10, "HR")));
            li.Add(new Employee_(106, "Abhishek", new Department_(30, "Sales")));
            li.Add(new Employee_(105, "Yash", new Department_(20, "HR")));
            li.Add(new Employee_(103, "Ritesh", new Department_(10, "Sales")));
            li.Add(new Employee_(102, "Pramod", new Department_(20, "Sales")));

            for (int i = 0; i < li.Count; i++)
            {
                for (int k = 0; k < li.Count; k++)
                {
                    if (li[i].eName.Equals("Nikhil") && li[k].edept.deptName.Equals(li[i].edept.deptName))
                    {
                        Console.WriteLine(li[k].eName + "  ");
                    }
                }
            }
        }
    }

}
