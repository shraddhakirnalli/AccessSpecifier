using System;
using System.Collections.Generic;
using System.Text;

namespace AccessSpecifier.ArrayDemo
{
    class Sample
    {
        int[] arr = new int[5];

        public void initialize()
        {
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            arr[3] = 4;
            arr[4] = 5;
        }

        public void display()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        static void Main(string[] args)
        {
            Sample s = new Sample();
            s.initialize();
            s.display();

            Sample s1 = new Sample();
            int[] ar = new int[5];
            Console.WriteLine("Enter array");
            for (int i = 0; i < 5; i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Array is ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(ar[i] + " ");
            }

            int[] arrs = { 2, 8, 5, 9, 7 };
            Console.WriteLine(arrs);

            int[] ars = { 5, 8, 9, 4, 6 };
            Console.WriteLine("Reverse Array is ");
            for (int i = 4; i >= 0; i--)
            {
                Console.Write(ars[i] + " ");
            }
        }
    }
    // Merge two array without duplicate element
    class Class1
    {
        static void Main(string[] args)
        {
            int[] a = { 4, 5, 6, 7, 8, 9, 4, 2, 1 };
            int[] b = { 3, 5, 4, 6, 10, 9, 14, 2, 11 };
            int[] c = new int[a.Length + b.Length];

            int k = 0;
            for (int i = 0; i < a.Length; i++)
            {
                bool IsCheck = true;
                for (int j = k - 1; j >= 0; j--)
                {
                    if (a[i] == c[j])
                    {
                        IsCheck = false;
                        break;
                    }
                }
                if (IsCheck)
                {
                    c[k++] = a[i];
                }
            }
            for (int i = 0; i < b.Length; i++)
            {
                bool IsCheck = true;
                for (int j = k - 1; j >= 0; j--)
                {
                    if (b[i] == c[j])
                    {
                        IsCheck = false;
                        break;
                    }
                }
                if (IsCheck)
                {
                    c[k++] = b[i];
                }
            }
            for (int i = 0; i < k; i++)
            {
                Console.Write(c[i] + " ");
            }
        }
    }
    class TriangularArray
    {

