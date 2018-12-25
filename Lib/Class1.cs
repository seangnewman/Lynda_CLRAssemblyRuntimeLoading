using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class Person
    {

        static Person()
        {
            System.Reflection.Assembly thisAssembly = typeof(Person).Assembly;
            Console.WriteLine(thisAssembly.CodeBase);
            Console.WriteLine(thisAssembly.Location);
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person()
        {

        }

        public override string ToString()
        {
            return string.Format($"[Person FN:{FirstName} LN: {LastName} A: {Age}");
        }
    }
}
