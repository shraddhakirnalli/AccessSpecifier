using System;
using System.Collections.Generic;
using System.Text;

namespace AccessSpecifier.List
{
    class Car:IComparable
    {
        public int model_no;
        public string car_name;
        public int car_price;
        public string car_colour;
        
        public Car(int model_no,string car_name,int car_price,string car_colour)
        {
            this.model_no = model_no;
            this.car_name = car_name;
            this.car_price = car_price;
            this.car_colour = car_colour;
        }
        public int CompareTo(object obj)
        {
            Car c = (Car)obj;
            if(this.car_price==c.car_price)
            {
                return this.car_name.CompareTo(c.car_name);
                
            }
            
            else if (this.car_name==c.car_name)
            {
                return this.model_no - c.model_no;
            }
            
            return this.car_price - c.car_price;
            
        }
        
        
    }

    class CustomListDemo2
    {
        static void Main(string[] args)
        {
            List<Car> li = new List<Car>();
            li.Add(new Car(11, "Tata", 500000, "White"));
            li.Add(new Car(21, "Maruti", 700000, "Grey"));
            li.Add(new Car(31, "BMW", 700000, "Red"));
            li.Add(new Car(41, "Maruti", 900000, "Black"));

            li.Sort();
            foreach (Car c in li)
            {
                Console.WriteLine(c.model_no + " " + c.car_name + " " + c.car_price+" "+c.car_colour);

            }
            

        }
    }
}
