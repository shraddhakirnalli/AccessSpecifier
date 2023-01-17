using System;
using System.Collections.Generic;
using System.Text;

namespace AccessSpecifier
{
    class Student
    {
        string sname;
        string fname;
        string mname;
        int sage;
        string saddress;
        int rid;

        public string SName
        {
            get { return sname; }
            set { sname = value; }
        }
        public string FName
        {
            get { return fname; }
            set { fname = value; }
        }
        public string MName
        {
            get { return mname; }
            set { mname = value; }
        }
        public int SAge
        {
            get { return sage; }
            set { sage = value; }
        }
        public string SAddress
        {
            get { return saddress; }
            set { saddress = value; }
        }
        public int Rid
        {
            get { return rid; }
            set { rid = value; }
        }
    }
    class Operations
    {
        public Student[] st = new Student[20];

        public void insert()
        {
            Console.WriteLine("How Many Student Details you want to enter?");
            int Nos = int.Parse(Console.ReadLine());
            int sage, rid;
            string sname, fname, mname, saddress;
            if (Nos < st.Length)
            {
                for (int i = 0; i < Nos; i++)
                {
                    st[i] = new Student();
                    bool IsPresent = false;
                    Console.WriteLine("Enter Student rid: ");
                    rid = int.Parse(Console.ReadLine());
                    for (int k = i - 1; k >= 0; k--)
                    {
                        if (st[k].Rid.Equals(rid))
                        {
                            Console.WriteLine("Rid already exists");
                            IsPresent = true;
                            Nos++;
                            st[i] = new Student();
                            break;
                        }
                        try
                        {
                            if (IsPresent == false)
                            {
                                
                                Console.WriteLine("Enter Student Name: ");
                                sname = Console.ReadLine();
                                Console.WriteLine("Enter Father Name: ");
                                fname = Console.ReadLine();
                                Console.WriteLine("Enter Mother Name: ");
                                mname = Console.ReadLine();
                                Console.WriteLine("Enter Student Age: ");
                                sage = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Student Address:");
                                saddress = Console.ReadLine();
                                Console.WriteLine("Enter Student Rid:");
                                rid = int.Parse(Console.ReadLine());

                                
                                st[i].SName = sname;
                                st[i].FName = fname;
                                st[i].MName = mname;
                                st[i].SAge = sage;
                                st[i].SAddress = saddress;
                                st[i].Rid = rid;


                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Please enter in proper format");
                            Nos++;
                        }
                    }
                }


            }
        }
        public void GetStudentDetails(int rid)
        {
            bool IsPresent = false;
            for (int i = 0; i < st.Length; i++)
            {
                if (st[i] != null)   //Check null value
                {
                    if (st[i].Rid.Equals(rid))
                    {
                        Console.WriteLine("Student Details:\nrid:" + st[i].Rid + "\nStudent Name: " + st[i].SName + "\nFathers Name: " + st[i].FName + "\nMothers Name: " + st[i].MName + "\nStudent Age:" + st[i].SAge + "\nStudent Address:" + st[i].SAddress);
                        IsPresent = true;
                        break;
                    }
                }
            }
            if (IsPresent == false)
            {
                Console.WriteLine("Student Details not found");
                Console.WriteLine("Registration id  not present please enter right  rid");
            }
        }
        public void DisplayAllData()
        {
            for (int i = 0; i < st.Length; i++)
            {
                if (st[i] != null && st[i].Rid != 0)
                {
                    Console.WriteLine("Student Details:\nrid:" + st[i].Rid + "\nStudent Name: " + st[i].SName + "\nFathers Name: " + st[i].FName + "\nMothers Name: " + st[i].MName + "\nStudent Age:" + st[i].SAge + "\nStudent Address:" + st[i].SAddress);

                }
            }
        }
        public void UpdateStudentDetails(int rid) 
        {
            bool IsPresent = false;

            for (int i = 0; i < st.Length; i++)
            {
                if (st[i] != null)  //Check null value
                {
                    if (st[i].Rid.Equals(rid))
                    {
                        Console.WriteLine("1.Upadte rid\n2.Update Student Name\n3.Update Fathers Name\n4.Update Mothers name\n5.Update Age\n6.Update Address");
                        Console.WriteLine("Enter option: ");
                        int option = int.Parse(Console.ReadLine());
                        switch (option)
                        {
                            case 1:
                                Console.WriteLine("Enter new  rid: ");
                                int newrid = int.Parse(Console.ReadLine());
                                st[i].Rid = newrid;
                                IsPresent = true;
                                break;
                            case 2:
                                Console.WriteLine("Enter new Student Name: ");
                                string newsname = Console.ReadLine();
                                st[i].SName = newsname;
                                IsPresent = true;
                                break;
                            case 3:
                                Console.WriteLine("Enter new Fathers  Name: ");
                                string newfname = Console.ReadLine();
                                st[i].FName = newfname;
                                IsPresent = true;
                                break;
                            case 4:
                                Console.WriteLine("Enter new Mothers Name: ");
                                string newmname = Console.ReadLine();
                                st[i].MName = newmname;
                                IsPresent = true;
                                break;
                            case 5:
                                Console.WriteLine("Enter new Age : ");
                                int newsage = int.Parse(Console.ReadLine());
                                st[i].SAge = newsage;
                                IsPresent = true;
                                break;
                            case 6:
                                Console.WriteLine("Enter new Address: ");
                                string newsaddress = Console.ReadLine();
                                st[i].SAddress = newsaddress;
                                IsPresent = true;
                                break;
                            
                        }
                    }
                }

            }
            if (IsPresent == false)
            {
                Console.WriteLine("Student  RId not found please enter proper RId");
            }
            else
            {
                Console.WriteLine("Student Details updated");
            }
        }
        public void DeleteStudentDetails(int rid) 
        {
            bool IsPresent = false;
            for (int i = 0; i < st.Length; i++)
            {
                if (st[i] != null)  //Check null value
                {
                    if (st[i].Rid.Equals(rid))
                    {
                        st[i].Rid = 0;
                        st[i].SName = "";
                        st[i].FName = "";
                        st[i].MName = "";
                        st[i].SAge = 0;
                        st[i].SAddress = "";
                        IsPresent = true;
                        break;
                    }
                }
            }
            if (IsPresent == true)
            {
                Console.WriteLine("SAtudent Details Deleted Successfully");
            }
            else
            {
                Console.WriteLine("Student Details not found");
            }
        }
    }
    class StudentDetails
    {
        static void Main(string[] args)
        {
            Operations op = new Operations();
            bool stop = false;
            do
            {
                
                Console.WriteLine("\t\t\t\t\t\tWelcome");
                Console.WriteLine("\t\t\t\t\tTo Student Management");
                Console.WriteLine();
                Console.WriteLine("\t\t\t\t\t1.Insert\n\t\t\t\t\t2.Display\n\t\t\t\t\t3.Update\n\t\t\t\t\t4.Delete\n\t\t\t\t\t5.Display All Data\n\t\t\t\t\t6.Exit\n\t\t\t\t\tEnter option: ");
                int n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        op.insert();
                        break;
                    case 2:
                        Console.WriteLine("Enter Students rid whose detailed to be viewed:");
                        op.GetStudentDetails(int.Parse(Console.ReadLine()));
                        break;
                    case 3:
                        Console.WriteLine("Enter Students rid whose detailed to be updated:");
                        op.UpdateStudentDetails(int.Parse(Console.ReadLine()));
                        break;
                    case 4:
                        Console.WriteLine("Enter Students rid whose detailed to be deleted:");
                        op.DeleteStudentDetails(int.Parse(Console.ReadLine()));
                        break;
                    case 5:
                        op.DisplayAllData();
                        break;
                    case 6:
                        stop = true;
                        break;
                    default:
                        Console.WriteLine("Invalid operation");
                        break;
                }
            } while (!stop);
        }
    }
}
