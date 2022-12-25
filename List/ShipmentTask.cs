using System;
using System.Collections.Generic;
using System.Text;

namespace AccessSpecifier.List
{
    class MyDate
    {
        public int dd, mm, yy;
        public MyDate(int dd, int mm, int yy)
        {
            this.dd = dd;
            this.mm = mm;
            this.yy = yy;
        }
        public void DisplayMydate()
        {
            Console.Write("\t" + dd + '/' + mm + '/' + yy);
        }
    }
    class Order
    {
        public int OrderID;
        public string custName;
        public string city;
        public Order(int orderId, string CustName, string city)
        {
            this.OrderID = orderId;
            this.custName = CustName;
            this.city = city;
        }
        public void DisplayOrder()
        {
            Console.Write("\t" + OrderID + "  " + custName + "  " + city);
        }
    }
    class Shipment : IComparable<Shipment>
    {
        public int ShipId;
        public Order order;
        public MyDate mydate;
        public Shipment(int sid, Order order, MyDate mydate)
        {
            this.ShipId = sid;
            this.order = order;
            this.mydate = mydate;
        }
        int IComparable<Shipment>.CompareTo(Shipment other)
        {
            if (this.order.city.Equals(other.order.city))
            {
                return this.mydate.dd - other.mydate.dd;
            }
            else
            {
                return this.order.city.CompareTo(other.order.city);
            }
        }
        public void DisplayShipment()
        {
            Console.Write(ShipId);
            order.DisplayOrder();
            mydate.DisplayMydate();
            Console.WriteLine();
        }
    }
    class ShipmentTask
    {
        static void Main(string[] args)
        {
            List<Shipment> sh = new List<Shipment>();

            sh.Add(new Shipment(123, new Order(101, "Rahul", "Mumbai"), new MyDate(25, 12, 22)));
            sh.Add(new Shipment(128, new Order(102, "Priya", "Pune"), new MyDate(26, 12, 22)));
            sh.Add(new Shipment(127, new Order(106, "Ira", "Bangalore"), new MyDate(28, 12, 22)));
            sh.Add(new Shipment(126, new Order(108, "Hema", "Hyderabad"), new MyDate(29, 12, 22)));
            sh.Add(new Shipment(122, new Order(107, "siya", "Pune"), new MyDate(5, 12, 22)));

            sh.Sort();
            foreach (Shipment s in sh)
            {
                s.DisplayShipment();
            }
        }
    }
}


    