        public void accept(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        public void Display(int[,] a)
        {
            Console.WriteLine("Matrix is := ");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                    Console.Write(a[i, j] + " ");
                Console.WriteLine("");
            }
        }
        public void IsLowerTriangular(int[,] a)
        {
            bool lowerTriangular = true;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i < j)
                    {
                        if (a[i, j] != 0)
                        {
                            lowerTriangular = false;
                            break;
                        }

                    }
                }
            }
            if (lowerTriangular)
            {
                Console.WriteLine("Given Matrix is Lower Triangular Matrix");
            }
            else
            {
                Console.WriteLine("Not Lower Triangular Matrix");
            }
        }

        public void IsUpperTriangular(int[,] a)
        {
            bool upperTriangular = true;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i > j)
                    {
                        if (a[i, j] != 0)
                        {
                            upperTriangular = false;
                            break;
                        }

                    }
                }
            }
            if (upperTriangular)
            {
                Console.WriteLine("Given Matrix is Upper Triangular Matrix");
            }
            else
            {
                Console.WriteLine("Not Upper Triangular Matrix");
            }
        }

        static void Main(string[] args)
        {
            TriangularArray obj = new TriangularArray();
            int[,] matrix = new int[3, 3];
            obj.accept(matrix);
            obj.Display(matrix);
            obj.IsLowerTriangular(matrix);
            obj.IsUpperTriangular(matrix);
            Console.ReadKey();
        }
    }


    class JaggedArray
    {
        static void Main(string[] args)
        {
            int[][] jaggedarr = new int[3][];
            jaggedarr[0] = new int[] { 1, 2, 3, 4, 5 };
            jaggedarr[1] = new int[] { 3, 4, 5 };
            jaggedarr[2] = new int[] { 2, 3, 4, 5 };
            Console.WriteLine("Jagged array :");
            for (int i = 0; i < jaggedarr.GetLength(0); i++)
            {
                for (int j = 0; j < jaggedarr[i].Length; j++)
                {
                    Console.Write(jaggedarr[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }

    class PatterArray
    {
        public int[,] matrix = new int[4, 4];
        public void Accept()
        {
            Console.WriteLine("Enter Matrix := ");
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = int.Parse(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine("Matrix is := ");
            Console.WriteLine();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }
        public void ExternallArray()
        {
            Console.WriteLine("Matrix is := ");
            Console.WriteLine();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j == 0 || j == 3 || i == 0 || i == 3)
                        Console.Write(matrix[i, j] + "  ");
                    else
                        Console.Write("   ");

                }
                Console.WriteLine();
            }
        }
        public void NPatternArray()
        {
            Console.WriteLine("Matrix is := ");
            Console.WriteLine();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j || j == 0 || j == 3)
                        Console.Write(matrix[i, j] + "  ");
                    else
                        Console.Write("   ");

                }
                Console.WriteLine();
            }
        }
        public void ZPatternArray()
        {
            Console.WriteLine("Matrix is := ");
            Console.WriteLine();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if ((i + j) == matrix.GetLength(0) - 1 || i == 0 || i == 3)
                        Console.Write(matrix[i, j] + "  ");
                    else
                        Console.Write("   ");

                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            PatterArray ar = new PatterArray();
            ar.Accept();
            ar.Display();
            ar.ExternallArray();
            ar.ZPatternArray();
            ar.NPatternArray();

        }
    }
    //array of objects
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }


        static void Main(string[] args)
        {
            Student[] stud = new Student[3];
            for (int i = 0; i < stud.Length; i++)
            {
                // create new object
                stud[i] = new Student();
                Console.WriteLine("Enter id");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter marks");
                int marks = int.Parse(Console.ReadLine());
                // set properties
                stud[i].Id = id;
                stud[i].Name = name;
                stud[i].Marks = marks;
            }

            Console.WriteLine("ID\tName\tMarks");
            for (int i = 0; i < stud.Length; i++)
            {
                Console.WriteLine(stud[i].Id + "\t" + stud[i].Name + "\t" + stud[i].Marks);
            }
            Console.WriteLine("ID\tName\tMarks");
            foreach (Student s in stud)
            {
                Console.WriteLine(s.Id + "\t" + s.Name + "\t" + s.Marks);
            }

        }



    }
    class Student1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }

        public Student1()
        {
            Id = 0;
            Name = "";
            Marks = 0;
        }
        public Student1(int id, string name, int marks)
        {
            this.Id = id;
            this.Name = name;
            this.Marks = marks;
        }
        public void Display()
        {
            Console.WriteLine(Id + "\t" + Name + "\t" + Marks);
        }
        static void Main(string[] args)
        {
            Student1[] stud = new Student1[3];
            for (int i = 0; i < stud.Length; i++)
            {
                Console.WriteLine("Enter id");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter marks");
                int marks = int.Parse(Console.ReadLine());
                stud[i] = new Student1(id, name, marks);
            }

            Console.WriteLine("ID\tName\tMarks");
            foreach (Student1 s in stud)
            {
                s.Display();
            }

        }
    }

    class Function
    {

        public void Show()
        {
            int a, b;
            a = 5; b = 8;
            Console.WriteLine("Default := " + a + b);
        }
        public void Add(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine("With Parameter := " + sum);
        }
        public int Sum(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
        static void Main(string[] args)
        {
            Function f = new Function();
            f.Show();
            f.Add(5, 8);
            Console.WriteLine(f.Sum(8, 10));

        }
    }
    class MultiDArray
    {
        int[,] arr = new int[3, 3];

        public void accept()
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());

                }
            }
        }

        public void display()
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public void rowWiseSum()
        {
            int sum;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                sum = 0;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sum += arr[i, j];
                }
                Console.WriteLine($"Addition of {i} row is {sum}");
            }
        }
        public void ColWiseSum()
        {
            int sum;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                sum = 0;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sum += arr[j, i];
                }
                Console.WriteLine($"Addition of {i} column is {sum}");
            }
        }
        public int DiagonalSum()
        {
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        sum += arr[j, i];
                    }
                }
            }
            return sum;
        }
        public int AntiDiagonalSum()
        {
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if ((i + j) == (arr.GetLength(0) - 1))
                    {
                        sum += arr[j, i];
                    }
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            MultiDArray m = new MultiDArray();
            Console.WriteLine("Enter element");
            m.accept();
            Console.WriteLine("Multi diamensional array:");
            m.display();
            Console.WriteLine("Rowwise sum:");
            m.rowWiseSum();
            Console.WriteLine("Columnwise sum");
            m.ColWiseSum();
            Console.WriteLine("Diagonal sum is : " + (m.DiagonalSum()));
            Console.WriteLine("Anti Diagonal sum is : " + (m.AntiDiagonalSum()));

        }
    }
    class MaxMin
    {
        public void accept(int[,] a)
        {
            Console.WriteLine("Enter Elements");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        public void display(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public void Maximum(int[,] a)
        {

            for (int i = 0; i < a.GetLength(0); i++)
            {
                int max = a[i, 0];
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] > max)
                    {
                        max = a[i, j];
                    }
                }
                Console.WriteLine($"Maximum element of {i + 1} row is {max}");
            }
        }
        public void Minimum(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                int min = a[0, i];
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[j, i] < min)
                    {
                        min = a[j, i];
                    }
                }
                Console.WriteLine($"Minimum element of {i + 1} column is {min}");
            }
        }

        static void Main(string[] args)
        {
            MaxMin m = new MaxMin();
            int[,] arr = new int[3, 3];
            m.accept(arr);
            m.display(arr);
            m.Maximum(arr);
            m.Minimum(arr);
        }



    }
    class Employee
    {
        public int Id;
        public string Name;
        public int Salary;

        public Employee()
        {
            Id = 0;
            Name = "";
            Salary = 0;
        }
        public Employee(int id, string name, int salary)
        {
            this.Id = id;
            this.Name = name;
            this.Salary = salary;
        }
        public void Display()
        {
            Console.WriteLine(Id + "\t" + Name + "\t" + Salary);
        }
        static void Main(string[] args)
        {
            Employee[] emp = new Employee[3];
            for (int i = 0; i < emp.Length; i++)
            {
                Console.WriteLine("Enter Id");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Salary");
                int salary = int.Parse(Console.ReadLine());
                emp[i] = new Employee(id, name, salary);
            }

            Console.WriteLine("ID\tName\tSalary");
            foreach (Employee e in emp)
            {
                e.Display();
            }

        }



    }
    // copy method
    class ArrayProgram
    {
        static void Main(string[] args)
        {
            int[] list = { 52, 45, 63, 87, 96, 74 };
            Console.WriteLine("Length of array : " + list.Length);

            int[] temp = list;
            int[] t = new int[list.Length];
            // Array.Copy(list, t, list.Length);
            Console.WriteLine("Copied array");
            foreach (int i in t)
            {
                Console.Write(i + " ");
            }
        }
    }
    // copy method
    class ArrayProgram1
    {
        static void Main(string[] args)
        {
            int[] list = { 52, 45, 63, 87, 96, 74, 53 };
            Console.WriteLine("Length of array : " + list.Length);

            int[] temp = list;
            int[] t = { 1, 2, 0, 0, 0, 0, 0 };
            // Array.Copy(list, 2, t, 2, 5);
            Console.WriteLine("Copied array");
            foreach (int i in t)
            {
                Console.Write(i + " ");
            }
        }
    }
    //reverse method
    class ArrayProgram2
    {
        static void Main(string[] args)
        {
            int[] list = { 52, 45, 63, 87, 96, 74, 53 };
            Console.WriteLine("Length of array : " + list.Length);
            int[] temp = list;
            // Array.Reverse(temp);
            Console.WriteLine("Reverse array");
            foreach (int i in temp)
            {
                Console.Write(i + " ");
            }
        }
    }
    // sort method
    class ArrayProgram3
    {
        static void Main(string[] args)
        {
            int[] list = { 52, 45, 63, 87, 96, 74, 53 };
            Console.WriteLine("Length of array : " + list.Length);
            // Array.Sort(list);
            Console.WriteLine("Sorted array");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
        }
    }
    // indexof method
    class ArrayProgram4
    {
        static void Main(string[] args)
        {
            int[] list = { 52, 45, 63, 87, 96, 74, 53 };
            Console.WriteLine("Length of array : " + list.Length);
            // int indx = Array.IndexOf(list, 63);
            // Console.WriteLine("Index of 63 is : " + indx);
        }
    }

    // Clear method
    class ArrayProgram5
    {
        static void Main(string[] args)
        {
            int[] list = { 52, 45, 63, 87, 96, 74, 53 };
            Console.WriteLine("Length of array : " + list.Length);
            // Array.Clear(list, 2, list.Length - 2);
            Console.WriteLine("Cleared array");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
        }
    }

    // Equals method
    class ArrayProgram6
    {
        static void Main(string[] args)
        {
            int[] list1 = { 52, 45, 63, 87, 96, 74, 53 };
            int[] list2 = list1;

            /* if (Array.Equals(list1, list2))
             {
                 Console.WriteLine("Array are equals");
             }
             else
             {
                 Console.WriteLine("Array are not equals");
             }*/
        }
    }

    class StringMethods
    {
        static void Main(string[] args)
        {
            string myName = "myName is Pooja";
            myName = myName.ToUpper();
            Console.WriteLine(myName);

            myName = "myName is MAHESH";
            myName = myName.ToLower();
            Console.WriteLine(myName);

            myName = "     myName is SHRADDHA       ";
            myName = myName.Trim();
            Console.WriteLine(myName);

            myName = "     myName is SHRADDHA       ";
            myName = myName.TrimEnd();
            Console.WriteLine(myName + "  " + " Done");

            myName = "     myName is SHRADDHA       ";
            myName = myName.TrimStart();
            Console.WriteLine(myName + "  " + " Done");

            myName = "myName is GIRISH";
            bool isContains = myName.Contains("GIRISH1");
            Console.WriteLine(isContains);

            myName = "myName is SHREYASH";
            char[] charArray = myName.ToCharArray();
            foreach (char c in charArray)
            {
                Console.WriteLine(c);
            }
            myName = "myName is SHIRISH";
            myName = myName.Substring(0, 6);
            Console.WriteLine(myName);


            myName = "myName is SHREENATH";
            isContains = myName.StartsWith("my");
            Console.WriteLine(isContains);

            myName = "myName is SHIKHA";
            string[] breakMysentence = myName.Split(' ');
            foreach (string data in breakMysentence)
                Console.WriteLine(data);



            Console.ReadKey();


        }
    }
    class Add2array
    {

        public void accept(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        public void display(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public int[,] addTwoArray(int[,] a1, int[,] a2)
        {
            for (int i = 0; i < a1.GetLength(0); i++)
            {
                for (int j = 0; j < a2.GetLength(1); j++)
                {
                    a1[i, j] = a1[i, j] + a2[i, j];
                }
            }
            return a1;
        }
        static void Main(string[] args)
        {
            Add2array ar1 = new Add2array();
            int[,] arr1 = new int[3, 3];
            int[,] arr2 = new int[3, 3];
            // accept array
            Console.WriteLine("Enter Element for first array");
            ar1.accept(arr1);
            Console.WriteLine("Enter Element for second array");
            ar1.accept(arr2);
            // display array
            Console.WriteLine("First array : ");
            ar1.display(arr1);
            Console.WriteLine("Second array : ");
            ar1.display(arr2);
            // add two array
            int[,] ar = ar1.addTwoArray(arr1, arr2);
            Console.WriteLine("Addition of two arrays : ");
            ar1.display(ar);
        }
    }
}
