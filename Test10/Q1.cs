using System;
using System.Collections.Generic;
using System.Text;

namespace AccessSpecifier.Test10
{
    class Q1
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>()
            {
                45,63,85,98,74,12,45,96,87,21,22,35,53,62,26,42,45,47,48,59,96
            };

            for (int i = 0; i < li.Count; i++)
            {
                for (int j = i + 1; j < li.Count; j++)
                {
                    if (li[i] < li[j])
                    {
                        var temp = li[i];
                        li[i] = li[j];
                        li[j] = temp;
                    }
                }
            }
            foreach (var item in li)
            {
                Console.Write(item + " ");
            }
        }
    }

    //Write a  program to Remove duplicate elements from List
    class Q2
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>()
            {
                45,63,85,98,74,12,45,90,87,21,22,35,53,62,26,42,45,47,48,59,96,
                63,85,98,12,96,21,22,42,45,59,20//96,96,90,90,90
            };

            for (int i = 0; i < li.Count; i++)
            {
                for (int j = i + 1; j < li.Count; j++)
                {
                    if (li[i].Equals(li[j]))
                    {
                        li.RemoveAt(j);
                    }
                }
            }

            foreach (var item in li)
            {
                Console.Write(item + "  ");
            }
            Console.WriteLine("........." + li.Count);
        }
    }
    public class Output
    {
        static void Main(string[] args)
        {
            List<String> list1 = new List<string>();
            list1.Add("Me");
            list1.Add("You");
            list1.Add("He");
            list1.Add("She");
            list1.Add("It");
            List<String> list2 = new List<string>();
            list2.Add("You");
            list1.InsertRange(0, list2);
            foreach (String temp in list1)
            {
                Console.WriteLine(temp + " ");
            }
        }
    }
    //WAP to create a List<Emp> and search for Emp object whose	
    //Empno=10 and delete all the records whose dept is same as
    //empno 10. 
    //Emp[Empno, ename, Dept d]
    //Dept[did, dname]

    class Dept
    {
        public int did;
        public string dname;

        public Dept(int did, string dname)
        {
            this.did = did;
            this.dname = dname;
        }
    }
    class Emp
    {
        public int empNo;
        public string ename;
        public Dept dept;
        public Emp(int empno, string ename, Dept dept)
        {
            this.empNo = empno;
            this.ename = ename;
            this.dept = dept;
        }
    }
    class Test10Que3
    {
        static void Main(string[] args)
        {
            List<Emp> elist = new List<Emp>();
            elist.Add(new Emp(20, "Shraddha", new Dept(201, "RND")));
            elist.Add(new Emp(10, "Rahul", new Dept(202, "HR")));
            elist.Add(new Emp(30, "Akash", new Dept(201, "RND")));
            elist.Add(new Emp(40, "Mohit", new Dept(203, "Sales")));
            elist.Add(new Emp(50, "Krushna", new Dept(202, "HR")));
            elist.Add(new Emp(60, "Nikhil", new Dept(203, "Sales")));

            for (int i = 0; i < elist.Count; i++)
            {
                if (elist[i].empNo == 10)
                {
                    for (int j = i + 1; j < elist.Count; j++)
                    {
                        if (elist[i].dept.dname.Equals(elist[j].dept.dname))
                        {
                            elist.RemoveAt(j);
                        }
                    }
                }
            }
            foreach (Emp e in elist)
            {
                Console.WriteLine(e.empNo + "  " + e.ename + "  " + e.dept.did + "  " + e.dept.dname);
            }
        }
    }
    //Consider an List of Movie						
    //Movie has(int movieid, String moviename, List<String> actor)
    //Find “Amitabh bachchan has acted in how many movies

    class Movie
    {
        public int movieid;
        public string movieName;
        public List<string> actor;

        public Movie(int mid, string mName, List<string> mactor)
        {
            this.movieid = mid;
            this.movieName = mName;
            this.actor = mactor;
        }
    }
    class Test10Que4
    {
        static void Main(string[] args)
        {
            List<Movie> ml = new List<Movie>();
            ml.Add(new Movie(121, "Baghban", new List<string>() { "salman", "amitabh", "hema" }));
            ml.Add(new Movie(181, "Dabbang", new List<string>() { "salman", "sonakshi", "sonu" }));
            ml.Add(new Movie(161, "Pink", new List<string>() { "taapsee", "kirti", "amitabh" }));
            ml.Add(new Movie(191, "Haseen Dilruba", new List<string>() { "taapsee", "vikrant", "shivaji" }));
            ml.Add(new Movie(171, "Khuda Gawah", new List<string>() { "sridevi", "amitabh", "nagarjuna" }));
            ml.Add(new Movie(131, "Hum", new List<string>() { "govinda", "amitabh", "rajinikant" }));

            int Amitabhmvcnt = 0;
            foreach (Movie m in ml)
            {
                if (m.actor.Contains("amitabh"))
                {
                    Console.WriteLine(m.movieName);
                    Amitabhmvcnt++;
                }
            }
            Console.WriteLine("Total acted movies : " + Amitabhmvcnt);
        }
    }
    //Write a program to find all pairs of elements in an integer array whose sum is equal to a given number?									
    //Input Array : [4, 6, 5, -10, 8, 5, 20]
    //InputNumber:10
    //Pairs of elements whose sum is 10 are :
    //4 + 6 = 10
    //5 + 5 = 10
    //-10 + 20 = 10
    class Test10Que5
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 6, 5, -10, 8, 5, 20, 23, 7, 9 };
            int num = 10;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == num)
                    {
                        Console.WriteLine($"{arr[i]} + {arr[j]} = {num}");
                    }
                }
            }
        }
    }
    //A Pen contains variables Refill, capLength and brand. Refill has variables
    //inkColor, length and Nib(tip). Nib has variables materialType and width.Create
    //a Java class structure for above.Write a main method which sets values in all the variables
    //using setter methods and prints all the variables using getter methods. 
    //(consider getter, setter are present in all classes only write main method)
    class Nib
    {
        string materialType;
        double width;
        public string MaterialType
        {
            get { return materialType; }
            set { materialType = value; }
        }
        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        public void DisplayNib()
        {
            Console.WriteLine("Nib Details : \nMaterial Type = " + MaterialType + "\nWidth = " + Width);
        }
    }
    class Refil
    {
        string inkColor;
        double length;
        Nib nib;
        public string InkColor
        {
            get { return inkColor; }
            set { inkColor = value; }
        }
        public double Length
        {
            get { return length; }
            set { length = value; }
        }
        public Nib Nib
        {
            get { return nib; }
            set { nib = value; }
        }
        public void DisplayRefil()
        {
            Console.WriteLine("Refill Details : \nInk Color = " + InkColor + "\nLength = " + Length);
            Nib.DisplayNib();
        }
    }
    class Pen1
    {
        Refil refil;
        double capLength;
        string brand;

        public Refil Refil
        {
            get { return refil; }
            set { refil = value; }
        }
        public double CapLength
        {
            get { return capLength; }
            set { capLength = value; }
        }
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public void DisplayPen()
        {
            Console.WriteLine("Pen Details : \nCaplength = " + CapLength + "\nBrand = " + Brand);
            Refil.DisplayRefil();
        }
    }

    class Structure
    {
        static void Main(string[] args)
        {
            Pen1 p = new Pen1();
            p.CapLength = 4.5;
            p.Brand = "Cello";
            p.Refil = new Refil();
            p.Refil.InkColor = "Red";
            p.Refil.Length = 8.5;
            p.Refil.Nib = new Nib();
            p.Refil.Nib.MaterialType = "Plastic";
            p.Refil.Nib.Width = 0.8;

            p.DisplayPen();
        }
    }
}

