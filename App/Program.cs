using Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {

            var person = new Person() {
                FirstName = "Sean",
                LastName = "Newman",
                Age = 56
            };

            Console.WriteLine($"Person = {person.FirstName}");
        }
    }
}
