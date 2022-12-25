using System;
using System.Collections.Generic;
using System.Text;

namespace AccessSpecifier.List
{
    class Train
    {
        public int Tid;
        public string Tname;
        public int Nos;

        public Train(int Tid,string Tname,int Nos)
        {
            this.Tid = Tid;
            this.Tname = Tname;
            this.Nos = Nos;
        }
        public void DisplayTrain()
        {
            Console.WriteLine(Tid + "  " + Tname + "  " + Nos);
        }
    }
    class SortbyNos : IComparer<Train>
    {
        int IComparer<Train>.Compare(Train x, Train y)
        {
            if (x.Nos == y.Nos)
            {
                return x.Tname.CompareTo(y.Tname);
            }
            else
            {
                return x.Nos - y.Nos;
            }

        }

    }

    class CustomDemo4
    {
        static void Main(string[] args)
        {
            List<Train> li = new List<Train>();
            li.Add(new Train(1250, "Intercity", 156));
            li.Add(new Train(1165, "Shatabdi", 172));
            li.Add(new Train(1734, "LTT VSKP",212));
            li.Add(new Train(1671, "DeccanQueen", 156));
            li.Sort(new SortbyNos());

            foreach (var t in li)
            {
                Console.WriteLine(t.Tid+" "+t.Tname+" "+t.Nos);
            }
            Console.WriteLine("----------------------------------------");

            
        }
        

    }
}
