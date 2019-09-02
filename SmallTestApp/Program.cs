using Bcs.Models;
using System;

namespace SmallTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Location a = new Location(20, 20);
            //Location b = a;
            //a.x = 100;

            Student student1 = new Student
            {
                FirstName = "Damilola",
                LastName = "Ajayi"
            };

            var student2 = new Student
            {
                FirstName = "Paul",
                LastName = "Oguche"
            };

            Console.WriteLine(student1.GetFullName());
            Console.WriteLine(student2.GetFullName());
            
            Console.WriteLine("Hello World!");
        }
    }


    struct Location
    {
        public int x, y;
        public Location(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    

}
