using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XD_2023
{
    internal class Car : Vehicle
    {
        public string color;
        public string name;
        public int maxSpeed; //field
        public int year;

        public string Name { //property
            get { return name; }
            set { name = value; }
        }
        public string Color { 
            get { return color; }
            set { name = value; }
        }
        public int Year {
            get { return year; }
            //set { year = value; }
            set
            {
                if (value < 1980)
                {
                    throw new Exception("Please pass a correct value");
                }
                else
                {
                    year = value;
                }
            }
        }
        public Car(string nameName, string colorName, int yearValue, int maxSpeedValue, string eng_type)
        {
            name = nameName;
            color = colorName;
            year = yearValue;
            maxSpeed = maxSpeedValue;
            engine_type = eng_type;
        }
        public Car(string nameName)
        {
            name = nameName;
        }
        public void fullThrottle()
        {
            Console.WriteLine(name + " is going at the speed of " + maxSpeed);
        }
    }
}
