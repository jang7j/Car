
using System;
using System.Collections.Generic;

namespace Car
{
    class Program
    {


        static void Main(string[] args)
        {
            var myCar = new Car();
            myCar.Make = "Ford";
            myCar.Model = "Escape";
            myCar.Year = 2013;

            var mazda = new Car()
            {
                Make = "Mazda",
                Model = "CX5",
                Year = 2009
            };

            var chevy = new Car("Chevy", "Impala", 2001);

            var carlist = new List<Car>() { myCar, mazda, chevy };

            foreach (var car in carlist)
            {
                Console.WriteLine(car.Make);
                Console.WriteLine(car.Model);
                Console.WriteLine(car.Year);
            }


        }

            
    }
}
