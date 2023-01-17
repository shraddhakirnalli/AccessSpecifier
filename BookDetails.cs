using System;
using System.Collections.Generic;
using System.Text;

namespace AccessSpecifier
{
    class Author
    {
        int authorid;
        string authorname;
        public int AuthorId
        {
            get { return authorid; }
            set { authorid = value; }
        }
        public string Authorname
        {
            get { return authorname; }
            set { authorname = value; }
        }
    }
    class Book
    {
        int bookid;
        string bookname;
        int price;
        Author author;
        public int BookId
        {
            get { return bookid; }
            set { bookid = value; }
        }
        public string BookName
        {
            get { return bookname; }
            set { bookname = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public Author Author
        {
            get { return author; }
            set { author = value; }
        }


    }
    class CrudeOperations
    {
        public Book[] bk = new Book[20];
        public void Insert() //Insertion of book
        {
            Console.WriteLine("how many books details you want to enter");
            int NoOfBook = int.Parse(Console.ReadLine());
            int bookid, price, authorid;
            string bookname, authorname;
            if (NoOfBook < bk.Length)
            {
                for (int i = 0; i < NoOfBook; i++)
                {
                    bk[i] = new Book();
                    bool ispresent = false;
                    Console.WriteLine("Enter Book id: ");
                    bookid = int.Parse(Console.ReadLine());
                    for (int k = i - 1; k >= 0; k--)
                    {
                        if (bk[k].BookId.Equals(bookid))
                        {
                            Console.WriteLine("Id already exists");
                            ispresent = true;
                            NoOfBook++;
                            bk[i] = new Book();
                            break;
                        }
                    }
                    try
                    {
                        if (ispresent == false)
                        {
                            Console.WriteLine("Enter Book name: ");
                            bookname = Console.ReadLine();
                            Console.WriteLine("Enter book price: ");
                            price = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter author id: ");
                            authorid = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter author name: ");
                            authorname = Console.ReadLine();
                            bk[i].BookId = bookid;
                            bk[i].BookName = bookname;
                            bk[i].Price = price;
                            bk[i].Author = new Author();
                            bk[i].Author.AuthorId = authorid;
                            bk[i].Author.Authorname = authorname;
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Please enter in proper format");
                        NoOfBook++;
                    }
                }
                //  booksize = NoOfBook;
            }
            else
            {
                Console.WriteLine("Please enter number of books again your books size is larger");
            }
        }
        public void GetBooksDetails(int bkid) //Display details of Book
        {
            bool ispresent = false;
            for (int i = 0; i < bk.Length; i++)
            {
                if (bk[i] != null)   //Check null value
                {
                    if (bk[i].BookId.Equals(bkid))
                    {
                        Console.WriteLine("Book Details:\nBook Id:" + bk[i].BookId + "\nBook Name: " + bk[i].BookName + "\nBook Price: " + bk[i].Price + "\nAuthor Id: " + bk[i].Author.AuthorId + "\nAuthor Name:" + bk[i].Author.Authorname);
                        ispresent = true;
                        break;
                    }
                }
            }
            if (ispresent == false)
            {
                Console.WriteLine("Book Details not found");
                Console.WriteLine("Book id doese not present please enter right book id");
            }
        }
        public void DisplayAllData()
        {
            for (int i = 0; i < bk.Length; i++)
            {
                if (bk[i] != null && bk[i].BookId != 0)
                {
                    Console.WriteLine("Book Details:\n Book Id:" + bk[i].BookId + "\nBook Name: " + bk[i].BookName + "\nBook Price: " + bk[i].Price + "\nAuthor Id: " + bk[i].Author.AuthorId + "\nAuthor Name:" + bk[i].Author.Authorname);
                }
            }
        }
        public void UpdateBookDetails(int bkid) //Update Details of book
        {
            bool ispresent = false;

            for (int i = 0; i < bk.Length; i++)
            {
                if (bk[i] != null)  //Check null value
                {
                    if (bk[i].BookId.Equals(bkid))
                    {
                        Console.WriteLine("1.Upadte id\n2.Update Name\n3.Update Price\n4.Update Author name\n5.Update Author id");
                        Console.WriteLine("Enter option: ");
                        int option = int.Parse(Console.ReadLine());
                        switch (option)
                        {
                            case 1:
                                Console.WriteLine("Enter new book id: ");
                                int newid = int.Parse(Console.ReadLine());
                                bk[i].BookId = newid;
                                ispresent = true;
                                break;
                            case 2:
                                Console.WriteLine("Enter new book name: ");
                                string newname = Console.ReadLine();
                                bk[i].BookName = newname;
                                ispresent = true;
                                break;
                            case 3:
                                Console.WriteLine("Enter new book price: ");
                                int newprice = int.Parse(Console.ReadLine());
                                bk[i].Price = newprice;
                                ispresent = true;
                                break;
                            case 4:
                                Console.WriteLine("Enter new author name: ");
                                string newauthorname = Console.ReadLine();
                                bk[i].Author.Authorname = newauthorname;
                                ispresent = true;
                                break;
                            case 5:
                                Console.WriteLine("Enter new book id: ");
                                int newauthorid = int.Parse(Console.ReadLine());
                                bk[i].Author.AuthorId = newauthorid;
                                ispresent = true;
                                break;
                        }
                    }
                }
            }
            if (ispresent == false)
            {
                Console.WriteLine("Book Id not found please enter proper Id");
            }
            else
            {
                Console.WriteLine("Book updated");
            }
        }
        public void DeleteBookDetails(int bkid) //Delete Details of book
        {
            bool ispresent = false;
            for (int i = 0; i < bk.Length; i++)
            {
                if (bk[i] != null)  //Check null value
                {
                    if (bk[i].BookId.Equals(bkid))
                    {
                        bk[i].BookId = 0;
                        bk[i].BookName = "";
                        bk[i].Price = 0;
                        bk[i].Author.AuthorId = 0;
                        bk[i].Author.Authorname = "";
                        ispresent = true;
                        break;
                    }
                }
            }
            if (ispresent == true)
            {
                Console.WriteLine("Book Details Deleted Successfully");
            }
            else
            {
                Console.WriteLine("Book Details not found");
            }
        }
    }
    class BookDetails
    {
        static void Main(string[] args)
        {
            CrudeOperations op = new CrudeOperations();
            bool stop = false;
            do
            {
                int n;
                Console.WriteLine("\t\t\t\t\t\tWelcome");
                Console.WriteLine("\t\t\t\t\tTo Book Management");
                Console.WriteLine();
                Console.WriteLine("\t\t\t\t\t1.Insert\n\t\t\t\t\t2.Display\n\t\t\t\t\t3.Update\n\t\t\t\t\t4.Delete\n\t\t\t\t\t5.Display All Data\n\t\t\t\t\t6.Exit\n\t\t\t\t\tEnter option: ");
                n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        op.Insert();
                        break;
                    case 2:
                        Console.WriteLine("Enter Book's id whose detailed to be viewed:");
                        op.GetBooksDetails(int.Parse(Console.ReadLine()));
                        break;
                    case 3:
                        Console.WriteLine("Enter Book's id whose detailed to be updated:");
                        op.UpdateBookDetails(int.Parse(Console.ReadLine()));
                        break;
                    case 4:
                        Console.WriteLine("Enter Book's id whose detailed to be deleted:");
                        op.DeleteBookDetails(int.Parse(Console.ReadLine()));
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
