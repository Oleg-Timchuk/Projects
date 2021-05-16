using System;
using System.Collections.Generic;
using System.Collections;
using System.Diagnostics;
using System.Linq;
using System.IO;
using System.Threading;

namespace Test_APP
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new() { Name = "Oleg", SurName = "Dud", Age = 14, Birthday = new DateTime(2002,7,12)};

            Person p2 = new() { Name = "Viktoriya", Age = 25, Birthday = new DateTime(2001, 6, 10)};

            Person p3 = new() { Name = "Bogdan", Age = 52, Birthday = new DateTime(1982, 3, 1)};

            Person[] a = new[] { p1, p2, p3 };

            Array.Sort(a, new PersonBirthdayComparer());
            foreach (Person p in a)
            {
                Console.WriteLine(p);
            }
        }
    }
}

