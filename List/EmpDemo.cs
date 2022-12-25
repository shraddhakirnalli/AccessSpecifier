using System;
using System.Collections.Generic;
using System.Text;

namespace AccessSpecifier.List
{
    class EmployeeList1
    {
        public int eid;
        public string ename;
        

        public EmployeeList1(int eid, string ename)
        {
            this.eid = eid;
            this.ename = ename;
            
        }
    }
    class EmpDemo
    {
        static void Main(string[] args)
        {
            
                List<EmployeeList1> li = new List<EmployeeList1>();
                li.Add(new EmployeeList1(101, "Rohan"));
                li.Add(new EmployeeList1(102, "Rohit"));
                li.Add(new EmployeeList1(103, "Shreya"));
                li.Add(new EmployeeList1(101, "Riya"));
        }
    }
}
