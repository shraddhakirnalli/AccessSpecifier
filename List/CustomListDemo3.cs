using System;
using System.Collections.Generic;
using System.Text;

namespace AccessSpecifier.List
{
    class CarDemo
    {
        public int model_no;
        public string car_name;
        public int car_price;

        public CarDemo(int model_no,string car_name,int car_price)
        {
            this.model_no = model_no;
            this.car_name = car_name;
            this.car_price = car_price;
        }
    }
    class CustomListDemo3
    {
        static void Main(string[] args)
        {
            List<CarDemo> li = new List<CarDemo>();
            li.Add(new CarDemo(123, "Tata", 500000));
            li.Add(new CarDemo(212, "Maruti", 700000));
            li.Add(new CarDemo(3145, "BMW", 700000));
            li.Add(new CarDemo(412, "Maruti", 900000));

            foreach(var c in li)
            {
                Console.WriteLine(c.model_no+" "+c.car_name+" "+c.car_price);
            }
            Console.WriteLine("----------------------------");

            li.Sort(new SortbyPrice());
        }
         class SortbyPrice:IComparer<CarDemo>
        {
            int IComparer<CarDemo>.Compare(CarDemo x, CarDemo y)
            {
                return x.car_price - y.car_price;

            }
        }
    }
}
