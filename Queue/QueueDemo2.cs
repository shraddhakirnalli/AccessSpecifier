using System;
using System.Collections.Generic;
using System.Text;

namespace AccessSpecifier.Queue
{
    class Student
    {
        public int id;
        public string name;
        public int marks;

        public Student(int id, string name, int marks)
        {
            this.id = id;
            this.name = name;
            this.marks = marks;
        }
        /*public void DisplayStudent()
        {
            Console.WriteLine(id+" "+name+" "+marks);
        }*/
    }
        class QueueDemo2
        {
            static void Main(string[] args)
            {
                Queue<Student> qst = new Queue<Student>();
                qst.Enqueue(new Student(11, "Shraddha", 75));
                qst.Enqueue(new Student(21, "Priya", 55));
                qst.Enqueue(new Student(34, "Rohan", 70));
                qst.Enqueue(new Student(54, "Piyush", 80));
                qst.Enqueue(new Student(11, "Kiara", 50));

                //Student s = qst.Peek();
                //s.DisplayStudent();
                foreach(var x  in qst)
                {
                if(x.marks>=60)
                {
                    Console.WriteLine(x.id+" "+x.name+" "+x.marks);
                }
                   //st.DisplayStudent();

                }
                 
            }
        }
    
}
