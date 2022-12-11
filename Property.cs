using System;
using System.Collections.Generic;
using System.Text;

namespace AccessSpecifier
{
    public class Course
    {
        private int id;
        private string name;
        private double fees;

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
        public double Fees
        {
            get { return fees; }
            set { fees = value; }
        }

        static void Main(string[] args)
        {
            Course C1 = new Course();
            // property initializer syntax
            C1.Id = 1;
            C1.Name = "Peter";
            C1.Fees = 25000;

            Console.WriteLine($"{C1.Id}  {C1.Name}  {C1.Fees}");
            // object initializer syntax
            Course C2 = new Course { Id = 2, Name = "Shraddha", Fees = 25000 };

            Console.WriteLine($"{C2.Id}  {C2.Name}  {C2.Fees}");


        }


    }
}
