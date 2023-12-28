using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XD_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Ford = new Car("Mustang", "white", 2021, 100, "electric");
            Car Opel = new Car("Astra", "blue", 2020, 120, "electric");
            Car Volvo = new Car("XC-90");

            Console.WriteLine(Ford.name);
            Console.WriteLine(Ford.color);
            Console.WriteLine(Ford.year);
            Console.WriteLine(Ford.engine_type);
            Ford.fullThrottle();
            Ford.honk();

            Console.WriteLine(Opel.name);
            Console.WriteLine(Opel.color);
            Console.WriteLine(Opel.year);
            Opel.fullThrottle();
            Opel.honk();

            Console.WriteLine("Enter Volvo's age: ");
            //int age = Console.ReadLine();
            try
            {
                Volvo.Year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Volvo age is: " + Volvo.Year);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
